// Copyright (c) 2014-2017 Silicon Studio Corp. All rights reserved. (https://www.siliconstudio.co.jp)
// See LICENSE.md for full license information.
using System;

using SiliconStudio.BuildEngine;
using SiliconStudio.Core.Serialization;

namespace SiliconStudio.Assets.Compiler
{
    /// <summary>
    /// Represents a list of <see cref="BuildStep"/> instances that compiles a given asset.
    /// </summary>
    public class AssetBuildStep : ListBuildStep
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetBuildStep"/> class.
        /// </summary>
        /// <param name="assetItem">The asset that can be build by this build step.</param>
        public AssetBuildStep(AssetItem assetItem)
        {
            if (assetItem == null) throw new ArgumentNullException("assetItem");
            AssetItem = assetItem;
        }

        /// <summary>
        /// Gets the <see cref="AssetItem"/> corresponding to the asset being built by this build step.
        /// </summary>
        public AssetItem AssetItem { get; private set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"Asset build steps [{AssetItem.Asset?.GetType().Name ?? "(null)"}:'{AssetItem.Location}'] ({Count} items)";
        }

        public override string OutputLocation => AssetItem.Location;
    }
}
