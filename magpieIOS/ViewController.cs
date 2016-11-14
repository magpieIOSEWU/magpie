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



		partial void CollectionButton_TouchUpInside(UIButton sender)
		{
			throw new NotImplementedException();
		}

		partial void FindLocationButton_TouchUpInside(UIButton sender)
		{
			throw new NotImplementedException();
		}

		partial void DistanceButton_TouchUpInside(UIButton sender)
		{
			throw new NotImplementedException();
		}

		partial void TermsButton_TouchUpInside(UIButton sender)
		{
			throw new NotImplementedException();
		}

		partial void PrivacyButton_TouchUpInside(UIButton sender)
		{
			throw new NotImplementedException();
		}

		partial void AccountSettingsButton_TouchUpInside(UIButton sender)
		{
			throw new NotImplementedException();
		}

		partial void LogoutButton_TouchUpInside(UIButton sender)
		{
			throw new NotImplementedException();
		}
	}
}
