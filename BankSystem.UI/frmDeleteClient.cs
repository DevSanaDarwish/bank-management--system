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
    public partial class frmDeleteClient : Form
    {
        public frmDeleteClient()
        {
            InitializeComponent();
        }

        //public frmDeleteClient(Clients client, Persons person, Phones phone, ClientUIHelper clientUI, TextBox txtAccountNumber)
        //{
        //    InitializeComponent();

        //    this._client = client;
        //    this._person = person;
        //    this._phone = phone;
        //    this._clientUI = clientUI;
        //    this._txtAccountNumber = txtAccountNumber;
        //}

        Clients _client = new Clients();
        Persons _person = new Persons();
        Phones _phone = new Phones();

        TextBox _txtAccountNumber;

        ClientUIHelper _clientUI;

        private void InitializeClientUIObject()
        {
            _clientUI = new ClientUIHelper(errorProvider1, gbClientCard, txtAccountNumber, lblFirstName, lblLastName, lblBalance, lblPinCode,
                 lblPhone, lblAccountNumber, lblEmail, _client, _person, _phone, _clientUI, btnDeleteClient, this);
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

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            HandleClientAction(enClientAction.Delete);
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            HandleClientAction(enClientAction.DeleteShowInfo);
        }

        private bool IsDeletionSuccessful(string accountNumber, Clients client)
        {
            int personID = client.personID;

            return (Clients.DeleteClient(accountNumber) && Phones.DeletePhone(personID) && Persons.DeletePerson(personID));
        }

        private void ClearAccountNumberText()
        {
            txtAccountNumber.Text = "";
        }

        public void DeleteClient(string accountNumber, Clients client)
        {
            if (IsDeletionSuccessful(accountNumber, client))
            {
                _clientUI.ShowMessage("Client Deleted Successfully");

                ControlHelper.HideControl(gbClientCard);

                ClearAccountNumberText();
            }

            else
                _clientUI.ShowMessage("Deletion Failed");
        }
    }
}

