// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ios_playground
{
    [Register ("LauncController")]
    partial class LauncController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITabBar Tabbar1 { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Tabbar1 != null) {
                Tabbar1.Dispose ();
                Tabbar1 = null;
            }
        }
    }
}