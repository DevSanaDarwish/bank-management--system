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
    public partial class frmUpdateClient : Form
    {
        public frmUpdateClient()
        {
            InitializeComponent();
        }

        public frmUpdateClient(Clients client, Persons person, Phones phone, int personID, TextBox txtEmail, TextBox txtBalance, TextBox txtPinCode, TextBox txtFirstName, TextBox txtLastName, ClientUIHelper clientUI)
        {
            InitializeComponent();

            this._client = client;
            this._person = person;
            this._phone = phone;
            this._personID = personID;
            this._txtEmail = txtEmail;
            this._txtBalance = txtBalance;
            this._txtPinCode = txtPinCode;
            this._txtFirstName = txtFirstName;
            this._txtLastName = txtLastName;
            this._clientUI = clientUI;
        }

        public frmUpdateClient(ClientUIHelper clientUI)
        {
            InitializeComponent();

            this._clientUI = clientUI;
        }

        public ClientUIHelper _clientUI;

        Clients _client = new Clients();
        Persons _person = new Persons();
        Phones _phone = new Phones();

        int _personID = -1;

        TextBox _txtEmail, _txtBalance, _txtPinCode, _txtFirstName, _txtLastName;

        bool _isValid = true;


        private void InitializeClientUIObject()
        {
            _clientUI = new ClientUIHelper(errorProvider1, gbClientCard, txtAccountNumber, txtEmail, txtPhone, txtBalance, txtPinCode, txtFirstName,
              txtLastName, pnlClientInfo, _isValid, lblFirstName, lblLastName, lblBalance, lblPinCode, lblPhone, lblEmail, _client, _person,
              _phone, cbPhones, btnUpdateClient, _personID, _clientUI);
        }

        private void SetClientAction(enClientAction clientAction)
        {
            _clientUI._clientAction = clientAction;
        }

        private void Update()
        {
            enClientAction clientAction = enClientAction.Update;
            SetClientAction(clientAction);

            _clientUI.FillClientInfo();

            _clientUI.ValidationSave();
        }

        public void UpdateClient()
        {
            Update();
        }

        private void HandleClientAction(enClientAction clientAction)
        {
            InitializeClientUIObject();

            SetClientAction(clientAction);

            _clientUI.HandleClientInfo();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            HandleClientAction(enClientAction.UpdateShowInfo);
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            HandleClientAction(enClientAction.Update);
        }

        private void AddPhone()
        {
            _clientUI.AddPhone();
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            AddPhone();
        }
    }
}
