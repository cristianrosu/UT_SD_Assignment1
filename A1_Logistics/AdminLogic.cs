using A1_DataSource;
using A1_POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_Logistics
{
    public class AdminLogic
    {
        private DataSource datasource;
        public AdminLogic()
        {
            datasource = DataSource.GetInstance;
        }

        public List<UserPOCO> GetUsers()
        {
            List<UserPOCO> users = new List<UserPOCO>();

            List<User> usrs = datasource.getUsers();
            foreach (User u in usrs)
            {
                UserPOCO usr = new UserPOCO();

                usr.FirstName = u.FirstName;
                usr.ID = u.ID;
                usr.LastName = u.LastName;
                usr.Password = u.Password;
                usr.Type = u.Type;
                usr.Username = usr.Username;

                users.Add(usr);
            }

            return users;
        }
    }
}
