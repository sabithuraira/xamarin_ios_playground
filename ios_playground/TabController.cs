using Foundation;
using System;
using System.Collections.Generic;
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
			List<UIBarButtonItem> list_bar = new List<UIBarButtonItem>();

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

			UIBarButtonItem t2 = new UIBarButtonItem(
				"Add Bar",
				UIBarButtonItemStyle.Plain,
				(s, e) =>
				{
					List<UIViewController> temp_list = new List<UIViewController>(this.ViewControllers);

					UIViewController new_tab = new DynamicController();
					new_tab.TabBarItem.Title = "Item #" + (temp_list.Count + 1).ToString();
					temp_list.Add(new_tab);

					this.ViewControllers = temp_list.ToArray();
				}
			);


			list_bar.Add(t1);
			list_bar.Add(t2);

			NavigationItem.RightBarButtonItems = list_bar.ToArray();
		}
    }
}