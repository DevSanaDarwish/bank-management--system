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
    public partial class frmTransfer : Form
    {
        public frmTransfer()
        {
            InitializeComponent();
        }

        public frmTransfer(int userID)
        {
            InitializeComponent();

            this.UserID = userID;
        }

        UIHelper _clientUI;
        
        public int UserID {  get; set; }
       
        private void InitializeClientUIObject(Clients client, Persons person, Phones phone)
        {
            _clientUI = new UIHelper(errorProvider1, txtTransferAmount, client, person, phone, gbClientCardFrom, gbClientCardTo, lblFirstNameFrom,
                lblLastNameFrom, lblBalanceFrom, lblPinCodeFrom, lblPhoneFrom, lblEmailFrom, lblFirstNameTo, lblLastNameTo, lblBalanceTo,
                lblPinCodeTo, lblPhoneTo, lblEmailTo, this, _clientUI, btnTransfer, txtAccountNumberFrom, txtAccountNumberTo, UserID);
        }
        
        private void InitializeAllObjects()
        {
            Clients client = new Clients();
            Persons person = new Persons();
            Phones phone = new Phones();

            InitializeClientUIObject(client, person, phone);
        }

        private void SetClientAction(enAction clientAction)
        {
            _clientUI.Action = clientAction;
        }

        private bool IsClientActionEqualsTransfer(enAction clientAction)
        {
            if (clientAction == enAction.Transfer)
            {
                _clientUI.HandleTransactionOperation();
                return true;
            }

            return false;
        }
        
        private void HandleClientAction(enAction clientAction)
        {
            InitializeAllObjects();       

            SetClientAction(clientAction);

            if (IsClientActionEqualsTransfer(clientAction))
                return;                

            _clientUI.HandleClientInfo();
        }

        private void btnShowInfoFrom_Click(object sender, EventArgs e)
        {
            HandleClientAction(enAction.TransferShowInfoFrom);
        }

        private void btnShowInfoTo_Click(object sender, EventArgs e)
        {
            HandleClientAction(enAction.TransferShowInfoTo);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            HandleClientAction(enAction.Transfer);
        }
    }
}
