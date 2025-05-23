﻿using BankSystemBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class frmAddNewClient : Form
    {
        public frmAddNewClient()
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
            _clientUI = new UIHelper(errorProvider1, txtAccountNumber, txtEmail, txtPhone, txtBalance, txtPinCode, txtFirstName,
                 txtLastName, pnlClientInfo, true, client, person, phone, cbPhones);
        }      

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            InitializeAllObjects();

            HandleNewClient();
        }
        
        private void HandleNewClient()
        {
            if (_clientUI.ValidateInputFields(pnlClientInfo))
            {
                if (!_clientUI.IsAccountNumberDuplicated(txtAccountNumber.Text))
                {
                    AddNewClient();

                    _clientUI.ClearForm(pnlClientInfo);
                }

                else
                {
                    _clientUI.ShowMessage("This account number already exists");
                }
            }
        }

        private void AddNewClient()
        {
            InitializeAllObjects();

            _clientUI.FillClientInfo();

            _clientUI.ValidationSave();
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            InitializeAllObjects();

            _clientUI.AddPhone();
        }
    }
}
