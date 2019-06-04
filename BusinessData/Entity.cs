using System;
using System.Collections.Generic;
using System.Text;
using BusinessData;

namespace BusinessData
{
    public class Entity
    {
        public class IEntity
        {
            public int uID;
            public DateTime uCreated;

            
            public int EntityID
            {
                get { return EntityID; }
                set { uID = value; }
            }
             
            public DateTime UserCreated
            {
                get { return UserCreated; }
                set { uCreated = value;}
            }
        }

    }
}
