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
using static BankSystem.UIHelper;

namespace BankSystem
{
    public partial class frmDeleteUser : Form
    {
        public frmDeleteUser()
        {
            InitializeComponent();
        }

        UIHelper _userUI;

        private void InitializeAllObjects()
        {
            Users user = new Users();
            Persons person = new Persons();
            Phones phone = new Phones();

            InitializeClientUIObject(user, person, phone);
        }

        private void InitializeClientUIObject(Users user, Persons person, Phones phone)
        {
            _userUI = new UIHelper(errorProvider1, gbUserCard, txtUsername, lblFullName,
                 lblPhone, lblUsername, lblEmail, lblPassword, lblPermissions, user, person, phone, _userUI, btnDeleteUser, this);
        }

        private void SetUserAction(enAction userAction)
        {
            _userUI.Action = userAction;
        }

        private void HandleUserAction(enAction userAction)
        {
            InitializeAllObjects();

            SetUserAction(userAction);

            _userUI.HandleUserInfo();
        }

        private bool IsDeletionSuccessful(string username, Users user)
        {
            int personID = user.PersonID;

            return (Users.DeleteUser(username) && Phones.DeletePhone(personID) && Persons.DeletePerson(personID));
        }

        private void HandleUserDeletionUI()
        {
            _userUI.ShowMessage("User Deleted Successfully");
            _userUI.ClearTextBox(txtUsername);
            _userUI.HidePanelOrGroup();
            _userUI.HideButton();
        }

        public void DeleteUser(string username, Users user)
        {
            if (IsDeletionSuccessful(username, user))
            {
                HandleUserDeletionUI();
            }

            else
                _userUI.ShowMessage("Deletion Failed");
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            HandleUserAction(enAction.DeleteShowInfo);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            HandleUserAction(enAction.Delete);
        }

       
    }
}
