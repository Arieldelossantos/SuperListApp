using Foundation;
using Realms;
using SuperList.Model;
using System;
using System.Collections.Generic;
using UIKit;

namespace SuperList
{
    public class SuperListItemsTableSouce : UITableViewSource
    {
        List<SuperListItem> SLItems;
        string CellIdentifier = "SLICell";

        public SuperListItemsTableSouce(List<SuperListItem> superListItems)
        {
            SLItems = superListItems;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier, indexPath);


            //if(cell==null)
            //{
            //    cell = new UITableViewCell(UITableViewCellStyle.Subtitle, CellIdentifier);
            //}
            SuperListItem list = SLItems[indexPath.Row];

            cell.TextLabel.Text = list.SLIName;
            cell.DetailTextLabel.Text = list.Description;

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return SLItems.Count;
        }
    }


    public partial class SuperListItemsViewController : UITableViewController
    {

        public List<SuperListItem> SLItems;
        public string SLId { get; set; }
        Realm _Realm;
        public SuperListItemsViewController(IntPtr handle) : base(handle)
        {
            _Realm = Realm.GetInstance();
        }


        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);


        }
        public override void ViewDidLoad()
        {
            if (!string.IsNullOrEmpty(SLId))
            {
                var sliId = SLId;
            }


        }



        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            if (segue.Identifier == "CreateItemSegue")
            {

                var createSLIViewController = segue.DestinationViewController as CreateSLIViewController;

                if (createSLIViewController != null)
                {
                    createSLIViewController.SLId = SLId;

                }

            }

        }

    }
}