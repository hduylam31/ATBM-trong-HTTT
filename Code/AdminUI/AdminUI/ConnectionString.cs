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
        static string user = "";
        static  string pass = "";
        
        public string getString()
        {
            return conStr;
        }

        public void setConStr(string username, string password)
        {
            conStr = "Data Source = " + PATH + "; User Id = " + username + ";password=" + password;
            user = username;
            pass = password;
        }

        public string getUser()
        {
            return user;
        }
        public string getPass()
        {
            return pass;
        }
    }
}
