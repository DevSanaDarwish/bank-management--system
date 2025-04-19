using BankSystemBusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BankSystem.ClientUIHelper;

namespace BankSystem
{
    public class ClientUIHelper
    {
        private Form _form { get; set; }

        public enum enClientAction
        {
            DeleteShowInfo, UpdateShowInfo, DepositShowInfo, WithdrawShowInfo, TransferShowInfoFrom, TransferShowInfoTo,
            Update, Delete, Find, Deposit, Withdraw, Transfer
        };
        public enClientAction _clientAction;

        enum enOperationType { Update, Add, Deposit, Withdraw, Transfer };
        enOperationType _typeWord;

        enum enOperationStatus { Updated, Added, Deposit, Withdraw, Transfer };
        enOperationStatus _statusWord;

        
        Guna2Button _btnUpdateClient, _btnDeleteClient, _btnTransaction;

        ErrorProvider _errorProvider1;

        Guna2GroupBox _gbClientCard, _gbClientCard2, _gbAllPhones;

        TextBox _txtAccountNumber, _txtEmail, _txtPhone, _txtBalance, _txtPinCode, _txtFirstName, _txtLastName, _txtTransactionAmount,
            _txtAccNumFrom, _txtAccNumTo;

        Guna2Panel _pnlClientInfo;

        Label _lblFirstName, _lblLastName, _lblBalance, _lblPinCode, _lblPhone, _lblAccountNumber, _lblEmail, _lblTransactionAmount,
            _lblFirstNameTo, _lblLastNameTo, _lblBalanceTo, _lblPinCodeTo, _lblPhoneTo, _lblAccountNumberTo, _lblEmailTo;

        ComboBox _cbPhones;

        bool _isValid = true;

        public int _personID = -1, _phoneID = -1, _clientID = -1;

        const decimal _maxAmount = 50000, _minAmount = 500;

        public Clients _client = new Clients();
        public Persons _person = new Persons();
        public Phones _phone = new Phones();
        public TransferLogs _transferLog = new TransferLogs();

        public List<Phones> _phoneList = new List<Phones>();

        ClientUIHelper _clientUI;

        private void InitializeCommonFields(ErrorProvider errorProvider1, TextBox txtAccountNumber, Clients client, Persons person, Phones phone)
        {
            this._errorProvider1 = errorProvider1;
            this._txtAccountNumber = txtAccountNumber;
            this._client = client;
            this._person = person;
            this._phone = phone;
        }

        //Constructor For frmTransfer
        public ClientUIHelper(ErrorProvider errorProvider1, TextBox txtTransactionAmount, Clients client, Persons person, Phones phone,
             Guna2GroupBox gbClientCardFrom, Guna2GroupBox gbClientCardTo, Label lblFirstNameFrom, Label lblLastNameFrom, Label lblBalanceFrom,
             Label lblPinCodeFrom, Label lblPhoneFrom, Label lblEmailFrom, Label lblFirstNameTo, Label lblLastNameTo, Label lblBalanceTo,
             Label lblPinCodeTo, Label lblPhoneTo, Label lblEmailTo,
             Form form, ClientUIHelper clientUI, Guna2Button btnTransfer, TextBox txtAccNumFrom, TextBox txtAccNumTo)
        {
            InitializeCommonFields(errorProvider1, txtTransactionAmount, client, person, phone);

            this._txtTransactionAmount = txtTransactionAmount;
            this._gbClientCard = gbClientCardFrom;
            this._gbClientCard2 = gbClientCardTo;
            this._lblFirstName = lblFirstNameFrom;
            this._lblLastName = lblLastNameFrom;
            this._lblBalance = lblBalanceFrom;
            this._lblPinCode = lblPinCodeFrom;
            this._lblPhone = lblPhoneFrom;
            this._lblEmail = lblEmailFrom;
            this._lblFirstNameTo = lblFirstNameTo;
            this._lblLastNameTo = lblLastNameTo;
            this._lblBalanceTo = lblBalanceTo;
            this._lblPinCodeTo = lblPinCodeTo;
            this._lblPhoneTo = lblPhoneTo;
            this._lblEmailTo = lblEmailTo;
            this._form = form;
            this._clientUI = clientUI;
            this._btnTransaction = btnTransfer;
            this._txtAccNumFrom = txtAccNumFrom;
            this._txtAccNumTo = txtAccNumTo;
        }

