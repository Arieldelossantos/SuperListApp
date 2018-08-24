using System;
using Realms;

namespace SuperList.Model
{
    public class SuperListItem : RealmObject
    {
        [PrimaryKey,]
        public string Id { get; set; }

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

        public SuperList SuperList
        {
            get;
            set;
        }
    }
}
