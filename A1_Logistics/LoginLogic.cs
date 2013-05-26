using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A1_DataSource;

namespace A1_Logistics
{
    public class LoginLogic
    {
        DataSource datasource;

        public LoginLogic()
        {
            datasource = new DataSource();
        }

        public int userType(string username, string password)
        {
            User user = datasource.getUser(username, password);
            if (user != null)
            {
                return user.Type;
            }
            else return -1;
        }
    }
}
