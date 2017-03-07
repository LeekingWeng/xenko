// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using System.Threading.Tasks;
using SiliconStudio.Core;
using SiliconStudio.Core.Annotations;
using SiliconStudio.Core.Collections;
using SiliconStudio.Xenko.Animations;
using SiliconStudio.Xenko.Engine.Design;

namespace SiliconStudio.Xenko.Engine
{
    /// <summary>
    /// Add animation capabilities to an <see cref="Entity"/>. It will usually apply to <see cref="ModelComponent.Skeleton"/>
    /// </summary>
    /// <remarks>
    /// Data is stored as in http://altdevblogaday.com/2011/10/23/low-level-animation-part-2/.
    /// </remarks>
    [DataContract("AnimationComponent")]
    [DefaultEntityComponentProcessor(typeof(AnimationProcessor), ExecutionMode = ExecutionMode.Runtime | ExecutionMode.Thumbnail | ExecutionMode.Preview)]
    [Display("Animations", Expand = ExpandRule.Once)]
    [ComponentOrder(2000)]
    public sealed class AnimationComponent : EntityComponent
    {
        private readonly Dictionary<string, AnimationClip> animations;
        private readonly TrackingCollection<PlayingAnimation> playingAnimations;

        [DataMemberIgnore]
        public AnimationBlender Blender { get; internal set; } = new AnimationBlender();

        public AnimationComponent()
        {
            animations = new Dictionary<string, AnimationClip>();
            playingAnimations = new TrackingCollection<PlayingAnimation>();
            playingAnimations.CollectionChanged += playingAnimations_CollectionChanged;
        }

        void playingAnimations_CollectionChanged(object sender, TrackingCollectionChangedEventArgs e)
        {
            var item = (PlayingAnimation)e.Item;
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Remove:
                {
                    var evaluator = item.Evaluator;
                    if (evaluator != null)
                    {
                        Blender.ReleaseEvaluator(evaluator);
                        item.Evaluator = null;
                    }

                    item.endedTCS?.TrySetResult(true);
                    item.endedTCS = null;
                    break;
                }

                default:
                    break;
            }
        }

        /// <summary>
        /// Gets the animations associated to the component.
        /// </summary>
        /// <userdoc>The list of the animation associated to the entity.</userdoc>
        public Dictionary<string, AnimationClip> Animations
        {
            get { return animations; }
        }

        /// <summary>
        /// Plays right away the animation with the specified name, instantly removing all other blended animations.
        /// </summary>
        /// <param name="name">The animation name.</param>
        public PlayingAnimation Play(string name)
        {
            playingAnimations.Clear();
            var playingAnimation = new PlayingAnimation(name, Animations[name]) { CurrentTime = TimeSpan.Zero, Weight = 1.0f };
            playingAnimations.Add(playingAnimation);
            return playingAnimation;
        }

        /// <summary>
        /// Returns <c>true</c> if the specified animation is in the list of currently playing animations
        /// </summary>
        /// <param name="name">The name of the animation to check</param>
        /// <returns><c>true</c> if the animation is playing, <c>false</c> otherwise</returns>
        public bool IsPlaying(string name)
        {
            foreach (var playingAnimation in playingAnimations)
            {
                if (playingAnimation.Name.Equals(name))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Adds a new playing animation at the end of the list. It doesn't alter currently playing animations.
        /// </summary>
        /// <param name="clip">Animation clip to add to the list of playing animations</param>
        /// <param name="timeScale">Speed at which the animation should play</param>
        /// <param name="weight">Weight of the animation, in regard to all other playing animations.</param>
        /// <param name="startTime">Time, in seconds, at which the animation starts playing</param>
        /// <param name="blend">Blend mode - linear or additive</param>
        /// <param name="repeatMode">Repeat mode - play once or loop indefinitely</param>
        public void Add(AnimationClip clip, double startTime = 0, AnimationBlendOperation blend = AnimationBlendOperation.LinearBlend, 
            float timeScale = 1f, float weight = 1f, AnimationRepeatMode ? repeatMode = null)
        {
            var playingAnimation = new PlayingAnimation("", clip)
            {
                TimeFactor = timeScale,
                Weight = weight,
                CurrentTime = TimeSpan.FromSeconds(startTime),
                BlendOperation = blend,
                RepeatMode = repeatMode ?? clip.RepeatMode,
            };

            playingAnimations.Add(playingAnimation);
        }

        /// <summary>
        /// Crossfades to a new animation.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="fadeTimeSpan">The fade time span.</param>
        /// <exception cref="ArgumentException">name</exception>
        public PlayingAnimation Crossfade(string name, TimeSpan fadeTimeSpan)
        {
            if (!Animations.ContainsKey(name))
                throw new ArgumentException(nameof(name));

            // Fade all animations
            foreach (var otherPlayingAnimation in playingAnimations)
            {
                otherPlayingAnimation.WeightTarget = 0.0f;
                otherPlayingAnimation.CrossfadeRemainingTime = fadeTimeSpan;
            }

            // Blend to new animation
            return Blend(name, 1.0f, fadeTimeSpan);
        }

        /// <summary>
        /// Blends progressively a new animation.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="desiredWeight">The desired weight.</param>
        /// <param name="fadeTimeSpan">The fade time span.</param>
        /// <exception cref="ArgumentException">name</exception>
        public PlayingAnimation Blend(string name, float desiredWeight, TimeSpan fadeTimeSpan)
        {
            if (!Animations.ContainsKey(name))
                throw new ArgumentException("name");

            var playingAnimation = new PlayingAnimation(name, Animations[name]) { CurrentTime = TimeSpan.Zero, Weight = 0.0f };
            playingAnimations.Add(playingAnimation);

            if (fadeTimeSpan > TimeSpan.Zero)
            {
                playingAnimation.WeightTarget = desiredWeight;
                playingAnimation.CrossfadeRemainingTime = fadeTimeSpan;
            }
            else
            {
                playingAnimation.Weight = desiredWeight;
            }

            return playingAnimation;
        }

        public PlayingAnimation NewPlayingAnimation(string name)
        {
            return new PlayingAnimation(name, Animations[name]);
        }

        /// <summary>
        /// Gets list of active animations. Use this to customize startup animations.
        /// </summary>
        [DataMemberIgnore]
        public TrackingCollection<PlayingAnimation> PlayingAnimations => playingAnimations;

        [DataMemberIgnore]
        public IBlendTreeBuilder BlendTreeBuilder { get; set; }

        /// <summary>
        /// Returns an awaitable object that will be completed when the animation is removed from the PlayingAnimation list.
        /// This happens when:
        /// - RepeatMode is PlayOnce and animation reached end
        /// - Animation faded out completely (due to blend to 0.0 or crossfade out)
        /// - Animation was manually removed from AnimationComponent.PlayingAnimations
        /// </summary>
        /// <returns></returns>
        public Task Ended(PlayingAnimation animation)
        {
            if (!playingAnimations.Contains(animation))
                throw new InvalidOperationException("Trying to await end of an animation which is not playing");

            if (animation.endedTCS == null)
            {
                Interlocked.CompareExchange(ref animation.endedTCS, new TaskCompletionSource<bool>(), null);
            }

            return animation.endedTCS.Task;
        }
    }

    public interface IBlendTreeBuilder
    {
        void BuildBlendTree(FastList<AnimationOperation> animationList);
    }
}
