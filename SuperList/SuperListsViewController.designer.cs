// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace SuperList
{
    [Register ("SuperListsViewController")]
    partial class SuperListsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem AddTaskListButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (AddTaskListButton != null) {
                AddTaskListButton.Dispose ();
                AddTaskListButton = null;
            }
        }
    }
}