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


        bool _isValidTextBoxes = true, _isNullTextBoxes = true;

        bool _isValid = true;

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
            if (IsInputFieldsNotNull())
            {
                if (IsInputFieldsValid())
                {
                    AddNewClient();
                }
            }           
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

            if(!IsPhoneNumberNull())
            {
                if(IsPhoneNumberValid())
                {
                    cbPhones.Items.Add(phoneNumber);
                }
            }
                

            //string phoneNumber = txtPhone.Text;
            //string messageValue = "This field should not be empty";

            //if (!NullValidation(txtPhone))
            //{
            //    cbPhones.Items.Add(phoneNumber);

            //    Set_isValid(txtPhone, "", true);
            //}

            //else
            //{
            //    Set_isValid(txtPhone, messageValue, false);
            //}
        }

        private void Set_isValid(TextBox textbox, string messageValue, bool validValue)
        {
            InputValidator.SetMessageError(textbox, messageValue, errorProvider1);

            _isValid = validValue;
        }

        private bool IsPhoneNumberNull()
        {
            byte itemsCount = Convert.ToByte(cbPhones.Items.Count);

            string messageValue = "Please Add One Phone Number At Least";

            if (itemsCount == 0)
            {
                Set_isValid(txtPhone, messageValue, false);
                return true;
            }

            else
            {
                Set_isValid(txtPhone, "", true);
                return false;
            }
        }

        private bool IsPhoneNumberValid()
        {
            string messageValue = "You must enter a valid value";

            AllValidation(txtPhone, NumericValidation(txtPhone), messageValue);

            if (_isValid == true)
                return true;

            return false;
        }


        private void AllValidation(TextBox textbox, bool typeValidation, string message)
        {
            if(typeValidation)
            {
                Set_isValid(textbox, "", true);
            }

            else
            {
                Set_isValid(textbox, message, false);
            }
        }
        
        private bool IsInputFieldsNotNull()
        {
            bool isNotNull = true;
            string message = "This field should not be empty";

            //all controls null validation
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                if (control is TextBox textbox)
                {
                    if (textbox == txtEmail || textbox == txtPhone)
                        continue;

                    AllValidation(textbox, !NullValidation(textbox), message);

                    if (!_isValid)
                          isNotNull = _isValid;
                }
            }

            //phone control null validation
            IsPhoneNumberNull();
            if (!_isValid)
                isNotNull = _isValid;

            return isNotNull;
        }

        private bool IsInputFieldsValid()
        {
            bool isValid = true;
            string message = "You must enter a valid value";

            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                if (control is TextBox textbox)
                {
                    if (textbox == txtBalance || textbox == txtPinCode)
                    {
                        AllValidation(textbox, NumericValidation(textbox), message);
                    }

                    if (textbox == txtFirstName || textbox == txtLastName)
                    {
                        AllValidation(textbox, StringValidation(textbox), message);
                    }


                    if (!_isValid)
                        isValid = _isValid;
                }
            }

            return isValid;
        }

       
        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            AddPhoneNumberToComboBox();

            ClearPhoneText();
        }
        

        private bool NullValidation(TextBox textbox)
        {
            return (InputValidator.IsControlTextNull(textbox.Text));
        }

        private bool NumericValidation(TextBox textbox)
        {
            return (InputValidator.IsNumeric(textbox.Text));
        }

        private bool StringValidation(TextBox textbox)
        {
            return (InputValidator.IsString(textbox.Text));
        }
        
        private void ResetTablesIdentity()
        {
            Clients.ResetClientIdentity();
            Persons.ResetPersonIdentity();
            Phones.ResetPhonesIdentity();
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
