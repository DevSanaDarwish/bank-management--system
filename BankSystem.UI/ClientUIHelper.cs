using BankSystemBusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BankSystem.ClientUIHelper;

namespace BankSystem
{
    public class ClientUIHelper
    {
        private Form _form { get; set; }

        public enum enClientAction { DeleteShowInfo = 0, UpdateShowInfo = 1, DepositShowInfo = 2, WithdrawShowInfo = 3, Update = 4, Delete = 5, Find = 6, Deposit = 7, Withdraw = 8 };
        public enClientAction _clientAction;

        enum enOperationType { Update = 0, Add = 1 };
        enOperationType _typeWord;

        enum enOperationStatus { Updated = 0, Added = 1 };
        enOperationStatus _statusWord;


        Guna2Button _btnUpdateClient, _btnDeleteClient, _btnTransaction;

        ErrorProvider _errorProvider1;

        Guna2GroupBox _gbClientCard;

        TextBox _txtAccountNumber, _txtEmail, _txtPhone, _txtBalance, _txtPinCode, _txtFirstName, _txtLastName, _txtTransactionAmount;

        Guna2Panel _pnlClientInfo;

        Label _lblFirstName, _lblLastName, _lblBalance, _lblPinCode, _lblPhone, _lblAccountNumber, _lblEmail, _lblTransactionAmount;
        ComboBox _cbPhones;

        bool _isValid = true;

        int _personID = -1;

        Clients _client = new Clients();
        Persons _person = new Persons();
        Phones _phone = new Phones();

        ClientUIHelper _clientUI;

        private void InitializeCommonFields(ErrorProvider errorProvider1, TextBox txtAccountNumber, Clients client, Persons person, Phones phone)
        {
            this._errorProvider1 = errorProvider1;
            this._txtAccountNumber = txtAccountNumber;
            this._client = client;
            this._person = person;
            this._phone = phone;
        }

        //Constructor for frmWithdraw And frmDeposit
        public ClientUIHelper(Guna2Button btnTransaction, TextBox txtAccountNumber, Guna2GroupBox gbClientCard, ErrorProvider errorProvider1,
            Clients client, Persons person, Phones phone, Label lblFirstName, Label lblLastName, Label lblBalance, Label lblPinCode, Label lblPhone,
            Label lblAccountNumber, Label lblEmail, TextBox txtTransactionAmount, Label lblTransactionAmount)
        {
            InitializeCommonFields(errorProvider1, txtAccountNumber, client, person, phone);

            this._btnTransaction = btnTransaction;
            this._gbClientCard = gbClientCard;
            this._lblFirstName = lblFirstName;
            this._lblLastName = lblLastName;
            this._lblBalance = lblBalance;
            this._lblPinCode = lblPinCode;
            this._lblPhone = lblPhone;
            this._lblAccountNumber = lblAccountNumber;
            this._lblEmail = lblEmail;
            this._txtTransactionAmount = txtTransactionAmount;
            this._lblTransactionAmount = lblTransactionAmount;
        }

        //Constructor For frmUpdateClient 
        public ClientUIHelper(ErrorProvider errorProvider1, Guna2GroupBox gbClientCard, TextBox txtAccountNumber, TextBox txtEmail, TextBox txtPhone,
           TextBox txtBalance, TextBox txtPinCode, TextBox txtFirstName, TextBox txtLastName, Guna2Panel pnlClientInfo, bool isValid,
           Label lblFirstName, Label lblLastName, Label lblBalance, Label lblPinCode, Label lblPhone, Label lblEmail,
           Clients client, Persons person, Phones phone, ComboBox cbPhones, Guna2Button btnUpdateClient, int personID, ClientUIHelper clientUI, Form form)
        {
            //this._errorProvider1 = errorProvider1;          
            //this._txtAccountNumber = txtAccountNumber;
            //this._client = client;
            //this._person = person;
            //this._phone = phone;

            InitializeCommonFields(errorProvider1, txtAccountNumber, client, person, phone);    

            this._gbClientCard = gbClientCard;
            this._lblFirstName = lblFirstName;
            this._lblLastName = lblLastName;
            this._lblBalance = lblBalance;
            this._lblPinCode = lblPinCode;
            this._lblPhone = lblPhone;
            this._lblEmail = lblEmail;        
            this._pnlClientInfo = pnlClientInfo;
            this._txtEmail = txtEmail;
            this._txtPhone = txtPhone;
            this._txtBalance = txtBalance;
            this._txtPinCode = txtPinCode;
            this._lblFirstName = lblFirstName;
            this._lblLastName = lblLastName;
            this._isValid = isValid;
            this._cbPhones = cbPhones;
            this._btnUpdateClient = btnUpdateClient;
            this._txtFirstName = txtFirstName;
            this._txtLastName = txtLastName;
            this._personID = personID;
            this._clientUI = clientUI;
            this._form = form;
        }

