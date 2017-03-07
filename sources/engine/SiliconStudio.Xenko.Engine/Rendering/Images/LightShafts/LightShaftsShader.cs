﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Xenko Shader Mixin Code Generator.
// To generate it yourself, please install SiliconStudio.Xenko.VisualStudio.Package .vsix
// and re-save the associated .xkfx.
// </auto-generated>

using System;
using SiliconStudio.Core;
using SiliconStudio.Xenko.Rendering;
using SiliconStudio.Xenko.Graphics;
using SiliconStudio.Xenko.Shaders;
using SiliconStudio.Core.Mathematics;
using Buffer = SiliconStudio.Xenko.Graphics.Buffer;

namespace SiliconStudio.Xenko.Rendering.Images
{
    public static partial class LightShaftsShaderKeys
    {
        public static readonly ValueParameterKey<Matrix> ShadowViewProjection = ParameterKeys.NewValue<Matrix>();
        public static readonly ValueParameterKey<Vector4> ShadowTextureFactor = ParameterKeys.NewValue<Vector4>();
        public static readonly ValueParameterKey<Color3> LightColor = ParameterKeys.NewValue<Color3>();
        public static readonly ValueParameterKey<Vector3> ShadowLightOffset = ParameterKeys.NewValue<Vector3>();
        public static readonly ValueParameterKey<Vector3> ShadowLightDirection = ParameterKeys.NewValue<Vector3>();
        public static readonly ValueParameterKey<float> ExtinctionFactor = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<float> DensityFactor = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<float> ShadowMapDistance = ParameterKeys.NewValue<float>();
        public static readonly ValueParameterKey<float> ExtinctionRatio = ParameterKeys.NewValue<float>();
    }
}
