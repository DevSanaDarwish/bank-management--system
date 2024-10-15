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

        bool _isTextBoxesValid = false;

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            IsValidInputFields();

            if (_isTextBoxesValid)
                AddNewClient();
        }

        private void AddNewClient()
        {

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
            }

            else
            {
                errorProvider1.SetError(txtPhone, messageValue);
            }
        }

        private void IsValidInputFields()
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
                        errorProvider1.SetError(control, messageValue);

                        _isTextBoxesValid = false;
                    }

                    else
                    {
                        errorProvider1.SetError(control, "");

                        _isTextBoxesValid = false;
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
