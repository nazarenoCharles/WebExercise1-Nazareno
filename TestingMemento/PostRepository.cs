using System;
using System.Collections.Generic;
using System.Text;

namespace TestingMemento
{
    public class PostRepository
    {
        public List<Post> posts = new List<Post>();
        
        public void CreatePost(Posts Post)
        {
            posts.Add(Post);
            Console.WriteLine("Successfully added new post!");
        }
    }
}
