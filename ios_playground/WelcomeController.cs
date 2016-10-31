using Foundation;
using System;
using UIKit;

namespace ios_playground
{
    public partial class WelcomeController : UIViewController
    {
        public WelcomeController (IntPtr handle) : base (handle)
        {
        }

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue(segue, sender);

			var viewContoller = segue.DestinationViewController as ViewController;

			if (viewContoller != null)
			{
				viewContoller.Param1 = "I love you";
			}
		}
    }
}