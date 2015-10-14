﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using SiliconStudio.Xenko.Graphics;

namespace SiliconStudio.TextureConverter.Requests
{
    /// <summary>
    /// Request to decompress a texture into R8G8B8A8
    /// </summary>
    internal class DecompressingRequest : IRequest
    {
        public override RequestType Type { get { return RequestType.Decompressing; } }

        /// <summary>
        /// The format of the decompressed data.
        /// </summary>
        public PixelFormat DecompressedFormat { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DecompressingRequest" /> class.
        /// </summary>
        /// <param name="isSRgb">Indicate if the input image is an sRGB image</param>
        /// <param name="pixelFormat">Input pixel format.</param>
        public DecompressingRequest(bool isSRgb, PixelFormat pixelFormat = PixelFormat.None)
        {
            if (pixelFormat.IsHDR())
                DecompressedFormat = PixelFormat.R16G16B16A16_Float;
            else
                DecompressedFormat = isSRgb ? PixelFormat.R8G8B8A8_UNorm_SRgb : PixelFormat.R8G8B8A8_UNorm;
        }
    }
}
