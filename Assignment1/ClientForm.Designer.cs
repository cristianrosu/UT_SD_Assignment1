namespace Assignment1
{
    partial class ClientForm
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
            this.textBox_first_name = new System.Windows.Forms.TextBox();
            this.textBox_last_name = new System.Windows.Forms.TextBox();
            this.btn_update_client = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_CNP = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_ICN = new System.Windows.Forms.TextBox();
            this.btn_delete_client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // textBox_first_name
            // 
            this.textBox_first_name.Location = new System.Drawing.Point(72, 35);
            this.textBox_first_name.Name = "textBox_first_name";
            this.textBox_first_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_first_name.TabIndex = 2;
            // 
            // textBox_last_name
            // 
            this.textBox_last_name.Location = new System.Drawing.Point(72, 61);
            this.textBox_last_name.Name = "textBox_last_name";
            this.textBox_last_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_last_name.TabIndex = 3;
            // 
            // btn_update_client
            // 
            this.btn_update_client.Location = new System.Drawing.Point(208, 232);
            this.btn_update_client.Name = "btn_update_client";
            this.btn_update_client.Size = new System.Drawing.Size(87, 31);
            this.btn_update_client.TabIndex = 4;
            this.btn_update_client.Text = "Update";
            this.btn_update_client.UseVisualStyleBackColor = true;
            this.btn_update_client.Click += new System.EventHandler(this.btn_update_client_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CNP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "ICN";
            // 
            // textBox_CNP
            // 
            this.textBox_CNP.Location = new System.Drawing.Point(72, 101);
            this.textBox_CNP.Name = "textBox_CNP";
            this.textBox_CNP.Size = new System.Drawing.Size(100, 20);
            this.textBox_CNP.TabIndex = 8;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(72, 135);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(100, 20);
            this.textBox_address.TabIndex = 9;
            // 
            // textBox_ICN
            // 
            this.textBox_ICN.Location = new System.Drawing.Point(72, 172);
            this.textBox_ICN.Name = "textBox_ICN";
            this.textBox_ICN.Size = new System.Drawing.Size(100, 20);
            this.textBox_ICN.TabIndex = 10;
            // 
            // btn_delete_client
            // 
            this.btn_delete_client.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btn_delete_client.Location = new System.Drawing.Point(115, 232);
            this.btn_delete_client.Name = "btn_delete_client";
            this.btn_delete_client.Size = new System.Drawing.Size(87, 31);
            this.btn_delete_client.TabIndex = 11;
            this.btn_delete_client.Text = "Delete Client";
            this.btn_delete_client.UseVisualStyleBackColor = true;
            this.btn_delete_client.Click += new System.EventHandler(this.btn_delete_client_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 285);
            this.Controls.Add(this.btn_delete_client);
            this.Controls.Add(this.textBox_ICN);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_CNP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_update_client);
            this.Controls.Add(this.textBox_last_name);
            this.Controls.Add(this.textBox_first_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClientForm";
            this.Text = "Client Information";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_first_name;
        private System.Windows.Forms.TextBox textBox_last_name;
        private System.Windows.Forms.Button btn_update_client;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_CNP;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_ICN;
        private System.Windows.Forms.Button btn_delete_client;
    }
}