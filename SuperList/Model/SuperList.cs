using System;
using System.Collections.Generic;
using Realms;

namespace SuperList.Model
{
    public class SuperList : RealmObject
    {
        [PrimaryKey]
        public string Id { get; set; }

        public string SLId { get; set; }
        public string SLName
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string Owner
        {
            get;
            set;
        }

        public IList<SuperListItem> SLItems
        {
            get;
        }
    }
}
