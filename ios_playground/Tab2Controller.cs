using Foundation;
using System;
using UIKit;

namespace ios_playground
{
	public partial class Tab2Controller : UIViewController, TabInterface
    {
		string label_text = "Tab2";
        public Tab2Controller (IntPtr handle) : base (handle)
        {
        }

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
			this.Lbl_Item.Text = label_text;
		}

		public void ReloadScreen(int click)
		{
			this.label_text = "Tab 2 : You tab me " + click.ToString() + " time(s)";
			if (this.Lbl_Item != null)
				this.Lbl_Item.Text = label_text;	
		}
    }
}