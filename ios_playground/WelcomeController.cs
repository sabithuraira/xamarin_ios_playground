using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace ios_playground
{
    public partial class WelcomeController : UIViewController
    {
		UIBarButtonItem customButton;
		private List<Player> datas;

        public WelcomeController (IntPtr handle) : base (handle)
        {
			this.datas = new List<Player>();
        }

		public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
		{
			base.PrepareForSegue(segue, sender);

			if (segue.Identifier == "dashboard")
			{
				var viewContoller = segue.DestinationViewController as ViewController;
				if (viewContoller != null)
				{
					viewContoller.Param1 = "I love you";
				}
			}
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			customButton = new UIBarButtonItem(
				"Search",
			UIBarButtonItemStyle.Plain, (s, e) =>
			 {
				 //this.Label1.Text = "Hoi";
			 }
			);
			NavigationItem.RightBarButtonItem = customButton;

			this.datas.Add(new Player("Christiano Ronaldo", "Real Madrid","Portuguese"));
			this.datas.Add(new Player("Lionel Messi", "Barcelona","Argentina"));
			this.datas.Add(new Player("Gareth Bale", "Real Madrid","Wales"));
			this.datas.Add(new Player("Zlatan Ibrahimovic", "Manchester United","Sweden"));
			this.datas.Add(new Player("Mesut Ozil", "Arsenal", "Germany"));

			this.My_Table.Source = new SimpleSource(this.datas);

		}
    }
}