using System;
using System.Collections.Generic;
using System.Text;


namespace TestingMemento
{
    public class Posts
    {

        public int pID;

        private string titleN;
        private string postN;
        private string commentN;

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

        internal static void CreatePost(Posts newposts)
        {
            throw new NotImplementedException();
        }
    }

}
