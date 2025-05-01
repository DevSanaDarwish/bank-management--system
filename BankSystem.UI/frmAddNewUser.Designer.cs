namespace BankSystem
{
    partial class frmAddNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewUser));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddNewUser = new Guna.UI2.WinForms.Guna2Button();
            this.pnlUserInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddPhone = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPhones = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlUserInfo.SuspendLayout();
            this.pnlPermissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(681, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 764);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewUser.FillColor = System.Drawing.Color.Chartreuse;
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.Location = new System.Drawing.Point(579, 737);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(296, 71);
            this.btnAddNewUser.TabIndex = 17;
            this.btnAddNewUser.Text = "Add";
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.Controls.Add(this.txtPassword);
            this.pnlUserInfo.Controls.Add(this.lblUsername);
            this.pnlUserInfo.Controls.Add(this.label1);
            this.pnlUserInfo.Controls.Add(this.label2);
            this.pnlUserInfo.Controls.Add(this.label3);
            this.pnlUserInfo.Controls.Add(this.label5);
            this.pnlUserInfo.Controls.Add(this.label6);
            this.pnlUserInfo.Controls.Add(this.txtUsername);
            this.pnlUserInfo.Controls.Add(this.txtEmail);
            this.pnlUserInfo.Controls.Add(this.txtFirstName);
            this.pnlUserInfo.Controls.Add(this.txtLastName);
            this.pnlUserInfo.Controls.Add(this.txtPhone);
            this.pnlUserInfo.Location = new System.Drawing.Point(12, 12);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(738, 341);
            this.pnlUserInfo.TabIndex = 24;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(253, 240);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(407, 35);
            this.txtPassword.TabIndex = 13;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(27, 12);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(135, 28);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Password: ";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(253, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(407, 35);
            this.txtUsername.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(253, 181);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(407, 35);
            this.txtEmail.TabIndex = 11;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(253, 63);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(407, 35);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(253, 122);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(407, 35);
            this.txtLastName.TabIndex = 10;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(253, 299);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(407, 35);
            this.txtPhone.TabIndex = 8;
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
            this.pnlPermissions.Location = new System.Drawing.Point(17, 594);
            this.pnlPermissions.Name = "pnlPermissions";
            this.pnlPermissions.Size = new System.Drawing.Size(415, 214);
            this.pnlPermissions.TabIndex = 15;
            // 
            // chkLoginRegisters
            // 
            this.chkLoginRegisters.AutoSize = true;
            this.chkLoginRegisters.CheckedState.BorderColor = System.Drawing.Color.Chartreuse;
            this.chkLoginRegisters.CheckedState.BorderRadius = 0;
            this.chkLoginRegisters.CheckedState.BorderThickness = 0;
            this.chkLoginRegisters.CheckedState.FillColor = System.Drawing.Color.Chartreuse;
            this.chkLoginRegisters.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLoginRegisters.Location = new System.Drawing.Point(250, 181);
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
            this.chkTransaction.CheckedState.BorderColor = System.Drawing.Color.Chartreuse;
            this.chkTransaction.CheckedState.BorderRadius = 0;
            this.chkTransaction.CheckedState.BorderThickness = 0;
            this.chkTransaction.CheckedState.FillColor = System.Drawing.Color.Chartreuse;
            this.chkTransaction.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTransaction.Location = new System.Drawing.Point(250, 95);
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
            this.chkManageUsers.CheckedState.BorderColor = System.Drawing.Color.Chartreuse;
            this.chkManageUsers.CheckedState.BorderRadius = 0;
            this.chkManageUsers.CheckedState.BorderThickness = 0;
            this.chkManageUsers.CheckedState.FillColor = System.Drawing.Color.Chartreuse;
            this.chkManageUsers.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkManageUsers.Location = new System.Drawing.Point(250, 138);
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
            this.chkFindClient.CheckedState.BorderColor = System.Drawing.Color.Chartreuse;
            this.chkFindClient.CheckedState.BorderRadius = 0;
            this.chkFindClient.CheckedState.BorderThickness = 0;
            this.chkFindClient.CheckedState.FillColor = System.Drawing.Color.Chartreuse;
            this.chkFindClient.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFindClient.Location = new System.Drawing.Point(250, 52);
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
            this.chkAll.CheckedState.BorderColor = System.Drawing.Color.Chartreuse;
            this.chkAll.CheckedState.BorderRadius = 0;
            this.chkAll.CheckedState.BorderThickness = 0;
            this.chkAll.CheckedState.FillColor = System.Drawing.Color.Chartreuse;
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
            this.chkShowClientsList.CheckedState.BorderColor = System.Drawing.Color.Chartreuse;
            this.chkShowClientsList.CheckedState.BorderRadius = 0;
            this.chkShowClientsList.CheckedState.BorderThickness = 0;
            this.chkShowClientsList.CheckedState.FillColor = System.Drawing.Color.Chartreuse;
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
            this.chkUpdateClient.CheckedState.BorderColor = System.Drawing.Color.Chartreuse;
            this.chkUpdateClient.CheckedState.BorderRadius = 0;
            this.chkUpdateClient.CheckedState.BorderThickness = 0;
            this.chkUpdateClient.CheckedState.FillColor = System.Drawing.Color.Chartreuse;
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
            this.chkDeleteClient.CheckedState.BorderColor = System.Drawing.Color.Chartreuse;
            this.chkDeleteClient.CheckedState.BorderRadius = 0;
            this.chkDeleteClient.CheckedState.BorderThickness = 0;
            this.chkDeleteClient.CheckedState.FillColor = System.Drawing.Color.Chartreuse;
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
            this.chkAddNewClient.CheckedState.BorderColor = System.Drawing.Color.Chartreuse;
            this.chkAddNewClient.CheckedState.BorderRadius = 0;
            this.chkAddNewClient.CheckedState.BorderThickness = 0;
            this.chkAddNewClient.CheckedState.FillColor = System.Drawing.Color.Chartreuse;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 547);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Permissions:";
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPhone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddPhone.FillColor = System.Drawing.Color.Chartreuse;
            this.btnAddPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhone.ForeColor = System.Drawing.Color.White;
            this.btnAddPhone.Location = new System.Drawing.Point(12, 366);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(376, 41);
            this.btnAddPhone.TabIndex = 23;
            this.btnAddPhone.Text = "Add The Phone Number To The List";
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(427, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 28);
            this.label7.TabIndex = 22;
            this.label7.Text = "All Phone Numbers: ";
            // 
            // cbPhones
            // 
            this.cbPhones.BackColor = System.Drawing.Color.White;
            this.cbPhones.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhones.ForeColor = System.Drawing.Color.Chartreuse;
            this.cbPhones.FormattingEnabled = true;
            this.cbPhones.Location = new System.Drawing.Point(432, 413);
            this.cbPhones.Name = "cbPhones";
            this.cbPhones.Size = new System.Drawing.Size(291, 36);
            this.cbPhones.TabIndex = 21;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1379, 830);
            this.Controls.Add(this.pnlPermissions);
            this.Controls.Add(this.pnlUserInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbPhones);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddNewUser";
            this.Text = "frmAddNewUser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlUserInfo.ResumeLayout(false);
            this.pnlUserInfo.PerformLayout();
            this.pnlPermissions.ResumeLayout(false);
            this.pnlPermissions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnAddNewUser;
        private Guna.UI2.WinForms.Guna2Panel pnlUserInfo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2Button btnAddPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbPhones;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlPermissions;
        private Guna.UI2.WinForms.Guna2CheckBox chkAddNewClient;
        private Guna.UI2.WinForms.Guna2CheckBox chkLoginRegisters;
        private Guna.UI2.WinForms.Guna2CheckBox chkTransaction;
        private Guna.UI2.WinForms.Guna2CheckBox chkManageUsers;
        private Guna.UI2.WinForms.Guna2CheckBox chkFindClient;
        private Guna.UI2.WinForms.Guna2CheckBox chkAll;
        private Guna.UI2.WinForms.Guna2CheckBox chkShowClientsList;
        private Guna.UI2.WinForms.Guna2CheckBox chkUpdateClient;
        private Guna.UI2.WinForms.Guna2CheckBox chkDeleteClient;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}