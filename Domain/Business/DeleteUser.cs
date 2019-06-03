using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Domain.Business
{
    class DeleteUser : Users
    {
        List<Users> userlist = new List<Users>();
        public void RemoveUser(int uID)
        {
            userlist.RemoveAll(x => x.entityID  == uID);
        }
    }
}
