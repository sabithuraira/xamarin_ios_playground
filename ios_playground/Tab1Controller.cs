using Foundation;
using System;
using UIKit;

namespace ios_playground
{
	public partial class Tab1Controller : UIViewController, TabInterface
    {
		string label_text = "Tab1";
        public Tab1Controller (IntPtr handle) : base (handle)
        {
        }

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
			this.Lbl_item.Text = label_text;
		}

		public void ReloadScreen(int click)
		{
			label_text = "Tab1 : You tab me " + click.ToString() + " time(s)";
			if (this.Lbl_item != null)
				this.Lbl_item.Text = label_text;
		}
    }
}