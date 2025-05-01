using BankSystemBusinessLayer;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class frmAddNewUser : Form
    {
        public frmAddNewUser()
        {
            InitializeComponent();
        }

        UIHelper _userUI;

        //This flag prevents recursive event calls when checkboxes are being changed programmatically
        bool _isChangingPermissions = false;

        private void InitializeUserUIObject(Users user, Persons person, Phones phone)
        {
            _userUI = new UIHelper(errorProvider1, txtUsername, txtEmail, txtPhone, txtPassword, txtFirstName, txtLastName,
                pnlUserInfo, true, user, person, phone, cbPhones);
        }

        private void InitializeAllObjects()
        {
            Users user = new Users();
            Persons person = new Persons();
            Phones phone = new Phones();

            InitializeUserUIObject(user, person, phone);
        }
        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            InitializeAllObjects();

            _userUI.AddPhone();
        }

        private void AddNewUser()
        {
            InitializeAllObjects();

            _userUI.FillUserInfo();

            _userUI.ValidationSave();
        }

        private void HandleNewUser()
        {
            if (_userUI.ValidateInputFields(pnlUserInfo))
            {
                if (!_userUI.IsUsernameDuplicated(txtUsername.Text))
                {
                    AddNewUser();

                    _userUI.ClearForm(pnlUserInfo);
                }

                else
                {
                    _userUI.ShowMessage("This username already exists");
                }
            }
        }
        
        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            InitializeAllObjects();

            HandleNewUser();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            // Exit if we're currently updating checkboxes to avoid triggering this event again
            if (_isChangingPermissions)
                return;

            //Prevents events from interacting during updating
            _isChangingPermissions = true;

            foreach(Control control in pnlPermissions.Controls)
            {
                //We put "checkbox != chkAll" because it is a line of protection that prevents the event from running on itself
                // and protects you from unnecessary repetitive execution.
                if (control is Guna2CheckBox checkbox && checkbox != chkAll)
                {
                    // Set its checked state to match the "All" checkbox
                    checkbox.Checked = chkAll.Checked;
                }
            }

            //Now that we're done the update, let's get back to doing the events 
            _isChangingPermissions = false;
        }

        private void PermissionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Exit if we're currently updating checkboxes to avoid triggering this event again
            if (_isChangingPermissions)
                return;

            _isChangingPermissions = true;

            if (sender is Guna2CheckBox checkbox && !checkbox.Checked)
            {
                chkAll.Checked = false;
            }

            else
            {
                bool allChecked = true;

                foreach(Control control in pnlPermissions.Controls)
                {
                    if(control is Guna2CheckBox checkBox && checkBox != chkAll && !checkBox.Checked)
                    {
                        allChecked = false;
                        break;
                    }
                }

                chkAll.Checked = allChecked;
            }

            //Now that we're done the update, let's get back to doing the events 
            _isChangingPermissions = false;
        }
    }
}
