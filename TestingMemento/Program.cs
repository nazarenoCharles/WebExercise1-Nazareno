using System;
using System.Collections.Generic;

namespace TestingMemento
{
    class Program
    {
        PostRepository postrepo = new PostRepository();
        static void Main(string[] args)
        {
          
        }
        public void Posted(int pID, string UserTitleName, string UserPost, string UserComment)
        {
            Posts newposts = new Posts
            {
                PostID = 000000,
                UserTitleName = "Sample Title",
                UserPost = "I have created a sample post",
                UserComment = "pls sub 2 pewds",
            };
            Posts.CreatePost(newposts);
        }




    }
}
