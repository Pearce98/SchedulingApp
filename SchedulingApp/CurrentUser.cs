using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingApp
{
    class CurrentUser
    {
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

        
    }
}
