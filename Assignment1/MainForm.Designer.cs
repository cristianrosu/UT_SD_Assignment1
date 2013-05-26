namespace Assignment1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_transfer = new System.Windows.Forms.Button();
            this.btn_add_client = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_edit_client = new System.Windows.Forms.Button();
            this.btn_view_accounts = new System.Windows.Forms.Button();
            this.clientId2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_transfer
            // 
            this.btn_transfer.Location = new System.Drawing.Point(484, 226);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Size = new System.Drawing.Size(75, 23);
            this.btn_transfer.TabIndex = 0;
            this.btn_transfer.Text = "Transfer $";
            this.btn_transfer.UseVisualStyleBackColor = true;
            // 
            // btn_add_client
            // 
            this.btn_add_client.Location = new System.Drawing.Point(484, 21);
            this.btn_add_client.Name = "btn_add_client";
            this.btn_add_client.Size = new System.Drawing.Size(75, 23);
            this.btn_add_client.TabIndex = 1;
            this.btn_add_client.Text = "Add Client";
            this.btn_add_client.UseVisualStyleBackColor = true;
            this.btn_add_client.Click += new System.EventHandler(this.btn_add_client_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.CNP,
            this.Address});
            this.dataGridView1.Location = new System.Drawing.Point(22, 21);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(445, 217);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // CNP
            // 
            this.CNP.HeaderText = "CNP";
            this.CNP.Name = "CNP";
            this.CNP.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // btn_edit_client
            // 
            this.btn_edit_client.Location = new System.Drawing.Point(484, 61);
            this.btn_edit_client.Name = "btn_edit_client";
            this.btn_edit_client.Size = new System.Drawing.Size(75, 23);
            this.btn_edit_client.TabIndex = 3;
            this.btn_edit_client.Text = "Edit Client";
            this.btn_edit_client.UseVisualStyleBackColor = true;
            this.btn_edit_client.Click += new System.EventHandler(this.btn_edit_client_Click);
            // 
            // btn_view_accounts
            // 
            this.btn_view_accounts.Location = new System.Drawing.Point(484, 101);
            this.btn_view_accounts.Name = "btn_view_accounts";
            this.btn_view_accounts.Size = new System.Drawing.Size(75, 42);
            this.btn_view_accounts.TabIndex = 4;
            this.btn_view_accounts.Text = "View Accounts";
            this.btn_view_accounts.UseVisualStyleBackColor = true;
            // 
            // clientId2
            // 
            this.clientId2.Location = new System.Drawing.Point(484, 166);
            this.clientId2.Name = "clientId2";
            this.clientId2.Size = new System.Drawing.Size(100, 20);
            this.clientId2.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 261);
            this.Controls.Add(this.clientId2);
            this.Controls.Add(this.btn_view_accounts);
            this.Controls.Add(this.btn_edit_client);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_add_client);
            this.Controls.Add(this.btn_transfer);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_transfer;
        private System.Windows.Forms.Button btn_add_client;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_edit_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.Button btn_view_accounts;
        private System.Windows.Forms.TextBox clientId2;
    }
}