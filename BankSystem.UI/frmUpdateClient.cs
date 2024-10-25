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
        ClientUIHelper _clientUI;

        Clients _client = new Clients();
        Persons _person = new Persons();
        Phones _phone = new Phones();

        int _personID = -1;

        bool _isValid = true;

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
            //SetPersonIDToClientObject();

            ValidationPhoneNumbersSave();

            if (_client.Save())
            {
                ShowMessage("Successfully Updated");
            }
        }

        private void ValidationSave()
        {
            _person.personID = _personID;

            if (_person.Save())
                ValidationClientsAndPhonesSave();

            else
                ShowMessage("Failed to update");
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
            _personID = _client.personID;

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

        public void UpdateClient(string accountNumber)
        {
            FillClientInfo();

            ValidationSave();
        }

        private bool StringValidation(TextBox textbox)
        {
            return (InputValidator.IsString(textbox.Text));
        }

        private bool IsInputFieldsValid()
        {
            bool isValid = true;
            string message = "You must enter a valid value";

            foreach (System.Windows.Forms.Control control in pnlClientInfo.Controls)
            {
                if (control is TextBox textbox)
                {
                    if (textbox == txtBalance || textbox == txtPinCode)
                    {
                        AllValidation(textbox, NumericValidation(textbox), message);
                    }

                    if (textbox == txtFirstName || textbox == txtLastName)
                    {
                        AllValidation(textbox, StringValidation(textbox), message);
                    }

                    if (!_isValid)
                        isValid = _isValid;
                }
            }

            return isValid;
        }

        private bool ValidateInputFields()
        {
            return IsInputFieldsNotNull() && IsInputFieldsValid();
        }

        private void ConfirmUpdate()
        {
            string accountNumber = txtAccountNumber.Text;

            if (AreObjectsInfoSuccessfullyLoaded(accountNumber))
            {
                if (ValidateInputFields())
                {
                    if (MessageBox.Show("Ary you sure to update information this client?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        UpdateClient(accountNumber);
                    }
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
            _clientUI = new ClientUIHelper(errorProvider1, gbClientCard, txtAccountNumber, lblFirstName, lblLastName, lblBalance, lblPinCode, lblPhone, lblEmail, _client, _person, _phone);

            _clientUI.clientAction = ClientUIHelper.enClientAction.ShowInfo;

            _clientUI.HandleClientInfo(_clientUI.clientAction);
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            _clientUI = new ClientUIHelper(errorProvider1, gbClientCard, txtAccountNumber, lblFirstName, lblLastName, lblBalance, lblPinCode, lblPhone, lblEmail, _client, _person, _phone);

            _clientUI.clientAction = ClientUIHelper.enClientAction.Update;

            _clientUI.HandleClientInfo(_clientUI.clientAction);
        }

        private bool IsPhoneNumberNull()
        {
            string messageValue = "Please Add One Phone Number At Least";

            if (NullValidation(txtPhone))
            {
                Set_isValid(txtPhone, messageValue, false);
                return true;
            }

            else
            {
                Set_isValid(txtPhone, "", true);
                return false;
            }
        }
        private void Set_isValid(TextBox textbox, string messageValue, bool validValue)
        {
            InputValidator.SetMessageError(textbox, messageValue, errorProvider1);

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

        private bool NumericValidation(TextBox textbox)
        {
            return (InputValidator.IsNumeric(textbox.Text));
        }

        private bool IsPhoneNumberValid()
        {
            string messageValue = "You must enter a valid value";

            AllValidation(txtPhone, NumericValidation(txtPhone), messageValue);

            if (_isValid == true)
                return true;

            return false;
        }

        private bool IsInputFieldsNotNull()
        {
            bool isNotNull = true;
            string message = "This field should not be empty";

            //all controls null validation
            foreach (System.Windows.Forms.Control control in pnlClientInfo.Controls)
            {
                if (control is TextBox textbox)
                {
                    //ignore txtEmail & txtPhone
                    if (textbox == txtEmail || textbox == txtPhone)
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

        private bool IsComboBoxNull()
        {
            byte itemsCount = Convert.ToByte(cbPhones.Items.Count);

            string messageValue = "Please Add One Phone Number At Least";

            if (itemsCount == 0)
            {
                Set_isValid(txtPhone, messageValue, false);
                return true;
            }

            else
            {
                Set_isValid(txtPhone, "", true);
                return false;
            }
        }

        private bool AddPhoneNumberToComboBox()
        {
            string phoneNumber = txtPhone.Text;

            if (!IsPhoneNumberNull())
            {
                if (IsPhoneNumberValid())
                {
                    cbPhones.Items.Add(phoneNumber);
                    return true;
                }
            }

            return false;
        }

        private void ClearPhoneText()
        {
            txtPhone.Clear();
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            if (AddPhoneNumberToComboBox())
            {
                ClearPhoneText();
            }
        }
    }
}