        //Constructor For frmDeposit And frmWithdraw
        public ClientUIHelper(Guna2Button btnTransaction, TextBox txtAccountNumber, Guna2GroupBox gbClientCard, ErrorProvider errorProvider1,
            Clients client, Persons person, Phones phone, Label lblFirstName, Label lblLastName, Label lblBalance, Label lblPinCode, Label lblPhone,
            Label lblAccountNumber, Label lblEmail, TextBox txtTransactionAmount, Label lblTransactionAmount, Form form)
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
            this._form = form;
        }

        //Constructor For frmUpdateClient 
        public ClientUIHelper(ErrorProvider errorProvider1, Guna2GroupBox gbClientCard, TextBox txtAccountNumber, TextBox txtEmail, /*Guna2GroupBox gbAllPhones,*/
           TextBox txtBalance, TextBox txtPinCode, TextBox txtFirstName, TextBox txtLastName, Guna2Panel pnlClientInfo, bool isValid,
           Label lblFirstName, Label lblLastName, Label lblBalance, Label lblPinCode, Label lblPhone, Label lblEmail,
           Clients client, Persons person, Phones phone, Guna2Button btnUpdateClient, int phoneID, ClientUIHelper clientUI, Form form)
        {
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
            //this._gbAllPhones = gbAllPhones;
            this._txtBalance = txtBalance;
            this._txtPinCode = txtPinCode;
            this._lblFirstName = lblFirstName;
            this._lblLastName = lblLastName;
            this._isValid = isValid;
            this._btnUpdateClient = btnUpdateClient;
            this._txtFirstName = txtFirstName;
            this._txtLastName = txtLastName;
            this._phoneID = phoneID;
            this._clientUI = clientUI;
            this._form = form;
        }

        //Constructor For frmAddNewClient
        public ClientUIHelper(ErrorProvider errorProvider1, TextBox txtAccountNumber, TextBox txtEmail, TextBox txtPhone,
            TextBox txtBalance, TextBox txtPinCode, TextBox txtFirstName, TextBox txtLastName, Guna2Panel pnlClientInfo, bool isValid,
            Clients client, Persons person, Phones phone, ComboBox cbPhones)
        {
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
            PresentationInputValidator.SetMessageError(_txtAccountNumber, message, _errorProvider1);
        }

        public void ShowMessage(string text)
        {
            MessageBox.Show(text, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

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
                case enClientAction.Deposit:
                case enClientAction.WithdrawShowInfo:
                case enClientAction.Withdraw:
                    ControlHelper.HideControl(_btnTransaction);
                    break;

                default:
                    break;
            }
        }

        private void HideTransactionDetails()
        {
             HideTransactionAmountText(_txtTransactionAmount);
             HideTransactionAmountLabel(_lblTransactionAmount);
        }

