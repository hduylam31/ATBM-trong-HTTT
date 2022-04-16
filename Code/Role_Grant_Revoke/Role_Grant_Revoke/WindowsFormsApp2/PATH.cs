using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class PATH
    {
        string path = @"Data Source=localhost:1521/xe;Persist Security Info=True;User ID=SYSTEM;Password=***********;Unicode=True;";

        public PATH()
        {

        }

        public string getPath()
        {
            return path;
        }
    }
}
