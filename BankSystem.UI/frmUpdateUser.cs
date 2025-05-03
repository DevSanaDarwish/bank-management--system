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
using static BankSystem.UIHelper;

namespace BankSystem
{
    public partial class frmUpdateUser : Form
    {
        public frmUpdateUser()
        {
            InitializeComponent();
        }

        public UIHelper UserUI;

        const short _initialTextboxX = 10, _initialTextboxY = 120;

        short _textboxX = _initialTextboxX, _textboxY = _initialTextboxY;

        byte _numberOfOriginalPhones = 0, _numberOfUpdatedPhones = 0;

        List<string> _originalPhoneNumbers = new List<string>();


        private void InitializeAllObjects()
        {
            Users user = new Users();
            Persons person = new Persons();
            Phones phone = new Phones();

            InitializeUserUIObject(user, person, phone);
        }

        private void InitializeUserUIObject(Users user, Persons person, Phones phone)
        {
            UserUI = new UIHelper(errorProvider1, gbUserCard, txtUsername, txtEmail, txtPassword, txtPermissions, txtFirstName,
              txtLastName, pnlUserInfo, true, lblFirstName, lblLastName, lblPhone, lblPermissions, lblPassword, lblEmail, user, person,
              phone, btnUpdateUser, -1, UserUI, this);
        }

        private void SetUserAction(enAction UserAction)
        {
            UserUI.Action = UserAction;
        }

        public void ShowPhonesNumbers()
        {
            ControlHelper.VisibleControl(gbAllPhones);
        }

        private void ShowAddPhoneButton()
        {
            ControlHelper.VisibleControl(btnAddNewPhone);
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

        private void ResetTextBoxPosition()
        {
            _textboxX = _initialTextboxX;
            _textboxY = _initialTextboxY;
        }

        private byte GetCountOfPhonesNumbers()
        {
            return Convert.ToByte(lblPhone.Text.Split(',').Length);
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

        private void ConfigureButton(Guna2Button btnDeletePhone, TextBox text)
        {
            btnDeletePhone.Text = "Delete ?";
            btnDeletePhone.Location = new Point(404, _textboxY);
            btnDeletePhone.Size = new Size(93, 32);
            btnDeletePhone.ForeColor = Color.White;
            btnDeletePhone.FillColor = Color.Coral;
            btnDeletePhone.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnDeletePhone.Click += new EventHandler(btnDeletePhone_Click);
            btnDeletePhone.Tag = text;

            gbAllPhones.Controls.Add(btnDeletePhone);
        }

        private void btnDeletePhone_Click(object sender, EventArgs e)
        {
            DeletePhoneTextBox(sender);
        }

        private void RemovePhoneControls(TextBox textBox, Guna2Button button)
        {
            ControlHelper.RemoveControl(textBox);
            ControlHelper.RemoveControl(button);
        }

        private bool IsPhoneExist(string phoneNumber)
        {
            return Phones.IsPhoneExistByPhoneNumber(phoneNumber);
        }

        private bool IsPhoneDeleted(string phoneNumber)
        {
            return Phones.DeletePhoneByPhoneNumber(phoneNumber);
        }

        private void CheckAndNotifyIfPhoneDeleted(string phoneNumber)
        {
            if (!IsPhoneExist(phoneNumber))
                return;

            if (IsPhoneDeleted(phoneNumber))
            {
                UserUI.ShowMessage("This number has been deleted");
            }
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


        private void CreatePhoneNumberTextBoxAndDeleteButton(string phoneNumber)
        {
            TextBox textBox = new TextBox();

            Guna2Button btnDeletePhone = new Guna2Button();

            ConfigureTextBox(textBox, phoneNumber);

            ConfigureButton(btnDeletePhone, textBox);

            _textboxY += 50;

            this.Refresh();
        }
        public void CreateTextBoxes()
        {
            List<string> phones = GetPhonesNumbersByDatabase();

            byte count = GetCountOfPhonesNumbers();

            for (byte i = 0; i < count; i++)
            {
                CreatePhoneNumberTextBoxAndDeleteButton(phones[i]);
            }
        }

        public void ShowAllPhones()
        {
            ShowPhonesNumbers();

            ClearPhonesGroupBox();

            ShowAddPhoneButton();

            CreateTextBoxes();

            _numberOfOriginalPhones = GetNumberOfPhones();

            _originalPhoneNumbers = GetPhonesNumbersByDatabase();
        }

        private void HandleUserAction(enAction UserAction)
        {
            InitializeAllObjects();

            SetUserAction(UserAction);

            UserUI.HandleUserInfo();
        }

        private void AddNewPhone()
        {
            CreatePhoneNumberTextBoxAndDeleteButton("");
        }

        private void btnAddNewPhone_Click(object sender, EventArgs e)
        {
            AddNewPhone();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            _numberOfUpdatedPhones = GetNumberOfPhones();

            HandleUserAction(enAction.Update);
        }

        public byte GetNumberOfPhones()
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

        public List<string> GetPhonesNumbersByDatabase()
        {
            List<string> lstPhones = new List<string>();

            if (UserUI.LoadPhoneInfo())
            {
                List<Phones> phonesList = Phones.FindInListByUserID(UserUI.User.UserID);

                foreach (Phones phone in phonesList)
                {
                    lstPhones.Add(phone.PhoneNumber);
                }
            }

            return lstPhones;
        }


        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            HandleUserAction(enAction.UpdateShowInfo);

            //_numberOfOriginalPhones = GetNumberOfPhones();

            //_originalPhoneNumbers = GetPhonesNumbersByDatabase();
        }
    }
}
