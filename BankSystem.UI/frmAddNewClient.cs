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
        

        private void AddPhoneNumberToComboBox()
        {
            string phoneNumber = txtPhone.Text;
            string messageValue = "This field should not be empty";

            if (!InputValidator.IsControlTextNull(txtPhone.Text))
            {
                cbPhones.Items.Add(phoneNumber);

                InputValidator.SetError(txtPhone, "", errorProvider1, ref _isValidTextBoxes);
            }

            else
            {
                InputValidator.SetError(txtPhone, messageValue ,errorProvider1, ref _isValidTextBoxes);
            }
        }

        

        private void PhoneNumbersValidation()
        {
            byte itemsCount = Convert.ToByte(cbPhones.Items.Count);

            string messageValue = "Please Add One Phone Number At Least";

            if (itemsCount == 0)
            {
                InputValidator.SetError(txtPhone, messageValue, errorProvider1, ref _isValidTextBoxes, false);
            }
        }

        private void SetTextBoxError(TextBox textbox)
        {
            string messageValue = "This field should not be empty";

            if (InputValidator.IsControlTextNull(textbox.Text))
            {
                InputValidator.SetError(textbox, messageValue, errorProvider1, ref _isValidTextBoxes, false);
            }

            else
            {
                InputValidator.SetError(textbox, "",errorProvider1, ref _isValidTextBoxes, true);
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

        private void ResetTablesIdentity()
        {
            Clients.ResetClientIdentity();
            Persons.ResetPersonIdentity();
            Phones.ResetPersonIdentity();
        }

        private void frmAddNewClient_Load(object sender, EventArgs e)
        {
            try
            {
                ResetTablesIdentity();
            }

            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
            
        }
    }
}
