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
//using System.Web.UI.WebControls;
using System.Windows.Forms;
using static BankSystem.UIHelper;

namespace BankSystem
{
    public class UIHelper
    {
        private Form _form { get; set; }

        public enum enAction
        {
            DeleteShowInfo, UpdateShowInfo, DepositShowInfo, WithdrawShowInfo, TransferShowInfoFrom, TransferShowInfoTo,
            Update, Delete, Find, Deposit, Withdraw, Transfer
        };
        public enAction Action;

        enum enOperationType { Update, Add, Deposit, Withdraw, Transfer };
        enOperationType _typeWord;

        enum enOperationStatus { Updated, Added, Deposit, Withdraw, Transfer };
        enOperationStatus _statusWord;

        enum enUserClient { User, Client };
        enUserClient _userClient;

        Guna2Button _btnUpdateClient, _btnDeleteClient, _btnTransaction, _btnDeleteUser;

        ErrorProvider _errorProvider1;

        Guna2GroupBox _gbClientCard, _gbClientCard2, _gbAllPhones, _gbUserCard;

        TextBox _txtAccountNumber, _txtEmail, _txtPhone, _txtBalance, _txtPinCode, _txtFirstName, _txtLastName, _txtTransactionAmount,
            _txtAccNumFrom, _txtAccNumTo, _txtUsername, _txtPassword;

        Guna2Panel _pnlClientInfo, _pnlUserInfo;

        Label _lblFirstName, _lblLastName, _lblBalance, _lblPinCode, _lblPhone, _lblAccountNumber, _lblEmail, _lblTransactionAmount, _lblUsername,
            _lblFirstNameTo, _lblLastNameTo, _lblBalanceTo, _lblPinCodeTo, _lblPhoneTo, _lblAccountNumberTo, _lblEmailTo, _lblFullName,
            _lblPermissions, _lblPassword;

        ComboBox _cbPhones;

        bool _isValid = true;

        public int PersonID = -1, PhoneID = -1, ClientID = -1, SourceClientID = -1, DestinationClientID = -1, UserID = -1;
        public short Permission = -1;

        const decimal _maxAmount = 50000, _minAmount = 500;

        public Clients Client = new Clients();
        public Persons Person = new Persons();
        public Phones Phone = new Phones();
        public TransferLogs TransferLog = new TransferLogs();
        public Users User = new Users();

        public List<Phones> PhoneList = new List<Phones>();

        UIHelper _clientUI;
        UIHelper _userUI;

        private void InitializeCommonClientFields(ErrorProvider errorProvider1, TextBox txtAccountNumber, Clients client, Persons person, Phones phone)
        {
            this._errorProvider1 = errorProvider1;
            this._txtAccountNumber = txtAccountNumber;
            this.Client = client;
            this.Person = person;
            this.Phone = phone;
        }

        private void InitializeCommonUserFields(ErrorProvider errorProvider1, Users user, Persons person, Phones phone)
        {
            this._errorProvider1 = errorProvider1;
            this.User = user;
            this.Person = person;
            this.Phone = phone;
        }

        public UIHelper() { }
      

        //Constructor For frmMainMenu
        public UIHelper(short permission) 
        { 
            this.Permission = permission;
        }
        

        //Constructor For frmTransfer
        public UIHelper(ErrorProvider errorProvider1, TextBox txtTransactionAmount, Clients client, Persons person, Phones phone,
             Guna2GroupBox gbClientCardFrom, Guna2GroupBox gbClientCardTo, Label lblFirstNameFrom, Label lblLastNameFrom, Label lblBalanceFrom,
             Label lblPinCodeFrom, Label lblPhoneFrom, Label lblEmailFrom, Label lblFirstNameTo, Label lblLastNameTo, Label lblBalanceTo,
             Label lblPinCodeTo, Label lblPhoneTo, Label lblEmailTo,
             Form form, UIHelper clientUI, Guna2Button btnTransfer, TextBox txtAccNumFrom, TextBox txtAccNumTo, int userID)
        {
            InitializeCommonClientFields(errorProvider1, txtTransactionAmount, client, person, phone);

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
            this.UserID = userID;
        }

