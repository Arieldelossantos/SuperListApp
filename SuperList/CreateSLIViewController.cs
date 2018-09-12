using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace SuperList
{
    public class Categories : UIPickerViewModel
    {


        public EventHandler ValueChanged;
        public string CategoryName;


        public string[] categoryList = new string[]
        {
            "Breakfast",
            "Lunch",
            "Dinner",
            "For the Kids",
            "Fridge",
            "Veggies/Fruits",
            "Bath",
            "Pantry",
            "Washing"

        };
        public override nint GetComponentCount(UIPickerView pickerView)
        {
            return 1;
        }

        public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
        {
            return categoryList.Length;
        }

        public override string GetTitle(UIPickerView pickerView, nint row, nint component)
        {
            if (component == 0)
                return categoryList[row];
            else
                return row.ToString();
        }

        public override void Selected(UIPickerView pickerView, nint row, nint component)
        {

            CategoryName = categoryList[pickerView.SelectedRowInComponent(0)];
            ValueChanged?.Invoke(null, null);
        }

        //public override nfloat GetComponentWidth(UIPickerView picker, nint component)
        //{
        //    if (component == 0)
        //        return 240f;
        //    else
        //        return 40f;
        //}

        public override nfloat GetRowHeight(UIPickerView picker, nint component)
        {
            return 40f;
        }

    }

    public partial class CreateSLIViewController : UITableViewController
    {

        public string SLId { get; set; }
        public string CategoryName { get; set; }

        public CreateSLIViewController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            var categoryModel = new Categories();
            CategoryPicker.Model = categoryModel;
            CategoryPicker.ShowSelectionIndicator = true;

            categoryModel.ValueChanged += (sender, e) =>
            {
                CategoryName = categoryModel.CategoryName;
            };
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

        }


        partial void BtnCancel(UIBarButtonItem sender)
        {
            this.DismissViewController(true, null);
        }

        partial void btnSave(UIBarButtonItem sender)
        {
            var name = ItemNameField.Text;
            var desc = DescriptionField.Text;
            var cat = CategoryName;
        }
    }
}