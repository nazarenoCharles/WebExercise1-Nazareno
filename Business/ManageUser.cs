using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessData;

namespace Business
{
    public class ManageUser : Users
    {
        List<Users> userlist;
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
            public void RemoveUser(int uID)
            {
                userlist.RemoveAll(x => x.entityID == uID);
            }
        
        public void EditUser(int uID)
        {
            userlist.FirstOrDefault(x => x.entityID == uID);
            foreach (var user in userlist)
            {
                userlist.Where(x => x.userFirstName == "")
                .Select(x => { x.userFirstName = userFirstName; return x; }).ToList();
                userlist.Where(x => x.userLastName == "")
                .Select(x => { x.userLastName = userLastName; return x; }).ToList();
                userlist.Where(x => x.userGender == "")
                .Select(x => { x.userGender = userGender; return x; }).ToList();
                userlist.Where(x => x.userBirthday == null)
                .Select(x => { x.userBirthday = userBirthday; return x; }).ToList();
                userlist.Where(x => x.userEmail == "")
                .Select(x => { x.userEmail = userEmail; return x; }).ToList();
                userlist.Where(x => x.userAge == 0)
                .Select(x => { x.userAge = userAge; return x; }).ToList();
            }
        }

    }
}
