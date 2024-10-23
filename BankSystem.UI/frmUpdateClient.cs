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

            lblEmail.Text = _person.email;

            lblBalance.Text = _client.balance.ToString();

            lblPinCode.Text = _client.pinCode.ToString();

            lblPhone.Text = _phone.phoneNumber;
        }

        private void ClearAccountNumberText()
        {
            txtAccountNumber.Text = "";
        }

        private void ShowMessage(string text)
        {
            MessageBox.Show(text, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool IsClientObjectNull()
        {
            return (_client == null);
        }

        private bool IsObjectsInfoSuccessfullyLoaded(string accountNumber)
        {
            _client = Clients.FindByAccountNumber(accountNumber);

            if (IsClientObjectNull())
            {
                HideClientCard();

                ShowMessage("Sorry, This Account Number Information Does Not Exist");

                return false;
            }

            _person = Persons.Find(_client.personID);

            _phone = Phones.Find(_client.personID);

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
        private void ShowClientInfo()
        {
            string accountNumber = txtAccountNumber.Text;

            if (!IsObjectsInfoSuccessfullyLoaded(accountNumber))
                return;

            FillClientCard(accountNumber);

            VisibleClientCard();
        }

        private bool IsUpdateSuccessful(string accountNumber)
        {
            //int personID = _client.personID;

            //return (Clients.DeleteClient(accountNumber) && Phones.DeletePhone(personID) && Persons.DeletePerson(personID));
        }

        private void UpdateClient(string accountNumber)
        {
            if (IsUpdateSuccessful(accountNumber))
            {
                ShowMessage("Client Updated Successfully");

                HideClientCard();

                ClearAccountNumberText();
            }

            else
                ShowMessage("Update Failed");
        }
        private void ConfirmUpdate()
        {
            string accountNumber = txtAccountNumber.Text;

            if (IsObjectsInfoSuccessfullyLoaded(accountNumber))
            {
                if (MessageBox.Show("Ary you sure to update this client?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
