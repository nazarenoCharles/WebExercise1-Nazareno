﻿using System;
using System.Collections.Generic;
using System.Text;
using BusinessData;

namespace Domain.Repository
{
    public sealed class PostRepository
    {
        private static readonly PostRepository _instance = new PostRepository();
        List<Posts> postlist = new List<Posts>();
        Posts listings = new Posts();

        public static PostRepository GetPostRepository()
        {
            var p = _instance.postlist;
            return _instance;
        }
        
        

        public void AddPostRepo(Posts newPost)
        {
            postlist.Add(newPost);
        }

    }
}
