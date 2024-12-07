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

            _clientUI.HandleClientInfo();
        }

        //private void HandleTransactionUI()
        //{
        //    _clientUI.ShowMessage("IsDepositSuccessful Successful");

        //    _clientUI.ClearAccountNumberText();

        //    _clientUI.ClearDepositAmountText();

        //    _clientUI.HidePanelOrGroup();

        //    _clientUI.HideButton();

        //    _clientUI.HideTransactionAmountLabel(lblDepositAmount);

        //    _clientUI.HideTransactionAmountText(txtDepositAmount);
        //}

        //public bool ValidateInputAmount()
        //{
        //    if(!_clientUI.IsAmountNull(txtDepositAmount))
        //    {
        //        if(_clientUI.IsAmountNumeric(txtDepositAmount))
        //        {
        //            decimal depositAmount = Convert.ToDecimal(txtDepositAmount.Text);

        //            return Clients.DepositAmount(depositAmount, txtAccountNumber.Text);
        //        }
        //    }

        //    return false;
        //}

        //public void IsDepositSuccessful()
        //{
        //    if (ValidateInputAmount())
        //    {
        //        HandleTransactionUI();
        //    }

        //    else
        //    {
        //        _clientUI.ShowMessage("IsDepositSuccessful Failed");
        //    }
        //}

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            //HandleClientAction(enClientAction.Deposit);

            _clientUI.ValidateInputAmount();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            HandleClientAction(enClientAction.DepositShowInfo);
        }
    }
}
