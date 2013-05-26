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
using A1_POCO;

namespace Assignment1
{
    public partial class MainForm : Form
    {
        private MainLogic mainlogic;
        private int clientId;
        public MainForm()
        {
            InitializeComponent();
            mainlogic = new MainLogic();
          
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateClientsList();
            UpdateSelectedId();
        }

        private void UpdateClientsList()
        {
            List<ClientPOCO> clienti = mainlogic.GetClients();
            dataGridView1.Rows.Clear();
            foreach (var c in clienti)
            {
                dataGridView1.Rows.Add(new string[] {c.ID.ToString(), c.FirstName, c.LastName, c.CNP, c.Address });
            }
        }

        private void btn_add_client_Click(object sender, EventArgs e)
        {
            Form client_form = new ClientForm();
       
            client_form.Show();
            client_form.FormClosed += client_form_FormClosed;
        }

        private void btn_edit_client_Click(object sender, EventArgs e)
        {
            Form client_form = new ClientForm(clientId);

            client_form.Show();
            client_form.FormClosed += client_form_FormClosed;
        }

        void client_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateClientsList();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateSelectedId();
        }

        private void UpdateSelectedId()
        {
            //update client id
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                    if (dataGridView1[0, i].Selected == true)
                    {
                        string xx = dataGridView1[0, i].Value.ToString();
                        clientId = Int32.Parse(xx);
                        clientId2.Text = clientId.ToString();
                        break;
                    }
            }
        }
    }
}
