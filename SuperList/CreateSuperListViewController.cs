using Foundation;
using System;
using UIKit;
using Realms;
using SuperList.Model;

namespace SuperList
{
    public partial class CreateSuperListViewController : UIViewController
    {
        Realm _Realm;

        public CreateSuperListViewController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewWillAppear(bool animated)
        {
            _Realm = Realm.GetInstance();
        }

        partial void OnDismiss(UIButton sender)
        {
            this.DismissViewController(true, null);
        }



        partial void OnCreatingSuperLst(UIButton sender)
        {
            if (string.IsNullOrWhiteSpace(EntrySLName.Text) || string.IsNullOrWhiteSpace(EntrySLDescription.Text))
            {
                Acr.UserDialogs.UserDialogs.Instance.Alert("Must fill all fields.", "Alert", "OK");

                return;
            }

            _Realm.Write(() =>
            {
                var superList = new Model.SuperList();

                superList.Id = Guid.NewGuid().ToString();
                superList.SLName = EntrySLName.Text;
                superList.Description = EntrySLDescription.Text;

                _Realm.Add(superList);
            });

            ClearFields();
        }

        void ClearFields()
        {
            EntrySLName.Text = string.Empty;
            EntrySLDescription.Text = string.Empty;
        }

        //void DisplayOKAlert(string title, string message)
        //{
        //    var okAlert = UIAlertController.Create(title, message, UIAlertControllerStyle.Alert);
        //    okAlert.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
        //    PresentViewController(okAlert, true, null);
        //}
    }
}