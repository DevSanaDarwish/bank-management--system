using BankSystemBusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Web.UI;
using System.Windows.Forms;
using static BankSystem.UIHelper;
using static System.Net.Mime.MediaTypeNames;

namespace BankSystem
{
    public partial class frmUpdateClient : Form
    {
        public frmUpdateClient()
        {
            InitializeComponent();
        }



        //public frmUpdateClient(Clients client, Persons person, Phones phone, int personID, TextBox txtEmail, TextBox txtBalance, TextBox txtPinCode, TextBox txtFirstName, TextBox txtLastName, ClientUIHelper clientUI)
        //{
        //    InitializeComponent();

        //    this.Client = client;
        //    this.Person = person;
        //    this.Phone = phone;
        //    this._personID = personID;
        //    this._txtEmail = txtEmail;
        //    this._txtBalance = txtBalance;
        //    this._txtPinCode = txtPinCode;
        //    this._txtFirstName = txtFirstName;
        //    this._txtLastName = txtLastName;
        //    this._clientUI = clientUI;
        //}

        public frmUpdateClient(UIHelper clientUI)
        {
            InitializeComponent();

            this._clientUI = clientUI;
        }

        public UIHelper _clientUI;

        const short _initialTextboxX = 10, _initialTextboxY = 120;

        short _textboxX = _initialTextboxX, _textboxY = _initialTextboxY;

        byte _numberOfOriginalPhones = 0, _numberOfUpdatedPhones = 0;

        List<string> _originalPhoneNumbers = new List<string>();

        private void InitializeAllObjects()
        {
            Clients client = new Clients();
            Persons person = new Persons();
            Phones phone = new Phones();

            InitializeClientUIObject(client, person, phone);
        }

        private void InitializeClientUIObject(Clients client, Persons person, Phones phone)
        {
            _clientUI = new UIHelper(errorProvider1, gbClientCard, txtAccountNumber, txtEmail/*, gbAllPhones*/, txtBalance, txtPinCode, txtFirstName,
              txtLastName, pnlClientInfo, true, lblFirstName, lblLastName, lblBalance, lblPinCode, lblPhone, lblEmail, client, person,
              phone, btnUpdateClient, -1, _clientUI, this);
        }

        private void SetClientAction(enAction clientAction)
        {
            _clientUI.Action = clientAction;
        }

        private void Update()
        {
            enAction clientAction = enAction.Update;
            SetClientAction(clientAction);

            _clientUI.FillClientInfo();

            _clientUI.ValidationSave();
        }

        public void UpdateClient()
        {
            Update();

            _clientUI.ClearForm(pnlClientInfo);

            _clientUI.HidePanelOrGroup();
        }

        private void HandleClientAction(enAction clientAction)
        {
            InitializeAllObjects();

            SetClientAction(clientAction);

            _clientUI.HandleClientInfo();
        }
        
        private byte GetCountOfPhonesNumbers()
        {
            return Convert.ToByte(lblPhone.Text.Split(',').Length);
        }

        private byte GetCountOfPhonesNumbersByDatabase()
        {
            return Phones.GetCountOfPhonesNumbers(_clientUI._personID);
        }

        private string[] GetPhonesNumbers()
        {
            return lblPhone.Text.Split(',');
        }

        private List<string> GetPhonesNumbersByDatabase()
        {
            List<string> lstPhones = new List<string>();

            if (_clientUI.LoadPhoneInfo())
            {
                List<Phones> phonesList = Phones.FindInList(_clientUI.Client.clientID);

                foreach (Phones phone in phonesList)
                {
                    lstPhones.Add(phone.phoneNumber);
                }
            }

            return lstPhones;
        }

        private void ConfigureTextBox(TextBox text, string phoneNumber)
        {
            text.Text = phoneNumber;
            text.Multiline = true;
            text.Location = new Point(_textboxX, _textboxY);
            text.Size = new Size(291, 32);
            text.ForeColor = Color.Black;
            text.BackColor = Color.White;
            text.BorderStyle = BorderStyle.FixedSingle;
            text.Font = new Font("Cambria", 12, FontStyle.Bold);

            gbAllPhones.Controls.Add(text);
        }

