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
    public partial class frmTransfer : Form
    {
        public frmTransfer()
        {
            InitializeComponent();
        }

        public frmTransfer(int userID)
        {
            InitializeComponent();

            this._userID = userID;
        }

        ClientUIHelper _clientUI;
        
        public int _userID {  get; set; }
       
        private void InitializeClientUIObject(Clients client, Persons person, Phones phone)
        {
            _clientUI = new ClientUIHelper(errorProvider1, txtTransferAmount, client, person, phone, gbClientCardFrom, gbClientCardTo, lblFirstNameFrom,
                lblLastNameFrom, lblBalanceFrom, lblPinCodeFrom, lblPhoneFrom, lblEmailFrom, lblFirstNameTo, lblLastNameTo, lblBalanceTo,
                lblPinCodeTo, lblPhoneTo, lblEmailTo, this, _clientUI, btnTransfer, txtAccountNumberFrom, txtAccountNumberTo, _userID);
        }
        
        private void InitializeAllObjects()
        {
            Clients client = new Clients();
            Persons person = new Persons();
            Phones phone = new Phones();

            InitializeClientUIObject(client, person, phone);
        }

        private void SetClientAction(enClientAction clientAction)
        {
            _clientUI._clientAction = clientAction;
        }

        private bool IsClientActionEqualsTransfer(enClientAction clientAction)
        {
            if (clientAction == enClientAction.Transfer)
            {
                _clientUI.HandleTransactionOperation();
                return true;
            }

            return false;
        }
        
        private void HandleClientAction(enClientAction clientAction)
        {
            InitializeAllObjects();       

            SetClientAction(clientAction);

            if (IsClientActionEqualsTransfer(clientAction))
                return;                

            _clientUI.HandleClientInfo();
        }

        private void btnShowInfoFrom_Click(object sender, EventArgs e)
        {
            HandleClientAction(enClientAction.TransferShowInfoFrom);
        }

        private void btnShowInfoTo_Click(object sender, EventArgs e)
        {
            HandleClientAction(enClientAction.TransferShowInfoTo);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            HandleClientAction(enClientAction.Transfer);
        }
    }
}
