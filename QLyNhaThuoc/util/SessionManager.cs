using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicine_store.util
{
    public class SessionManager
    {
        private static string loggedInUserID;
        private static string loggedInUsername;

        public static string LoggedInUser 
        {
            get {  return loggedInUsername; } 
            set { loggedInUsername = value; }
        }

        public static string loggedInAdminID
        {
            get { return loggedInUserID; }
            set { loggedInUserID = value; }
        }
    }
}
