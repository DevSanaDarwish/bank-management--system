using BankSystemBusinessLayer;
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

        bool _isValid = true;

        Clients _client = new Clients();
        Persons _person = new Persons();
        Phones _phone = new Phones();

        ClientUIHelper _clientUI;

        private void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void InitializeClientUIObject()
        {
            _clientUI = new ClientUIHelper(errorProvider1, txtAccountNumber, txtEmail, txtPhone, txtBalance, txtPinCode, txtFirstName,
                 txtLastName, pnlClientInfo, _isValid, _client, _person,
                 _phone, cbPhones);
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            InitializeClientUIObject();

            if (_clientUI.ValidateInputFields())
            {
                AddNewClient();
            }
        }

        private void Add()
        {
            _clientUI.FillClientInfo();
            _clientUI.ValidationSave();
        }

        private void AddNewClient()
        {
            InitializeClientUIObject();

            Add();
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            InitializeClientUIObject();

            _clientUI.AddPhone();
        }

        private void ResetTablesIdentity()
        {
            Clients.ResetClientIdentity();
            Persons.ResetPersonIdentity();
            Phones.ResetPhonesIdentity();
        }

        private void frmAddNewClient_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    ResetTablesIdentity();
            //}

            //catch (Exception ex)
            //{
            //    ShowMessage(ex.Message);
            //}
        }
    }
}
