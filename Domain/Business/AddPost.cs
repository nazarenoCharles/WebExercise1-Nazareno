using System;
using System.Collections.Generic;
using System.Text;
using Domain.Data;
namespace Domain.Business
{
    class AddPost : Posts
    {
        Domain.Users NewUsers = new Domain.Users();
        List<Posts> postlist = new List<Posts>();

        public void CreatePost(string titleN, string postN, string commentN)
        {

            postlist.Add(new Posts
            {
                
                UserTitleName = titleN,
                UserPost= postN,
                UserComment = commentN,
            });
        
        

        }
    }
}
