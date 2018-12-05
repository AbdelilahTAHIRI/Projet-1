// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace BrakeOrDie
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton autonomousButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel connectLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField getIPAddress { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField getSpeed { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton leftButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel modeLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton rightButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton setSpeedButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView speedValue { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton startButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton stopWheelButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton upButton { get; set; }

        [Action ("AutonomousButtonClicked:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void AutonomousButtonClicked (UIKit.UIButton sender);

        [Action ("DownButtonPushed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DownButtonPushed (UIKit.UIButton sender);

        [Action ("LeftButtonPushed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void LeftButtonPushed (UIKit.UIButton sender);

        [Action ("RightButtonPushed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void RightButtonPushed (UIKit.UIButton sender);

        [Action ("SetSpeedToCar:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SetSpeedToCar (UIKit.UIButton sender);

        [Action ("StartButtonPushed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void StartButtonPushed (UIKit.UIButton sender);

        [Action ("StopWheelButtonPushed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void StopWheelButtonPushed (UIKit.UIButton sender);

        [Action ("UpButtonPushed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UpButtonPushed (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (autonomousButton != null) {
                autonomousButton.Dispose ();
                autonomousButton = null;
            }

            if (connectLabel != null) {
                connectLabel.Dispose ();
                connectLabel = null;
            }

            if (getIPAddress != null) {
                getIPAddress.Dispose ();
                getIPAddress = null;
            }

            if (getSpeed != null) {
                getSpeed.Dispose ();
                getSpeed = null;
            }

            if (leftButton != null) {
                leftButton.Dispose ();
                leftButton = null;
            }

            if (modeLabel != null) {
                modeLabel.Dispose ();
                modeLabel = null;
            }

            if (rightButton != null) {
                rightButton.Dispose ();
                rightButton = null;
            }

            if (setSpeedButton != null) {
                setSpeedButton.Dispose ();
                setSpeedButton = null;
            }

            if (speedValue != null) {
                speedValue.Dispose ();
                speedValue = null;
            }

            if (startButton != null) {
                startButton.Dispose ();
                startButton = null;
            }

            if (stopWheelButton != null) {
                stopWheelButton.Dispose ();
                stopWheelButton = null;
            }

            if (upButton != null) {
                upButton.Dispose ();
                upButton = null;
            }
        }
    }
}