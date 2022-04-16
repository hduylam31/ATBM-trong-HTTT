using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminUI
{
    internal class ConnectionString
    {
        string PATH = "(DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)))(CONNECT_DATA = (SERVICE_NAME = XEPDB1)))";
        static string conStr = "";
        
        public string getString()
        {
            return conStr;
        }

        public void setConStr(string username, string password)
        {
            conStr = "Data Source = " + PATH + "; User Id = " + username + ";password=" + password;
        }
    }
}
