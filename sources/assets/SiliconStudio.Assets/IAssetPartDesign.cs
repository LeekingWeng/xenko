﻿using SiliconStudio.Core;
using SiliconStudio.Core.Annotations;

namespace SiliconStudio.Assets
{
    /// <summary>
    /// An interface representing a design-time part in an <see cref="AssetComposite"/>.
    /// </summary>
    public interface IAssetPartDesign
    {
        [CanBeNull]
        BasePart Base { get; set; }
    }
    /// <summary>
    /// An interface representing a design-time part in an <see cref="AssetComposite"/>.
    /// </summary>
    /// <typeparam name="TAssetPart">The underlying type of part.</typeparam>
    public interface IAssetPartDesign<TAssetPart> : IAssetPartDesign where TAssetPart : IIdentifiable
    {
        /// <summary>
        /// The actual part.
        /// </summary>
        [NotNull]
        TAssetPart Part { get; set; }
    }
}
