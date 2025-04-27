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
    public partial class frmWithdraw : Form
    {
        public frmWithdraw()
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
            _clientUI = new UIHelper(btnWithdraw, txtAccountNumber, gbClientCard, errorProvider1, client, person, phone, lblFirstName, lblLastName,
                lblBalance, lblPinCode, lblPhone, lblAccountNumber, lblEmail, txtWithdrawAmount, lblWithdrawAmount, this);
        }

        private void SetClientAction(enAction clientAction)
        {
            _clientUI.Action = clientAction;
        }

        private void HandleClientAction(enAction clientAction)
        {
            InitializeAllObjects();

            SetClientAction(clientAction);

            if (clientAction == enAction.Withdraw)
            {
                _clientUI.HandleTransactionOperation();

                return;
            }

            _clientUI.HandleClientInfo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            HandleClientAction(enAction.WithdrawShowInfo);
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            HandleClientAction(enAction.Withdraw);
        }
    }
}
