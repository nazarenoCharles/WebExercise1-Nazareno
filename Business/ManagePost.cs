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
        

        //public void EditPosts(int pID)
        //{
        //    postlist.Where(p => p.PostID == pID);

        //}
        public Posts UpdatePost(Posts updatepost)
        {
            MementoPost save = new MementoPost();
            PostCaretaker savelist = new PostCaretaker();
            Posts post = postlist.FirstOrDefault(p => p.PostID == updatepost.pID); 

            if (post != null)
            {
                save.UserTitleName = post.titleN= updatepost.UserTitleName;
                save.UserPost = post.postN = updatepost.UserPost;
                save.UserComment = post.commentN = updatepost.UserComment;
            }
            else
            {
                postlist.Where(p => p.PostID == updatepost.pID);
                Undo();
            }
            return post;
        }
        public void Undo()
        {
            MementoPost save = new MementoPost();
            PostCaretaker savelist = new PostCaretaker();
            save.RestoreMemento(savelist.Memento);
        }
    }
}

