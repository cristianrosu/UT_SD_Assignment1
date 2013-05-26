using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A1_Logistics;
using A1_POCO;
namespace Assignment1
{
    public partial class ClientForm : Form
    {
        private ClientLogic clientlogic;
        private int clientID;

        public ClientForm()
        {
            InitializeComponent();
            clientlogic = new ClientLogic();
        }

        public ClientForm(int clientId)
        {
            InitializeComponent();
            clientlogic = new ClientLogic(); 

            this.clientID = clientId;
        }

        private void btn_update_client_Click(object sender, EventArgs e)
        {
            clientlogic.UpdateClient(clientID,
                                     textBox_first_name.Text,
                                     textBox_last_name.Text,
                                     textBox_CNP.Text,
                                     textBox_address.Text,
                                     textBox_ICN.Text);
            this.Close();
        }

        private void btn_delete_client_Click(object sender, EventArgs e)
        {
            clientlogic.DeleteUser(clientID);

            this.Close();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            ClientPOCO currentClient = clientlogic.getClient(clientID);
            if (currentClient != null)
            {
                textBox_first_name.Text = currentClient.FirstName;
                textBox_last_name.Text = currentClient.LastName;
                textBox_CNP.Text = currentClient.CNP;
                textBox_address.Text = currentClient.Address;
            }
        }

    }
}
