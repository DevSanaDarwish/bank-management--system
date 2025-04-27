using BankSystemBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
