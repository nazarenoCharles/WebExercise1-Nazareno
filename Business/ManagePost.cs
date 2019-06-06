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
            MementoPost save = new MementoPost();
            PostCaretaker savelist = new PostCaretaker();
            postlist.FirstOrDefault(p => p.PostID == pID);
            foreach (var post in postlist)
            {
                save.pID = postlist.Select(c => {c.needChange = PostID; return c; });
                save.UserTitleName = postlist.Select(c => { c.needChange = UserTitleName; return c; });
                save.UserPost = postlist.Where(x => x.UserPost == "Body of Edit").Select(x => { x.UserPost = UserPost; return x; }).ToList();
                save.UserComment = postlist.Where(x => x.UserComment == "Commented").Select(x => { x.UserComment = UserComment; return x; }).ToList();
                
                if (post != null)
                {
                    save.RestoreMemento(savelist.Memento);
                }
            }
            
        }


    }
}

