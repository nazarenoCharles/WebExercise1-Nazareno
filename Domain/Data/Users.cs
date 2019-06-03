using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Users : Entity
    {
        IEntity users = new IEntity();
        int uID;
        string fName;
        string lName;
        string gender;
        DateTime uBDay;
        int uAge;
        string uEmail;
        private DateTime uBday;
        private DateTime userBirthDate;

        public int entityID
        {
            get { return entityID; }
            set { uID = value; }
        }

        public string userFirstName
        {
            get { return userFirstName; }
            set { fName = value; }
        }
        public string userLastName
        {
            get { return userLastName; }
            set { lName = value; }
        }
        public DateTime userBirthday
        {
            get { return userBirthDate; }
            set { uBDay = value; }
        }
        public string userGender
        {
            get { return userGender; }
            set { gender = value; }
        }
        public int userAge
        {
            get { return userAge; }
            set { uAge = value; }
        }
        public string userEmail
        {
            get { return userEmail; }
            set { uEmail = value; }
        }


    }
    

}

