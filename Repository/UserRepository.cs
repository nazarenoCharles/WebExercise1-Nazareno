using System;
using System.Collections.Generic;
using System.Text;
using BusinessData;

namespace Domain.Repository
{
    public class IUserRepository : Users
    {
        List<Users> userlist = new List<Users>
        {
            
        };
        public void AddUserRepo(Users newUsers)
        {
            userlist.Add(newUsers);
        }

    }
}
