// Copyright (c) 2017 Silicon Studio Corp. All rights reserved. (https://www.siliconstudio.co.jp)
// See LICENSE.md for full license information.

using System.Collections.Generic;
using SiliconStudio.Core.Mathematics;
using SiliconStudio.Xenko.Games;
using SiliconStudio.Xenko.Rendering.Lights;

namespace SiliconStudio.Xenko.Engine.Processors
{
    public class LightShaftProcessor : EntityProcessor<LightShaftComponent, LightShaftProcessor.AssociatedData>
    {
        private readonly List<AssociatedData> activeLightShafts = new List<AssociatedData>();

        public List<AssociatedData> LightShafts => activeLightShafts;

        /// <inheritdoc />
        protected override AssociatedData GenerateComponentData(Entity entity, LightShaftComponent component)
        {
            return new AssociatedData
            {
                Component = component,
                LightComponent = entity.Get<LightComponent>()
            };
        }

        /// <inheritdoc />
        protected override bool IsAssociatedDataValid(Entity entity, LightShaftComponent component, AssociatedData associatedData)
        {
            return component == associatedData.Component &&
                   entity.Get<LightComponent>() == associatedData.LightComponent;
        }

        /// <inheritdoc />
        public override void Update(GameTime time)
        {
            activeLightShafts.Clear();
            foreach (var pair in ComponentDatas)
            {
                if (!pair.Key.Enabled)
                    continue;

                var lightShaft = pair.Value;
                var light = lightShaft.LightComponent;

                var directLight = light?.Type as IDirectLight;
                if (directLight == null)
                    continue;

                lightShaft.Light = directLight;
                activeLightShafts.Add(lightShaft);
            }
        }

        public class AssociatedData
        {
            public LightShaftComponent Component;
            public LightComponent LightComponent;
            public IDirectLight Light;
            public int SampleCount => Component.SampleCount;
            public Matrix LightWorld => Component.Entity.Transform.WorldMatrix;
            public float DensityFactor => Component.DensityFactor;
            public bool SeparateBoundingVolumes => Component.SeparateBoundingVolumes;
        }
    }
}
