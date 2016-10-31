using System;

using UIKit;

namespace ios_playground
{
	public partial class ViewController : UIViewController
	{
		public string Param1;
		protected ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.Txt_param.Text = Param1;
			this.Txt_Name.EditingChanged += (sender, ea) =>
			{
				this.Label_count.Text = "Count of character : " + ((UITextField)sender).Text.Length;
			};	
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
