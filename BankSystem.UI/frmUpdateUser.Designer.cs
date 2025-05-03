namespace BankSystem
{
    partial class frmUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateUser));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnShowInfo = new Guna.UI2.WinForms.Guna2Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbAllPhones = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnAddNewPhone = new Guna.UI2.WinForms.Guna2Button();
            this.pnlUserInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPermissions = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUserCard = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPermissions = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnUpdateUser = new Guna.UI2.WinForms.Guna2Button();
            this.pnlPermissions = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.chkLoginRegisters = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkTransaction = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkManageUsers = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkFindClient = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkAll = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkShowClientsList = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkUpdateClient = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkDeleteClient = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkAddNewClient = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbAllPhones.SuspendLayout();
            this.pnlUserInfo.SuspendLayout();
            this.gbUserCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.pnlPermissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(886, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 830);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnShowInfo
            // 
            this.btnShowInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowInfo.FillColor = System.Drawing.Color.Coral;
            this.btnShowInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowInfo.ForeColor = System.Drawing.Color.White;
            this.btnShowInfo.Location = new System.Drawing.Point(1139, 60);
            this.btnShowInfo.Name = "btnShowInfo";
            this.btnShowInfo.Size = new System.Drawing.Size(134, 35);
            this.btnShowInfo.TabIndex = 40;
            this.btnShowInfo.Text = "Show Info";
            this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(858, 60);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(257, 35);
            this.txtUsername.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(853, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 28);
            this.label6.TabIndex = 38;
            this.label6.Text = "Please Enter Username: ";
            // 
            // gbAllPhones
            // 
            this.gbAllPhones.AutoScroll = true;
            this.gbAllPhones.Controls.Add(this.btnAddNewPhone);
            this.gbAllPhones.CustomBorderColor = System.Drawing.Color.Coral;
            this.gbAllPhones.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAllPhones.ForeColor = System.Drawing.Color.White;
            this.gbAllPhones.Location = new System.Drawing.Point(10, 344);
            this.gbAllPhones.Name = "gbAllPhones";
            this.gbAllPhones.Size = new System.Drawing.Size(529, 273);
            this.gbAllPhones.TabIndex = 51;
            this.gbAllPhones.Text = "All Phones";
            this.gbAllPhones.Visible = false;
            // 
            // btnAddNewPhone
            // 
            this.btnAddNewPhone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPhone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewPhone.FillColor = System.Drawing.Color.Coral;
            this.btnAddNewPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPhone.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPhone.Location = new System.Drawing.Point(7, 49);
            this.btnAddNewPhone.Name = "btnAddNewPhone";
            this.btnAddNewPhone.Size = new System.Drawing.Size(171, 36);
            this.btnAddNewPhone.TabIndex = 51;
            this.btnAddNewPhone.Text = "Add New Phone";
            this.btnAddNewPhone.Click += new System.EventHandler(this.btnAddNewPhone_Click);
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.Controls.Add(this.pnlPermissions);
            this.pnlUserInfo.Controls.Add(this.gbAllPhones);
            this.pnlUserInfo.Controls.Add(this.label3);
            this.pnlUserInfo.Controls.Add(this.txtEmail);
            this.pnlUserInfo.Controls.Add(this.txtPermissions);
            this.pnlUserInfo.Controls.Add(this.txtPassword);
            this.pnlUserInfo.Controls.Add(this.txtLastName);
            this.pnlUserInfo.Controls.Add(this.txtFirstName);
            this.pnlUserInfo.Controls.Add(this.label10);
            this.pnlUserInfo.Controls.Add(this.label11);
            this.pnlUserInfo.Controls.Add(this.label12);
            this.pnlUserInfo.Controls.Add(this.label13);
            this.pnlUserInfo.Controls.Add(this.label14);
            this.pnlUserInfo.Controls.Add(this.label1);
            this.pnlUserInfo.Location = new System.Drawing.Point(12, 194);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(932, 629);
            this.pnlUserInfo.TabIndex = 42;
            this.pnlUserInfo.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(226, 295);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(291, 35);
            this.txtEmail.TabIndex = 49;
            // 
            // txtPermissions
            // 
            this.txtPermissions.BackColor = System.Drawing.Color.White;
            this.txtPermissions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPermissions.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPermissions.Location = new System.Drawing.Point(226, 237);
            this.txtPermissions.Name = "txtPermissions";
            this.txtPermissions.Size = new System.Drawing.Size(291, 35);
            this.txtPermissions.TabIndex = 48;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(226, 179);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(291, 35);
            this.txtPassword.TabIndex = 47;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(226, 121);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(291, 35);
            this.txtLastName.TabIndex = 46;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(226, 63);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(291, 35);
            this.txtFirstName.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(59, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 28);
            this.label10.TabIndex = 43;
            this.label10.Text = "Permissions: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(59, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 28);
            this.label11.TabIndex = 42;
            this.label11.Text = "Password: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(59, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 28);
            this.label12.TabIndex = 41;
            this.label12.Text = "Email:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(59, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 28);
            this.label13.TabIndex = 40;
            this.label13.Text = "Last Name: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(59, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 28);
            this.label14.TabIndex = 39;
            this.label14.Text = "First Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 42);
            this.label1.TabIndex = 38;
            this.label1.Text = "Update User Info: ";
            // 
            // gbUserCard
            // 
            this.gbUserCard.BorderColor = System.Drawing.Color.Coral;
            this.gbUserCard.Controls.Add(this.lblPhone);
            this.gbUserCard.Controls.Add(this.label8);
            this.gbUserCard.Controls.Add(this.lblPermissions);
            this.gbUserCard.Controls.Add(this.lblEmail);
            this.gbUserCard.Controls.Add(this.lblPassword);
            this.gbUserCard.Controls.Add(this.lblLastName);
            this.gbUserCard.Controls.Add(this.lblFirstName);
            this.gbUserCard.Controls.Add(this.label5);
            this.gbUserCard.Controls.Add(this.label4);
            this.gbUserCard.Controls.Add(this.label2);
            this.gbUserCard.Controls.Add(this.label7);
            this.gbUserCard.Controls.Add(this.label);
            this.gbUserCard.CustomBorderColor = System.Drawing.Color.Coral;
            this.gbUserCard.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserCard.ForeColor = System.Drawing.Color.White;
            this.gbUserCard.Location = new System.Drawing.Point(12, 9);
            this.gbUserCard.Name = "gbUserCard";
            this.gbUserCard.Size = new System.Drawing.Size(761, 183);
            this.gbUserCard.TabIndex = 41;
            this.gbUserCard.Text = "User Card";
            this.gbUserCard.Visible = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Black;
            this.lblPhone.Location = new System.Drawing.Point(474, 144);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(124, 26);
            this.lblPhone.TabIndex = 34;
            this.lblPhone.Text = "First Name: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(350, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 26);
            this.label8.TabIndex = 33;
            this.label8.Text = "Phone: ";
            // 
            // lblPermissions
            // 
            this.lblPermissions.AutoSize = true;
            this.lblPermissions.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermissions.ForeColor = System.Drawing.Color.Black;
            this.lblPermissions.Location = new System.Drawing.Point(143, 102);
            this.lblPermissions.Name = "lblPermissions";
            this.lblPermissions.Size = new System.Drawing.Size(124, 26);
            this.lblPermissions.TabIndex = 32;
            this.lblPermissions.Text = "First Name: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(141, 144);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(124, 26);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "First Name: ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(474, 102);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(124, 26);
            this.lblPassword.TabIndex = 30;
            this.lblPassword.Text = "First Name: ";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(474, 60);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(124, 26);
            this.lblLastName.TabIndex = 28;
            this.lblLastName.Text = "First Name: ";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(143, 60);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(124, 26);
            this.lblFirstName.TabIndex = 27;
            this.lblFirstName.Text = "First Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "Permissions: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(350, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Password: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 144);
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
            this.label7.Location = new System.Drawing.Point(350, 60);
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
            this.label.Location = new System.Drawing.Point(15, 60);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(128, 26);
            this.label.TabIndex = 14;
            this.label.Text = "First Name: ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.Coral;
            this.btnUpdateUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateUser.FillColor = System.Drawing.Color.Empty;
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Location = new System.Drawing.Point(968, 747);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(296, 71);
            this.btnUpdateUser.TabIndex = 43;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.Visible = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // pnlPermissions
            // 
            this.pnlPermissions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlPermissions.BorderColor = System.Drawing.Color.Black;
            this.pnlPermissions.BorderThickness = 1;
            this.pnlPermissions.Controls.Add(this.chkLoginRegisters);
            this.pnlPermissions.Controls.Add(this.chkTransaction);
            this.pnlPermissions.Controls.Add(this.chkManageUsers);
            this.pnlPermissions.Controls.Add(this.chkFindClient);
            this.pnlPermissions.Controls.Add(this.chkAll);
            this.pnlPermissions.Controls.Add(this.chkShowClientsList);
            this.pnlPermissions.Controls.Add(this.chkUpdateClient);
            this.pnlPermissions.Controls.Add(this.chkDeleteClient);
            this.pnlPermissions.Controls.Add(this.chkAddNewClient);
            this.pnlPermissions.Location = new System.Drawing.Point(567, 117);
            this.pnlPermissions.Name = "pnlPermissions";
            this.pnlPermissions.Size = new System.Drawing.Size(365, 213);
            this.pnlPermissions.TabIndex = 45;
            // 
            // chkLoginRegisters
            // 
            this.chkLoginRegisters.AutoSize = true;
            this.chkLoginRegisters.CheckedState.BorderColor = System.Drawing.Color.Coral;
            this.chkLoginRegisters.CheckedState.BorderRadius = 0;
            this.chkLoginRegisters.CheckedState.BorderThickness = 0;
            this.chkLoginRegisters.CheckedState.FillColor = System.Drawing.Color.Coral;
            this.chkLoginRegisters.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLoginRegisters.Location = new System.Drawing.Point(196, 181);
            this.chkLoginRegisters.Name = "chkLoginRegisters";
            this.chkLoginRegisters.Size = new System.Drawing.Size(152, 26);
            this.chkLoginRegisters.TabIndex = 9;
            this.chkLoginRegisters.Text = "Login Registers";
            this.chkLoginRegisters.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkLoginRegisters.UncheckedState.BorderRadius = 0;
            this.chkLoginRegisters.UncheckedState.BorderThickness = 0;
            this.chkLoginRegisters.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkLoginRegisters.CheckedChanged += new System.EventHandler(this.PermissionCheckBox_CheckedChanged);
            // 
            // chkTransaction
            // 
            this.chkTransaction.AutoSize = true;
            this.chkTransaction.CheckedState.BorderColor = System.Drawing.Color.Coral;
            this.chkTransaction.CheckedState.BorderRadius = 0;
            this.chkTransaction.CheckedState.BorderThickness = 0;
            this.chkTransaction.CheckedState.FillColor = System.Drawing.Color.Coral;
            this.chkTransaction.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTransaction.Location = new System.Drawing.Point(196, 95);
            this.chkTransaction.Name = "chkTransaction";
            this.chkTransaction.Size = new System.Drawing.Size(123, 26);
            this.chkTransaction.TabIndex = 8;
            this.chkTransaction.Text = "Transaction";
            this.chkTransaction.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkTransaction.UncheckedState.BorderRadius = 0;
            this.chkTransaction.UncheckedState.BorderThickness = 0;
            this.chkTransaction.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkTransaction.CheckedChanged += new System.EventHandler(this.PermissionCheckBox_CheckedChanged);
            // 
            // chkManageUsers
            // 
            this.chkManageUsers.AutoSize = true;
            this.chkManageUsers.CheckedState.BorderColor = System.Drawing.Color.Coral;
            this.chkManageUsers.CheckedState.BorderRadius = 0;
            this.chkManageUsers.CheckedState.BorderThickness = 0;
            this.chkManageUsers.CheckedState.FillColor = System.Drawing.Color.Coral;
            this.chkManageUsers.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkManageUsers.Location = new System.Drawing.Point(196, 138);
            this.chkManageUsers.Name = "chkManageUsers";
            this.chkManageUsers.Size = new System.Drawing.Size(142, 26);
            this.chkManageUsers.TabIndex = 7;
            this.chkManageUsers.Text = "Manage Users";
            this.chkManageUsers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkManageUsers.UncheckedState.BorderRadius = 0;
            this.chkManageUsers.UncheckedState.BorderThickness = 0;
            this.chkManageUsers.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkManageUsers.CheckedChanged += new System.EventHandler(this.PermissionCheckBox_CheckedChanged);
            // 
            // chkFindClient
            // 
            this.chkFindClient.AutoSize = true;
            this.chkFindClient.CheckedState.BorderColor = System.Drawing.Color.Coral;
            this.chkFindClient.CheckedState.BorderRadius = 0;
            this.chkFindClient.CheckedState.BorderThickness = 0;
            this.chkFindClient.CheckedState.FillColor = System.Drawing.Color.Coral;
            this.chkFindClient.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.chkFindClient.Location = new System.Drawing.Point(196, 52);
            this.chkFindClient.Name = "chkFindClient";
            this.chkFindClient.Size = new System.Drawing.Size(115, 26);
            this.chkFindClient.TabIndex = 6;
            this.chkFindClient.Text = "Find Client";
            this.chkFindClient.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkFindClient.UncheckedState.BorderRadius = 0;
            this.chkFindClient.UncheckedState.BorderThickness = 0;
            this.chkFindClient.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkFindClient.CheckedChanged += new System.EventHandler(this.PermissionCheckBox_CheckedChanged);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.CheckedState.BorderColor = System.Drawing.Color.Coral;
            this.chkAll.CheckedState.BorderRadius = 0;
            this.chkAll.CheckedState.BorderThickness = 0;
            this.chkAll.CheckedState.FillColor = System.Drawing.Color.Coral;
            this.chkAll.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.chkAll.Location = new System.Drawing.Point(12, 9);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(51, 26);
            this.chkAll.TabIndex = 5;
            this.chkAll.Text = "All";
            this.chkAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkAll.UncheckedState.BorderRadius = 0;
            this.chkAll.UncheckedState.BorderThickness = 0;
            this.chkAll.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // chkShowClientsList
            // 
            this.chkShowClientsList.AutoSize = true;
            this.chkShowClientsList.CheckedState.BorderColor = System.Drawing.Color.Coral;
            this.chkShowClientsList.CheckedState.BorderRadius = 0;
            this.chkShowClientsList.CheckedState.BorderThickness = 0;
            this.chkShowClientsList.CheckedState.FillColor = System.Drawing.Color.Coral;
            this.chkShowClientsList.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.chkShowClientsList.Location = new System.Drawing.Point(12, 52);
            this.chkShowClientsList.Name = "chkShowClientsList";
            this.chkShowClientsList.Size = new System.Drawing.Size(166, 26);
            this.chkShowClientsList.TabIndex = 4;
            this.chkShowClientsList.Text = "Show Clients List";
            this.chkShowClientsList.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkShowClientsList.UncheckedState.BorderRadius = 0;
            this.chkShowClientsList.UncheckedState.BorderThickness = 0;
            this.chkShowClientsList.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkShowClientsList.CheckedChanged += new System.EventHandler(this.PermissionCheckBox_CheckedChanged);
            // 
            // chkUpdateClient
            // 
            this.chkUpdateClient.AutoSize = true;
            this.chkUpdateClient.CheckedState.BorderColor = System.Drawing.Color.Coral;
            this.chkUpdateClient.CheckedState.BorderRadius = 0;
            this.chkUpdateClient.CheckedState.BorderThickness = 0;
            this.chkUpdateClient.CheckedState.FillColor = System.Drawing.Color.Coral;
            this.chkUpdateClient.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpdateClient.Location = new System.Drawing.Point(12, 181);
            this.chkUpdateClient.Name = "chkUpdateClient";
            this.chkUpdateClient.Size = new System.Drawing.Size(138, 26);
            this.chkUpdateClient.TabIndex = 3;
            this.chkUpdateClient.Text = "Update Client";
            this.chkUpdateClient.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkUpdateClient.UncheckedState.BorderRadius = 0;
            this.chkUpdateClient.UncheckedState.BorderThickness = 0;
            this.chkUpdateClient.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkUpdateClient.CheckedChanged += new System.EventHandler(this.PermissionCheckBox_CheckedChanged);
            // 
            // chkDeleteClient
            // 
            this.chkDeleteClient.AutoSize = true;
            this.chkDeleteClient.CheckedState.BorderColor = System.Drawing.Color.Coral;
            this.chkDeleteClient.CheckedState.BorderRadius = 0;
            this.chkDeleteClient.CheckedState.BorderThickness = 0;
            this.chkDeleteClient.CheckedState.FillColor = System.Drawing.Color.Coral;
            this.chkDeleteClient.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeleteClient.Location = new System.Drawing.Point(12, 138);
            this.chkDeleteClient.Name = "chkDeleteClient";
            this.chkDeleteClient.Size = new System.Drawing.Size(131, 26);
            this.chkDeleteClient.TabIndex = 2;
            this.chkDeleteClient.Text = "Delete Client";
            this.chkDeleteClient.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkDeleteClient.UncheckedState.BorderRadius = 0;
            this.chkDeleteClient.UncheckedState.BorderThickness = 0;
            this.chkDeleteClient.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkDeleteClient.CheckedChanged += new System.EventHandler(this.PermissionCheckBox_CheckedChanged);
            // 
            // chkAddNewClient
            // 
            this.chkAddNewClient.AutoSize = true;
            this.chkAddNewClient.CheckedState.BorderColor = System.Drawing.Color.Coral;
            this.chkAddNewClient.CheckedState.BorderRadius = 0;
            this.chkAddNewClient.CheckedState.BorderThickness = 0;
            this.chkAddNewClient.CheckedState.FillColor = System.Drawing.Color.Coral;
            this.chkAddNewClient.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.chkAddNewClient.Location = new System.Drawing.Point(13, 95);
            this.chkAddNewClient.Name = "chkAddNewClient";
            this.chkAddNewClient.Size = new System.Drawing.Size(153, 26);
            this.chkAddNewClient.TabIndex = 1;
            this.chkAddNewClient.Text = "Add New Client";
            this.chkAddNewClient.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkAddNewClient.UncheckedState.BorderRadius = 0;
            this.chkAddNewClient.UncheckedState.BorderThickness = 0;
            this.chkAddNewClient.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkAddNewClient.CheckedChanged += new System.EventHandler(this.PermissionCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 28);
            this.label3.TabIndex = 44;
            this.label3.Text = "Permissions:";
            // 
            // frmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1379, 830);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.pnlUserInfo);
            this.Controls.Add(this.gbUserCard);
            this.Controls.Add(this.btnShowInfo);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateUser";
            this.Text = "frmUpdateUser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbAllPhones.ResumeLayout(false);
            this.pnlUserInfo.ResumeLayout(false);
            this.pnlUserInfo.PerformLayout();
            this.gbUserCard.ResumeLayout(false);
            this.gbUserCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.pnlPermissions.ResumeLayout(false);
            this.pnlPermissions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnShowInfo;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2GroupBox gbAllPhones;
        private Guna.UI2.WinForms.Guna2Button btnAddNewPhone;
        private Guna.UI2.WinForms.Guna2Panel pnlUserInfo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPermissions;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox gbUserCard;
        private System.Windows.Forms.Label lblPermissions;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button btnUpdateUser;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlPermissions;
        private Guna.UI2.WinForms.Guna2CheckBox chkLoginRegisters;
        private Guna.UI2.WinForms.Guna2CheckBox chkTransaction;
        private Guna.UI2.WinForms.Guna2CheckBox chkManageUsers;
        private Guna.UI2.WinForms.Guna2CheckBox chkFindClient;
        private Guna.UI2.WinForms.Guna2CheckBox chkAll;
        private Guna.UI2.WinForms.Guna2CheckBox chkShowClientsList;
        private Guna.UI2.WinForms.Guna2CheckBox chkUpdateClient;
        private Guna.UI2.WinForms.Guna2CheckBox chkDeleteClient;
        private Guna.UI2.WinForms.Guna2CheckBox chkAddNewClient;
        private System.Windows.Forms.Label label3;
    }
}