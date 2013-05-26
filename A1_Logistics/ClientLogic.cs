using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A1_DataSource;
using A1_POCO;

namespace A1_Logistics
{
    public class ClientLogic
    {
        DataSource datasource;

        

        public ClientLogic()
        {
            datasource = DataSource.GetInstance;
        }

        public void UpdateClient(int id, string firstName, string lastname, string cnp, string address, string icn)
        {
            datasource.updateClient(id, firstName, lastname, cnp, address, icn);
        }



        public ClientPOCO getClient(int clientID)
        {
            Client c = datasource.getClientbyId(clientID);
            ClientPOCO cPoco = new ClientPOCO();
            if (c != null)
            {
                cPoco.ID = c.ID;
                cPoco.FirstName = c.FirstName;
                cPoco.LastName = c.LastName;
                cPoco.CNP = c.CNP;
                cPoco.Address = c.Address;
                return cPoco;
            }
            return null;
            
        }

        public void DeleteUser(int clientID)
        {
            datasource.DeleteClient(clientID);
        }
    }
}
