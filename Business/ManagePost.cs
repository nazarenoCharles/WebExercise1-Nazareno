using System;
using System.Collections.Generic;
using System.Text;
using BusinessData;

namespace Business
{
    public class ManagePost : Posts
    {
        public class DeletePost : Posts
        {
            List<Posts> postlist = new List<Posts>();
            public void RemoveData(int pID)
            {
                postlist.RemoveAll(x => x.PostID == pID);
            }
        }



        public class AddPost : Posts
        {
            BusinessData.Users NewUsers = new BusinessData.Users();
            List<Posts> postlist = new List<Posts>();

            public void CreatePost(int pID, string titleN, string postN, string commentN)
            {

                postlist.Add(new Posts
                {
                    PostID = pID,
                    UserTitleName = titleN,
                    UserPost = postN,
                    UserComment = commentN,
                });
            }

        }
        class ShowPost : Posts
        {
            List<Posts> postlist = new List<Posts>();
            public Posts Posted(int pID)
            {
                Posts posts = new Posts()
                {
                    PostID = 0,
                    UserTitleName = "",
                    UserPost = "",
                    UserComment = "",
                };

                foreach(var post in postlist)
                {
                    if (PostID == pID)
                    {
                        return post;
                    }
                    
                }
                return posts;
            }
            
        }



    }


}
