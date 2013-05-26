using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A1_DataSource;
using A1_POCO;

namespace A1_Logistics
{
    public class MainLogic
    {
        DataSource datasource;

        public MainLogic()
        {
            datasource = new DataSource();
        }


        public List<UserPOCO> GetUsers()
        {
            List<UserPOCO> usersPoco = new List<UserPOCO>();
            List<User> users =  datasource.getUsers();

            foreach (var u in users) 
            {
                UserPOCO userPoco = new UserPOCO();
                userPoco.ID = u.ID;
                userPoco.FirstName = u.FirstName;

                usersPoco.Add(userPoco);
            }
            return usersPoco;
        }

        public List<ClientPOCO> GetClients()
        {
            List<ClientPOCO> usersPoco = new List<ClientPOCO>();
            List<Client> users = datasource.getClients();

            foreach (var u in users)
            {
                ClientPOCO userPoco = new ClientPOCO();
                userPoco.ID = u.ID;
                userPoco.FirstName = u.FirstName;
                userPoco.LastName = u.LastName;
                userPoco.Address = u.Address;
                userPoco.CNP = u.CNP;
                userPoco.ICN = u.ICN;

                usersPoco.Add(userPoco);
            }
            return usersPoco;
        }
    }
}
