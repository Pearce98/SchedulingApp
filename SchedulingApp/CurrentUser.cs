using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingApp
{
    class CurrentUser
    {
        //class is used to store data of the logged in user
        private static int currentID;
        private static string currentUserName;
        
        public static void setUserID(int ID)
        {
            currentID = ID;
        }

        public static int returnUserID()
        {
            return currentID;
        }

        public static void setName(string name)
        {
            currentUserName = name;
        }
        
        public static string returnName()
        {
            return currentUserName;
        }
    }
}
