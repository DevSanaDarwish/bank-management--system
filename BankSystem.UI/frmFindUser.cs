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
    public partial class frmFindUser : Form
    {
        public frmFindUser()
        {
            InitializeComponent();
        }


        Users _user = new Users();
        Persons _person = new Persons();
        Phones _phone = new Phones();

        UIHelper _userUI;


        private void InitializeUserUIObject()
        {
            _userUI = new UIHelper(errorProvider1, gbUserCard, txtUsername,lblFirstName, lblLastName, lblPassword, lblPermissions,
                lblPhone, lblUsername, lblEmail, _user, _person, _phone);
        }
        private void HandleUserAction(enAction userAction)
        {
            InitializeUserUIObject();

            _userUI.Action = userAction;

            _userUI.HandleUserInfo();
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            HandleUserAction(enAction.Find);
        }
    }
}
