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
    public partial class frmDeleteClient : Form
    {
        public frmDeleteClient()
        {
            InitializeComponent();
        }

        Clients _client = new Clients();
        Persons _person = new Persons();
        Phones _phone = new Phones();

        enum enClientAction { Delete = 0, ShowInfo = 1 };


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

                ShowMessage("Sorry, This Account Number Information Does Not Exist");

                return true;
            }

            return false;

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

        private bool IsDeletionSuccessful(string accountNumber)
        {
            int personID = _client.personID;

            return (Clients.DeleteClient(accountNumber) && Phones.DeletePhone(personID) && Persons.DeletePerson(personID));
        }

        private void ClearAccountNumberText()
        {
            txtAccountNumber.Text = "";
        }
        public void DeleteClient(string accountNumber)
        {
                if (IsDeletionSuccessful(accountNumber))
                {
                    ShowMessage("Client Deleted Successfully");

                    HideClientCard();

                    ClearAccountNumberText();
                }                 

                else
                    ShowMessage("Deletion Failed");            
        }

        private void ConfirmDeletion()
        {
            string accountNumber = txtAccountNumber.Text;

            if (AreObjectsInfoSuccessfullyLoaded(accountNumber))
            {
                if (MessageBox.Show("Ary you sure to delete this client?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteClient(accountNumber);
                }
            }
                   
        }
        private bool IsClientObjectNull()
        {
            return (_client == null);
        }

        private void FillClientCard(string accountNumber)
        {
            lblFirstName.Text = _person.firstName;

            lblLastName.Text = _person.lastName;

            lblBalance.Text = _client.balance.ToString();

            lblPinCode.Text = _client.pinCode.ToString();

            lblPhone.Text = _phone.phoneNumber;

            lblAccountNumber.Text = accountNumber;

            if (_person.email != "")
                lblEmail.Text = _person.email;

            else
                lblEmail.Text = "Unknown";
        }
        private void ShowClientInfo()
        {
            string accountNumber = txtAccountNumber.Text;

            if (!AreObjectsInfoSuccessfullyLoaded(accountNumber))
                return;
            
            FillClientCard(accountNumber);
          
            VisibleClientCard();
        }


        private void VisibleClientCard()
        {
            gbClientCard.Visible = true;
        }

        private void HideClientCard()
        {
            gbClientCard.Visible = false;
        }

        private bool NullValidation(TextBox textbox)
        {
            return (InputValidator.IsControlTextNull(textbox.Text));
        }

        private void SetErrorOnAccountNumber(string message = "This field should not be empty")
        {
            InputValidator.SetMessageError(txtAccountNumber, message, errorProvider1);
        }

        private void ExecuteClientAction(enClientAction clientAction)
        {
            switch (clientAction)
            {
                case enClientAction.Delete:
                    ConfirmDeletion();
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
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            HandleClientAction(enClientAction.Delete);
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            HandleClientAction(enClientAction.ShowInfo);
        }
    }
}
