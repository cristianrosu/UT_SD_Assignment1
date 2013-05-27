namespace Assignment1
{
    partial class AccountsForm
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
            this.accountList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_newAccount = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_transfer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.accountList)).BeginInit();
            this.SuspendLayout();
            // 
            // accountList
            // 
            this.accountList.AllowUserToAddRows = false;
            this.accountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Number,
            this.Type,
            this.Currency,
            this.Amount,
            this.Date});
            this.accountList.Location = new System.Drawing.Point(12, 12);
            this.accountList.MultiSelect = false;
            this.accountList.Name = "accountList";
            this.accountList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountList.Size = new System.Drawing.Size(645, 190);
            this.accountList.TabIndex = 0;
            this.accountList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Number
            // 
            this.Number.HeaderText = "Number";
            this.Number.Name = "Number";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // Currency
            // 
            this.Currency.HeaderText = "Currency";
            this.Currency.Name = "Currency";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // btn_newAccount
            // 
            this.btn_newAccount.Location = new System.Drawing.Point(25, 220);
            this.btn_newAccount.Name = "btn_newAccount";
            this.btn_newAccount.Size = new System.Drawing.Size(75, 23);
            this.btn_newAccount.TabIndex = 1;
            this.btn_newAccount.Text = "New";
            this.btn_newAccount.UseVisualStyleBackColor = true;
            this.btn_newAccount.Click += new System.EventHandler(this.btn_newAccount_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(138, 220);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_transfer
            // 
            this.btn_transfer.Location = new System.Drawing.Point(256, 220);
            this.btn_transfer.Name = "btn_transfer";
            this.btn_transfer.Size = new System.Drawing.Size(75, 23);
            this.btn_transfer.TabIndex = 3;
            this.btn_transfer.Text = "Transfer";
            this.btn_transfer.UseVisualStyleBackColor = true;
            // 
            // AccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 258);
            this.Controls.Add(this.btn_transfer);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_newAccount);
            this.Controls.Add(this.accountList);
            this.Name = "AccountsForm";
            this.Text = "AccountsForm";
            ((System.ComponentModel.ISupportInitialize)(this.accountList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView accountList;
        private System.Windows.Forms.Button btn_newAccount;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_transfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;

    }
}