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
    public partial class frmFindClient : Form
    {
        public frmFindClient()
        {
            InitializeComponent();
        }

        Clients _client = new Clients();
        Persons _person = new Persons();
        Phones _phone = new Phones();

        ClientUIHelper _clientUI;
        private void HandleClientAction(ClientUIHelper.enClientAction clientAction)
        {
            _clientUI = new ClientUIHelper(errorProvider1, gbClientCard, txtAccountNumber, lblFirstName, lblLastName, lblBalance, lblPinCode,
                lblPhone, lblAccountNumber, lblEmail, _client, _person, _phone);
            

            _clientUI._clientAction = clientAction;

            _clientUI.HandleClientInfo();
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            HandleClientAction(ClientUIHelper.enClientAction.ShowInfo);
        }
    }
}
