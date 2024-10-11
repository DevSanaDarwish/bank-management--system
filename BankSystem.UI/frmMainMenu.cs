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


        private void btnShowClientsList_Click(object sender, EventArgs e)
        {
            SetValueInLabelTitle(btnShowClientsList.Text);
            ResetButtonsColor();
            ColoringButton(btnShowClientsList, Color.DeepPink);

            SharedForm.OpenChildForm(new frmShowClientsList(), pnlContent);
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            SetValueInLabelTitle(btnAddNewClient.Text);
            ResetButtonsColor();
            ColoringButton(btnAddNewClient, Color.DeepSkyBlue);

            SharedForm.OpenChildForm(new frmAddNewClient(), pnlContent);
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            SetValueInLabelTitle(btnDeleteClient.Text);
            ResetButtonsColor();
            ColoringButton(btnDeleteClient, Color.Gold);

            SharedForm.OpenChildForm(new frmDeleteClient(), pnlContent);
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            SetValueInLabelTitle(btnUpdateClient.Text);
            ResetButtonsColor();
            ColoringButton(btnUpdateClient, Color.DarkSeaGreen);

            SharedForm.OpenChildForm(new frmUpdateClient(), pnlContent);
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            SetValueInLabelTitle(btnFindClient.Text);
            ResetButtonsColor();
            ColoringButton(btnFindClient, Color.DarkRed);

            SharedForm.OpenChildForm(new frmFindClient(), pnlContent);
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
            SetValueInLabelTitle(btnDeposit.Text);
            ResetButtonsColor();
            ColoringButton(btnDeposit, Color.DarkViolet);

            SharedForm.OpenChildForm(new frmDeposit(), pnlContent);
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
            SetValueInLabelTitle(btnWithdraw.Text);
            ResetButtonsColor();
            ColoringButton(btnWithdraw, Color.DarkOrange);


            SharedForm.OpenChildForm(new frmWithdraw(), pnlContent);
        }

        private void btnTotalBalances_Click(object sender, EventArgs e)
        {
            SetValueInLabelTitle(btnTotalBalances.Text);
            ResetButtonsColor();
            ColoringButton(btnTotalBalances, Color.Fuchsia);


            SharedForm.OpenChildForm(new frmTotalBalances(), pnlContent);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            SetValueInLabelTitle(btnTransfer.Text);
            ResetButtonsColor();
            ColoringButton(btnTransfer, Color.Black);

            SharedForm.OpenChildForm(new frmTransfer(), pnlContent);
        }

        private void btnTransferLogsList_Click(object sender, EventArgs e)
        {
            SetValueInLabelTitle(btnTransferLogsList.Text);
            ResetButtonsColor();
            ColoringButton(btnTransferLogsList, Color.BurlyWood);

            SharedForm.OpenChildForm(new frmTransferLogsList(), pnlContent);
        }

        private void btnShowUsersList_Click(object sender, EventArgs e)
        {
            SetValueInLabelTitle(btnShowUsersList.Text);
            ResetButtonsColor();
            ColoringButton(btnShowUsersList, Color.CadetBlue);

            SharedForm.OpenChildForm(new frmShowUsersList(), pnlContent);
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            SetValueInLabelTitle(btnAddNewUser.Text);
            ResetButtonsColor();
            ColoringButton(btnAddNewUser, Color.Chartreuse);

            SharedForm.OpenChildForm(new frmAddNewUser(), pnlContent);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            SetValueInLabelTitle(btnDeleteUser.Text);
            ResetButtonsColor();
            ColoringButton(btnDeleteUser, Color.DarkOliveGreen);

            SharedForm.OpenChildForm(new frmDeleteUser(), pnlContent);
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            SetValueInLabelTitle(btnUpdateUser.Text);
            ResetButtonsColor();
            ColoringButton(btnUpdateUser, Color.Coral);

            SharedForm.OpenChildForm(new frmUpdateUser(), pnlContent);
        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            SetValueInLabelTitle(btnFindUser.Text);
            ResetButtonsColor();
            ColoringButton(btnFindUser, Color.CornflowerBlue);

            SharedForm.OpenChildForm(new frmFindUser(), pnlContent);
        }

        private void btnLoginRegisters_Click(object sender, EventArgs e)
        {
            SetValueInLabelTitle(btnLoginRegisters.Text);
            ResetButtonsColor();
            ColoringButton(btnLoginRegisters, Color.DarkMagenta);

            SharedForm.OpenChildForm(new frmLoginRegisters(), pnlContent);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            SetValueInLabelTitle(btnLogout.Text);
            ResetButtonsColor();
            ColoringButton(btnLogout, Color.DarkMagenta);

            SharedForm.OpenChildForm(new frmLogout(), pnlContent);
        }
    }
}
