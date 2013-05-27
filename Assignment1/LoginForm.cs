using A1_Logistics;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            loginLogic = new LoginLogic();
        }

        private LoginLogic loginLogic;

        private void btn_login_Click(object sender, EventArgs e)
        {
            Form main_form = null;

            int userType = loginLogic.userType(textBox_username.Text, textBox_password.Text);
            
            if (userType == -1)
            {
                MessageBox.Show("Wrong Credentials! ");
                return; 
            }

            if (userType == 0)
            {
                main_form = new MainForm();
            }

            if (userType == 1)
            {
                main_form = new AdminForm();
            }


           
            main_form.Show(); // Show Main Form
            this.Hide(); // closes the Login Form instance.

            main_form.FormClosed +=main_form_FormClosed;
        }

        private void main_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

    }
}