        private void btnDeletePhone_Click(object sender, EventArgs e)
        {
            DeletePhoneTextBox(sender);
        }

        private bool IsPhoneDeleted(string phoneNumber)
        {
            return Phones.DeletePhoneByPhoneNumber(phoneNumber);
        }

        private bool IsPhoneExist(string phoneNumber)
        {
            return Phones.IsPhoneExistByPhoneNumber(phoneNumber);
        }

        private void CheckAndNotifyIfPhoneDeleted(string phoneNumber)
        {
            if (!IsPhoneExist(phoneNumber))
                return;

            if (IsPhoneDeleted(phoneNumber))
            {
                _clientUI.ShowMessage("This number has been deleted");
            }
        }

        private void ResetTextBoxPosition()
        {
            _textboxX = _initialTextboxX;
            _textboxY = _initialTextboxY;
        }

        private void RemovePhoneControls(TextBox textBox, Guna2Button button)
        {
            ControlHelper.RemoveControl(textBox);
            ControlHelper.RemoveControl(button);
        }

        private void DeletePhoneTextBox(object sender)
        {
            Guna2Button clickedButton = sender as Guna2Button;
            TextBox textBox = clickedButton.Tag as TextBox;
            string phoneNumber = textBox.Text;

            RemovePhoneControls(textBox, clickedButton);

            ResetTextBoxPosition();

            CheckAndNotifyIfPhoneDeleted(phoneNumber);
        }

        private void ConfigureButton(Guna2Button btnDeletePhone, TextBox text)
        {
            btnDeletePhone.Text = "Delete ?";
            btnDeletePhone.Location = new Point(404, _textboxY);
            btnDeletePhone.Size = new Size(93, 32);
            btnDeletePhone.ForeColor = Color.White;
            btnDeletePhone.FillColor = Color.DarkSeaGreen;
            btnDeletePhone.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnDeletePhone.Click += new EventHandler(btnDeletePhone_Click);
            btnDeletePhone.Tag = text;

            gbAllPhones.Controls.Add(btnDeletePhone);
        }

        private void CreatePhoneNumberTextBoxAndDeleteButton(string phoneNumber)
        {
            TextBox textBox = new TextBox();

            Guna2Button btnDeletePhone = new Guna2Button();

            ConfigureTextBox(textBox, phoneNumber);

            ConfigureButton(btnDeletePhone, textBox);

            _textboxY += 50;

            this.Refresh();
        } 

        private byte GetNumberOfPhones()
        {
            byte count = 0;

            foreach (Control control in gbAllPhones.Controls)
            {
                if (control is TextBox textbox)
                {
                    count++;
                }
            }

            return count;
        }
        
       
        private void HandleAllPhones()
        {
            short index = 0;

            foreach (Control control in gbAllPhones.Controls)
            {
                if (control is TextBox textbox)
                {
                    string item = textbox.Text;

                    if(index < _numberOfOriginalPhones)
                        _clientUI.ProcessPhoneItem(item, index);

                    else
                        _clientUI.ProcessPhoneItemForAdd(item);

                    index++;
                }

            }
        }

        public void UpdatePhones()
        {
            HandleAllPhones();       
        }  

        public void CreateTextBoxes()
        {
            List<string> phones = GetPhonesNumbersByDatabase();

            byte count = GetCountOfPhonesNumbers();

            for(byte i = 0; i < count; i++)
            {
                CreatePhoneNumberTextBoxAndDeleteButton(phones[i]);
            }
        }

        private void ShowAddPhoneButton()
        {
            ControlHelper.VisibleControl(btnAddNewPhone);
        }

        public void ShowAllPhones()
        {
            ShowPhonesNumbers();

            ClearPhonesGroupBox();

            ShowAddPhoneButton();

            CreateTextBoxes();
        }

        public void ShowPhonesNumbers()
        {
            ControlHelper.VisibleControl(gbAllPhones);
        }

