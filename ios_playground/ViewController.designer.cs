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
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Label_count { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField Txt_Name { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Txt_param { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Label_count != null) {
                Label_count.Dispose ();
                Label_count = null;
            }

            if (Txt_Name != null) {
                Txt_Name.Dispose ();
                Txt_Name = null;
            }

            if (Txt_param != null) {
                Txt_param.Dispose ();
                Txt_param = null;
            }
        }
    }
}