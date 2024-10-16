using BankSystemBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class frmAddNewClient : Form
    {
        //public frmAddNewClient(int clientID)
        //{
        //    InitializeComponent();

        //    _clientID = clientID;

        //    SetMode();
        //}

        public frmAddNewClient()
        {
            InitializeComponent();
        }


        public enum enMode { AddNew = 0, Update = 1};
        private enMode _mode;

        bool _isValidTextBoxes = false;

        int _clientID = -1;

        Clients _client;

        Persons _person;

        Phones _phone;

        private void SetMode()
        {
            if (_clientID == -1)
                _mode = enMode.AddNew;

            else
                _mode = enMode.Update;
        }
        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            InputFieldsValidation();

            if (_isValidTextBoxes)
                AddNewClient();
        }

        private void FillClientInfo()
        {
            int personID = Persons.Find(txtFirstName.Text).personID;

            string firstName = Persons.Find(txtFirstName.Text).firstName;

            string lastName = Persons.Find(txtFirstName.Text).lastName;

            string email = Persons.Find(txtFirstName.Text).email;

            string phoneNumber = Persons.Find(txtFirstName.Text).email;

            _client.pinCode = txtPinCode.Text;

            _client.balance = Convert.ToDecimal(txtBalance.Text);

            _client.accountNumber = txtAccountNumber.Text;

            _client.personID = personID;

            _person.personID = personID;

            _person.firstName = firstName;

            _person.lastName = lastName;

            _person.email = email;

            _phone.phoneNumber = phoneNumber;
        }

        private void ValidationSave()
        {
            if (_client.Save())
                MessageBox.Show("Successfully added");

            else
                MessageBox.Show("Failed to add");
        }
        private void AddNewClient()
        {
            FillClientInfo();

            ValidationSave();

            _mode = enMode.Update;
        }

        private void ClearPhoneText()
        {
            txtPhone.Clear();
        }

        private bool IsControlTextNull(TextBox control)
        {
            if (string.IsNullOrWhiteSpace(control.Text))
                return true;

            return false;
        }

        private void AddPhoneNumberToComboBox()
        {
            string phoneNumber = txtPhone.Text;
            string messageValue = "This field should not be empty";

            if (!IsControlTextNull(txtPhone))
            {
                cbPhones.Items.Add(phoneNumber);

                SetError(txtPhone, "");
            }

            else
            {
                SetError(txtPhone, messageValue);
            }
        }

        private void SetError(TextBox control, string messageValue, bool isValid = false)
        {
            errorProvider1.SetError(control, messageValue);

            _isValidTextBoxes = isValid;
        }

        private void InputFieldsValidation()
        {
            string messageValue = "This field should not be empty";
        
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                if(control is TextBox textbox)
                {
                    if (textbox == txtEmail)
                        continue;
                    
                    if (IsControlTextNull(textbox))
                    {
                        SetError(textbox, messageValue, false);
                    }

                    else
                    {
                        SetError(textbox, "", true);
                    }
                }    
            }
        }

       

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            AddPhoneNumberToComboBox();

            ClearPhoneText();
        }
    }
}
