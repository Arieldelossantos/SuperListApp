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
    [Register ("CreateSLIViewController")]
    partial class CreateSLIViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView CategoryPicker { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField DescriptionField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField ItemNameField { get; set; }

        [Action ("BtnCancel:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnCancel (UIKit.UIBarButtonItem sender);

        [Action ("btnSave:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void btnSave (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets ()
        {
            if (CategoryPicker != null) {
                CategoryPicker.Dispose ();
                CategoryPicker = null;
            }

            if (DescriptionField != null) {
                DescriptionField.Dispose ();
                DescriptionField = null;
            }

            if (ItemNameField != null) {
                ItemNameField.Dispose ();
                ItemNameField = null;
            }
        }
    }
}