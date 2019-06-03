using System;
using System.Collections.Generic;
using System.Text;
using Domain.Data;

namespace Domain.Data
{
    public class Posts : Users 
    {
        string titleN;
        string postN;
        string commentN;

        public string UserTitleName
        {
            get { return UserTitleName; }
            set { titleN = value; }
        }
        public string UserPost
        {
            get { return UserPost; }
            set { postN = value; }
        }
        public string UserComment
        {
            get { return UserComment; }
            set { commentN = value; }
        }
    }

}
