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

        TextBox _txtAccountNumber, _txtEmail, _txtPhone, _txtBalance, _txtPinCode, _txtFirstName, _txtLastName;

        Guna2Panel _pnlClientInfo;

        Label _lblFirstName, _lblLastName, _lblBalance, _lblPinCode, _lblPhone, _lblAccountNumber, _lblEmail;

        ComboBox _cbPhones;

        bool _isValid = true;

        Clients _client = new Clients();
        Persons _person = new Persons();
        Phones _phone = new Phones();

        public enum enClientAction { Update = 0, ShowInfo = 1, Delete = 2 };
        public enClientAction clientAction = enClientAction.ShowInfo;


        //Constructor For frmUpdateClient
        public ClientUIHelper(ErrorProvider errorProvider1, Guna2GroupBox gbClientCard, TextBox txtAccountNumber, TextBox txtEmail, TextBox txtPhone,
            TextBox txtBalance, TextBox txtPinCode, TextBox txtFirstName, TextBox txtLastName, Guna2Panel pnlClientInfo, bool isValid,
            Label lblFirstName, Label lblLastName, Label lblBalance, Label lblPinCode, Label lblPhone, Label lblEmail,
            Clients client, Persons person, Phones phone, ComboBox cbPhones)
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
            this._pnlClientInfo = pnlClientInfo;
            this._txtEmail = txtEmail;
            this._txtPhone = txtPhone;
            this._txtBalance = txtBalance;
            this._txtPinCode = txtPinCode;
            this._lblFirstName = lblFirstName;
            this._lblLastName = lblLastName;
            this._isValid = isValid;
            this._cbPhones = cbPhones;
        }

        //Constructor For frmAddNewClient
        public ClientUIHelper(ErrorProvider errorProvider1, TextBox txtAccountNumber, TextBox txtEmail, TextBox txtPhone,
            TextBox txtBalance, TextBox txtPinCode, TextBox txtFirstName, TextBox txtLastName, Guna2Panel pnlClientInfo, bool isValid,
            Clients client, Persons person, Phones phone, ComboBox cbPhones)
        {
            this._errorProvider1 = errorProvider1;
            this._txtAccountNumber = txtAccountNumber;
            this._client = client;
            this._person = person;
            this._phone = phone;
            this._pnlClientInfo = pnlClientInfo;
            this._txtEmail = txtEmail;
            this._txtPhone = txtPhone;
            this._txtBalance = txtBalance;
            this._txtPinCode = txtPinCode;
            this._isValid = isValid;
            this._cbPhones = cbPhones;
        }

        //Constructor For frmFindClient and frmDeleteClient
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

        private void Set_isValid(TextBox textbox, string messageValue, bool validValue)
        {
            InputValidator.SetMessageError(textbox, messageValue, _errorProvider1);

            _isValid = validValue;
        }

        private void AllValidation(TextBox textbox, bool typeValidation, string message)
        {
            if (typeValidation)
            {
                Set_isValid(textbox, "", true);
            }

            else
            {
                Set_isValid(textbox, message, false);
            }
        }
        private bool IsComboBoxNull()
        {
            byte itemsCount = Convert.ToByte(_cbPhones.Items.Count);

            string messageValue = "Please Add One Phone Number At Least";

            if (itemsCount == 0)
            {
                Set_isValid(_txtPhone, messageValue, false);
                return true;
            }

            else
            {
                Set_isValid(_txtPhone, "", true);
                return false;
            }
        }


        private bool IsInputFieldsNotNull()
        {
            bool isNotNull = true;
            string message = "This field should not be empty";

            //all controls null validation
            foreach (System.Windows.Forms.Control control in _pnlClientInfo.Controls)
            {
                if (control is TextBox textbox)
                {
                    //ignore txtEmail & txtPhone
                    if (textbox == _txtEmail || textbox == _txtPhone)
                        continue;

                    AllValidation(textbox, !NullValidation(textbox), message);

                    if (!_isValid)
                        isNotNull = _isValid;
                }
            }

            //_phone control null validation
            IsComboBoxNull();

            if (!_isValid)
                isNotNull = _isValid;

            return isNotNull;
        }

        private bool NumericValidation(TextBox textbox)
        {
            return (InputValidator.IsNumeric(textbox.Text));
        }

        private bool StringValidation(TextBox textbox)
        {
            return (InputValidator.IsString(textbox.Text));
        }

        private bool IsInputFieldsValid()
        {
            bool isValid = true;
            string message = "You must enter a valid value";

            foreach (System.Windows.Forms.Control control in _pnlClientInfo.Controls)
            {
                if (control is TextBox textbox)
                {
                    if (textbox == _txtBalance || textbox == _txtPinCode)
                    {
                        AllValidation(textbox, NumericValidation(textbox), message);
                    }

                    if (textbox == _txtFirstName || textbox == _txtLastName)
                    {
                        AllValidation(textbox, StringValidation(textbox), message);
                    }

                    if (!_isValid)
                        isValid = _isValid;
                }
            }

            return isValid;
        }
        public bool ValidateInputFields()
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
                    switch (clientAction)
                    {
                        case enClientAction.Update:
                            frmUpdateClient updateClient = new frmUpdateClient();
                            updateClient.UpdateClient(accountNumber);
                            break;

                        case enClientAction.Delete:
                            frmDeleteClient deleteClient = new frmDeleteClient();
                            deleteClient.DeleteClient(accountNumber);
                            break;
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