        //Constructor For frmDeposit And frmWithdraw
        public UIHelper(Guna2Button btnTransaction, TextBox txtAccountNumber, Guna2GroupBox gbClientCard, ErrorProvider errorProvider1,
            Clients client, Persons person, Phones phone, Label lblFirstName, Label lblLastName, Label lblBalance, Label lblPinCode, Label lblPhone,
            Label lblAccountNumber, Label lblEmail, TextBox txtTransactionAmount, Label lblTransactionAmount, Form form)
        {
            InitializeCommonClientFields(errorProvider1, txtAccountNumber, client, person, phone);

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
        public UIHelper(ErrorProvider errorProvider1, Guna2GroupBox gbClientCard, TextBox txtAccountNumber, TextBox txtEmail, /*Guna2GroupBox gbAllPhones,*/
           TextBox txtBalance, TextBox txtPinCode, TextBox txtFirstName, TextBox txtLastName, Guna2Panel pnlClientInfo, bool isValid,
           Label lblFirstName, Label lblLastName, Label lblBalance, Label lblPinCode, Label lblPhone, Label lblEmail,
           Clients client, Persons person, Phones phone, Guna2Button btnUpdateClient, int phoneID, UIHelper clientUI, Form form)
        {
            InitializeCommonClientFields(errorProvider1, txtAccountNumber, client, person, phone);

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
            this.PhoneID = phoneID;
            this._clientUI = clientUI;
            this._form = form;
        }

        //Constructor For frmAddNewClient
        public UIHelper(ErrorProvider errorProvider1, TextBox txtAccountNumber, TextBox txtEmail, TextBox txtPhone,
            TextBox txtBalance, TextBox txtPinCode, TextBox txtFirstName, TextBox txtLastName, Guna2Panel pnlClientInfo, bool isValid,
            Clients client, Persons person, Phones phone, ComboBox cbPhones)
        {
            InitializeCommonClientFields(errorProvider1, txtAccountNumber, client, person, phone);

            this._pnlClientInfo = pnlClientInfo;
            this._txtEmail = txtEmail;
            this._txtPhone = txtPhone;
            this._txtBalance = txtBalance;
            this._txtPinCode = txtPinCode;
            this._isValid = isValid;
            this._cbPhones = cbPhones;
            this._txtFirstName = txtFirstName;
            this._txtLastName = txtLastName;
            this._userClient = enUserClient.Client;
        }

        //Constructor For frmAddNewUser
        public UIHelper(ErrorProvider errorProvider1, TextBox txtUsername, TextBox txtEmail, TextBox txtPhone,
            TextBox txtPassword, TextBox txtFirstName, TextBox txtLastName, Guna2Panel pnlUserInfo, bool isValid,
            Users user, Persons person, Phones phone, ComboBox cbPhones)
        {
            InitializeCommonUserFields(errorProvider1, user, person, phone);

            this._pnlUserInfo = pnlUserInfo;
            this._txtEmail = txtEmail;
            this._txtPhone = txtPhone;
            this._txtPassword = txtPassword;
            this._txtUsername = txtUsername;
            this._isValid = isValid;
            this._cbPhones = cbPhones;
            this._txtFirstName = txtFirstName;
            this._txtLastName = txtLastName;
            this._userClient = enUserClient.User;
        }

        //Constructor For frmFindClient
        public UIHelper(ErrorProvider errorProvider1, Guna2GroupBox gbClientCard, TextBox txtAccountNumber,
          Label lblFirstName, Label lblLastName, Label lblBalance, Label lblPinCode, Label lblPhone, Label lblAccountNumber, Label lblEmail,
          Clients client, Persons person, Phones phone)
        {
            InitializeCommonClientFields(errorProvider1, txtAccountNumber, client, person, phone);

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
        public UIHelper(ErrorProvider errorProvider1, Guna2GroupBox gbClientCard, TextBox txtAccountNumber,
         Label lblFirstName, Label lblLastName, Label lblBalance, Label lblPinCode, Label lblPhone, Label lblAccountNumber, Label lblEmail,
         Clients client, Persons person, Phones phone, UIHelper clientUI, Guna2Button btnDeleteClient, Form form)
        {
            InitializeCommonClientFields(errorProvider1, txtAccountNumber, client, person, phone);

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
            this._userClient = enUserClient.Client;
        }

        //Constructor For frmDeleteUser
        public UIHelper(ErrorProvider errorProvider1, Guna2GroupBox gbUserCard, TextBox txtUsername,
         Label lblFullName,  Label lblPhone, Label lblUsername, Label lblEmail, Label lblPassword, Label lblPermissions,
         Users user, Persons person, Phones phone, UIHelper userUI, Guna2Button btnDeleteUser, Form form)
        {
            InitializeCommonUserFields(errorProvider1, user, person, phone);

            this._gbUserCard = gbUserCard;
            this._txtUsername = txtUsername;
            this._lblFullName = lblFullName;
            this._lblPhone = lblPhone;
            this._lblUsername = lblUsername;
            this._lblEmail = lblEmail;
            this._lblPassword = lblPassword;
            this._lblPermissions = lblPermissions;
            this._form = form;
            this._userUI = userUI;
            this._btnDeleteUser = btnDeleteUser;
            this._userClient = enUserClient.User;
        }

        private void SetErrorOnTextBox(TextBox textBox, string message = "This field should not be empty")
        {
            PresentationInputValidator.SetMessageError(textBox, message, _errorProvider1);
        }

        public void ShowMessage(string text)
        {
            MessageBox.Show(text, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void HideButton()
        {
            switch (Action)
            {
                case enAction.UpdateShowInfo:
                    ControlHelper.HideControl(_btnUpdateClient);
                    break;

                case enAction.DeleteShowInfo:
                case enAction.Delete:
                    if(_userClient == enUserClient.Client)
                        ControlHelper.HideControl(_btnDeleteClient);

                    else
                        ControlHelper.HideControl(_btnDeleteUser);

                    break;

                case enAction.DepositShowInfo:
                case enAction.Deposit:
                case enAction.WithdrawShowInfo:
                case enAction.Withdraw:
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

        private bool IsObjectNotFound(object obj)
        {
            string word = _userClient == enUserClient.Client ? "Account Number" : "Username";

            string message = $"Sorry, This {word} Information Does Not Exist";

            if (PresentationInputValidator.IsObjectNull(obj))
            {
                HidePanelOrGroup();

                HideButton();

                if (Action == enAction.DepositShowInfo || Action == enAction.WithdrawShowInfo)
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
            Client = Clients.FindByAccountNumber(accountNumber);

            return !IsObjectNotFound(Client);
        }

        private bool LoadUserInfo(string username)
        {
            User = Users.FindByUsername(username);

            return !IsObjectNotFound(User);
        }

        private bool LoadPersonInfo()
        {
            if(_userClient == enUserClient.Client)
            {
                Person = Persons.Find(Client.PersonID);
                PersonID = Client.PersonID;
                return !IsObjectNotFound(Person);
            }

            else
            {
                Person = Persons.Find(User.PersonID);
                PersonID = User.PersonID;
                return !IsObjectNotFound(Person);
            }     
        }

        public bool LoadPhoneInfo()
        {
            if (_userClient == enUserClient.Client)
            {
                Phone = Phones.FindByClientID(Client.ClientID);
                return !IsObjectNotFound(Phone);
            }

            else
            {
                Phone = Phones.FindByUserID(User.UserID);
                return !IsObjectNotFound(Phone);
            }
        }

        //public bool LoadPhoneInfoByFindByList()
        //{
        //    Phone = Phones.FindInList(Client.ClientID);
            
        //    return !IsObjectNotFound(Phone);
        //}


        private bool AreClientObjectsInfoSuccessfullyLoaded(string accountNumber)
        {
            return LoadClientInfo(accountNumber) && LoadPersonInfo() && LoadPhoneInfo();
        }

        private bool AreUserObjectsInfoSuccessfullyLoaded(string username)
        {
            return LoadUserInfo(username) && LoadPersonInfo() && LoadPhoneInfo();
        }

        private void SetEmailLabel(Label label)
        {
            if (Person.Email != "")
                label.Text = Person.Email;

            else
                label.Text = "Unknown";
        }

        private void SetAccountNumberLabel(string accountNumber)
        {
            if (Action == enAction.DeleteShowInfo || Action == enAction.Find ||
                Action == enAction.WithdrawShowInfo || Action == enAction.DepositShowInfo)
            {
                _lblAccountNumber.Text = accountNumber;
            }
        }

        private void SetUsernameLabel(string username)
        {
            if (Action == enAction.DeleteShowInfo || Action == enAction.Find)
            {
                _lblUsername.Text = username;
            }
        }

        private void SetLabelsInfo(string value)
        {
            switch (Action)
            {
                case enAction.TransferShowInfoTo:
                    FillClientCardInLabelsTo();
                    break;

                default:

                    if (_userClient == enUserClient.Client)
                        FillClientCard(value);

                    else
                        FillUserCard(value);

                    break;
            }
        }

        private void FillClientCard(string accountNumber)
        {
            _lblFirstName.Text = Person.FirstName;

            _lblLastName.Text = Person.LastName;

            _lblBalance.Text = Client.Balance.ToString();

            _lblPinCode.Text = Client.PinCode.ToString();

            _lblPhone.Text = Phone.PhoneNumber;

            SetEmailLabel(_lblEmail);

            SetAccountNumberLabel(accountNumber);
        }

        private void FillUserCard(string username)
        {
            _lblUsername.Text = User.Username;

            _lblFullName.Text = Person.FirstName + " " + Person.LastName;

            _lblPassword.Text = User.Password;

            _lblPermissions.Text = User.Permissions.ToString();

            _lblPhone.Text = Phone.PhoneNumber;

            SetEmailLabel(_lblEmail);

            SetUsernameLabel(username);
        }

        private void FillClientCardInLabelsTo()
        {
            _lblFirstNameTo.Text = Person.FirstName;

            _lblLastNameTo.Text = Person.LastName;

            _lblBalanceTo.Text = Client.Balance.ToString();

            _lblPinCodeTo.Text = Client.PinCode.ToString();

            _lblPhoneTo.Text = Phone.PhoneNumber;

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
            _txtFirstName.Text = Person.FirstName;

            _txtLastName.Text = Person.LastName;

            _txtBalance.Text = Client.Balance.ToString();

            _txtPinCode.Text = Client.PinCode.ToString();

            _txtEmail.Text = Person.Email;
        }

        private void ShowTransactionDetails()
        {
            ShowTransactionAmountText(_txtTransactionAmount);
            ShowTransactionAmountLabel(_lblTransactionAmount);
        }

        private void ShowDefaultValues()
        {
            if (Action == enAction.UpdateShowInfo)
            {
                FillDefaultValuesForUpdate();
            }
        }

        private bool CanEnableTransactionButton()
        {
            return (Action == enAction.TransferShowInfoFrom || Action == enAction.TransferShowInfoTo) && AreGroupBoxesVisible();
        }
        private void ShowClientInfo()
        {
            string accountNumber = _txtAccountNumber.Text;

            if (!AreClientObjectsInfoSuccessfullyLoaded(accountNumber))
                return;

            HandleShowClientUserInfo(accountNumber);
        }

        private void ShowUserInfo()
        {
            string username = _txtUsername.Text;

            if (!AreUserObjectsInfoSuccessfullyLoaded(username))
                return;

            HandleShowClientUserInfo(username);
        }

        private void HandleShowClientUserInfo(string value)
        {
            SetLabelsInfo(value);

            ShowButton();

            HandleClientActionForShowInfo();

            if(_userClient == enUserClient.Client)
                HandleTransactionButton();
        }

        private void HandleClientActionForShowInfo()
        {
            switch (Action)
            {
                case enAction.DepositShowInfo:
                case enAction.WithdrawShowInfo:
                    ShowTransactionDetails();
                    break;

                case enAction.UpdateShowInfo:
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

        private bool IsInputFieldsNotNull(Guna2Panel panel)
        {
            bool isNotNull = true;
            string message = "This field should not be empty";

            //all controls null validation
            foreach (System.Windows.Forms.Control control in panel.Controls)
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

            //Phone control null validation
            if(Action != enAction.Update)
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

        private bool IsInputFieldsValid(Guna2Panel panel)
        {
            bool isValid = true;
            string message = "You must enter a valid value";

            foreach (System.Windows.Forms.Control control in panel.Controls)
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

        private void ClearTextBoxes(Guna2Panel panel)
        {
            foreach (System.Windows.Forms.Control control in panel.Controls)
            {
                if (control is TextBox textBox)
                {
                    ControlHelper.ClearTextBox(textBox);
                }
            }

            if (Action == enAction.Update)
                ClearTextBox(_txtAccountNumber);
        }

        public void ClearTextBox(TextBox textBox)
        {
            if(_userClient == enUserClient.Client)
                SetTextAccountNumber();

            ControlHelper.ClearTextBox(textBox);
        }


       
        public void ClearForm(Guna2Panel panel)
        {
            ClearTextBoxes(panel);

            if( Action != enAction.Update)
            {
                ClearComboBoxPhones();
            }  
        }

        public bool IsUsernameDuplicated(string username)
        {
            return PresentationInputValidator.IsUsernameDuplicated(username);
        }

        public bool IsAccountNumberDuplicated(string accountNumber)
        {
            return PresentationInputValidator.IsAccountNumberDuplicated(accountNumber);
        }

        public bool IsPhoneNumberValueDuplicated(string phoneNumber)
        {
            return PresentationInputValidator.IsPhoneNumberValueDuplicated(phoneNumber);
        }

        public bool ValidateInputFields(Guna2Panel panel)
        {
            return IsInputFieldsNotNull(panel) && IsInputFieldsValid(panel);
        }
        
        private string GetAccountNumberOrUsername(TextBox textbox)
        {
            string text = textbox.Text;

            return text;
        }

        private bool IsUpdateAndValid()
        {
            if (Action == enAction.Update)
                return (ValidateInputFields(_pnlClientInfo) && ((frmUpdateClient)_form).ValidatePhoneNumbers());

            return true;
        }

        private bool ShowConfirmMessage(string confirmMessage)
        {
            return (MessageBox.Show(confirmMessage, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }


        private void ExecuteClientOperations()
        {
            switch (Action)
            {
                case enAction.Update:
                    ((frmUpdateClient)_form).UpdateClient();

                    break;

                case enAction.Delete:
                    ((frmDeleteClient)_form).DeleteClient(GetAccountNumberOrUsername(_txtAccountNumber), Client);
                    break;

                case enAction.Deposit:
                    ConfirmDeposit();
                    break;

                case enAction.Withdraw:
                    ConfirmWithdraw();
                    break;

                case enAction.Transfer:
                    ConfirmTransfer();
                    break;
            }
        }

        private void ExecuteUserOperations()
        {
            switch (Action)
            {
                case enAction.Delete:
                    ((frmDeleteUser)_form).DeleteUser(GetAccountNumberOrUsername(_txtUsername), User);
                    break;

            }
        }

        private void FillTransferLogObject()
        {
            TransferLog.Date = DateTime.Now;
            TransferLog.SourceClientID = SourceClientID;
            TransferLog.DestinationClientID = DestinationClientID;
            TransferLog.Amount = Convert.ToDecimal(_txtTransactionAmount.Text);
            TransferLog.SourceBalance = Convert.ToDecimal(_lblBalance.Text);
            TransferLog.DestinationBalance = Convert.ToDecimal(_lblBalanceTo.Text);
            TransferLog.UserID = UserID;
        }
        private bool AddTransferLog()
        {
            FillTransferLogObject();

            return TransferLog.AddTransferLog();
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
                if(_userClient == enUserClient.Client)
                    ExecuteClientOperations();

                else
                    ExecuteUserOperations();
            }
        }

        private bool ConfirmTransferOperation()
        {
            string accTo = GetAccountNumberOrUsername(_txtAccNumTo), accFrom = GetAccountNumberOrUsername(_txtAccNumFrom);

            if (AreClientObjectsInfoSuccessfullyLoaded(accFrom))
            {
                SourceClientID = Client.ClientID;

                if(AreClientObjectsInfoSuccessfullyLoaded(accTo))
                {
                    DestinationClientID = Client.ClientID;
                }
                
                return true;
            }

            return false;
        }

        private bool CanConfirmMessage()
        {
            return (Action == enAction.Transfer && ConfirmTransferOperation())
                   ||
                   AreClientObjectsInfoSuccessfullyLoaded(GetAccountNumberOrUsername(_txtAccountNumber));
        }
       
        private void ConfirmOperation(string confirmMessage)
        {
            if (_userClient == enUserClient.Client && CanConfirmMessage())
            {
                Confirm(confirmMessage);
            }

            else if(_userClient == enUserClient.User && AreUserObjectsInfoSuccessfullyLoaded(GetAccountNumberOrUsername(_txtUsername)))
            {
                Confirm(confirmMessage);
            }

            else
            {
                ShowMessage("Failed to load data");
            }
        }

        private void ExecuteClientUserAction()
        {
            switch (Action)
            {
                case enAction.Update:
                    ConfirmOperation("Are you sure to do that update?");
                    break;

                case enAction.Delete:
                    ConfirmOperation("Are you sure to do that delete?");
                    break;

                case enAction.Deposit:
                    ConfirmOperation("Are you sure to do that deposit?");
                    break;

                case enAction.Withdraw:
                    ConfirmOperation("Are you sure to do that withdraw?");
                    break;

                case enAction.Transfer:
                    ConfirmOperation("Are you sure to do that transfer?");
                    break;

                default:
                    if(_userClient == enUserClient.Client)
                        ShowClientInfo();

                    else
                        ShowUserInfo();

                    break;
            }
        }

        private void ShowButton()
        {
            switch (Action)
            {
                case enAction.UpdateShowInfo:
                    ControlHelper.VisibleControl(_btnUpdateClient);
                    break;

                case enAction.DeleteShowInfo:
                    if(_userClient == enUserClient.Client)
                        ControlHelper.VisibleControl(_btnDeleteClient);

                    else
                        ControlHelper.VisibleControl(_btnDeleteUser);

                    break;

                case enAction.DepositShowInfo:
                case enAction.WithdrawShowInfo:
                    ControlHelper.VisibleControl(_btnTransaction);
                    break;
            }
        }

        private void ShowPanelOrGroup()
        {
            switch (Action)
            {
                case enAction.UpdateShowInfo:
                    ControlHelper.VisibleControl(_pnlClientInfo);
                    ControlHelper.VisibleControl(_gbClientCard);
                    break;

                case enAction.TransferShowInfoTo:
                    ControlHelper.VisibleControl(_gbClientCard2);
                    break;

                default:
                    if(_userClient == enUserClient.Client)
                        ControlHelper.VisibleControl(_gbClientCard);

                    else
                        ControlHelper.VisibleControl(_gbUserCard);

                    break;
            }
        }



        public void HidePanelOrGroup()
        {
            switch (Action)
            {
                case enAction.Update:
                case enAction.UpdateShowInfo:
                    ControlHelper.HideControl(_pnlClientInfo);
                    ControlHelper.HideControl(_gbClientCard);
                    break;

                case enAction.TransferShowInfoTo:
                    ControlHelper.HideControl(_gbClientCard2);
                    break;

                case enAction.Transfer:
                    ControlHelper.HideControl(_gbClientCard);
                    ControlHelper.HideControl(_gbClientCard2);
                    break;

                default:
                    if(_userClient == enUserClient.Client)
                        ControlHelper.HideControl(_gbClientCard);

                    else
                        ControlHelper.HideControl(_gbUserCard);

                    break;
            }
        }

        public void SetTextAccountNumber()
        {
            switch (Action)
            {
                case enAction.TransferShowInfoTo:
                    _txtAccountNumber = _txtAccNumTo;
                    break;

                case enAction.TransferShowInfoFrom:
                    _txtAccountNumber = _txtAccNumFrom;
                    break;

                case enAction.Transfer:
                    _txtAccountNumber = _txtTransactionAmount;
                    break;
            }
        }

        private bool EnsureDifferentAccounts()
        {
            if (Action == enAction.TransferShowInfoFrom || Action == enAction.TransferShowInfoTo)
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

            SetErrorOnTextBox(_txtAccountNumber, "");

            ExecuteClientUserAction();
        }

        private void PerformUserActionWorkflow()
        {
            ShowPanelOrGroup();

            SetErrorOnTextBox(_txtUsername, "");

            ExecuteClientUserAction();
        }

        public void HandleClientInfo()
        {
            SetTextAccountNumber();

            if (!PresentationInputValidator.IsControlTextNull(_txtAccountNumber.Text))
                PerformClientActionWorkflow();

            else
                SetErrorOnTextBox(_txtAccountNumber);
        }

        public void HandleUserInfo()
        {
            if (!PresentationInputValidator.IsControlTextNull(_txtUsername.Text))
                PerformUserActionWorkflow();

            else
                SetErrorOnTextBox(_txtUsername);
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
            Person.FirstName = _txtFirstName.Text;

            Person.LastName = _txtLastName.Text;

            Person.Email = string.IsNullOrWhiteSpace(_txtEmail.Text) ? "Unknown" : _txtEmail.Text;
        }

        private void FillClientData()
        {
            Client.PinCode = _txtPinCode.Text;

            Client.Balance = Convert.ToDecimal(_txtBalance.Text);

            if (!(Action == enAction.Update))
                Client.AccountNumber = _txtAccountNumber.Text;
        }

        private void FillUserData(short permission)
        {
            User.Username = _txtUsername.Text;
            User.Password = _txtPassword.Text;
            //User.Permissions = Permission;
            User.Permissions = permission;
        }

        public void FillClientInfo()
        {
            FillPersonData();

            FillClientData();
        }

        public void FillUserInfo(short permission)
        {
            FillPersonData();

            FillUserData(permission);
        }

        public bool CheckAccessRights(Users.enPermissions permission)
        {
            User.Permissions = Permission;

            if (!User.CheckAccessPermission(permission))
            {
                ShowMessage("Access Denied! Contact Your Admin");
                return false;
            }

            return true;
        }

        private void SetTypeWord()
        {
            switch (Action)
            {
                case enAction.Update:
                    Person.PersonID = PersonID;
                    _typeWord = enOperationType.Update;
                    break;

                case enAction.Deposit:
                    _typeWord = enOperationType.Deposit;
                    break;

                case enAction.Withdraw:
                    _typeWord = enOperationType.Withdraw;
                    break;

                case enAction.Transfer:
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

            if (Person.Save())
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

            Phone.Mode = Phones.enMode.AddNew;

            if (Phone.Save())
            {
                ResetPhoneObject(Phone);
            }
        }

        public void ProcessPhoneItem(string phoneItem, short index)
        {
            FillPhoneListObject();

            if(PhoneList[index].Save(phoneItem))
            {
                ResetPhoneObject(PhoneList[index]);
            }

            //foreach (Phones phone in PhoneList)
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

            //Phone = new Phones();
        }

        private void FillPhoneListObjectForAdd(string item)
        {
            Phone.PhoneNumber = item;

            Phone.PersonID = PersonID;
        }

        private void FillPhoneListObject()
        {
            ClientID = Clients.FindByAccountNumber(_txtAccountNumber.Text).ClientID;

            PhoneList = Phones.FindInList(ClientID);


            //List<int> lstPhoneIDs = Phones.GetPhoneIDs(ClientID);

            //Phone.PhoneNumber = item;

            //Phone.PhoneID = PhoneID;

            //Phone.PhoneID = PersonID;
        }

        private void SetPersonIDToClientUserObject()
        {
            string firstName = _txtFirstName.Text, lastName = _txtLastName.Text;

            PersonID = Persons.Find(firstName, lastName).PersonID;


            if(_userClient == enUserClient.Client)
                Client.PersonID = PersonID;

            else
                User.PersonID = PersonID;

        }


        private void SetStatusWord()
        {
            switch (Action)
            {
                case enAction.Update:
                    _statusWord = enOperationStatus.Updated;
                    break;

                case enAction.Deposit:
                    _statusWord = enOperationStatus.Deposit;
                    break;

                case enAction.Withdraw:
                    _statusWord = enOperationStatus.Withdraw;
                    break;

                case enAction.Transfer:
                    _statusWord = enOperationStatus.Transfer;
                    break;

                default:
                    SetPersonIDToClientUserObject();
                    _statusWord = enOperationStatus.Added;
                    break;
            }
        }

        private void ShowSaveMessage()
        {
            switch (_userClient)
            {
                case enUserClient.Client:
                    if(Client.Save())
                    {
                        ShowSuccessfulMessage();
                    }
                    break;

                default:
                    if (User.Save())
                    {
                        ShowSuccessfulMessage();
                    }
                    break;           
            }
        }

        private void ValidationClientsAndPhonesSave()
        {
            SetStatusWord();

            if(Action == enAction.Update)
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

            if (!PresentationInputValidator.ValidationValue(amount, _maxAmount, _minAmount))
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

            ClearTextBox(_txtAccNumTo);

            ClearTextBox(_txtAccNumFrom);

            SetErrorOnTextBox(_txtAccountNumber);
        }
        private void HandleTransactionUI()
        {
            SetStatusWord();

            ShowSuccessfulMessage();

            ClearTextBox(_txtAccountNumber);

            ClearTextBox(_txtTransactionAmount);

            HidePanelOrGroup();

            HideButton();

            if (Action == enAction.Transfer)
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
            
            ExecuteClientUserAction();
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

            return Client.WithdrawAmount(withdrawAmount, _txtAccountNumber.Text);
        }

        private bool IsTransferSuccessful()
        {
            decimal transferAmount = Convert.ToDecimal(_txtTransactionAmount.Text);
            string accountNumberFrom = _txtAccNumFrom.Text;
            string accountNumberTo = _txtAccNumTo.Text;

            if (!ValidateTransaction(transferAmount))
                return false;

            return Client.TransferAmount(accountNumberFrom, accountNumberTo, transferAmount);
        }
    }
}
