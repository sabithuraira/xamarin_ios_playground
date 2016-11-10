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
    [Register ("Tab2Controller")]
    partial class Tab2Controller
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Lbl_Item { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Lbl_Item != null) {
                Lbl_Item.Dispose ();
                Lbl_Item = null;
            }
        }
    }
}