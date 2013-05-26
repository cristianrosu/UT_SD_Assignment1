namespace Assignment1
{
    partial class AccountForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_IdentificationNr = new System.Windows.Forms.TextBox();
            this.textBox_deposit_value = new System.Windows.Forms.TextBox();
            this.textBox_currency = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_delete_account = new System.Windows.Forms.Button();
            this.btn_update_account = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identification Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Currency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Deposit Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Created";
            // 
            // textBox_IdentificationNr
            // 
            this.textBox_IdentificationNr.Location = new System.Drawing.Point(142, 66);
            this.textBox_IdentificationNr.Name = "textBox_IdentificationNr";
            this.textBox_IdentificationNr.Size = new System.Drawing.Size(100, 20);
            this.textBox_IdentificationNr.TabIndex = 4;
            // 
            // textBox_deposit_value
            // 
            this.textBox_deposit_value.Location = new System.Drawing.Point(142, 123);
            this.textBox_deposit_value.Name = "textBox_deposit_value";
            this.textBox_deposit_value.Size = new System.Drawing.Size(100, 20);
            this.textBox_deposit_value.TabIndex = 6;
            // 
            // textBox_currency
            // 
            this.textBox_currency.Location = new System.Drawing.Point(142, 94);
            this.textBox_currency.Name = "textBox_currency";
            this.textBox_currency.Size = new System.Drawing.Size(100, 20);
            this.textBox_currency.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "15.04,2010";
            // 
            // btn_delete_account
            // 
            this.btn_delete_account.Location = new System.Drawing.Point(263, 226);
            this.btn_delete_account.Name = "btn_delete_account";
            this.btn_delete_account.Size = new System.Drawing.Size(75, 23);
            this.btn_delete_account.TabIndex = 9;
            this.btn_delete_account.Text = "Delete";
            this.btn_delete_account.UseVisualStyleBackColor = true;
            // 
            // btn_update_account
            // 
            this.btn_update_account.Location = new System.Drawing.Point(178, 226);
            this.btn_update_account.Name = "btn_update_account";
            this.btn_update_account.Size = new System.Drawing.Size(75, 23);
            this.btn_update_account.TabIndex = 10;
            this.btn_update_account.Text = "Update";
            this.btn_update_account.UseVisualStyleBackColor = true;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 261);
            this.Controls.Add(this.btn_update_account);
            this.Controls.Add(this.btn_delete_account);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_currency);
            this.Controls.Add(this.textBox_deposit_value);
            this.Controls.Add(this.textBox_IdentificationNr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AccountForm";
            this.Text = "Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_IdentificationNr;
        private System.Windows.Forms.TextBox textBox_deposit_value;
        private System.Windows.Forms.TextBox textBox_currency;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_delete_account;
        private System.Windows.Forms.Button btn_update_account;
    }
}