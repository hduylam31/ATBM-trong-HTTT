using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminUI
{
    internal class ConnectionString
    {
        string PATH = "(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = WaterFourPC.mshome.net)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = XE)))";
        static string conStr = "";
<<<<<<< HEAD
        static string user = "";
        static  string pass = "";
        
=======
        public string user = "";
        public string pass = "";

>>>>>>> 8667402447bf2047a5f9023cc42626f5989ff35e
        public string getString()
        {
            return conStr;
        }

        public void setConStr(string username, string password)
        {
            conStr = "Data Source = " + PATH + "; User Id = " + username + ";password=" + password;
            user = username;
            pass = password;
<<<<<<< HEAD
        }

        public string getUser()
        {
            return user;
        }
        public string getPass()
        {
            return pass;
=======
>>>>>>> 8667402447bf2047a5f9023cc42626f5989ff35e
        }
    }
}
