using A1_Logistics;
using A1_POCO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class AccountsForm : Form
    {
        private int clientId;
        private AccountLogic accountLogic;
        private int selectedId;
        public AccountsForm()
        {
            InitializeComponent();
            accountLogic = new AccountLogic();
        }

        public AccountsForm(int clientId)
        {
            InitializeComponent();
            accountLogic = new AccountLogic();
            this.clientId = clientId;
            reload();
        }

        private void reload()
        {
            ClientPOCO client = accountLogic.Get(clientId);

            accountList.Rows.Clear();

            foreach (var a in client.Accounts)
            {
                accountList.Rows.Add(new object[] { a.ID, a.Number, a.Type, a.Currency, a.Amount, a.CreationDate });
            }
            UpdateSelectedRow();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateSelectedRow();
        }

        private void UpdateSelectedRow()
        {
            if (accountList.SelectedRows.Count > 0)
            {
                for (int i = 0; i < accountList.RowCount; i++)
                {
                    if (accountList[0, i].Selected)
                    {
                        selectedId = (int)accountList[0, i].Value;
                        break;
                    }
                }
            }
        }

        private void btn_newAccount_Click(object sender, EventArgs e)
        {
            //new 
            AccountPOCO account = new AccountPOCO();
            account.ClientID = clientId;

            Form accountForm = new NewAccountForm(account);
            accountForm.ShowDialog();

            accountLogic.Save(account);

            reload();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            accountLogic.Delete(selectedId);
            reload();
        }
    }
}
