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
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void ResetOneButtonColor(Guna2Button button)
        {
            button.BackColor = Color.Transparent;
        }

        public void ResetButtonsColor()
        {
            ResetOneButtonColor(btnShowClientsList);
            ResetOneButtonColor(btnAddNewClient);
            ResetOneButtonColor(btnDeleteClient);
            ResetOneButtonColor(btnUpdateClient);
            ResetOneButtonColor(btnFindClient);       
            ResetOneButtonColor(btnDeposit);     
            ResetOneButtonColor(btnWithdraw);     
            ResetOneButtonColor(btnTotalBalances);     
            ResetOneButtonColor(btnTransfer);     
            ResetOneButtonColor(btnTransferLogsList);     
            ResetOneButtonColor(btnShowUsersList);     
            ResetOneButtonColor(btnAddNewUser);     
            ResetOneButtonColor(btnDeleteUser);     
            ResetOneButtonColor(btnUpdateUser);     
            ResetOneButtonColor(btnFindUser);     
            ResetOneButtonColor(btnLoginRegisters);     
            ResetOneButtonColor(btnLogout);     
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
            if(!pnlTransactions.Visible)
                pnlTransactions.Visible = true;

            else
                pnlTransactions.Visible = false;

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            HandleButtonClick(btnDeposit, Color.DarkViolet, new frmDeposit());
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            if (!pnlUsers.Visible)
                pnlUsers.Visible = true;

            else
                pnlUsers.Visible = false;
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
            HandleButtonClick(btnTransfer, Color.Black, new frmTransfer());
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
            HandleButtonClick(btnDeleteUser, Color.DarkOliveGreen, new frmDeleteUser());
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
            HandleButtonClick(btnLoginRegisters, Color.DarkMagenta, new frmLoginRegisters());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            HandleButtonClick(btnLogout, Color.DarkMagenta, new frmLogout());
        }
    }
}
