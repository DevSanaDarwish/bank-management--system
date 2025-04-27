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
using static BankSystem.UIHelper;

namespace BankSystem
{
    public partial class frmDeposit : Form
    {
        public frmDeposit()
        {
            InitializeComponent();
        }

        UIHelper _clientUI;

        private void InitializeAllObjects()
        {
            Clients client = new Clients();
            Persons person = new Persons();
            Phones phone = new Phones();

            InitializeClientUIObject(client, person, phone);
        }

        private void InitializeClientUIObject(Clients client, Persons person, Phones phone)
        {
            _clientUI = new UIHelper(btnDeposit, txtAccountNumber, gbClientCard, errorProvider1, client, person, phone, lblFirstName, lblLastName,
                lblBalance, lblPinCode, lblPhone, lblAccountNumber, lblEmail, txtDepositAmount, lblDepositAmount, this);
        }

        private void SetClientAction(enAction clientAction)
        {
            _clientUI.Action = clientAction;
        }

        private void HandleClientAction(enAction clientAction)
        {
            InitializeAllObjects();

            SetClientAction(clientAction);

            if(clientAction == enAction.Deposit)
            {
                _clientUI.HandleTransactionOperation();

                return;
            }

            _clientUI.HandleClientInfo();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            HandleClientAction(enAction.Deposit);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            HandleClientAction(enAction.DepositShowInfo);
        }
    }
}
