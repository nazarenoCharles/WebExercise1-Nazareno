using System;
using System.Collections.Generic;
using System.Text;
using Domain;

namespace Domain.Business
{
    class AddUser : Users
    {
        Domain.Users NewUsers = new Domain.Users();
        List<Users> userlist = new List<Users>();

        
        public void CreateUser(int uID, string fName, string lName, string uEmail, int uAge, DateTime uBday, string gender)
        {
            userlist.Add(new Users
            {
                entityID = uID,
                userFirstName = fName,
                userLastName = lName,
                userEmail = uEmail,
                userAge = uAge,
                userBirthday = uBday,
                userGender = gender
            });
        }
       


    }
}
