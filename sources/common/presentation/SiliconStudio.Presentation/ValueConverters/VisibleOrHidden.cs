// Copyright (c) 2014-2017 Silicon Studio Corp. All rights reserved. (https://www.siliconstudio.co.jp)
// See LICENSE.md for full license information.
using System;
using System.Globalization;
using System.Windows;
using SiliconStudio.Core.Annotations;
using SiliconStudio.Presentation.Internal;

namespace SiliconStudio.Presentation.ValueConverters
{
    /// <summary>
    /// This converter will convert a boolean value to a <see cref="Visibility"/> value, where false translates to <see cref="Visibility.Hidden"/>.
    /// <see cref="ConvertBack"/> is supported.
    /// </summary>
    /// <remarks>If the boolean value <c>false</c> is passed as converter parameter, the visibility is inverted.</remarks>
    /// <seealso cref="VisibleOrCollapsed"/>
    public class VisibleOrHidden : ValueConverterBase<VisibleOrHidden>
    {
        /// <inheritdoc/>
        [NotNull]
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = ConverterHelper.ConvertToBoolean(value, culture);
            if (parameter as bool? == false)
            {
                result = !result;
            }
            return result ? VisibilityBoxes.VisibleBox : VisibilityBoxes.HiddenBox;
        }

        /// <inheritdoc/>
        [NotNull]
        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var visibility = (Visibility)value;
            var result = visibility == Visibility.Visible;
            if (parameter as bool? == false)
            {
                result = !result;
            }
            return result.Box();
        }
    }
}