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
            _clientUI = new ClientUIHelper(errorProvider1, gbClientCard, txtAccountNumber, lblFirstName, lblLastName, lblBalance, lblPinCode,
                 lblPhone, lblAccountNumber, lblEmail, client, person, phone, _clientUI, btnDeleteClient, this);
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

        private void HandleClientDeletionUI()
        {
            _clientUI.ShowMessage("Client Deleted Successfully");

            _clientUI.ClearAccountNumberText();

            _clientUI.HidePanelOrGroup();

            _clientUI.HideButton();
        }

        public void DeleteClient(string accountNumber, Clients client)
        {
            if (IsDeletionSuccessful(accountNumber, client))
            {
                HandleClientDeletionUI();
            }

            else
                _clientUI.ShowMessage("Deletion Failed");
        }
    }
}

