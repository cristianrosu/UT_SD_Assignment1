using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_DataSource
{
    public class DataSource
    {
        private static DataSource instance;
        private DataSource()
        {
            DB_Entities = new Bank_DBEntities();
        }

        public static DataSource GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataSource();
                }
                return instance;
            }
        }

        protected Bank_DBEntities DB_Entities
        { get; private set; }

        public User getUser(string username, string password)
        {
            User user = (from u in DB_Entities.Users
                    where u.Username == username && u.Password == password
                    select u).FirstOrDefault();
            return user;
        }

        public List<User> getUsers()
        { 
            return (from u in DB_Entities.Users
                   select u).ToList();
        }

        public List<Client> getClients()
        {
            List<Client> clients = (from c in DB_Entities.Clients
                    select c).ToList();
            return clients;
        }

        public Client updateClient(int id, string firstName, string lastname, string cnp, string address, string icn)
        {
            Client client = (from c in DB_Entities.Clients
                             where c.ID == id
                             select c).FirstOrDefault();
            if (client == null)
            {
                Client newClient = new Client();
                newClient.FirstName = firstName;
                newClient.LastName = lastname;
                newClient.CNP = cnp;
                newClient.Address = address;
                newClient.ICN = icn;
                
                DB_Entities.Clients.Add(newClient);
                DB_Entities.SaveChanges();


                return newClient;
            }
            else
            {
                client.FirstName = firstName;
                client.LastName = lastname;
                client.CNP = cnp;
                client.Address = address;
                client.ICN = icn;

                DB_Entities.SaveChanges();
                return client;


            } 
        }

        public Client getClientbyId(int clientID)
        {
            return (from c in DB_Entities.Clients
                    where clientID == c.ID
                    select c).FirstOrDefault();
        }

        public void DeleteClient(int clientID)
        {
            Client clientToRemove = (from c in DB_Entities.Clients
                        where clientID == c.ID
                        select c).FirstOrDefault();

            DB_Entities.Clients.Remove(clientToRemove);
            DB_Entities.SaveChanges();

        }
    }

}
