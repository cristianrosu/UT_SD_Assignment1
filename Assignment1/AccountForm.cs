﻿using System;
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
    public partial class AccountForm : Form
    {
        private int clientId;

        public AccountForm()
        {
            InitializeComponent();
        }

        public AccountForm(int clientId)
        {
            InitializeComponent();
            this.clientId = clientId;
        }
    }
}
