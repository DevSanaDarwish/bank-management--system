namespace BankSystem
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnLoginRegisters = new Guna.UI2.WinForms.Guna2Button();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.btnFindUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowUsersList = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageUsers = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.btnTransferLogsList = new Guna.UI2.WinForms.Guna2Button();
            this.btnTransfer = new Guna.UI2.WinForms.Guna2Button();
            this.btnTotalBalances = new Guna.UI2.WinForms.Guna2Button();
            this.btnWithdraw = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeposit = new Guna.UI2.WinForms.Guna2Button();
            this.btnTransactions = new Guna.UI2.WinForms.Guna2Button();
            this.btnFindClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewClient = new Guna.UI2.WinForms.Guna2Button();
            this.btnShowClientsList = new Guna.UI2.WinForms.Guna2Button();
            this.pnlLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlUsers.SuspendLayout();
            this.pnlTransactions.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.btnLoginRegisters);
            this.pnlMenu.Controls.Add(this.pnlUsers);
            this.pnlMenu.Controls.Add(this.btnManageUsers);
            this.pnlMenu.Controls.Add(this.pnlTransactions);
            this.pnlMenu.Controls.Add(this.btnTransactions);
            this.pnlMenu.Controls.Add(this.btnFindClient);
            this.pnlMenu.Controls.Add(this.btnUpdateClient);
            this.pnlMenu.Controls.Add(this.btnDeleteClient);
            this.pnlMenu.Controls.Add(this.btnAddNewClient);
            this.pnlMenu.Controls.Add(this.btnShowClientsList);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(238, 920);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogout.Location = new System.Drawing.Point(0, 870);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(238, 40);
            this.btnLogout.TabIndex = 22;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLoginRegisters
            // 
            this.btnLoginRegisters.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoginRegisters.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoginRegisters.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoginRegisters.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoginRegisters.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoginRegisters.FillColor = System.Drawing.Color.Transparent;
            this.btnLoginRegisters.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginRegisters.ForeColor = System.Drawing.Color.White;
            this.btnLoginRegisters.Image = ((System.Drawing.Image)(resources.GetObject("btnLoginRegisters.Image")));
            this.btnLoginRegisters.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLoginRegisters.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLoginRegisters.Location = new System.Drawing.Point(0, 830);
            this.btnLoginRegisters.Name = "btnLoginRegisters";
            this.btnLoginRegisters.Size = new System.Drawing.Size(238, 40);
            this.btnLoginRegisters.TabIndex = 21;
            this.btnLoginRegisters.Text = "Login Registers";
            this.btnLoginRegisters.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLoginRegisters.Click += new System.EventHandler(this.btnLoginRegisters_Click);
            // 
            // pnlUsers
            // 
            this.pnlUsers.BackColor = System.Drawing.Color.Gray;
            this.pnlUsers.Controls.Add(this.btnFindUser);
            this.pnlUsers.Controls.Add(this.btnUpdateUser);
            this.pnlUsers.Controls.Add(this.btnDeleteUser);
            this.pnlUsers.Controls.Add(this.btnAddNewUser);
            this.pnlUsers.Controls.Add(this.btnShowUsersList);
            this.pnlUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsers.Location = new System.Drawing.Point(0, 655);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(238, 175);
            this.pnlUsers.TabIndex = 20;
            this.pnlUsers.Visible = false;
            // 
            // btnFindUser
            // 
            this.btnFindUser.BackColor = System.Drawing.Color.Gray;
            this.btnFindUser.BorderRadius = 1;
            this.btnFindUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFindUser.FillColor = System.Drawing.Color.Transparent;
            this.btnFindUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindUser.ForeColor = System.Drawing.Color.White;
            this.btnFindUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFindUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFindUser.Location = new System.Drawing.Point(0, 140);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnFindUser.Size = new System.Drawing.Size(238, 35);
            this.btnFindUser.TabIndex = 23;
            this.btnFindUser.Text = "Find User";
            this.btnFindUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.Gray;
            this.btnUpdateUser.BorderRadius = 1;
            this.btnUpdateUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateUser.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateUser.Location = new System.Drawing.Point(0, 105);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnUpdateUser.Size = new System.Drawing.Size(238, 35);
            this.btnUpdateUser.TabIndex = 22;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Gray;
            this.btnDeleteUser.BorderRadius = 1;
            this.btnDeleteUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteUser.FillColor = System.Drawing.Color.Transparent;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteUser.Location = new System.Drawing.Point(0, 70);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnDeleteUser.Size = new System.Drawing.Size(238, 35);
            this.btnDeleteUser.TabIndex = 21;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BackColor = System.Drawing.Color.Gray;
            this.btnAddNewUser.BorderRadius = 1;
            this.btnAddNewUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNewUser.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewUser.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNewUser.Location = new System.Drawing.Point(0, 35);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnAddNewUser.Size = new System.Drawing.Size(238, 35);
            this.btnAddNewUser.TabIndex = 20;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // btnShowUsersList
            // 
            this.btnShowUsersList.BackColor = System.Drawing.Color.Gray;
            this.btnShowUsersList.BorderRadius = 1;
            this.btnShowUsersList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowUsersList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowUsersList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowUsersList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowUsersList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowUsersList.FillColor = System.Drawing.Color.Transparent;
            this.btnShowUsersList.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowUsersList.ForeColor = System.Drawing.Color.White;
            this.btnShowUsersList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnShowUsersList.ImageSize = new System.Drawing.Size(30, 30);
            this.btnShowUsersList.Location = new System.Drawing.Point(0, 0);
            this.btnShowUsersList.Name = "btnShowUsersList";
            this.btnShowUsersList.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnShowUsersList.Size = new System.Drawing.Size(238, 35);
            this.btnShowUsersList.TabIndex = 19;
            this.btnShowUsersList.Text = "Show Users List";
            this.btnShowUsersList.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnShowUsersList.Click += new System.EventHandler(this.btnShowUsersList_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageUsers.FillColor = System.Drawing.Color.Transparent;
            this.btnManageUsers.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnManageUsers.Image")));
            this.btnManageUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageUsers.ImageSize = new System.Drawing.Size(30, 30);
            this.btnManageUsers.Location = new System.Drawing.Point(0, 615);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(238, 40);
            this.btnManageUsers.TabIndex = 19;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.BackColor = System.Drawing.Color.Gray;
            this.pnlTransactions.Controls.Add(this.btnTransferLogsList);
            this.pnlTransactions.Controls.Add(this.btnTransfer);
            this.pnlTransactions.Controls.Add(this.btnTotalBalances);
            this.pnlTransactions.Controls.Add(this.btnWithdraw);
            this.pnlTransactions.Controls.Add(this.btnDeposit);
            this.pnlTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTransactions.Location = new System.Drawing.Point(0, 438);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(238, 177);
            this.pnlTransactions.TabIndex = 18;
            this.pnlTransactions.Visible = false;
            // 
            // btnTransferLogsList
            // 
            this.btnTransferLogsList.BackColor = System.Drawing.Color.Gray;
            this.btnTransferLogsList.BorderRadius = 1;
            this.btnTransferLogsList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransferLogsList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransferLogsList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransferLogsList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransferLogsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransferLogsList.FillColor = System.Drawing.Color.Transparent;
            this.btnTransferLogsList.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferLogsList.ForeColor = System.Drawing.Color.White;
            this.btnTransferLogsList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTransferLogsList.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTransferLogsList.Location = new System.Drawing.Point(0, 140);
            this.btnTransferLogsList.Name = "btnTransferLogsList";
            this.btnTransferLogsList.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnTransferLogsList.Size = new System.Drawing.Size(238, 35);
            this.btnTransferLogsList.TabIndex = 23;
            this.btnTransferLogsList.Text = "Transfer Logs List";
            this.btnTransferLogsList.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTransferLogsList.Click += new System.EventHandler(this.btnTransferLogsList_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Gray;
            this.btnTransfer.BorderRadius = 1;
            this.btnTransfer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransfer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransfer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransfer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransfer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransfer.FillColor = System.Drawing.Color.Transparent;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTransfer.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTransfer.Location = new System.Drawing.Point(0, 105);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnTransfer.Size = new System.Drawing.Size(238, 35);
            this.btnTransfer.TabIndex = 22;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnTotalBalances
            // 
            this.btnTotalBalances.BackColor = System.Drawing.Color.Gray;
            this.btnTotalBalances.BorderRadius = 1;
            this.btnTotalBalances.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTotalBalances.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTotalBalances.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTotalBalances.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTotalBalances.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTotalBalances.FillColor = System.Drawing.Color.Transparent;
            this.btnTotalBalances.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalBalances.ForeColor = System.Drawing.Color.White;
            this.btnTotalBalances.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTotalBalances.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTotalBalances.Location = new System.Drawing.Point(0, 70);
            this.btnTotalBalances.Name = "btnTotalBalances";
            this.btnTotalBalances.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnTotalBalances.Size = new System.Drawing.Size(238, 35);
            this.btnTotalBalances.TabIndex = 21;
            this.btnTotalBalances.Text = "Total Balances";
            this.btnTotalBalances.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTotalBalances.Click += new System.EventHandler(this.btnTotalBalances_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.Gray;
            this.btnWithdraw.BorderRadius = 1;
            this.btnWithdraw.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWithdraw.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWithdraw.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWithdraw.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWithdraw.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWithdraw.FillColor = System.Drawing.Color.Transparent;
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWithdraw.ImageSize = new System.Drawing.Size(30, 30);
            this.btnWithdraw.Location = new System.Drawing.Point(0, 35);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnWithdraw.Size = new System.Drawing.Size(238, 35);
            this.btnWithdraw.TabIndex = 20;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.Gray;
            this.btnDeposit.BorderRadius = 1;
            this.btnDeposit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeposit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeposit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeposit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeposit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeposit.FillColor = System.Drawing.Color.Transparent;
            this.btnDeposit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeposit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeposit.Location = new System.Drawing.Point(0, 0);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Padding = new System.Windows.Forms.Padding(55, 0, 0, 0);
            this.btnDeposit.Size = new System.Drawing.Size(238, 35);
            this.btnDeposit.TabIndex = 19;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransactions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransactions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransactions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransactions.FillColor = System.Drawing.Color.Transparent;
            this.btnTransactions.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactions.ForeColor = System.Drawing.Color.White;
            this.btnTransactions.Image = ((System.Drawing.Image)(resources.GetObject("btnTransactions.Image")));
            this.btnTransactions.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTransactions.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTransactions.Location = new System.Drawing.Point(0, 398);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(238, 40);
            this.btnTransactions.TabIndex = 17;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnFindClient
            // 
            this.btnFindClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFindClient.FillColor = System.Drawing.Color.Transparent;
            this.btnFindClient.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindClient.ForeColor = System.Drawing.Color.White;
            this.btnFindClient.Image = ((System.Drawing.Image)(resources.GetObject("btnFindClient.Image")));
            this.btnFindClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFindClient.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFindClient.Location = new System.Drawing.Point(0, 358);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(238, 40);
            this.btnFindClient.TabIndex = 16;
            this.btnFindClient.Text = "Find Client";
            this.btnFindClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // btnUpdateClient
            // 
            this.btnUpdateClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateClient.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdateClient.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClient.ForeColor = System.Drawing.Color.White;
            this.btnUpdateClient.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateClient.Image")));
            this.btnUpdateClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateClient.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateClient.Location = new System.Drawing.Point(0, 318);
            this.btnUpdateClient.Name = "btnUpdateClient";
            this.btnUpdateClient.Size = new System.Drawing.Size(238, 40);
            this.btnUpdateClient.TabIndex = 15;
            this.btnUpdateClient.Text = "Update Client";
            this.btnUpdateClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateClient.Click += new System.EventHandler(this.btnUpdateClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteClient.FillColor = System.Drawing.Color.Transparent;
            this.btnDeleteClient.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClient.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteClient.Image")));
            this.btnDeleteClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteClient.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteClient.Location = new System.Drawing.Point(0, 278);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(238, 40);
            this.btnDeleteClient.TabIndex = 14;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // btnAddNewClient
            // 
            this.btnAddNewClient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewClient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNewClient.FillColor = System.Drawing.Color.Transparent;
            this.btnAddNewClient.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewClient.ForeColor = System.Drawing.Color.White;
            this.btnAddNewClient.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewClient.Image")));
            this.btnAddNewClient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewClient.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNewClient.Location = new System.Drawing.Point(0, 238);
            this.btnAddNewClient.Name = "btnAddNewClient";
            this.btnAddNewClient.Size = new System.Drawing.Size(238, 40);
            this.btnAddNewClient.TabIndex = 13;
            this.btnAddNewClient.Text = "Add New Client";
            this.btnAddNewClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewClient.Click += new System.EventHandler(this.btnAddNewClient_Click);
            // 
            // btnShowClientsList
            // 
            this.btnShowClientsList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnShowClientsList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnShowClientsList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnShowClientsList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowClientsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowClientsList.FillColor = System.Drawing.Color.Transparent;
            this.btnShowClientsList.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowClientsList.ForeColor = System.Drawing.Color.White;
            this.btnShowClientsList.Image = ((System.Drawing.Image)(resources.GetObject("btnShowClientsList.Image")));
            this.btnShowClientsList.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnShowClientsList.ImageSize = new System.Drawing.Size(30, 30);
            this.btnShowClientsList.Location = new System.Drawing.Point(0, 198);
            this.btnShowClientsList.Name = "btnShowClientsList";
            this.btnShowClientsList.Size = new System.Drawing.Size(238, 40);
            this.btnShowClientsList.TabIndex = 12;
            this.btnShowClientsList.Text = "Show Clients List";
            this.btnShowClientsList.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnShowClientsList.Click += new System.EventHandler(this.btnShowClientsList_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.pbLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(238, 198);
            this.pnlLogo.TabIndex = 2;
            // 
            // pbLogo
            // 
            this.pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(3, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(235, 146);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.lblUsername);
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(238, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(1213, 90);
            this.pnlTitle.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(31, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(92, 34);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "HOME";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(1086, 43);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(53, 25);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Sana";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1032, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "User: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(238, 90);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1213, 830);
            this.pnlContent.TabIndex = 3;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1451, 920);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlUsers.ResumeLayout(false);
            this.pnlTransactions.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2Panel pnlLogo;
        private Guna.UI2.WinForms.Guna2Button btnShowClientsList;
        private Guna.UI2.WinForms.Guna2Button btnAddNewClient;
        private System.Windows.Forms.Panel pnlTitle;
        private Guna.UI2.WinForms.Guna2Button btnDeleteClient;
        private Guna.UI2.WinForms.Guna2Button btnFindClient;
        private Guna.UI2.WinForms.Guna2Button btnUpdateClient;
        private System.Windows.Forms.Panel pnlTransactions;
        private Guna.UI2.WinForms.Guna2Button btnTransactions;
        private Guna.UI2.WinForms.Guna2Button btnDeposit;
        private Guna.UI2.WinForms.Guna2Button btnTotalBalances;
        private Guna.UI2.WinForms.Guna2Button btnWithdraw;
        private Guna.UI2.WinForms.Guna2Button btnTransferLogsList;
        private Guna.UI2.WinForms.Guna2Button btnTransfer;
        private Guna.UI2.WinForms.Guna2Button btnManageUsers;
        private System.Windows.Forms.Panel pnlUsers;
        private Guna.UI2.WinForms.Guna2Button btnFindUser;
        private Guna.UI2.WinForms.Guna2Button btnUpdateUser;
        private Guna.UI2.WinForms.Guna2Button btnDeleteUser;
        private Guna.UI2.WinForms.Guna2Button btnAddNewUser;
        private Guna.UI2.WinForms.Guna2Button btnShowUsersList;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnLoginRegisters;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContent;
    }
}