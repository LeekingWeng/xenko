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

namespace SiliconStudio.Xenko.Rendering
{
    public static partial class CameraKeys
    {
        public static readonly ParameterKey<float> NearClipPlane = ParameterKeys.New<float>(1.0f);
        public static readonly ParameterKey<float> FarClipPlane = ParameterKeys.New<float>(100.0f);
        public static readonly ParameterKey<Vector2> ZProjection = ParameterKeys.New<Vector2>();
        public static readonly ParameterKey<float> AspectRatio = ParameterKeys.New<float>();
        public static readonly ParameterKey<Vector2> ViewSize = ParameterKeys.New<Vector2>();
        public static readonly ParameterKey<float> VerticalFieldOfView = ParameterKeys.New<float>();
        public static readonly ParameterKey<float> OrthoSize = ParameterKeys.New<float>();
    }
}