        //Constructor For frmAddNewClient
        public ClientUIHelper(ErrorProvider errorProvider1, TextBox txtAccountNumber, TextBox txtEmail, TextBox txtPhone,
            TextBox txtBalance, TextBox txtPinCode, TextBox txtFirstName, TextBox txtLastName, Guna2Panel pnlClientInfo, bool isValid,
            Clients client, Persons person, Phones phone, ComboBox cbPhones)
        {
            //this._errorProvider1 = errorProvider1;
            //this._txtAccountNumber = txtAccountNumber;
            //this._client = client;
            //this._person = person;
            //this._phone = phone;

            InitializeCommonFields(errorProvider1, txtAccountNumber, client, person, phone);

            this._pnlClientInfo = pnlClientInfo;
            this._txtEmail = txtEmail;
            this._txtPhone = txtPhone;
            this._txtBalance = txtBalance;
            this._txtPinCode = txtPinCode;
            this._isValid = isValid;
            this._cbPhones = cbPhones;
            this._txtFirstName = txtFirstName;
            this._txtLastName = txtLastName;
        }

        //Constructor For frmFindClient
        public ClientUIHelper(ErrorProvider errorProvider1, Guna2GroupBox gbClientCard, TextBox txtAccountNumber,
          Label lblFirstName, Label lblLastName, Label lblBalance, Label lblPinCode, Label lblPhone, Label lblAccountNumber, Label lblEmail,
          Clients client, Persons person, Phones phone)
        {
            InitializeCommonFields(errorProvider1, txtAccountNumber, client, person, phone);

            //this._errorProvider1 = errorProvider1;
            //this._txtAccountNumber = txtAccountNumber;
            //this._client = client;
            //this._person = person;
            //this._phone = phone;


            this._gbClientCard = gbClientCard;         
            this._lblFirstName = lblFirstName;
            this._lblLastName = lblLastName;
            this._lblBalance = lblBalance;
            this._lblPinCode = lblPinCode;
            this._lblPhone = lblPhone;
            this._lblAccountNumber = lblAccountNumber;
            this._lblEmail = lblEmail;
          
        }

        //Constructor For frmDeleteClient
        public ClientUIHelper(ErrorProvider errorProvider1, Guna2GroupBox gbClientCard, TextBox txtAccountNumber,
         Label lblFirstName, Label lblLastName, Label lblBalance, Label lblPinCode, Label lblPhone, Label lblAccountNumber, Label lblEmail,
         Clients client, Persons person, Phones phone, ClientUIHelper clientUI, Guna2Button btnDeleteClient, Form form)
        {
            InitializeCommonFields(errorProvider1, txtAccountNumber, client, person, phone);

            //this._errorProvider1 = errorProvider1;
            //this._txtAccountNumber = txtAccountNumber;
            //this._client = client;
            //this._person = person;
            //this._phone = phone;

            this._gbClientCard = gbClientCard;     
            this._lblFirstName = lblFirstName;
            this._lblLastName = lblLastName;
            this._lblBalance = lblBalance;
            this._lblPinCode = lblPinCode;
            this._lblPhone = lblPhone;
            this._lblAccountNumber = lblAccountNumber;
            this._lblEmail = lblEmail;   
            this._clientUI = clientUI;
            this._btnDeleteClient = btnDeleteClient;
            this._form = form;
        }

        private void SetErrorOnAccountNumber(string message = "This field should not be empty")
        {
            InputValidator.SetMessageError(_txtAccountNumber, message, _errorProvider1);
        }

