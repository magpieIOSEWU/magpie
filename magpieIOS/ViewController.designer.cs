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
        UIKit.UIButton collectionButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton distanceButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton findLocationButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lineBreak { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton logoutButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView mainView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton privacyButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton termsButton { get; set; }

        [Action ("AccountSettingsButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void AccountSettingsButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("CollectionButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CollectionButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("DistanceButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DistanceButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("FindLocationButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void FindLocationButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("LogoutButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void LogoutButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("PrivacyButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void PrivacyButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("TermsButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void TermsButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (accountSettingsButton != null) {
                accountSettingsButton.Dispose ();
                accountSettingsButton = null;
            }

            if (collectionButton != null) {
                collectionButton.Dispose ();
                collectionButton = null;
            }

            if (distanceButton != null) {
                distanceButton.Dispose ();
                distanceButton = null;
            }

            if (findLocationButton != null) {
                findLocationButton.Dispose ();
                findLocationButton = null;
            }

            if (lineBreak != null) {
                lineBreak.Dispose ();
                lineBreak = null;
            }

            if (logoutButton != null) {
                logoutButton.Dispose ();
                logoutButton = null;
            }

            if (mainView != null) {
                mainView.Dispose ();
                mainView = null;
            }

            if (privacyButton != null) {
                privacyButton.Dispose ();
                privacyButton = null;
            }

            if (termsButton != null) {
                termsButton.Dispose ();
                termsButton = null;
            }
        }
    }
}