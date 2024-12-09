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
    public partial class frmDeposit : Form
    {
        public frmDeposit()
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
            _clientUI = new ClientUIHelper(btnDeposit, txtAccountNumber, gbClientCard, errorProvider1, client, person, phone, lblFirstName, lblLastName,
                lblBalance, lblPinCode, lblPhone, lblAccountNumber, lblEmail, txtDepositAmount, lblDepositAmount, this);
        }

        private void SetClientAction(enClientAction clientAction)
        {
            _clientUI._clientAction = clientAction;
        }

        private void HandleClientAction(enClientAction clientAction)
        {
            InitializeAllObjects();

            SetClientAction(clientAction);

            if(clientAction == enClientAction.Deposit)
            {
                _clientUI.HandleTransactionOperation();

                return;
            }

            _clientUI.HandleClientInfo();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            HandleClientAction(enClientAction.Deposit);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            HandleClientAction(enClientAction.DepositShowInfo);
        }
    }
}
