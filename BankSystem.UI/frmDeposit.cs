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

        private void InitializeClientUIObject()
        {
            _clientUI = new ClientUIHelper(btnDeposit);
        }

        private void SetClientAction(enClientAction clientAction)
        {
            _clientUI._clientAction = clientAction;
        }

        private void HandleClientAction(enClientAction clientAction)
        {
            InitializeClientUIObject();

            SetClientAction(clientAction);

            _clientUI.HandleClientInfo();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            HandleClientAction(enClientAction.DepositShowInfo);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            HandleClientAction(enClientAction.Deposit);
        }
    }
}
