using System;
using System.Collections.Generic;
using System.Text;
using BusinessData;

namespace Domain.Repository
{
    public sealed class PostRepository
    {
        public List<Posts> postlist = new List<Posts>();
        private static readonly PostRepository _instance = new PostRepository();

        Posts listing = new Posts();

        public static PostRepository GetPostRepository()
        {
            var p = _instance.postlist;
            return _instance;

        }

        public void AddPostRepo(int pID, string titlename, string userp, string commented)
        {
            postlist.Add(new Posts
            {
                PostID = pID,
                UserTitleName = titlename,
                UserPost = userp,
                UserComment = commented,

            });
           
        }


    }
}
