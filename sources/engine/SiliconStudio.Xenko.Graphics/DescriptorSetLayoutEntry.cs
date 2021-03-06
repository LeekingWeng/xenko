// Copyright (c) 2011-2017 Silicon Studio Corp. All rights reserved. (https://www.siliconstudio.co.jp)
// See LICENSE.md for full license information.
using SiliconStudio.Xenko.Shaders;

namespace SiliconStudio.Xenko.Graphics
{
    // D3D11 implementation
    /// <summary>
    /// Used internally to store descriptor layout entries.
    /// </summary>
    internal struct DescriptorSetLayoutEntry
    {
        public EffectParameterClass Type;
        public int ArraySize;

        public DescriptorSetLayoutEntry(EffectParameterClass type, int arraySize = 1) : this()
        {
            Type = type;
            ArraySize = arraySize;
        }
    }
}
