using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryForChildForm;

namespace BankSystem
{
    public partial class frmMainMenu : Form
    {
        private string _username { get; set; }

        private int _userID { get; set; }

        public frmMainMenu()
        {
            InitializeComponent();
        }

        public frmMainMenu(string username, int userID)
        {
            InitializeComponent();

            this._username = username;
            this._userID = userID;

            SetUsernameInLabel();
        }

        private void SetUsernameInLabel()
        {
            lblUsername.Text = _username;
        }

        private void ResetOneButtonColor(Guna2Button button)
        {
            button.BackColor = Color.Transparent;
        }

        public void ResetButtonsColor()
        {
            foreach(Control control in pnlMenu.Controls)
            {
                if(control is Guna2Button button)
                {
                    ResetOneButtonColor(button);
                }
            }

            foreach (Control control in pnlTransactions.Controls)
            {
                if (control is Guna2Button button)
                {
                    ResetOneButtonColor(button);
                }
            }

            foreach (Control control in pnlUsers.Controls)
            {
                if (control is Guna2Button button)
                {
                    ResetOneButtonColor(button);
                }
            }
        }

        private void ColoringButton(Guna2Button button, Color color)
        {
            //DeepPink    DeepSkyBlue   Gold         DarkSeaGreen    DarkRed     DarkViolet       DarkOrange     Fuchsia
            //Black       BurlyWood     CadetBlue    Chartreuse      DarkOliveGreen   Coral            CornflowerBlue  DarkMagenta

            button.BackColor = color;
            pnlTitle.BackColor = color;
        }

        private void SetValueInLabelTitle(string text)
        {
            lblTitle.Text = text.ToUpper();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            ChildFormManager.OpenChildForm(new frmHome(), pnlContent);
        }

        private void HandleButtonClick(Guna2Button button, Color color, Form form)
        {
            SetValueInLabelTitle(button.Text);

            ResetButtonsColor();

            ColoringButton(button, color);

            ChildFormManager.OpenChildForm(form, pnlContent);
        }

        private void btnShowClientsList_Click(object sender, EventArgs e)
        {
            HandleButtonClick(btnShowClientsList, Color.DeepPink, new frmShowClientsList());
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            HandleButtonClick(btnAddNewClient, Color.DeepSkyBlue, new frmAddNewClient());
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            HandleButtonClick(btnDeleteClient, Color.Gold, new frmDeleteClient());
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            HandleButtonClick(btnUpdateClient, Color.DarkSeaGreen, new frmUpdateClient());
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            HandleButtonClick(btnFindClient, Color.DarkRed, new frmFindClient());
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            TogglePanelVisibility(pnlTransactions);
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            TogglePanelVisibility(pnlUsers);
        }

        private void TogglePanelVisibility(Panel panel)
        {
            panel.Visible = !panel.Visible;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            HandleButtonClick(btnDeposit, Color.DarkViolet, new frmDeposit());
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            HandleButtonClick(btnWithdraw, Color.DarkOrange, new frmWithdraw());
        }

        private void btnTotalBalances_Click(object sender, EventArgs e)
        {
            HandleButtonClick(btnTotalBalances, Color.Fuchsia, new frmTotalBalances());
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            HandleButtonClick(btnTransfer, Color.Black, new frmTransfer(_userID));
        }

        private void btnTransferLogsList_Click(object sender, EventArgs e)
        {
            HandleButtonClick(btnTransferLogsList, Color.BurlyWood, new frmTransferLogsList());
        }

        private void btnShowUsersList_Click(object sender, EventArgs e)
        {
            HandleButtonClick(btnShowUsersList, Color.CadetBlue, new frmShowUsersList());
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            HandleButtonClick(btnAddNewUser, Color.Chartreuse, new frmAddNewUser());
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            HandleButtonClick(btnDeleteUser, Color.Orchid, new frmDeleteUser());
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            HandleButtonClick(btnUpdateUser, Color.Coral, new frmUpdateUser());
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            HandleButtonClick(btnFindUser, Color.CornflowerBlue, new frmFindUser());
        }

        private void btnLoginRegisters_Click(object sender, EventArgs e)
        {
            HandleButtonClick(btnLoginRegisters, Color.SteelBlue, new frmLoginRegisters());
        }

        private void Logout()
        {
            try
            {
                frmLoginScreen loginScreen = new frmLoginScreen();

                loginScreen.Show();

                this.Hide();
            }

            catch(Exception ex)
            {
                MessageBox.Show("An error occurred while logging out: " + ex.Message);
            }
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            HandleButtonClick(btnLogout, Color.DarkMagenta, new frmLogout());

            var result = MessageBox.Show("Are you sure you want to logout?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                Logout();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            ResetButtonsColor();

            lblTitle.Text = "HOME";

            pnlTitle.BackColor = Color.FromArgb(51, 51, 76);

            ChildFormManager.OpenChildForm(new frmHome(), pnlContent);
        }
    }
}