        private bool IsClientNotFound(object obj)
        {
            string message = "Sorry, This Account Number Information Does Not Exist";

            if (PresentationInputValidator.IsObjectNull(obj))
            {
                HidePanelOrGroup();

                HideButton();

                if (_clientAction == enClientAction.DepositShowInfo || _clientAction == enClientAction.WithdrawShowInfo)
                {
                    HideTransactionDetails();
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

        public bool LoadPhoneInfo()
        {
            _phone = Phones.Find(_client.clientID);

            return !IsClientNotFound(_phone);
        }

        //public bool LoadPhoneInfoByFindByList()
        //{
        //    _phone = Phones.FindInList(_client.clientID);
            
        //    return !IsClientNotFound(_phone);
        //}


        private bool AreObjectsInfoSuccessfullyLoaded(string accountNumber)
        {
            return LoadClientInfo(accountNumber) && LoadPersonInfo() && LoadPhoneInfo();
        }

        private void SetEmailLabel(Label label)
        {
            if (_person.email != "")
                label.Text = _person.email;

            else
                label.Text = "Unknown";
        }

        private void SetAccountNumberLabel(string accountNumber)
        {
            if (_clientAction == enClientAction.DeleteShowInfo || _clientAction == enClientAction.Find ||
                _clientAction == enClientAction.WithdrawShowInfo || _clientAction == enClientAction.DepositShowInfo)
            {
                _lblAccountNumber.Text = accountNumber;
            }
        }

        private void SetLabelsInfo(string accountNumber)
        {
            switch (_clientAction)
            {
                case enClientAction.TransferShowInfoTo:
                    FillClientCardInLabelsTo();
                    break;

                default:
                    FillClientCard(accountNumber);
                    break;
            }
        }

        private void FillClientCard(string accountNumber)
        {
            _lblFirstName.Text = _person.firstName;

            _lblLastName.Text = _person.lastName;

            _lblBalance.Text = _client.balance.ToString();

            _lblPinCode.Text = _client.pinCode.ToString();

            _lblPhone.Text = _phone.phoneNumber;

            SetEmailLabel(_lblEmail);

            SetAccountNumberLabel(accountNumber);
        }

        private void FillClientCardInLabelsTo()
        {
            _lblFirstNameTo.Text = _person.firstName;

            _lblLastNameTo.Text = _person.lastName;

            _lblBalanceTo.Text = _client.balance.ToString();

            _lblPinCodeTo.Text = _client.pinCode.ToString();

            _lblPhoneTo.Text = _phone.phoneNumber;

            SetEmailLabel(_lblEmailTo);
        }

        private void ShowTransactionAmountText(TextBox txtTransactionAmount)
        {
            ControlHelper.VisibleControl(txtTransactionAmount);
        }

        public void HideTransactionAmountText(TextBox txtTransactionAmount)
        {
            ControlHelper.HideControl(txtTransactionAmount);
        }

        private void ShowTransactionAmountLabel(Label lblTransactionAmount)
        {
            ControlHelper.VisibleControl(lblTransactionAmount);
        }

        public void HideTransactionAmountLabel(Label lblTransactionAmount)
        {
            ControlHelper.HideControl(lblTransactionAmount);
        }

        private void FillDefaultValuesForUpdate()
        {
            _txtFirstName.Text = _person.firstName;

            _txtLastName.Text = _person.lastName;

            _txtBalance.Text = _client.balance.ToString();

            _txtPinCode.Text = _client.pinCode.ToString();

            _txtEmail.Text = _person.email;
        }

        private void ShowTransactionDetails()
        {
            ShowTransactionAmountText(_txtTransactionAmount);
            ShowTransactionAmountLabel(_lblTransactionAmount);
        }

        private void ShowDefaultValues()
        {
            if (_clientAction == enClientAction.UpdateShowInfo)
            {
                FillDefaultValuesForUpdate();
            }
        }

        private bool CanEnableTransactionButton()
        {
            return (_clientAction == enClientAction.TransferShowInfoFrom || _clientAction == enClientAction.TransferShowInfoTo) && AreGroupBoxesVisible();
        }
        private void ShowClientInfo()
        {
            string accountNumber = _txtAccountNumber.Text;

            if (!AreObjectsInfoSuccessfullyLoaded(accountNumber))
                return;

            HandleShowClientInfo(accountNumber);
        }

        private void HandleShowClientInfo(string accountNumber)
        {
            SetLabelsInfo(accountNumber);

            ShowButton();

            HandleClientActionForShowInfo();

            HandleTransactionButton();
        }

        private void HandleClientActionForShowInfo()
        {
            switch (_clientAction)
            {
                case enClientAction.DepositShowInfo:
                case enClientAction.WithdrawShowInfo:
                    ShowTransactionDetails();
                    break;

                case enClientAction.UpdateShowInfo:
                    PrepareClientUpdateForm();
                    break;
            }
        }

       
        private void HandleTransactionButton()
        {
            if (CanEnableTransactionButton())
            {
                EnableTransactionButton();
            }
        }

        
        private void PrepareClientUpdateForm()
        {
            FillDefaultValuesForUpdate();

            ((frmUpdateClient)_form).ShowAllPhones();

            //((frmUpdateClient)_form).ClearPhonesGroupBox();

            //((frmUpdateClient)_form).ShowPhonesNumbers();

            //((frmUpdateClient)_form).CreateTextBoxes();
        }

        private void EnableTransactionButton()
        {
            ControlHelper.EnableControl(_btnTransaction);
        }

        public void Set_isValid(TextBox textbox, string messageValue, bool validValue)
        {
            PresentationInputValidator.SetMessageError(textbox, messageValue, _errorProvider1);

            _isValid = validValue;
        }

        public void AllValidation(TextBox textbox, bool typeValidation, string message)
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

                    AllValidation(textbox, !PresentationInputValidator.IsControlTextNull(textbox.Text), message);

                    if (!_isValid)
                        isNotNull = _isValid;
                }
            }

            //_phone control null validation
            if(_clientAction != enClientAction.Update)
            {
                IsComboBoxNull();
            }
            
            if (!_isValid)
                isNotNull = _isValid;

            return isNotNull;
        }

