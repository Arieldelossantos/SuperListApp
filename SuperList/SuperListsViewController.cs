using Foundation;
using Realms;
using System;
using UIKit;
using SuperList.Model;
using System.Collections.Generic;
using System.Linq;

namespace SuperList
{

    public class SuperListTableSouce : UITableViewSource
    {
        List<Model.SuperList> MySuperLists;
        string CellIdentifier = "SuperListCell";

        public SuperListTableSouce(List<Model.SuperList> mySuperLists)
        {
            MySuperLists = mySuperLists;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier, indexPath);


            //if(cell==null)
            //{
            //    cell = new UITableViewCell(UITableViewCellStyle.Subtitle, CellIdentifier);
            //}
            Model.SuperList list = MySuperLists[indexPath.Row];

            cell.TextLabel.Text = list.SLName;
            cell.DetailTextLabel.Text = list.Description;

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return MySuperLists.Count;
        }
    }


    public partial class SuperListsViewController : UITableViewController
    {
        Realm _Realm;

        List<Model.SuperList> AllSuperList;
        public SuperListsViewController(IntPtr handle) : base(handle)
        {
            _Realm = Realm.GetInstance();
        }

        public override void ViewWillAppear(bool animated)
        {
            AllSuperList = _Realm.All<Model.SuperList>().ToList();

            TableView.Source = new SuperListTableSouce(AllSuperList);

        }
        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            if (segue.Identifier == "showDetails")
            {
                var content = AllSuperList[TableView.IndexPathForSelectedRow.Row];

                var sliViewController = segue.DestinationViewController as SuperListItemsViewController;

                if (sliViewController != null)
                {
                    sliViewController.SLId = content.Id;

                }

            }
        }

        public override void ViewDidLoad()
        {

        }
    }
}