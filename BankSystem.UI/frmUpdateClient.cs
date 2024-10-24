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

namespace BankSystem
{
    public partial class frmUpdateClient : Form
    {
        public frmUpdateClient()
        {
            InitializeComponent();
        }

        Clients _client = new Clients();
        Persons _person = new Persons();
        Phones _phone = new Phones();

        int _personID = -1;


        enum enClientAction { Update = 0, ShowInfo = 1 };

        private bool NullValidation(TextBox textbox)
        {
            return (InputValidator.IsControlTextNull(textbox.Text));
        }

        private void SetErrorOnAccountNumber(string message = "This field should not be empty")
        {
            InputValidator.SetMessageError(txtAccountNumber, message, errorProvider1);
        }

        private void FillClientCard(string accountNumber)
        {
            lblFirstName.Text = _person.firstName;

            lblLastName.Text = _person.lastName;

            lblBalance.Text = _client.balance.ToString();

            lblPinCode.Text = _client.pinCode.ToString();

            lblPhone.Text = _phone.phoneNumber;

            if(_person.email != "")
                lblEmail.Text = _person.email;

            else
                lblEmail.Text = "Unknown";
        }

        private void ClearAccountNumberText()
        {
            txtAccountNumber.Text = "";
        }

        private void ShowMessage(string text)
        {
            MessageBox.Show(text, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool IsObjectNull(object obj)
        {
            return (obj == null);
        }

        private bool IsClientNotFound(object obj)
        {
            if (IsObjectNull(obj))
            {
                HideClientCard();
                HideClientInfoPanel();
                HideUpdateButton();

                ShowMessage("Sorry, This Account Number Information Does Not Exist");

                return true;
            }

            return false;
                
        }

        private void SetPersonIDToClientObject()
        {
            string firstName = txtFirstName.Text, lastName = txtLastName.Text;

            _personID = Persons.Find(firstName, lastName).personID;

            _client.personID = _personID;
        }

        private void ValidationClientsAndPhonesSave()
        {
            SetPersonIDToClientObject();

            ValidationPhoneNumbersSave();

            if (_client.Save())
            {
                ShowMessage("Successfully Added");
            }
        }

        private void ValidationSave()
        {
            if (_person.Save())
                ValidationClientsAndPhonesSave();

            else
                ShowMessage("Failed to add");
        }

        private void ValidationPhoneNumbersSave()
        {
            byte itemsCount = Convert.ToByte(cbPhones.Items.Count);
            string item = "";

            for (byte itemIndex = 0; itemIndex < itemsCount; itemIndex++)
            {
                item = cbPhones.Items[itemIndex].ToString();

                FillPhoneObject(item);

                if (_phone.Save())
                {
                    _phone = new Phones();
                }
            }
        }

        private bool AreObjectsInfoSuccessfullyLoaded(string accountNumber)
        {
            _client = Clients.FindByAccountNumber(accountNumber);

            if (IsClientNotFound(_client))
                return false;
           

            _person = Persons.Find(_client.personID);

            if (IsClientNotFound(_person))
                return false;


            _phone = Phones.Find(_client.clientID);

            if (IsClientNotFound(_phone))
                return false;


            return true;
        }

        private void VisibleClientCard()
        {
            gbClientCard.Visible = true;
        }

        private void HideClientCard()
        {
            gbClientCard.Visible = false;
        }

        private void VisibleUpdateButton()
        {
            btnUpdateClient.Visible = true;
        }

        private void HideUpdateButton()
        {
            btnUpdateClient.Visible = false;
        }

        private void VisibleClientInfoPanel()
        {
            pnlClientInfo.Visible = true;
        }

        private void HideClientInfoPanel()
        {
            pnlClientInfo.Visible = false;
        }
        private void ShowClientInfo()
        {
            string accountNumber = txtAccountNumber.Text;

            if (!AreObjectsInfoSuccessfullyLoaded(accountNumber))
                return;

            FillClientCard(accountNumber);

            VisibleClientCard();
            VisibleClientInfoPanel();
            VisibleUpdateButton();
        }

        private void FillPhoneObject(string item)
        {
            _phone.phoneNumber = item;
            _phone.personID = _personID;
        }

        private void FillClientInfo()
        {
            _client.pinCode = txtPinCode.Text;

            _client.balance = Convert.ToDecimal(txtBalance.Text);

            _person.firstName = txtFirstName.Text;

            _person.lastName = txtLastName.Text;

            _person.email = txtEmail.Text;
        }

        //private bool IsUpdateSuccessful(string accountNumber)
        //{
        //    //int personID = _client.personID;

        //    //return (Clients.DeleteClient(accountNumber) && Phones.DeletePhone(personID) && Persons.DeletePerson(personID));


        //}

        private void UpdateClient(string accountNumber)
        {
            FillClientInfo();

            ValidationSave();
        }
        private void ConfirmUpdate()
        {
            string accountNumber = txtAccountNumber.Text;

            if (AreObjectsInfoSuccessfullyLoaded(accountNumber))
            {
                if (MessageBox.Show("Ary you sure to update information this client?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdateClient(accountNumber);
                }
            }

        }

        private void ExecuteClientAction(enClientAction clientAction)
        {
            switch (clientAction)
            {
                case enClientAction.Update:
                    ConfirmUpdate();
                    break;

                case enClientAction.ShowInfo:
                    ShowClientInfo();
                    break;
            }
        }

        private void HandleClientAction(enClientAction clientAction)
        {
            if (!NullValidation(txtAccountNumber))
            {
                SetErrorOnAccountNumber("");

                ExecuteClientAction(clientAction);
            }

            else
                SetErrorOnAccountNumber();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            HandleClientAction(enClientAction.ShowInfo);
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            HandleClientAction(enClientAction.Update);
        }
    }
}
