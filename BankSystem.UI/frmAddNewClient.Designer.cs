namespace BankSystem
{
    partial class frmAddNewClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewClient));
            this.btnAddNewClient = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbPhones = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddPhone = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlClientInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlClientInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewClient.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddNewClient.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewClient.ForeColor = System.Drawing.Color.White;
            this.btnAddNewClient.Location = new System.Drawing.Point(530, 717);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.Size = new System.Drawing.Size(296, 71);
            this.btnAddNewClient.TabIndex = 14;
            this.btnAddNewClient.Text = "Add";
            this.btnAddNewClient.Click += new System.EventHandler(this.btnAddNewClient_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(619, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(760, 830);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // cbPhones
            // 
            this.cbPhones.BackColor = System.Drawing.Color.White;
            this.cbPhones.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhones.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cbPhones.FormattingEnabled = true;
            this.cbPhones.Location = new System.Drawing.Point(39, 704);
            this.cbPhones.Name = "cbPhones";
            this.cbPhones.Size = new System.Drawing.Size(291, 36);
            this.cbPhones.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 663);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "All Phone Numbers: ";
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPhone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPhone.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhone.ForeColor = System.Drawing.Color.White;
            this.btnAddPhone.Location = new System.Drawing.Point(99, 590);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(376, 41);
            this.btnAddPhone.TabIndex = 18;
            this.btnAddPhone.Text = "Add The Phone Number To The List";
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pnlClientInfo
            // 
            this.pnlClientInfo.Controls.Add(this.txtAccountNumber);
            this.pnlClientInfo.Controls.Add(this.lblFirstName);
            this.pnlClientInfo.Controls.Add(this.label1);
            this.pnlClientInfo.Controls.Add(this.label2);
            this.pnlClientInfo.Controls.Add(this.label3);
            this.pnlClientInfo.Controls.Add(this.label4);
            this.pnlClientInfo.Controls.Add(this.label5);
            this.pnlClientInfo.Controls.Add(this.label6);
            this.pnlClientInfo.Controls.Add(this.txtFirstName);
            this.pnlClientInfo.Controls.Add(this.txtEmail);
            this.pnlClientInfo.Controls.Add(this.txtLastName);
            this.pnlClientInfo.Controls.Add(this.txtBalance);
            this.pnlClientInfo.Controls.Add(this.txtPhone);
            this.pnlClientInfo.Controls.Add(this.txtPinCode);
            this.pnlClientInfo.Location = new System.Drawing.Point(12, 12);
            this.pnlClientInfo.Name = "pnlClientInfo";
            this.pnlClientInfo.Size = new System.Drawing.Size(558, 555);
            this.pnlClientInfo.TabIndex = 20;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.BackColor = System.Drawing.Color.White;
            this.txtAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountNumber.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber.Location = new System.Drawing.Point(232, 414);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(291, 35);
            this.txtAccountNumber.TabIndex = 13;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(27, 6);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(143, 28);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Balance: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pin Code: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Account Number: ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(232, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(291, 35);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(232, 332);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(291, 35);
            this.txtEmail.TabIndex = 11;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(232, 86);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(291, 35);
            this.txtLastName.TabIndex = 7;
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.White;
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBalance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(232, 168);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(291, 35);
            this.txtBalance.TabIndex = 10;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(232, 496);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(291, 35);
            this.txtPhone.TabIndex = 8;
            // 
            // txtPinCode
            // 
            this.txtPinCode.BackColor = System.Drawing.Color.White;
            this.txtPinCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPinCode.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPinCode.Location = new System.Drawing.Point(232, 250);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Size = new System.Drawing.Size(291, 35);
            this.txtPinCode.TabIndex = 9;
            // 
            // frmAddNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1379, 830);
            this.Controls.Add(this.pnlClientInfo);
            this.Controls.Add(this.btnAddPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbPhones);
            this.Controls.Add(this.btnAddNewClient);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddNewClient";
            this.Text = "frmAddNewClient";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlClientInfo.ResumeLayout(false);
            this.pnlClientInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAddNewClient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbPhones;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnAddPhone;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Panel pnlClientInfo;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPinCode;
    }
}