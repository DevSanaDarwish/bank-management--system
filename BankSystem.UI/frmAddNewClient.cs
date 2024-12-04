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
            _clientUI = new ClientUIHelper(errorProvider1, txtAccountNumber, txtEmail, txtPhone, txtBalance, txtPinCode, txtFirstName,
                 txtLastName, pnlClientInfo, true, client, person, phone, cbPhones);
        }      

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            InitializeAllObjects();

            if (_clientUI.ValidateInputFields())
            {
                AddNewClient();

                _clientUI.ClearForm();
            }
        }

        private void Add()
        {
            _clientUI.FillClientInfo();

            _clientUI.ValidationSave();
        }

        private void AddNewClient()
        {
            InitializeAllObjects();

            Add();
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            InitializeAllObjects();

            _clientUI.AddPhone();
        }

        //private void ResetTablesIdentity()
        //{
        //    Clients.ResetClientIdentity();
        //    Persons.ResetPersonIdentity();
        //    Phones.ResetPhonesIdentity();
        //}

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
