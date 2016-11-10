using Foundation;
using System;
using System.Drawing;
using UIKit;

namespace ios_playground
{
    public partial class TabController : UITabBarController
    {
        public TabController (IntPtr handle) : base (handle)
        {
			
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			this.InitializeBar();
		}

		private int click_count = 0;
		private void InitializeBar()
		{
			UIBarButtonItem t1 = new UIBarButtonItem(
				UIBarButtonSystemItem.Add,
				(s, e) =>
				{
					++click_count;
					foreach (UIViewController temp in this.ViewControllers)
					{
						TabInterface pi = (TabInterface)temp;
						pi.ReloadScreen(click_count);
					} 
				}
			);

			NavigationItem.RightBarButtonItem = t1;
		}
    }
}