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
    [Register ("WelcomeController")]
    partial class WelcomeController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Btn_Nav { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView My_Table { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Btn_Nav != null) {
                Btn_Nav.Dispose ();
                Btn_Nav = null;
            }

            if (My_Table != null) {
                My_Table.Dispose ();
                My_Table = null;
            }
        }
    }
}