        private bool AreGroupBoxesVisible()
        {
            return _gbClientCard.Visible && _gbClientCard2.Visible;
        }

        private bool IsDifferentAccountsNumber()
        {
            string accFrom = _txtAccNumFrom.Text, accTo = _txtAccNumTo.Text;

            return PresentationInputValidator.IsDifferentAccountsNumber(accFrom, accTo);
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
                        AllValidation(textbox, PresentationInputValidator.IsNumeric(textbox.Text), message);
                    }

                    if (textbox == _txtFirstName || textbox == _txtLastName)
                    {
                        AllValidation(textbox, PresentationInputValidator.IsString(textbox.Text), message);
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
                if (control is TextBox textBox)
                {
                    ControlHelper.ClearTextBox(textBox);
                }
            }

            if (_clientAction == enClientAction.Update)
                ClearAccountNumberText(_txtAccountNumber);
        }

        public void ClearAccountNumberText(TextBox textBox)
        {
            SetTextAccountNumber();

            ControlHelper.ClearTextBox(textBox);
        }


        public void ClearForm()
        {
            ClearTextBoxes();

            if( _clientAction != enClientAction.Update)
            {
                ClearComboBoxPhones();
            }    
        }

        public bool IsAccountNumberDuplicated(string accountNumber)
        {
            return PresentationInputValidator.IsAccountNumberDuplicated(accountNumber);
        }

        public bool IsPhoneNumberValueDuplicated(string phoneNumber)
        {
            return PresentationInputValidator.IsPhoneNumberValueDuplicated(phoneNumber); 
        }

        public bool ValidateInputFields()
        {
            return IsInputFieldsNotNull() && IsInputFieldsValid();
        }
        
        private string GetAccountNumber(TextBox textbox)
        {
            string accountNumber = textbox.Text;

            return accountNumber;
        }

        private bool IsUpdateAndValid()
        {
            if (_clientAction == enClientAction.Update)
                return (ValidateInputFields() && ((frmUpdateClient)_form).ValidatePhoneNumbers());

            return true;
        }

        private bool ShowConfirmMessage(string confirmMessage)
        {
            return (MessageBox.Show(confirmMessage, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }


        private void ExecuteClientOperations()
        {
            switch (_clientAction)
            {
                case enClientAction.Update:
                    ((frmUpdateClient)_form).UpdateClient();

                    break;

                case enClientAction.Delete:
                    ((frmDeleteClient)_form).DeleteClient(GetAccountNumber(_txtAccountNumber), _client);
                    break;

                case enClientAction.Deposit:
                    ConfirmDeposit();
                    break;

                case enClientAction.Withdraw:
                    ConfirmWithdraw();
                    break;

                case enClientAction.Transfer:
                    ConfirmTransfer();
                    break;
            }
        }

        private void FillTransferLogObject()
        {
            _transferLog.date = DateTime.Now;
            _transferLog.sourceClientID = 
        }
        private bool AddTransferLog()
        {
            
            
            return _transferLog.AddTransferLog();
        }

        private void ProcessTransaction(bool expression)
        {
            if (expression)
            {
                HandleTransactionUI();


            }

            else
            {
                SetTypeWord();

                ShowFailedMessage();
            }
        }

        private void ConfirmTransfer()
        {
            ProcessTransaction(IsTransferSuccessful() && AddTransferLog());
        }
        private void ConfirmWithdraw()
        {
            ProcessTransaction(IsWithdrawSuccessful());
        }

        private void ConfirmDeposit()
        {
            ProcessTransaction(IsDepositSuccessful());
        }

        private void Confirm(string confirmMessage)
        {
            if (!IsUpdateAndValid())
                return;

            if (ShowConfirmMessage(confirmMessage))
            {
                ExecuteClientOperations();
            }
        }

        private bool ConfirmTransferOperation()
        {
            string accTo = GetAccountNumber(_txtAccNumTo), accFrom = GetAccountNumber(_txtAccNumFrom);

                if (AreObjectsInfoSuccessfullyLoaded(accFrom) && AreObjectsInfoSuccessfullyLoaded(accTo))
                {
                    return true;
                }

            return false;
        }

        private bool CanConfirmMessage()
        {
            return (_clientAction == enClientAction.Transfer && ConfirmTransferOperation())
                   ||
                   AreObjectsInfoSuccessfullyLoaded(GetAccountNumber(_txtAccountNumber));
        }
       
        private void ConfirmOperation(string confirmMessage)
        {
            if (CanConfirmMessage())
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

                case enClientAction.Deposit:
                    ConfirmOperation("Are you sure to do that deposit?");
                    break;

                case enClientAction.Withdraw:
                    ConfirmOperation("Are you sure to do that withdraw?");
                    break;

                case enClientAction.Transfer:
                    ConfirmOperation("Are you sure to do that transfer?");
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
                    ControlHelper.VisibleControl(_gbClientCard);
                    break;

                case enClientAction.TransferShowInfoTo:
                    ControlHelper.VisibleControl(_gbClientCard2);
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
                case enClientAction.Update:
                case enClientAction.UpdateShowInfo:
                    ControlHelper.HideControl(_pnlClientInfo);
                    ControlHelper.HideControl(_gbClientCard);
                    break;

                case enClientAction.TransferShowInfoTo:
                    ControlHelper.HideControl(_gbClientCard2);
                    break;

                case enClientAction.Transfer:
                    ControlHelper.HideControl(_gbClientCard);
                    ControlHelper.HideControl(_gbClientCard2);
                    break;

                default:
                    ControlHelper.HideControl(_gbClientCard);
                    break;
            }
        }

        public void SetTextAccountNumber()
        {
            switch (_clientAction)
            {
                case enClientAction.TransferShowInfoTo:
                    _txtAccountNumber = _txtAccNumTo;
                    break;

                case enClientAction.TransferShowInfoFrom:
                    _txtAccountNumber = _txtAccNumFrom;
                    break;

                case enClientAction.Transfer:
                    _txtAccountNumber = _txtTransactionAmount;
                    break;
            }
        }

        private bool EnsureDifferentAccounts()
        {
            if (_clientAction == enClientAction.TransferShowInfoFrom || _clientAction == enClientAction.TransferShowInfoTo)
            {
                if (!IsDifferentAccountsNumber())
                {
                    ShowMessage("Account 'from' and 'to' Cannot Be The Same.");
                    return false;
                }

                return true;
            }

            return true;
        }

        private void PerformClientActionWorkflow()
        {
            if (!EnsureDifferentAccounts())
                return;

            ShowPanelOrGroup();

            SetErrorOnAccountNumber("");

            ExecuteClientAction();
        }

        public void HandleClientInfo()
        {
            SetTextAccountNumber();

            if (!PresentationInputValidator.IsControlTextNull(_txtAccountNumber.Text))
                PerformClientActionWorkflow();

            else
                SetErrorOnAccountNumber();
        }

        private bool IsPhoneNumberValid()
        {
            string messageValue = "You must enter a valid value";

            AllValidation(_txtPhone, PresentationInputValidator.IsNumeric(_txtPhone.Text), messageValue);

            return _isValid;
        }

        private bool IsPhoneNumberNull()
        {
            string messageValue = "Please Add One Phone Number At Least";

            if (PresentationInputValidator.IsControlTextNull(_txtPhone.Text))
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

                case enClientAction.Deposit:
                    _typeWord = enOperationType.Deposit;
                    break;

                case enClientAction.Withdraw:
                    _typeWord = enOperationType.Withdraw;
                    break;

                case enClientAction.Transfer:
                    _typeWord = enOperationType.Transfer;
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
                ShowFailedMessage();
        }

        private void ValidationPhoneNumbersSave()
        {
            byte itemsCount = Convert.ToByte(_cbPhones.Items.Count);

            for (byte itemIndex = 0; itemIndex < itemsCount; itemIndex++)
            {
                string item = _cbPhones.Items[itemIndex].ToString();

                ProcessPhoneItemForAdd(item);
            }
        }

        public void ProcessPhoneItemForAdd(string phoneItem)
        {
            FillPhoneListObjectForAdd(phoneItem);

            _phone.mode = Phones.enMode.AddNew;

            if (_phone.Save())
            {
                ResetPhoneObject(_phone);
            }
        }

        public void ProcessPhoneItem(string phoneItem, short index)
        {
            FillPhoneListObject();

            if(_phoneList[index].Save(phoneItem))
            {
                ResetPhoneObject(_phoneList[index]);
            }

            //foreach (Phones phone in _phoneList)
            //{
            //    if (phone.Save(phoneItem))
            //    {
            //        ResetPhoneObject(phone);
            //    }
            //}
        }

        
        private void ResetPhoneObject(Phones phone)
        {
            phone = new Phones();

            //_phone = new Phones();
        }

        private void FillPhoneListObjectForAdd(string item)
        {
            _phone.phoneNumber = item;

            _phone.personID = _personID;
        }

        private void FillPhoneListObject()
        {
            _clientID = Clients.FindByAccountNumber(_txtAccountNumber.Text).clientID;

            _phoneList = Phones.FindInList(_clientID);


            //List<int> lstPhoneIDs = Phones.GetPhoneIDs(_clientID);

            //_phone.phoneNumber = item;

            //_phone.phoneID = _phoneID;

            //_phone.phoneID = _personID;
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

                case enClientAction.Deposit:
                    _statusWord = enOperationStatus.Deposit;
                    break;

                case enClientAction.Withdraw:
                    _statusWord = enOperationStatus.Withdraw;
                    break;

                case enClientAction.Transfer:
                    _statusWord = enOperationStatus.Transfer;
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
                ShowSuccessfulMessage();
            }
        }

        private void ValidationClientsAndPhonesSave()
        {
            SetStatusWord();

            if(_clientAction == enClientAction.Update)
            {
                ((frmUpdateClient)_form).UpdatePhones();
                ShowSaveMessage();
                return;
            }

            ValidationPhoneNumbersSave();

            ShowSaveMessage();
        }

        public bool IsAmountNull(TextBox txtAmount)
        {
            if (PresentationInputValidator.IsControlTextNull(txtAmount.Text))
            {
                AllValidation(txtAmount, false, "This field should not be empty");
                return true;
            }

            return false;
        }

        public bool IsAmountNumeric(TextBox txtAmount)
        {
            if (!PresentationInputValidator.IsNumeric(txtAmount.Text))
            {
                AllValidation(txtAmount, false, "You must enter a valid value");
                return false;
            }

            return true;
        }

        public bool IsAmountPositive(TextBox txtAmount)
        {
            decimal amount = Convert.ToDecimal(txtAmount.Text);

            if (!PresentationInputValidator.IsAmountPositive(amount))
            {
                AllValidation(txtAmount, false, "You must enter a positive value");
                return false;
            }

            return true;
        }

        private bool ValidateInputAmount()
        {
            return  !IsAmountNull(_txtTransactionAmount)     &&
                     IsAmountNumeric(_txtTransactionAmount)  &&
                     IsAmountPositive(_txtTransactionAmount) &&
                     IsAmountValid(_txtTransactionAmount);
        }

        private bool IsAmountValid(TextBox txtAmount)
        {
            decimal amount = Convert.ToDecimal(txtAmount.Text);

            if (!PresentationInputValidator.IsAmountValid(amount, _maxAmount, _minAmount))
            {
                AllValidation(txtAmount, false, $"The amount is invalid, it should be between {_minAmount} and {_maxAmount}");
                return false;
            }

            return true;
        }

        private void ShowSuccessfulMessage()
        {
            ShowMessage($"Successfully {_statusWord}");
        }

        public void ShowFailedMessage()
        {
            ShowMessage($"Failed to {_typeWord}");
        }

        private void HandleTransferUI()
        {
            _btnTransaction.Enabled = false;

            ClearAccountNumberText(_txtAccNumTo);

            ClearAccountNumberText(_txtAccNumFrom);

            SetErrorOnAccountNumber("");
        }
        private void HandleTransactionUI()
        {
            SetStatusWord();

            ShowSuccessfulMessage();

            ClearAccountNumberText(_txtAccountNumber);

            ClearAccountNumberText(_txtTransactionAmount);

            HidePanelOrGroup();

            HideButton();

            if (_clientAction == enClientAction.Transfer)
            {
                HandleTransferUI();
                return;
            }
                
            HideTransactionAmountLabel(_lblTransactionAmount);

            HideTransactionAmountText(_txtTransactionAmount);
        }

        public void HandleTransactionOperation()
        {
            if (!ValidateInputAmount())
                return;
            
            ExecuteClientAction();
        }


        private bool IsDepositSuccessful()
        {
            decimal depositAmount = Convert.ToDecimal(_txtTransactionAmount.Text);

            return Clients.DepositAmount(depositAmount, _txtAccountNumber.Text);
        }

        private bool IsAmountLessThanBalance(decimal amount)
        {
            decimal balance = Convert.ToDecimal(_lblBalance.Text);

            return PresentationInputValidator.IsAmountLessThanBalance(amount, balance);
        }

        private bool IsAmountZero()
        {
            decimal balance = Convert.ToDecimal(_lblBalance.Text);

            return PresentationInputValidator.IsBalanceZero(balance);
        }

        private bool ValidateTransaction(decimal amount)
        {
            if (IsAmountZero())
            {
                SetTypeWord();
                ShowMessage($"{_typeWord} is not allowed because your account balance is zero");
                return false;
            }

            else if (!IsAmountLessThanBalance(amount))
            {
                ShowMessage("The amount must not be greater than balance");
                return false;
            }

            return true;
        }

        

        private bool IsWithdrawSuccessful()
        {
            decimal withdrawAmount = Convert.ToDecimal(_txtTransactionAmount.Text);

            if (!ValidateTransaction(withdrawAmount))
                return false;

            return _client.WithdrawAmount(withdrawAmount, _txtAccountNumber.Text);
        }

        private bool IsTransferSuccessful()
        {
            decimal transferAmount = Convert.ToDecimal(_txtTransactionAmount.Text);
            string accountNumberFrom = _txtAccNumFrom.Text;
            string accountNumberTo = _txtAccNumTo.Text;

            if (!ValidateTransaction(transferAmount))
                return false;

            return _client.TransferAmount(accountNumberFrom, accountNumberTo, transferAmount);
        }
    }
}
