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
    [Register ("CreateSuperListViewController")]
    partial class CreateSuperListViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField EntrySLDescription { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField EntrySLName { get; set; }

        [Action ("OnCreatingSuperLst:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void OnCreatingSuperLst (UIKit.UIButton sender);

        [Action ("OnDismiss:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void OnDismiss (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (EntrySLDescription != null) {
                EntrySLDescription.Dispose ();
                EntrySLDescription = null;
            }

            if (EntrySLName != null) {
                EntrySLName.Dispose ();
                EntrySLName = null;
            }
        }
    }
}