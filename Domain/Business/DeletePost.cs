using System;
using System.Collections.Generic;
using System.Text;
using Domain.Data;

namespace Domain.Business
{
    class DeletePost : Posts
    {
        List<Posts> userlist = new List<Posts>();
        public void RemoveData(string titleN)
        {
            userlist.RemoveAll(x => x.UserTitleName == titleN);
        }
    }
}
