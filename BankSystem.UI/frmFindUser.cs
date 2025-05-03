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
    public partial class frmFindUser : Form
    {
        public frmFindUser()
        {
            InitializeComponent();
        }


        Users _user = new Users();
        Persons _person = new Persons();
        Phones _phone = new Phones();

        UIHelper _clientUI;


        private void InitializeClientUIObject()
        {
            _clientUI = new UIHelper(errorProvider1, gbClientCard, txtAccountNumber, lblFirstName, lblLastName, lblBalance, lblPinCode,
                lblPhone, lblAccountNumber, lblEmail, _client, _person, _phone);
        }
        private void HandleClientAction(enAction clientAction)
        {
            InitializeClientUIObject();

            _clientUI.Action = clientAction;

            _clientUI.HandleClientInfo();
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            HandleClientAction(enAction.Find);
        }
    }
}
