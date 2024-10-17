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

        public frmAddNewClient()
        {
            InitializeComponent();
        }


        bool _isValidTextBoxes = false;

        int _personID = -1;

        Clients _client = new Clients();

        Persons _person = new Persons();

        Phones _phone = new Phones();

        private void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            InputFieldsValidation();

            if (_isValidTextBoxes)
                AddNewClient();
        }

        private void LoadData()
        {
            
        }

        private void FillPhoneObject(string item)
        {
            _phone.phoneNumber = item;
            _phone.personID = _personID;
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
        private void FillClientInfo()
        {
            _client.pinCode = txtPinCode.Text;

            _client.balance = Convert.ToDecimal(txtBalance.Text);

            _client.accountNumber = txtAccountNumber.Text;

            _person.firstName = txtFirstName.Text;

            _person.lastName = txtLastName.Text;

            _person.email = txtEmail.Text;

            //_phone.phoneNumber = txtPhone.Text;           
        }

        private void SetPersonIDToClientObject()
        {
            string firstName = txtFirstName.Text, lastName = txtLastName.Text;

            _personID = Persons.Find(firstName, lastName).personID;

            _client.personID = _personID;
        }

        private void ValidationClientsAndPhonesSave()
        {
            SetPersonIDToClientObject();

            ValidationPhoneNumbersSave();

            if (_client.Save())
            {
                ShowMessage("Successfully added");
            }
        }

        private void ValidationSave()
        {
            if (_person.Save())
                ValidationClientsAndPhonesSave();

            else
                ShowMessage("Failed to add");
        }

        private void AddNewClient()
        {
            FillClientInfo();

            ValidationSave();
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

        private void PhoneNumbersValidation()
        {
            byte itemsCount = Convert.ToByte(cbPhones.Items.Count);

            string messageValue = "Please Add One Phone Number At Least";

            if (itemsCount == 0)
            {
                SetError(txtPhone, messageValue, false);
            }
        }

        private void SetTextBoxError(TextBox textbox)
        {
            string messageValue = "This field should not be empty";

            if (IsControlTextNull(textbox))
            {
                SetError(textbox, messageValue, false);
            }

            else
            {
                SetError(textbox, "", true);
            }
        }
        private void InputFieldsValidation()
        {
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                if(control is TextBox textbox)
                {
                    if (textbox == txtEmail || textbox == txtPhone)
                        continue;

                    SetTextBoxError(textbox);
                }    
            }

            PhoneNumbersValidation();
        }  

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            AddPhoneNumberToComboBox();

            ClearPhoneText();
        }

        private void frmAddNewClient_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
