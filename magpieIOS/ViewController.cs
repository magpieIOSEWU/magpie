using System;

using UIKit;

namespace magpieIOS
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}





		partial void AccountSettingsButton_TouchUpInside(UIButton sender)
		{
			
		}

		partial void LogoutButton_TouchUpInside(UIButton sender)
		{
			
		}

		partial void PrivatcyPolicyButton_TouchUpInside(UIButton sender)
		{
			
		}

		partial void TermsOfUseButton_TouchUpInside(UIButton sender)
		{
			
		}

		partial void DistanceAwayButton_TouchUpInside(UIButton sender)
		{
			
		}

		partial void FindLocationButton_TouchUpInside(UIButton sender)
		{
			
		}

		partial void CollecitonsButoon_TouchUpInside(UIButton sender)
		{
			
		}
	}
}