        public void ClearPhonesGroupBox()
        {
            for (int i = gbAllPhones.Controls.Count - 1; i >= 0; i--)
            {
                Control control = gbAllPhones.Controls[i];

                if (control == btnAddNewPhone)
                    continue;

                if (control is TextBox || control is Guna2Button)
                {
                    ControlHelper.RemoveControl(control);
                }
            }

            ResetTextBoxPosition();
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            HandleClientAction(enAction.UpdateShowInfo);

            _numberOfOriginalPhones = GetNumberOfPhones();

            _originalPhoneNumbers = GetPhonesNumbersByDatabase();
        }

        private bool IsUpdatedOrNewPhone(TextBox textBox)
        {
            for(byte i = 0; i <_originalPhoneNumbers.Count; i++)
            {
                if (textBox.Text == _originalPhoneNumbers[i])
                    return false;
            }               

            return true;
        }

        private bool IsNumberDuplicatedInHashSet(string phoneNumber, HashSet<string> seenNumbers)
        {
            return seenNumbers.Contains(phoneNumber);
        }

        private void AddNumberToHashSet(string phoneNumber, HashSet<string> seenNumbers)
        {
            seenNumbers.Add(phoneNumber);
        }

        private bool IsNumberDuplicatedInDatabase(string phoneNumber, TextBox textBox)
        {
            return IsUpdatedOrNewPhone(textBox) && PresentationInputValidator.IsPhoneNumberValueDuplicated(phoneNumber);
        }

        private void MarkDuplicated(TextBox textBox, ref bool isDuplicated)
        {
            string duplicatedValueMessage = "This number already exists";

            MarkControlAsInvalid(textBox, duplicatedValueMessage);

            isDuplicated = true;
        }

        private bool CheckPhoneNumbersIfDuplicated()
        {
            bool isDuplicated = false;
            HashSet<string> seenNumbers = new HashSet<string>();

            foreach (Control control in gbAllPhones.Controls)
            {
                if (control is TextBox textBox)
                {
                    string phoneNumber = textBox.Text;

                    if(IsNumberDuplicatedInHashSet(phoneNumber, seenNumbers))
                    {
                        MarkDuplicated(textBox, ref isDuplicated);

                        continue;
                    }

                    AddNumberToHashSet(phoneNumber, seenNumbers);

                    if (IsNumberDuplicatedInDatabase(phoneNumber, textBox))
                    {
                        MarkDuplicated(textBox, ref isDuplicated);
                    }
                }
            }
            
            return isDuplicated;
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            _numberOfUpdatedPhones = GetNumberOfPhones();

            HandleClientAction(enAction.Update);
        }

        private void MarkControlAsInvalid(TextBox textBox, string message)
        {
            _clientUI.AllValidation(textBox, false, message);
        }

        private bool IsPhoneNumberNull(string phoneNumber, TextBox textBox)
        {
            string nullMessage = "This Field Should Not Be Empty";

            if (PresentationInputValidator.IsControlTextNull(phoneNumber))
            {
                MarkControlAsInvalid(textBox, nullMessage);
                return true;
            }

            return false;
        }

        private bool IsPhoneNumberValidFormat(string phoneNumber, TextBox textBox)
        {
            string numMessage = "This Field Should Be Numeric";

            if (!PresentationInputValidator.IsNumeric(phoneNumber))
            {
                MarkControlAsInvalid(textBox, numMessage);
                return false;
            }

            return true;
        }
        public bool ValidatePhoneNumbers()
        {
            bool isValid = true;

            foreach (Control control in gbAllPhones.Controls)
            {
                if(control is TextBox textBox)
                {
                    string phoneNumber = textBox.Text;

                    if (IsPhoneNumberNull(phoneNumber, textBox))
                        isValid = false;

                    if(!IsPhoneNumberValidFormat(phoneNumber, textBox))
                        isValid = false;
                }
            }

            if (CheckPhoneNumbersIfDuplicated())
                isValid = false;

            return isValid;
        }

        private void AddNewPhone()
        {
            CreatePhoneNumberTextBoxAndDeleteButton("");
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            AddNewPhone();
        }
    }
}
