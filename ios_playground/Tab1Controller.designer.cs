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
    [Register ("Tab1Controller")]
    partial class Tab1Controller
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Lbl_item { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Lbl_item != null) {
                Lbl_item.Dispose ();
                Lbl_item = null;
            }
        }
    }
}