using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessData;
using Domain.Repository;


namespace Business
{
    public class ManagePost : Posts
    {

        private static readonly ManagePost _instance = new ManagePost();
        List<Posts> postlist;

        public static ManagePost ManagingPost()
        {
            return _instance;
        }
        public List<Posts> ShowPost()
        {
            return PostRepository.GetPostRepository().postlist;
        }
        public void AddPost(int pID, string titlename, string userp, string commented)
        {
            PostRepository.GetPostRepository().AddPostRepo(pID, titlename, userp, commented);
        }

        public void RemoveData(int pID)
        {
            postlist.RemoveAll(x => x.PostID == pID);
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

