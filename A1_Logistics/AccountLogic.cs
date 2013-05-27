using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A1_DataSource;
using A1_POCO;

namespace A1_Logistics
{
    public class AccountLogic
    {
        private DataSource datasource;

        public AccountLogic()
        {
            datasource = DataSource.GetInstance;
        }



        public void Save(A1_POCO.AccountPOCO account)
        {
            Account a = new Account();
            a.Amount = account.Amount;
            a.ClientID = account.ClientID;
            a.CreationDate = account.CreationDate;
            a.Currency = account.Currency;
            a.Number = account.Number;
            a.Type = account.Type;
                
            datasource.SaveAccount(a);
        }

        public A1_POCO.ClientPOCO Get(int clientId)
        {
            Client c = datasource.getClientbyId(clientId);
            ClientPOCO client = new ClientPOCO();

            client.Address = c.Address;
            client.CNP = c.CNP;
            client.FirstName = c.FirstName;
            client.ICN = c.ICN;
            client.ID = c.ID;
            client.LastName = c.LastName;

            client.Accounts = new List<AccountPOCO>();

            foreach (var account in c.Accounts)
            { 
                AccountPOCO a = new AccountPOCO();

                a.ID = account.ID;
                a.Amount = account.Amount;
                a.ClientID = account.ClientID;
                a.CreationDate = account.CreationDate;
                a.Currency = account.Currency;
                a.Number = account.Number;
                a.Type = account.Type;

                client.Accounts.Add(a);
            }

            return client;
        }

        public void Delete(int accountId)
        {
            datasource.DeleteAccount(accountId);
        }
    }
}
