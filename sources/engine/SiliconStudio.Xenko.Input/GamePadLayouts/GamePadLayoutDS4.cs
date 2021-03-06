// Copyright (c) 2016-2017 Silicon Studio Corp. All rights reserved. (https://www.siliconstudio.co.jp)
// See LICENSE.md for full license information.

using System;

namespace SiliconStudio.Xenko.Input
{
    /// <summary>
    /// A gamepad layout for a DualShock4 controller
    /// </summary>
    public class GamePadLayoutDS4 : GamePadLayout
    {
        private static readonly Guid commonProductId = new Guid(0x05c4054c, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
        
        public GamePadLayoutDS4()
        {
            AddButtonToButton(8, GamePadButton.Back);
            AddButtonToButton(9, GamePadButton.Start);
            AddButtonToButton(10, GamePadButton.LeftThumb);
            AddButtonToButton(11, GamePadButton.RightThumb);
            AddButtonToButton(4, GamePadButton.LeftShoulder);
            AddButtonToButton(5, GamePadButton.RightShoulder);
            AddButtonToButton(1, GamePadButton.A);
            AddButtonToButton(2, GamePadButton.B);
            AddButtonToButton(0, GamePadButton.X);
            AddButtonToButton(3, GamePadButton.Y);
            AddAxisToAxis(0, GamePadAxis.LeftThumbX);
            AddAxisToAxis(1, GamePadAxis.LeftThumbY, true);
            AddAxisToAxis(2, GamePadAxis.RightThumbX);
            AddAxisToAxis(5, GamePadAxis.RightThumbY, true);
            AddAxisToAxis(3, GamePadAxis.LeftTrigger, false, true);
            AddAxisToAxis(4, GamePadAxis.RightTrigger, false, true);
        }

        public override bool MatchDevice(IInputSource source, IGameControllerDevice device)
        {
            return CompareProductId(device.ProductId, commonProductId, 4);
        }
    }
}