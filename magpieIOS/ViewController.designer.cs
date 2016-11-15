// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace magpieIOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton accountSettingsButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton collecitonsButoon { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton distanceAwayButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton findLocationButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton logoutButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView mainView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton privatcyPolicyButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton termsOfUseButton { get; set; }

        [Action ("AccountSettingsButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void AccountSettingsButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("CollecitonsButoon_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CollecitonsButoon_TouchUpInside (UIKit.UIButton sender);

        [Action ("DistanceAwayButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DistanceAwayButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("FindLocationButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void FindLocationButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("LogoutButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void LogoutButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("PrivatcyPolicyButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void PrivatcyPolicyButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("TermsOfUseButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void TermsOfUseButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (accountSettingsButton != null) {
                accountSettingsButton.Dispose ();
                accountSettingsButton = null;
            }

            if (collecitonsButoon != null) {
                collecitonsButoon.Dispose ();
                collecitonsButoon = null;
            }

            if (distanceAwayButton != null) {
                distanceAwayButton.Dispose ();
                distanceAwayButton = null;
            }

            if (findLocationButton != null) {
                findLocationButton.Dispose ();
                findLocationButton = null;
            }

            if (logoutButton != null) {
                logoutButton.Dispose ();
                logoutButton = null;
            }

            if (mainView != null) {
                mainView.Dispose ();
                mainView = null;
            }

            if (privatcyPolicyButton != null) {
                privatcyPolicyButton.Dispose ();
                privatcyPolicyButton = null;
            }

            if (termsOfUseButton != null) {
                termsOfUseButton.Dispose ();
                termsOfUseButton = null;
            }
        }
    }
}