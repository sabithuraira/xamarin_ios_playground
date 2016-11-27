using Foundation;
using System;
using UIKit;

namespace ios_playground
{
	public partial class Tab2Controller : UIViewController, TabInterface
    {
		UIWebView webView;
		string url = "http://xamarin.com/";
        public Tab2Controller (IntPtr handle) : base (handle)
        {}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			webView = new UIWebView(View.Bounds);
			View.AddSubview(webView);

			webView.LoadRequest(new NSUrlRequest(new NSUrl(url)));
			webView.ScalesPageToFit = true;
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);
		}

		public void ReloadScreen(int click)
		{
		}
    }
}