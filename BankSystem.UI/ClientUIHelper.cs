using BankSystemBusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public class ClientUIHelper
    {
        ErrorProvider _errorProvider1;

        Guna2GroupBox _gbClientCard;

        TextBox _txtAccountNumber;

        Label _lblFirstName, _lblLastName, _lblBalance, _lblPinCode, _lblPhone, _lblAccountNumber, _lblEmail;

        Clients _client = new Clients();
        Persons _person = new Persons();
        Phones _phone = new Phones();

        public enum enClientAction { Update = 0, ShowInfo = 1, Delete = 2 };
        public enClientAction clientAction = enClientAction.ShowInfo;
        public ClientUIHelper(ErrorProvider errorProvider1, Guna2GroupBox gbClientCard, TextBox txtAccountNumber,
            Label lblFirstName, Label lblLastName, Label lblBalance, Label lblPinCode, Label lblPhone, Label lblAccountNumber, Label lblEmail,
            Clients client, Persons person, Phones phone)
        {
            this._errorProvider1 = errorProvider1;
            this._gbClientCard = gbClientCard;
            this._txtAccountNumber = txtAccountNumber;
            this._lblFirstName = lblFirstName;
            this._lblLastName = lblLastName;
            this._lblBalance = lblBalance;
            this._lblPinCode = lblPinCode;
            this._lblPhone = lblPhone;
            this._lblAccountNumber = lblAccountNumber;
            this._lblEmail = lblEmail;
            this._client = client;
            this._person = person;
            this._phone = phone;
        }

        public ClientUIHelper(ErrorProvider errorProvider1, Guna2GroupBox gbClientCard, TextBox txtAccountNumber,
           Label lblFirstName, Label lblLastName, Label lblBalance, Label lblPinCode, Label lblPhone, Label lblEmail,
           Clients client, Persons person, Phones phone)
        {
            this._errorProvider1 = errorProvider1;
            this._gbClientCard = gbClientCard;
            this._txtAccountNumber = txtAccountNumber;
            this._lblFirstName = lblFirstName;
            this._lblLastName = lblLastName;
            this._lblBalance = lblBalance;
            this._lblPinCode = lblPinCode;
            this._lblPhone = lblPhone;
            this._lblEmail = lblEmail;
            this._client = client;
            this._person = person;
            this._phone = phone;
        }



        private bool NullValidation(TextBox textbox)
        {
            return (InputValidator.IsControlTextNull(textbox.Text));
        }

        private void SetErrorOnAccountNumber(string message = "This field should not be empty")
        {
            InputValidator.SetMessageError(_txtAccountNumber, message, _errorProvider1);
        }

        private void ShowMessage(string text)
        {
            MessageBox.Show(text, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private  bool IsObjectNull(object obj)
        {
            return (obj == null);
        }

        private void VisibleClientCard()
        {
            _gbClientCard.Visible = true;
        }

        private void HideClientCard()
        {
            _gbClientCard.Visible = false;
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

        private void FillClientCard(string accountNumber)
        {
            _lblFirstName.Text = _person.firstName;

            _lblLastName.Text = _person.lastName;

            _lblBalance.Text = _client.balance.ToString();

            _lblPinCode.Text = _client.pinCode.ToString();

            _lblPhone.Text = _phone.phoneNumber;

            _lblAccountNumber.Text = accountNumber;

            if (_person.email != "")
                _lblEmail.Text = _person.email;

            else
                _lblEmail.Text = "Unknown";
        }

        private void ShowClientInfo()
        {
            string accountNumber = _txtAccountNumber.Text;

            if (!AreObjectsInfoSuccessfullyLoaded(accountNumber))
                return;

            FillClientCard(accountNumber);

            VisibleClientCard();
        }

        private bool ValidateInputFields()
        {
            return IsInputFieldsNotNull() && IsInputFieldsValid();
        }



        private void ConfirmOperation(enClientAction clientAction, string confirmMessage)
        {
            string accountNumber = _txtAccountNumber.Text;

            if (AreObjectsInfoSuccessfullyLoaded(accountNumber))
            {
                if (clientAction == enClientAction.Update && !ValidateInputFields())
                    return;

                if (MessageBox.Show(confirmMessage, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clientAction == enClientAction.Update)
                    {
                        frmUpdateClient updateClient = new frmUpdateClient();

                        updateClient.UpdateClient(accountNumber);
                    }


                    else if (clientAction == enClientAction.Delete)
                    {
                        frmDeleteClient deleteClient = new frmDeleteClient();

                        deleteClient.DeleteClient(accountNumber);
                    }
                }
            }
        }
        private void ExecuteClientAction(enClientAction clientAction)
        {
            switch (clientAction)
            {
                case enClientAction.Update:
                    ConfirmOperation(clientAction, "Ary you sure to update information this client?");
                    break;

                case enClientAction.Delete:
                    ConfirmOperation(clientAction, "Ary you sure to delete this client?");
                    break;

                case enClientAction.ShowInfo:
                    ShowClientInfo();
                    break;
            }
        }

        public void HandleClientInfo(enClientAction clientAction)
        {
            if (!NullValidation(_txtAccountNumber))
            {
                SetErrorOnAccountNumber("");

                ExecuteClientAction(clientAction);
            }

            else
                SetErrorOnAccountNumber();
        }

}
    }
}
