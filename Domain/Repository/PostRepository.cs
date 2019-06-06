using System;
using System.Collections.Generic;
using System.Text;
using BusinessData;

namespace Domain.Repository
{
    public class PostRepository
    {
        List<Posts> postlist = new List<Posts>();
        public void AddPostRepo(Posts newPost)
        {
            postlist.Add(newPost);
        }

    }
}
