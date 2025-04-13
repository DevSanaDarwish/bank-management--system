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
using System.Windows.Forms;
using static BankSystem.ClientUIHelper;
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

        //    this._client = client;
        //    this._person = person;
        //    this._phone = phone;
        //    this._personID = personID;
        //    this._txtEmail = txtEmail;
        //    this._txtBalance = txtBalance;
        //    this._txtPinCode = txtPinCode;
        //    this._txtFirstName = txtFirstName;
        //    this._txtLastName = txtLastName;
        //    this._clientUI = clientUI;
        //}

        public frmUpdateClient(ClientUIHelper clientUI)
        {
            InitializeComponent();

            this._clientUI = clientUI;
        }

        public ClientUIHelper _clientUI;

        short _textboxX = 10, _textboxY = 120;

        byte _numberOfOriginalPhones = 0, _numberOfUpdatedPhones = 0;

        private void InitializeAllObjects()
        {
            Clients client = new Clients();
            Persons person = new Persons();
            Phones phone = new Phones();

            InitializeClientUIObject(client, person, phone);
        }

        private void InitializeClientUIObject(Clients client, Persons person, Phones phone)
        {
            _clientUI = new ClientUIHelper(errorProvider1, gbClientCard, txtAccountNumber, txtEmail/*, gbAllPhones*/, txtBalance, txtPinCode, txtFirstName,
              txtLastName, pnlClientInfo, true, lblFirstName, lblLastName, lblBalance, lblPinCode, lblPhone, lblEmail, client, person,
              phone, btnUpdateClient, -1, _clientUI, this);
        }

        private void SetClientAction(enClientAction clientAction)
        {
            _clientUI._clientAction = clientAction;
        }

        private void Update()
        {
            enClientAction clientAction = enClientAction.Update;
            SetClientAction(clientAction);

            _clientUI.FillClientInfo();

            _clientUI.ValidationSave();
        }

        public void UpdateClient()
        {
            Update();

            _clientUI.ClearForm();

            _clientUI.HidePanelOrGroup();
        }

        private void HandleClientAction(enClientAction clientAction)
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
                List<Phones> phonesList = Phones.FindInList(_clientUI._client.clientID);

                foreach (Phones phone in phonesList)
                {
                    lstPhones.Add(phone.phoneNumber);
                }
            }

            return lstPhones;

            //for(byte i = 0; i < lstPhones.Count; i++)
            //{
            //    if (_clientUI.LoadPhoneInfo())
            //    {
            //        lstPhones = Phones.FindInList(_clientUI._client.clientID).ToString();
            //    }
            //}
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
            DeletePhone(sender);
        }

        private void DeletePhone(object sender)
        {
            Guna2Button clickedButton = sender as Guna2Button;
            TextBox textBox = clickedButton.Tag as TextBox;

            gbAllPhones.Controls.Remove(textBox);
            gbAllPhones.Controls.Remove(clickedButton);

            _textboxX = 100;
            _textboxY = 120;
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

        private byte GetCountOfTextBoxes()
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
        
        private void UpdatePhonesEqualCount()
        {
            short index = 0;

            foreach (Control control in gbAllPhones.Controls)
            {
                if (control is TextBox textbox)
                {
                    string item = textbox.Text;

                    _clientUI.ProcessPhoneItem(item, index);

                    index++;
                }
            }
        }

        private void RemoveExtraPhoneNumbers()
        {

        }

        private void AddExtraPhoneNumbers()
        {
            short index = 0;

            UpdatePhonesEqualCount();

            foreach(Control control in gbAllPhones.Controls)
            {
                if(control is TextBox textbox)
                {
                    if(index >= _numberOfOriginalPhones)
                    {
                        string item = textbox.Text;

                        _clientUI.ProcessPhoneItemForAdd(item);
                    }

                    index++;
                }
            }
        }
        public void UpdatePhones()
        {
            if(_numberOfUpdatedPhones > _numberOfOriginalPhones)
            {
                AddExtraPhoneNumbers();
            }

            else if (_numberOfUpdatedPhones < _numberOfOriginalPhones)
            {
                RemoveExtraPhoneNumbers();
            }

            else
            {
                UpdatePhonesEqualCount();
            }       
        }  

        
       public void ResetXAndY()
        {
            _textboxX = 10;
            _textboxY = 120;
        }

        public void CreateTextBoxes()
        {
            byte count = GetCountOfPhonesNumbers();

            for(byte i = 0; i < count; i++)
            {
                CreatePhoneNumberTextBoxAndDeleteButton(GetPhonesNumbersByDatabase()[i]);
            }

            ResetXAndY();
        }

        private void ShowAddPhoneButton()
        {
            ControlHelper.VisibleControl(btnAddNewPhone);
        }

        public void ShowAllPhones()
        {
            ClearPhonesGroupBox();

            ShowPhonesNumbers();

            ShowAddPhoneButton();

            CreateTextBoxes();
        }

        public void ShowPhonesNumbers()
        {
            ControlHelper.VisibleControl(gbAllPhones);
        }

        public void ClearPhonesGroupBox()
        {
            foreach(Control control in gbAllPhones.Controls)
            {
                if (control == btnAddNewPhone)
                    continue;
                
                if(control is TextBox || control is Guna2Button)
                {
                    ControlHelper.RemoveControl(control);
                }
            }
        }


        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            _numberOfOriginalPhones = GetNumberOfPhones();

            HandleClientAction(enClientAction.UpdateShowInfo);
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            _numberOfUpdatedPhones = GetNumberOfPhones();

            HandleClientAction(enClientAction.Update);
        }

        public bool ValidatePhoneNumbers()
        {
            string nullMessage = "This Field Should Not Be Empty";
            string numMessage = "This Field Should Be Numeric";
            bool isValid = true;

            foreach (Control control in gbAllPhones.Controls)
            {
                if(control is TextBox textbox)
                {
                    if (PresentationInputValidator.IsControlTextNull(textbox.Text))
                    {
                        _clientUI.AllValidation(textbox, false, nullMessage);
                        isValid = false;
                    }

                    if(!PresentationInputValidator.IsNumeric(textbox.Text))
                    {
                        _clientUI.AllValidation(textbox, false, numMessage);
                        isValid = false;
                    }
                }
            }

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
