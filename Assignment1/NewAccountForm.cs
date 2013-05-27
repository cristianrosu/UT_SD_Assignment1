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
    public partial class NewAccountForm : Form
    {
        private AccountPOCO account;
        public NewAccountForm()
        {
            InitializeComponent();
        }


        public NewAccountForm(AccountPOCO account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //Save
            account.Amount = 0;
            account.Number = number.Text;
            account.Type = int.Parse(type.Text);
            account.Currency = int.Parse(currency.Text);
            account.CreationDate = DateTime.Today.ToShortDateString();

            this.Close();
        }
    }
}