        public void ShowMessage(string text)
        {
            MessageBox.Show(text, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //private bool IsObjectNull(object obj)
        //{
        //    return (obj == null);
        //}

        public void HideButton()
        {
            switch (_clientAction)
            {
                case enClientAction.UpdateShowInfo:
                    ControlHelper.HideControl(_btnUpdateClient);
                    break;

                case enClientAction.DeleteShowInfo:
                case enClientAction.Delete:
                    ControlHelper.HideControl(_btnDeleteClient);
                    break;

                case enClientAction.DepositShowInfo:
                case enClientAction.WithdrawShowInfo:
                    ControlHelper.HideControl(_btnTransaction);
                    break;

                default:
                    break;
            }
        }

        private bool IsClientNotFound(object obj)
        {
            string message = "Sorry, This Account Number Information Does Not Exist";

            if (InputValidator.IsObjectNull(obj))
            {
                HidePanelOrGroup();

                HideButton();

                if (_clientAction == enClientAction.DepositShowInfo || _clientAction == enClientAction.WithdrawShowInfo)
                {
                    HideTransactionAmountText(_txtTransactionAmount);
                    HideTransactionAmountLabel(_lblTransactionAmount);
                }

                ShowMessage(message);

                return true;
            }
            
            return false;
        }

        private bool LoadClientInfo(string accountNumber)
        {
            _client = Clients.FindByAccountNumber(accountNumber);

            return !IsClientNotFound(_client);
        }

        private bool LoadPersonInfo()
        {
            _person = Persons.Find(_client.personID);

            _personID = _client.personID;

            return !IsClientNotFound(_person);
        }

        private bool LoadPhoneInfo()
        {
            _phone = Phones.Find(_client.clientID);

            return !IsClientNotFound(_phone);
        }

        private bool AreObjectsInfoSuccessfullyLoaded(string accountNumber)
        {
            return LoadClientInfo(accountNumber) && LoadPersonInfo() && LoadPhoneInfo();
        }

        private void SetEmailLabel()
        {
            if (_person.email != "")
                _lblEmail.Text = _person.email;

            else
                _lblEmail.Text = "Unknown";
        }

        private void SetAccountNumberLabel(string accountNumber)
        {
            if (_clientAction == enClientAction.DeleteShowInfo || _clientAction == enClientAction.Find ||
                _clientAction == enClientAction.WithdrawShowInfo || _clientAction == enClientAction.DepositShowInfo)
            {
                _lblAccountNumber.Text = accountNumber;
            }       
        }

        private void FillClientCard(string accountNumber)
        {
            _lblFirstName.Text = _person.firstName;

            _lblLastName.Text = _person.lastName;

            _lblBalance.Text = _client.balance.ToString();

            _lblPinCode.Text = _client.pinCode.ToString();

            _lblPhone.Text = _phone.phoneNumber;

            SetEmailLabel();

            SetAccountNumberLabel(accountNumber);
        }

        private void ShowTransactionAmountText(TextBox txtTransactionAmount)
        {
            ControlHelper.VisibleControl(txtTransactionAmount);
        }

        private void HideTransactionAmountText(TextBox txtTransactionAmount)
        {
            ControlHelper.HideControl(txtTransactionAmount);
        }

        private void ShowTransactionAmountLabel(Label lblTransactionAmount)
        {
            ControlHelper.VisibleControl(lblTransactionAmount);
        }

        private void HideTransactionAmountLabel(Label lblTransactionAmount)
        {
            ControlHelper.HideControl(lblTransactionAmount);
        }

        private void ShowClientInfo()
        {
            string accountNumber = _txtAccountNumber.Text;

            if (!AreObjectsInfoSuccessfullyLoaded(accountNumber))
                return;

            ShowButton();

            if(_clientAction == enClientAction.DepositShowInfo || _clientAction == enClientAction.WithdrawShowInfo)
            {
                ShowTransactionAmountText(_txtTransactionAmount);
                ShowTransactionAmountLabel(_lblTransactionAmount);
            }

            FillClientCard(accountNumber);

            ControlHelper.VisibleControl(_gbClientCard);
        }

        public void Set_isValid(TextBox textbox, string messageValue, bool validValue)
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

                    AllValidation(textbox, !ControlHelper.NullValidation(textbox), message);

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
                        AllValidation(textbox, ControlHelper.NumericValidation(textbox), message);
                    }

                    if (textbox == _txtFirstName || textbox == _txtLastName)
                    {
                        AllValidation(textbox, ControlHelper.StringValidation(textbox), message);
                    }

                    if (!_isValid)
                        isValid = _isValid;
                }
            }

