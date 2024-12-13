namespace BankSystem
{
    partial class frmTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransfer));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnShowInfoFrom = new Guna.UI2.WinForms.Guna2Button();
            this.txtAccountNumberFrom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbClientCardFrom = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblPhoneFrom = new System.Windows.Forms.Label();
            this.lblEmailFrom = new System.Windows.Forms.Label();
            this.lblPinCodeFrom = new System.Windows.Forms.Label();
            this.lblBalanceFrom = new System.Windows.Forms.Label();
            this.lblLastNameFrom = new System.Windows.Forms.Label();
            this.lblFirstNameFrom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.gbClientCardTo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblPhoneTo = new System.Windows.Forms.Label();
            this.lblEmailTo = new System.Windows.Forms.Label();
            this.lblPinCodeTo = new System.Windows.Forms.Label();
            this.lblBalanceTo = new System.Windows.Forms.Label();
            this.lblLastNameTo = new System.Windows.Forms.Label();
            this.lblFirstNameTo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnShowInfoTo = new Guna.UI2.WinForms.Guna2Button();
            this.txtAccountNumberTo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTransferAmount = new System.Windows.Forms.TextBox();
            this.btnTransfer = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbClientCardFrom.SuspendLayout();
            this.gbClientCardTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(755, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 830);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnShowInfoFrom
            // 
            this.btnShowInfoFrom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowInfoFrom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowInfoFrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowInfoFrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowInfoFrom.FillColor = System.Drawing.Color.Black;
            this.btnShowInfoFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInfoFrom.ForeColor = System.Drawing.Color.White;
            this.btnShowInfoFrom.Location = new System.Drawing.Point(616, 13);
            this.btnShowInfoFrom.Name = "btnShowInfoFrom";
            this.btnShowInfoFrom.Size = new System.Drawing.Size(134, 35);
            this.btnShowInfoFrom.TabIndex = 28;
            this.btnShowInfoFrom.Text = "Show Info";
            this.btnShowInfoFrom.Click += new System.EventHandler(this.btnShowInfoFrom_Click);
            // 
            // txtAccountNumberFrom
            // 
            this.txtAccountNumberFrom.BackColor = System.Drawing.Color.White;
            this.txtAccountNumberFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountNumberFrom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumberFrom.Location = new System.Drawing.Point(343, 15);
            this.txtAccountNumberFrom.Name = "txtAccountNumberFrom";
            this.txtAccountNumberFrom.Size = new System.Drawing.Size(257, 32);
            this.txtAccountNumberFrom.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(334, 26);
            this.label6.TabIndex = 26;
            this.label6.Text = "Transfer From Account\'s Number: ";
            // 
            // gbClientCardFrom
            // 
            this.gbClientCardFrom.BorderColor = System.Drawing.Color.Black;
            this.gbClientCardFrom.Controls.Add(this.lblPhoneFrom);
            this.gbClientCardFrom.Controls.Add(this.lblEmailFrom);
            this.gbClientCardFrom.Controls.Add(this.lblPinCodeFrom);
            this.gbClientCardFrom.Controls.Add(this.lblBalanceFrom);
            this.gbClientCardFrom.Controls.Add(this.lblLastNameFrom);
            this.gbClientCardFrom.Controls.Add(this.lblFirstNameFrom);
            this.gbClientCardFrom.Controls.Add(this.label5);
            this.gbClientCardFrom.Controls.Add(this.label4);
            this.gbClientCardFrom.Controls.Add(this.label3);
            this.gbClientCardFrom.Controls.Add(this.label2);
            this.gbClientCardFrom.Controls.Add(this.label7);
            this.gbClientCardFrom.Controls.Add(this.label);
            this.gbClientCardFrom.CustomBorderColor = System.Drawing.Color.Black;
            this.gbClientCardFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClientCardFrom.ForeColor = System.Drawing.Color.White;
            this.gbClientCardFrom.Location = new System.Drawing.Point(8, 74);
            this.gbClientCardFrom.Name = "gbClientCardFrom";
            this.gbClientCardFrom.Size = new System.Drawing.Size(742, 178);
            this.gbClientCardFrom.TabIndex = 29;
            this.gbClientCardFrom.Text = "Client Card";
            this.gbClientCardFrom.Visible = false;
            // 
            // lblPhoneFrom
            // 
            this.lblPhoneFrom.AutoSize = true;
            this.lblPhoneFrom.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneFrom.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneFrom.Location = new System.Drawing.Point(603, 138);
            this.lblPhoneFrom.Name = "lblPhoneFrom";
            this.lblPhoneFrom.Size = new System.Drawing.Size(124, 26);
            this.lblPhoneFrom.TabIndex = 33;
            this.lblPhoneFrom.Text = "First Name: ";
            // 
            // lblEmailFrom
            // 
            this.lblEmailFrom.AutoSize = true;
            this.lblEmailFrom.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailFrom.ForeColor = System.Drawing.Color.Black;
            this.lblEmailFrom.Location = new System.Drawing.Point(205, 138);
            this.lblEmailFrom.Name = "lblEmailFrom";
            this.lblEmailFrom.Size = new System.Drawing.Size(124, 26);
            this.lblEmailFrom.TabIndex = 31;
            this.lblEmailFrom.Text = "First Name: ";
            // 
            // lblPinCodeFrom
            // 
            this.lblPinCodeFrom.AutoSize = true;
            this.lblPinCodeFrom.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinCodeFrom.ForeColor = System.Drawing.Color.Black;
            this.lblPinCodeFrom.Location = new System.Drawing.Point(603, 95);
            this.lblPinCodeFrom.Name = "lblPinCodeFrom";
            this.lblPinCodeFrom.Size = new System.Drawing.Size(124, 26);
            this.lblPinCodeFrom.TabIndex = 30;
            this.lblPinCodeFrom.Text = "First Name: ";
            // 
            // lblBalanceFrom
            // 
            this.lblBalanceFrom.AutoSize = true;
            this.lblBalanceFrom.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceFrom.ForeColor = System.Drawing.Color.Black;
            this.lblBalanceFrom.Location = new System.Drawing.Point(603, 52);
            this.lblBalanceFrom.Name = "lblBalanceFrom";
            this.lblBalanceFrom.Size = new System.Drawing.Size(124, 26);
            this.lblBalanceFrom.TabIndex = 29;
            this.lblBalanceFrom.Text = "First Name: ";
            // 
            // lblLastNameFrom
            // 
            this.lblLastNameFrom.AutoSize = true;
            this.lblLastNameFrom.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameFrom.ForeColor = System.Drawing.Color.Black;
            this.lblLastNameFrom.Location = new System.Drawing.Point(205, 95);
            this.lblLastNameFrom.Name = "lblLastNameFrom";
            this.lblLastNameFrom.Size = new System.Drawing.Size(124, 26);
            this.lblLastNameFrom.TabIndex = 28;
            this.lblLastNameFrom.Text = "First Name: ";
            // 
            // lblFirstNameFrom
            // 
            this.lblFirstNameFrom.AutoSize = true;
            this.lblFirstNameFrom.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameFrom.ForeColor = System.Drawing.Color.Black;
            this.lblFirstNameFrom.Location = new System.Drawing.Point(205, 52);
            this.lblFirstNameFrom.Name = "lblFirstNameFrom";
            this.lblFirstNameFrom.Size = new System.Drawing.Size(124, 26);
            this.lblFirstNameFrom.TabIndex = 27;
            this.lblFirstNameFrom.Text = "First Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(436, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "Phone: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(436, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Pin Code: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(436, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Balance: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(26, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Last Name: ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(26, 52);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(128, 26);
            this.label.TabIndex = 14;
            this.label.Text = "First Name: ";
            // 
            // gbClientCardTo
            // 
            this.gbClientCardTo.BorderColor = System.Drawing.Color.Black;
            this.gbClientCardTo.Controls.Add(this.lblPhoneTo);
            this.gbClientCardTo.Controls.Add(this.lblEmailTo);
            this.gbClientCardTo.Controls.Add(this.lblPinCodeTo);
            this.gbClientCardTo.Controls.Add(this.lblBalanceTo);
            this.gbClientCardTo.Controls.Add(this.lblLastNameTo);
            this.gbClientCardTo.Controls.Add(this.lblFirstNameTo);
            this.gbClientCardTo.Controls.Add(this.label13);
            this.gbClientCardTo.Controls.Add(this.label14);
            this.gbClientCardTo.Controls.Add(this.label15);
            this.gbClientCardTo.Controls.Add(this.label16);
            this.gbClientCardTo.Controls.Add(this.label17);
            this.gbClientCardTo.Controls.Add(this.label18);
            this.gbClientCardTo.CustomBorderColor = System.Drawing.Color.Black;
            this.gbClientCardTo.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbClientCardTo.ForeColor = System.Drawing.Color.White;
            this.gbClientCardTo.Location = new System.Drawing.Point(7, 400);
            this.gbClientCardTo.Name = "gbClientCardTo";
            this.gbClientCardTo.Size = new System.Drawing.Size(742, 178);
            this.gbClientCardTo.TabIndex = 33;
            this.gbClientCardTo.Text = "Client Card";
            this.gbClientCardTo.Visible = false;
            // 
            // lblPhoneTo
            // 
            this.lblPhoneTo.AutoSize = true;
            this.lblPhoneTo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneTo.ForeColor = System.Drawing.Color.Black;
            this.lblPhoneTo.Location = new System.Drawing.Point(603, 138);
            this.lblPhoneTo.Name = "lblPhoneTo";
            this.lblPhoneTo.Size = new System.Drawing.Size(124, 26);
            this.lblPhoneTo.TabIndex = 33;
            this.lblPhoneTo.Text = "First Name: ";
            // 
            // lblEmailTo
            // 
            this.lblEmailTo.AutoSize = true;
            this.lblEmailTo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailTo.ForeColor = System.Drawing.Color.Black;
            this.lblEmailTo.Location = new System.Drawing.Point(205, 138);
            this.lblEmailTo.Name = "lblEmailTo";
            this.lblEmailTo.Size = new System.Drawing.Size(124, 26);
            this.lblEmailTo.TabIndex = 31;
            this.lblEmailTo.Text = "First Name: ";
            // 
            // lblPinCodeTo
            // 
            this.lblPinCodeTo.AutoSize = true;
            this.lblPinCodeTo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinCodeTo.ForeColor = System.Drawing.Color.Black;
            this.lblPinCodeTo.Location = new System.Drawing.Point(603, 95);
            this.lblPinCodeTo.Name = "lblPinCodeTo";
            this.lblPinCodeTo.Size = new System.Drawing.Size(124, 26);
            this.lblPinCodeTo.TabIndex = 30;
            this.lblPinCodeTo.Text = "First Name: ";
            // 
            // lblBalanceTo
            // 
            this.lblBalanceTo.AutoSize = true;
            this.lblBalanceTo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceTo.ForeColor = System.Drawing.Color.Black;
            this.lblBalanceTo.Location = new System.Drawing.Point(603, 52);
            this.lblBalanceTo.Name = "lblBalanceTo";
            this.lblBalanceTo.Size = new System.Drawing.Size(124, 26);
            this.lblBalanceTo.TabIndex = 29;
            this.lblBalanceTo.Text = "First Name: ";
            // 
            // lblLastNameTo
            // 
            this.lblLastNameTo.AutoSize = true;
            this.lblLastNameTo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameTo.ForeColor = System.Drawing.Color.Black;
            this.lblLastNameTo.Location = new System.Drawing.Point(205, 95);
            this.lblLastNameTo.Name = "lblLastNameTo";
            this.lblLastNameTo.Size = new System.Drawing.Size(124, 26);
            this.lblLastNameTo.TabIndex = 28;
            this.lblLastNameTo.Text = "First Name: ";
            // 
            // lblFirstNameTo
            // 
            this.lblFirstNameTo.AutoSize = true;
            this.lblFirstNameTo.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNameTo.ForeColor = System.Drawing.Color.Black;
            this.lblFirstNameTo.Location = new System.Drawing.Point(205, 52);
            this.lblFirstNameTo.Name = "lblFirstNameTo";
            this.lblFirstNameTo.Size = new System.Drawing.Size(124, 26);
            this.lblFirstNameTo.TabIndex = 27;
            this.lblFirstNameTo.Text = "First Name: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(436, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 26);
            this.label13.TabIndex = 19;
            this.label13.Text = "Phone: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(436, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 26);
            this.label14.TabIndex = 18;
            this.label14.Text = "Pin Code: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(436, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 26);
            this.label15.TabIndex = 17;
            this.label15.Text = "Balance: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(26, 138);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 26);
            this.label16.TabIndex = 16;
            this.label16.Text = "Email:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(26, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 26);
            this.label17.TabIndex = 15;
            this.label17.Text = "Last Name: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(26, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 26);
            this.label18.TabIndex = 14;
            this.label18.Text = "First Name: ";
            // 
            // btnShowInfoTo
            // 
            this.btnShowInfoTo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowInfoTo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowInfoTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowInfoTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowInfoTo.FillColor = System.Drawing.Color.Black;
            this.btnShowInfoTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInfoTo.ForeColor = System.Drawing.Color.White;
            this.btnShowInfoTo.Location = new System.Drawing.Point(615, 339);
            this.btnShowInfoTo.Name = "btnShowInfoTo";
            this.btnShowInfoTo.Size = new System.Drawing.Size(134, 35);
            this.btnShowInfoTo.TabIndex = 32;
            this.btnShowInfoTo.Text = "Show Info";
            this.btnShowInfoTo.Click += new System.EventHandler(this.btnShowInfoTo_Click);
            // 
            // txtAccountNumberTo
            // 
            this.txtAccountNumberTo.BackColor = System.Drawing.Color.White;
            this.txtAccountNumberTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountNumberTo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumberTo.Location = new System.Drawing.Point(342, 341);
            this.txtAccountNumberTo.Name = "txtAccountNumberTo";
            this.txtAccountNumberTo.Size = new System.Drawing.Size(257, 32);
            this.txtAccountNumberTo.TabIndex = 31;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(2, 344);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(305, 26);
            this.label19.TabIndex = 30;
            this.label19.Text = "Transfer To Account\'s Number: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 685);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 34;
            this.label1.Text = "Transfer Amount:";
            // 
            // txtTransferAmount
            // 
            this.txtTransferAmount.BackColor = System.Drawing.Color.White;
            this.txtTransferAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransferAmount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransferAmount.Location = new System.Drawing.Point(342, 683);
            this.txtTransferAmount.Name = "txtTransferAmount";
            this.txtTransferAmount.Size = new System.Drawing.Size(257, 32);
            this.txtTransferAmount.TabIndex = 35;
            // 
            // btnTransfer
            // 
            this.btnTransfer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransfer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransfer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransfer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransfer.Enabled = false;
            this.btnTransfer.FillColor = System.Drawing.Color.Black;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(616, 680);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(134, 35);
            this.btnTransfer.TabIndex = 36;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1379, 830);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.txtTransferAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbClientCardTo);
            this.Controls.Add(this.btnShowInfoTo);
            this.Controls.Add(this.txtAccountNumberTo);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.gbClientCardFrom);
            this.Controls.Add(this.btnShowInfoFrom);
            this.Controls.Add(this.txtAccountNumberFrom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransfer";
            this.Text = "Transfer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbClientCardFrom.ResumeLayout(false);
            this.gbClientCardFrom.PerformLayout();
            this.gbClientCardTo.ResumeLayout(false);
            this.gbClientCardTo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnShowInfoFrom;
        private System.Windows.Forms.TextBox txtAccountNumberFrom;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2GroupBox gbClientCardFrom;
        private System.Windows.Forms.Label lblPhoneFrom;
        private System.Windows.Forms.Label lblEmailFrom;
        private System.Windows.Forms.Label lblPinCodeFrom;
        private System.Windows.Forms.Label lblBalanceFrom;
        private System.Windows.Forms.Label lblLastNameFrom;
        private System.Windows.Forms.Label lblFirstNameFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label;
        private Guna.UI2.WinForms.Guna2GroupBox gbClientCardTo;
        private System.Windows.Forms.Label lblPhoneTo;
        private System.Windows.Forms.Label lblEmailTo;
        private System.Windows.Forms.Label lblPinCodeTo;
        private System.Windows.Forms.Label lblBalanceTo;
        private System.Windows.Forms.Label lblLastNameTo;
        private System.Windows.Forms.Label lblFirstNameTo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private Guna.UI2.WinForms.Guna2Button btnShowInfoTo;
        private System.Windows.Forms.TextBox txtAccountNumberTo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTransferAmount;
        private Guna.UI2.WinForms.Guna2Button btnTransfer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}