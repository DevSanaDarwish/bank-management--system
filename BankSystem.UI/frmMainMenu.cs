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
        }

        private void ColoringButton(Guna2Button button, Color color)
        {
            //DeepPink     DarkSeaGreen    DeepSkyBlue    DarkViolet     DarkRed    DarkOrange     Gold     Fuchsia
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
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            SetValueInLabelTitle(btnAddNewClient.Text);
            ResetButtonsColor();
            ColoringButton(btnAddNewClient, Color.DeepSkyBlue);
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            SetValueInLabelTitle(btnDeleteClient.Text);
            ResetButtonsColor();
            ColoringButton(btnDeleteClient, Color.Gold);
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            SetValueInLabelTitle(btnUpdateClient.Text);
            ResetButtonsColor();
            ColoringButton(btnUpdateClient, Color.DarkSeaGreen);
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            SetValueInLabelTitle(btnFindClient.Text);
            ResetButtonsColor();
            ColoringButton(btnFindClient, Color.DarkRed);
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

        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            if (!pnlUsers.Visible)
                pnlUsers.Visible = true;

            else
                pnlUsers.Visible = false;
        }
    }
}
