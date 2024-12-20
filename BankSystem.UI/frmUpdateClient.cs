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

        //public frmUpdateClient(ClientUIHelper clientUI)
        //{
        //    InitializeComponent();

        //    this._clientUI = clientUI;
        //}

        public ClientUIHelper _clientUI;

        short _textboxX = 100;
        short _textboxY = 120;

        short _labelX = 3;
        short _labelY = 120;

        byte order = 0;

        //int _personID = -1;


        private void InitializeAllObjects()
        {
            Clients client = new Clients();
            Persons person = new Persons();
            Phones phone = new Phones();

            InitializeClientUIObject(client, person, phone);
        }



        private void InitializeClientUIObject(Clients client, Persons person, Phones phone)
        {
            _clientUI = new ClientUIHelper(errorProvider1, gbClientCard, txtAccountNumber, txtEmail, txtPhone, txtBalance, txtPinCode, txtFirstName,
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

        private byte GetCount()
        {
            return Phones.GetCountOfPhonesNumbers(_clientUI._personID);
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
            text.Font = new Font("Cambria", 12, FontStyle.Regular);

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

            this.Controls.Remove(textBox);
            this.Controls.Remove(clickedButton);

            _textboxX = 100;
            _textboxY = 120;
        }

        private void ConfigureButton(TextBox text)
        {
            Guna2Button btnDeletePhone = new Guna2Button();

            btnDeletePhone.Text = "Delete ?";
            btnDeletePhone.Location = new Point(500, _textboxY);
            btnDeletePhone.Size = new Size(97, 40);
            btnDeletePhone.ForeColor = Color.FromArgb(192, 192, 255);
            btnDeletePhone.FillColor = Color.FromArgb(0, 0, 64);
            btnDeletePhone.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnDeletePhone.Click += new EventHandler(btnDeletePhone_Click);
            btnDeletePhone.Tag = text;

            gbAllPhones.Controls.Add(text);
        }

        private void CreatePhoneNumberTextBox()
        {
            TextBox textBox = new TextBox();

            ConfigureTextBox(textBox, "");

            _textboxY += 50;

            this.Refresh();
        }

        private void CreatePhoneLabel()
        {
            Label label = new Label();

            ConfigureLabel(label, ++order);

            _labelY += 50;

            this.Refresh();
        }

        private void CreateTextBoxes()
        {
            byte count = GetCount();

            for(byte i = 0; i < count; i++)
            {
                CreatePhoneNumberTextBox();

                CreatePhoneLabel();
            }
        }

        private void ConfigureLabel(Label text, byte order)
        {
            text.Text = $"Phone {order}:";
            text.Location = new Point(_labelX, _labelY);
            text.Size = new Size(291, 32);
            text.ForeColor = Color.Black;
            text.BackColor = Color.White;
            text.Font = new Font("Trebuchet MS", 12, FontStyle.Bold);

            gbAllPhones.Controls.Add(text);
        }

        private void ShowPhonesNumbers()
        {
            ControlHelper.VisibleControl(gbAllPhones);
        }
        
        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            HandleClientAction(enClientAction.UpdateShowInfo);
            ShowPhonesNumbers();
            CreateTextBoxes();

        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            HandleClientAction(enClientAction.Update);
        }

        private void UpdatePhone()
        {
            _clientUI.AddPhone();
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            UpdatePhone();
        }

        private void frmUpdateClient_Load(object sender, EventArgs e)
        {

        }
    }
}