            return isValid;
        }

        private void ClearComboBoxPhones()
        {
            _cbPhones.Items.Clear();
        }

        private void ClearTextBoxes()
        {
            foreach (System.Windows.Forms.Control control in _pnlClientInfo.Controls)
            {
                if(control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }

            if (_clientAction == enClientAction.Update)
                ClearAccountNumberText();
        }

        public void ClearAccountNumberText()
        {
            _txtAccountNumber.Clear();
        }

        public void ClearForm()
        {
            ClearTextBoxes();

            ClearComboBoxPhones();
        }

        public bool ValidateInputFields()
        {
            return IsInputFieldsNotNull() && IsInputFieldsValid();
        }

        private string GetAccountNumber()
        {
            string accountNumber = _txtAccountNumber.Text;

            return accountNumber;
        }

        private bool IsUpdateAndValid()
        {
            if (_clientAction == enClientAction.Update)
                return (ValidateInputFields());

            return true;
        }

        private bool ShowConfirmMessage(string confirmMessage)
        {
            return (MessageBox.Show(confirmMessage, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }

        private void ExecuteUpdateDeleteClient()
        {
            switch (_clientAction)
            {
                case enClientAction.Update:
                    //frmUpdateClient updateClient = new frmUpdateClient(_client, _person, _phone, _personID, _txtEmail, _txtBalance, _txtPinCode, _txtFirstName, _txtLastName, _clientUI);
                    //updateClient.UpdateClient();

                    ((frmUpdateClient)_form).UpdateClient();

                    break;

                case enClientAction.Delete:
                    //frmDeleteClient deleteClient = new frmDeleteClient(_client, _person, _phone, _clientUI, _txtAccountNumber);
                    //deleteClient.DeleteClient(accountNumber);

                    ((frmDeleteClient)_form).DeleteClient(GetAccountNumber(), _client);

                    break;
            }
        }

        private void Confirm(string confirmMessage)
        {
            if (!IsUpdateAndValid())
                return;

            if (ShowConfirmMessage(confirmMessage))
            {
                ExecuteUpdateDeleteClient();
            }
        }
        
        private void ConfirmOperation(string confirmMessage)
        {
            if (AreObjectsInfoSuccessfullyLoaded(GetAccountNumber()))
            {
                Confirm(confirmMessage);
            }

            else
            {
                ShowMessage("Failed to load client data");
            }
        }   

        private void ExecuteClientAction()
        {
            switch (_clientAction)
            {
                case enClientAction.Update:
                    ConfirmOperation("Ary you sure to update information this client?");
                    break;

                case enClientAction.Delete:
                    ConfirmOperation("Ary you sure to delete this client?");
                    break;

                default:
                    ShowClientInfo();
                    break;
            }
        }

        private void ShowButton()
        {
            switch (_clientAction)
            {
                case enClientAction.UpdateShowInfo:
                    ControlHelper.VisibleControl(_btnUpdateClient);
                    break;

                case enClientAction.DeleteShowInfo:
                    ControlHelper.VisibleControl(_btnDeleteClient);
                    break;

                case enClientAction.DepositShowInfo:
                case enClientAction.WithdrawShowInfo:
                    ControlHelper.VisibleControl(_btnTransaction);
                    break;
            }
        }

        private void ShowPanelOrGroup()
        {
            switch (_clientAction)
            {
                case enClientAction.UpdateShowInfo:
                    ControlHelper.VisibleControl(_pnlClientInfo);
                    break;

                default:
                    ControlHelper.VisibleControl(_gbClientCard);
                    break;
            }
        }

        public void HidePanelOrGroup()
        {
            switch (_clientAction)
            {
                case enClientAction.UpdateShowInfo:
                    ControlHelper.HideControl(_pnlClientInfo);
                    break;

                case enClientAction.Update:
                    ControlHelper.HideControl(_pnlClientInfo);
                    ControlHelper.HideControl(_gbClientCard);
                    break;

                default:
                    ControlHelper.HideControl(_gbClientCard);
                    break;
            }
        }

        public void HandleClientInfo()
        {
            if (!ControlHelper.NullValidation(_txtAccountNumber))
            {
                ShowPanelOrGroup();

                SetErrorOnAccountNumber("");

                ExecuteClientAction();
            }

            else
                SetErrorOnAccountNumber();
        }

        private bool IsPhoneNumberValid()
        {
            string messageValue = "You must enter a valid value";

            AllValidation(_txtPhone, ControlHelper.NumericValidation(_txtPhone), messageValue);

            return _isValid;
        }

        private bool IsPhoneNumberNull()
        {
            string messageValue = "Please Add One Phone Number At Least";

            if (ControlHelper.NullValidation(_txtPhone))
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

        private void AddPhoneNumberToComboBox()
        {
            string phoneNumber = _txtPhone.Text;

            _cbPhones.Items.Add(phoneNumber);
        }

        private bool AddPhoneNumber()
        {
            if (!IsPhoneNumberNull())
            {
                if (IsPhoneNumberValid())
                {
                    AddPhoneNumberToComboBox();

                    return true;
                }
            }

            return false;
        }

        private void ClearPhoneText()
        {
            _txtPhone.Clear();
        }

        public void AddPhone()
        {
            if (AddPhoneNumber())
            {
                ClearPhoneText();
            }
        }

        private void FillPersonData()
        {
            _person.firstName = _txtFirstName.Text;

            _person.lastName = _txtLastName.Text;

            _person.email = string.IsNullOrWhiteSpace(_txtEmail.Text) ? "Unknown" : _txtEmail.Text;
        }

        private void FillClientData()
        {
            _client.pinCode = _txtPinCode.Text;

            _client.balance = Convert.ToDecimal(_txtBalance.Text);

            if (!(_clientAction == enClientAction.Update))
                _client.accountNumber = _txtAccountNumber.Text;
        }

        public void FillClientInfo()
        {
            FillPersonData();

            FillClientData();
        }

        private void SetTypeWord()
        {
            switch (_clientAction)
            {
                case enClientAction.Update:
                    _person.personID = _personID;
                    _typeWord = enOperationType.Update;
                    break;

                default:
                    _typeWord = enOperationType.Add;
                    break;
            }
        }

        public void ValidationSave()
        {
            SetTypeWord();

            if (_person.Save())
                ValidationClientsAndPhonesSave();

            else
                ShowMessage($"Failed to {_typeWord}");
        }

        private void ValidationPhoneNumbersSave()
        {
            byte itemsCount = Convert.ToByte(_cbPhones.Items.Count);
            string item = "";

            for (byte itemIndex = 0; itemIndex < itemsCount; itemIndex++)
            {
                item = _cbPhones.Items[itemIndex].ToString();

                ProcessPhoneItem(item);
            }
        }

        private void ProcessPhoneItem(string phoneItem)
        {
            FillPhoneObject(phoneItem);

            if (_phone.Save())
            {
                ResetPhoneObject();
            }
        }

        private void ResetPhoneObject()
        {
            _phone = new Phones();
        }

        private void FillPhoneObject(string item)
        {
            _phone.phoneNumber = item;

            _phone.personID = _personID;
        }

        private void SetPersonIDToClientObject()
        {
            string firstName = _txtFirstName.Text, lastName = _txtLastName.Text;

            _personID = Persons.Find(firstName, lastName).personID;

            _client.personID = _personID;
        }

        private void SetStatusWord()
        {
            switch (_clientAction)
            {
                case enClientAction.Update:
                    _statusWord = enOperationStatus.Updated;
                    break;

                default:
                    SetPersonIDToClientObject();
                    _statusWord = enOperationStatus.Added;
                    break;
            }
        }

        private void ShowSaveMessage()
        {
            if (_client.Save())
            {
                ShowMessage($"Successfully {_statusWord}");
            }
        }

        private void ValidationClientsAndPhonesSave()
        {
            SetStatusWord();

            ValidationPhoneNumbersSave();

            ShowSaveMessage();
        }

        
    }
}
