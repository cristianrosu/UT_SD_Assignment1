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
    public partial class AdminForm : Form
    {
        private AdminLogic adminLogic;
        public AdminForm()
        {
            InitializeComponent();
            adminLogic = new AdminLogic();
            UpdateUsersList();
        }

        private void UpdateUsersList()
        {
            List<UserPOCO> users = adminLogic.GetUsers();

            userList.Rows.Clear();

            foreach (UserPOCO u in users)
            {
                userList.Rows.Add(new Object[] { u.ID, u.FirstName, u.LastName, u.Username });
            }

        }

        private void userList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
