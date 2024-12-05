using BankSystemBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BankSystem.ClientUIHelper;

namespace BankSystem
{
    public partial class frmWithdraw : Form
    {
        public frmWithdraw()
        {
            InitializeComponent();
        }

        ClientUIHelper _clientUI;

        private void InitializeAllObjects()
        {
            Clients client = new Clients();
            Persons person = new Persons();
            Phones phone = new Phones();

            InitializeClientUIObject(client, person, phone);
        }

        private void InitializeClientUIObject(Clients client, Persons person, Phones phone)
        {
            _clientUI = new ClientUIHelper(btnWithdraw, txtAccountNumber, gbClientCard, errorProvider1, client, person, phone, lblFirstName, lblLastName,
                lblBalance, lblPinCode, lblPhone, lblAccountNumber, lblEmail, txtWithdrawAmount, lblWithdrawAmount);
        }

        private void SetClientAction(enClientAction clientAction)
        {
            _clientUI._clientAction = clientAction;
        }

        private void HandleClientAction(enClientAction clientAction)
        {
            InitializeAllObjects();

            SetClientAction(clientAction);

            _clientUI.HandleClientInfo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            HandleClientAction(enClientAction.WithdrawShowInfo);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            HandleClientAction(enClientAction.Withdraw);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
