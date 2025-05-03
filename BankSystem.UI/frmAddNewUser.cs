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
//using System.Web.UI;
using System.Windows.Forms;
using static BankSystemBusinessLayer.Users;

namespace BankSystem
{
    public partial class frmAddNewUser : Form
    {
        public frmAddNewUser()
        {
            InitializeComponent();
        }

        public enum enPermissions
        {
            All = -1,
            ShowClientsList = 1,
            FindClient = 2,
            AddNewClient = 4,
            Transaction = 8,
            DeleteClient = 16,
            ManageUsers = 32,
            UpdateClient = 64,
            LoginRegisters = 128
        };


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

        private void AddNewUser(short permission)
        {
            InitializeAllObjects();

            _userUI.FillUserInfo(permission);

            _userUI.ValidationSave();
        }

        

        private bool IsAnyPermissionChecked()
        {
            foreach (Control control in pnlPermissions.Controls)
            {
                if (control is Guna2CheckBox checkBox && checkBox.Checked)
                {
                    return true;
                }
            }

            return false;
        }

        private void ClearCheckedPermissions()
        {
            foreach (Control control in pnlPermissions.Controls)
            {
                if (control is Guna2CheckBox checkBox && checkBox.Checked)
                {
                    checkBox.Checked = false;
                }
            }
        }

        private bool IsValidPasswordLength(byte minimumPasswordLength, byte maximumPasswordLength)
        {
            byte passwordLength = (Byte)txtPassword.Text.Length;

            return (PresentationInputValidator.ValidationValue(passwordLength, maximumPasswordLength, minimumPasswordLength));
        }

        private bool IsValidPermissionSelection()
        {
            if (!IsAnyPermissionChecked())
            {
                _userUI.ShowMessage("You must choose one permission at least");
                return false;
            }
            return true;
        }

        private bool IsValidInputFields()
        {
            return _userUI.ValidateInputFields(pnlUserInfo);
        }

        private bool IsUsernameDuplicated()
        {
            if (_userUI.IsUsernameDuplicated(txtUsername.Text))
            {
                _userUI.ShowMessage("This username already exists");
                return true;
            }
            return false;
        }

        private bool IsPasswordLengthValid()
        {
            byte minimumPasswordLength = Users.GetMinimumPasswordLength();
            byte maximumPasswordLength = Users.GetMaximumPasswordLength();

            if (!IsValidPasswordLength(minimumPasswordLength, maximumPasswordLength))
            {
                string message = $"The password must be between {minimumPasswordLength} and {maximumPasswordLength} characters long.";
                errorProvider1.SetError(txtPassword, message);
                return false;
            }

            return true;
        }


        private void HandleNewUser()
        {
            if (!IsValidPermissionSelection() || !IsValidInputFields() || IsUsernameDuplicated() || !IsPasswordLengthValid())
                return;

            short permission = GetPermissions();

            AddNewUser(permission);

            ClearCheckedPermissions();

            _userUI.ClearForm(pnlUserInfo);   
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

            // If any individual checkbox is unchecked by the user
            if (sender is Guna2CheckBox checkbox && !checkbox.Checked)
            {
                // Uncheck the "All" checkbox
                chkAll.Checked = false;
            }

            else
            {
                // Check if all individual checkboxes are selected manually
                bool allChecked = true;

                foreach(Control control in pnlPermissions.Controls)
                {
                    // If any checkbox (other than "All") is not checked, set the flag to false
                    if (control is Guna2CheckBox checkBox && checkBox != chkAll && !checkBox.Checked)
                    {
                        allChecked = false;
                        break;
                    }
                }

                // If all individual checkboxes are checked manually, also check the "All" checkbox
                chkAll.Checked = allChecked;
            }

            //Now that we're done the update, let's get back to doing the events 
            _isChangingPermissions = false;
        }

        public short GetPermissions()
        {
            short permission = 0;

            foreach(Control control in pnlPermissions.Controls)
            {
                if (control is Guna2CheckBox checkBox && checkBox.Checked)
                {
                    if (chkAll.Checked)
                        return -1;

                    else if(checkBox == chkShowClientsList)
                    {
                        permission += (short)enPermissions.ShowClientsList;
                    }

                    else if (checkBox == chkFindClient)
                    {
                        permission += (short)enPermissions.FindClient;
                    }

                    else if (checkBox == chkAddNewClient)
                    {
                        permission += (short)enPermissions.AddNewClient;
                    }

                    else if (checkBox == chkTransaction)
                    {
                        permission += (short)enPermissions.Transaction;
                    }

                    else if (checkBox == chkDeleteClient)
                    {
                        permission += (short)enPermissions.DeleteClient;
                    }

                    else if (checkBox == chkManageUsers)
                    {
                        permission += (short)enPermissions.ManageUsers;
                    }

                    else if (checkBox == chkUpdateClient)
                    {
                        permission += (short)enPermissions.UpdateClient;
                    }

                    else if (checkBox == chkLoginRegisters)
                    {
                        permission += (short)enPermissions.LoginRegisters;
                    }
                }
            }

            return permission;
        }
    }
}
