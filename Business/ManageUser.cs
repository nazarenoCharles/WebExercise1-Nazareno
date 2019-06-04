using System;
using System.Collections.Generic;
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
                Users nouser = new Users();
                {
                    uID = 0;
                    userFirstName = "";
                    userLastName = "";
                    userAge = 0;
                    userEmail = "";
                    userBirthday = DateTime.Parse("");
                    userGender = "";

                    
                }
                foreach (var user in userlist)
                {
                    if (entityID == uID)
                    {
                        return user;
                    }
                }
                return nouser;

            }
        }


    }
}
