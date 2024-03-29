﻿using System;
using System.Collections.Generic;
using System.Text;
using BusinessData;

namespace BusinessData
{
    public class Posts : Entity
    {
        
        public int pID;
        
        public string titleN;
        public string postN;
        public string commentN;

        public int PostID
        {
            get { return PostID; }
            set { pID = value; }
        }
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

        public string needChange { get; set; }
    }

}
