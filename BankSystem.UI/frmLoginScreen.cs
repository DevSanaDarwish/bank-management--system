using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystemBusinessLayer;
using ClassLibraryForChildForm;
using Guna.UI2.WinForms;

namespace BankSystem
{
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        byte _trialCounter = 3;

        bool _isShowPassword = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.R;

            panel2.BackColor = Color.FromArgb(200, 0, 0, 0);
        }

        private void ColoringPanel(Panel panel, Color color)
        {
            panel.BackColor = color;
        }

        private void ColoringPasswordAndUsernamePanel()
        {
            ColoringPanel(pnlPassword, Color.White);
            ColoringPanel(pnlUsername, Color.MidnightBlue);
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            ColoringPasswordAndUsernamePanel();
        }
        
        private void txtPassword_Click(object sender, EventArgs e)
        {
            ColoringPasswordAndUsernamePanel();
        }

        private void TogglePasswordVisibility()
        {
            Image _hidePassword = Properties.Resources.HideEye;
            Image _showPassword = Properties.Resources.visible;

            if (!_isShowPassword)
            {
                pbPasswordIcon.Image = _showPassword;
                txtPassword.PasswordChar = '\0';
                _isShowPassword = true;
            }

            else
            {
                pbPasswordIcon.Image = _hidePassword;
                txtPassword.PasswordChar = '*';
                _isShowPassword = false;
            }
        }

        private void pbPasswordIcon_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility();
        }

        private bool ISValidUsernameAndPassword()
        {
            Users user = Users.Find(txtUsername.Text, txtPassword.Text);

            return (user != null);
        }

        private void OpenMainForm()
        {
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void DisableUsernameText()
        {
            txtUsername.Enabled = false;
        }

        private void DisablePasswordText()
        {
            txtPassword.Enabled = false;
        }

        private void HandleLockout()
        {
            lblLoginMessage.Visible = false;

            string LockoutMessage = "Locked after 3 failed trials, You can try after 10 seconds";

            MessageBox.Show(LockoutMessage);

            DisableUsernameText();
            DisablePasswordText();

            ColoringPanel(pnlPassword, Color.White);
            ColoringPanel(pnlUsername, Color.White);

            lblTrialTimer.Visible = true;
        }

        private void ShowLoginMessage()
        {
            string _loginMessage = "Invalid username or password\r\nYou have " + _trialCounter + " trials to login\r\n\r\n";

            lblLoginMessage.Text = _loginMessage;
            lblLoginMessage.Visible = true;
        }

        private void HandleFailedLogin()
        {
            --_trialCounter;

            if (_trialCounter == 0)
            {
                HandleLockout();

                return;
            }

            ShowLoginMessage();
        }

        private void HandleLogin()
        {
            if (ISValidUsernameAndPassword())
            {
                OpenMainForm();
            }

            else
            {
                HandleFailedLogin();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            HandleLogin();       
        }
    }
}
