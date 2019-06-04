using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessData;

namespace Business
{
    public class ManageUser : Users
    {
        BusinessData.Users NewUsers = new BusinessData.Users();
        public class AddUser : Users
        {

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
        public class DeleteUser : Users
        {
            List<Users> userlist = new List<Users>();
            public void RemoveUser(int uID)
            {
                userlist.RemoveAll(x => x.entityID == uID);
            }
        }

        public class showProfile : Users
        {
            List<Users> userlist = new List<Users>();
            public Users UserProfile(int uID)
            {
                Users Getuser = new Users();
                {
                    uID = 37010;
                    userFirstName = "Charles";
                    userLastName = "Nazareno";
                    userAge = 21;
                    userEmail = "friendflare456@gmail.com";
                    userBirthday = DateTime.Parse("06/27/1996");
                    userGender = "Female";
                    
                }
                foreach (var user in userlist)
                {
                    if (entityID == uID)
                    {
                        return user;
                    }
                }
                return Getuser;
            }
        }
        public void EditUser(Users users)
        {
            List<Users> userlist = new List<Users>();
            foreach (var user in userlist)
            {
                var edit = userlist.FirstOrDefault(x => x.userFirstName == userFirstName);
                if (edit != null) edit.userFirstName = userFirstName;
            }
        }


    }
}
