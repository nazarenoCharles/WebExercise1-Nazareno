using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessData;


namespace Business
{
    public class ManagePost : Posts
    {
        List<Posts> postlist;

        public ManagePost()
        {
            postlist.Add(new Posts
            {
                PostID = 1,
                UserTitleName = "asdsadsa",
                UserPost = "samp post",
                UserComment = "commentN",

            });

        }
        public void RemoveData(int pID)
        {

            postlist.RemoveAll(x => x.PostID == pID);
        }

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
        public Posts Posted(int pID)
        {

            Posts posts = new Posts()
            {
                PostID = 000000,
                UserTitleName = "Sample Title",
                UserPost = "I have created a sample post",
                UserComment = "pls sub 2 pewds",
            };

            foreach (var post in postlist)
            {
                if (PostID == pID)
                {
                    return post;
                }

            }
            return posts;
        }

        public void EditPosts(int pID)
        {
            postlist.FirstOrDefault(p => p.PostID == pID);
            foreach (var post in postlist)
            {
                postlist.Where(x => x.UserTitleName == "")
                .Select(x => { x.UserTitleName = UserTitleName; return x; }).ToList();
                postlist.Where(x => x.UserPost == "")
                .Select(x => { x.UserPost = UserPost; return x; }).ToList();
                postlist.Where(x => x.UserComment == "")
                .Select(x => { x.UserComment = UserComment; return x; }).ToList();

                if(postlist != null)
                {
                    Undo();
                }
            }
        }
        public void Undo()
        {
            MementoPost mememnto = new MementoPost();
        }

    }
}

