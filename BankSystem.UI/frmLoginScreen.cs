﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using BankSystemBusinessLayer;
using ClassLibraryForChildForm;
using Guna.UI2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace BankSystem
{
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        byte _waitDurationPerSeconds = 10;

        bool _isShowPassword = false;    

        TimeSpan _selectedTime = new TimeSpan(0, 0, 10);

        StringBuilder _formattedSelectedTime = new StringBuilder();

        string _username { get; set; }
        private void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title);
        }

        private void GetFormattedTime(TimeSpan time)
        {
            int remainingSeconds = (int)time.TotalSeconds;

            _formattedSelectedTime.AppendFormat("{0:D2}:00", remainingSeconds);
        }

        private void ClearFormattedTime()
        {
            _formattedSelectedTime.Clear();
        }

        private void DecrementSelectedTimeOneSecond()
        {
            TimeSpan oneSecond = new TimeSpan(0, 0, 1);

            _selectedTime -= oneSecond;
        }

        private void SetFormattedTimeInLabel()
        {
            lblTrialTimer.Text = _formattedSelectedTime.ToString();
        }

        private void UpdateTime(TimeSpan time)
        {
            GetFormattedTime(time);

            SetFormattedTimeInLabel();

            ClearFormattedTime();
        }

        private void ShowNotificationMessage()
        {
            string notificationText = "Time's up .. you can try now", title = "Notification";

            ShowMessage(notificationText, title);
        }

        private void EnableInputFields()
        {
            EnableUsernameText();

            EnablePasswordText();
        }

        private void StopTrialTimer()
        {
            TrialTimer.Stop();
        }

        private void StartTrialTimer()
        {
            TrialTimer.Start();
        }

        private void EnableLoginButton()
        {
            btnLogin.Enabled = true;
        }

        private void HandleTrialTimeIsUp(TimeSpan zero)
        {
            UpdateTime(zero);

            StopTrialTimer();

            ShowNotificationMessage();

            UnvisibleTrialTimerLabel();

            EnableInputFields();

            EnableLoginButton();
        }

        private void CheckTrialTimeIsUp()
        {
            TimeSpan zero = TimeSpan.Zero;

            if (_selectedTime <= zero)
            {
                HandleTrialTimeIsUp(zero);
            }
        }

        private void StartTimer()
        {
            DecrementSelectedTimeOneSecond();

            if (_selectedTime.TotalSeconds >= 0)
            {
                UpdateTime(_selectedTime);

                CheckTrialTimeIsUp();
            }

            else
            {
                StopTrialTimer();
            }

           
        }

        private void VisibleTrialTimerLabel()
        {
            lblTrialTimer.Visible = true;
        }

        private void UnvisibleTrialTimerLabel()
        {
            lblTrialTimer.Visible = false;
        }

        private void EnableUsernameText()
        {
            txtUsername.Enabled = true;
        }

        private void EnablePasswordText()
        {
            txtPassword.Enabled = true;
        }

        private void DisableUsernameText()
        {
            txtUsername.Enabled = false;
        }

        private void DisablePasswordText()
        {
            txtPassword.Enabled = false;
        }

        private void SetFormBackground()
        {
            this.BackgroundImage = Properties.Resources.R;
        }

        private void SetLoginPanelBackColor()
        {
            pnlLoginScreen.BackColor = Color.FromArgb(200, 0, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetFormBackground();

            SetLoginPanelBackColor();
        }

        private void ColoringPanel(Panel panel, Color color)
        {
            panel.BackColor = color;
        }

        private void ColoringPasswordAndUsernamePanel()
        {
            ColoringPanel(pnlLineForPassword, Color.White);

            ColoringPanel(pnlLineForUsername, Color.MidnightBlue);
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            ColoringPasswordAndUsernamePanel();
        }
        
        private void txtPassword_Click(object sender, EventArgs e)
        {
            ColoringPasswordAndUsernamePanel();
        }

        private void ShowPassword()
        {
            Image _showPassword = Properties.Resources.visible;

            pbPasswordIcon.Image = _showPassword;

            txtPassword.PasswordChar = '\0';

            _isShowPassword = true;
        }

        private void HidePassword()
        {
            Image _hidePassword = Properties.Resources.HideEye;

            pbPasswordIcon.Image = _hidePassword;

            txtPassword.PasswordChar = '*';

            _isShowPassword = false;

        }

        private void TogglePasswordVisibility()
        {
            if (!_isShowPassword)
            {
                ShowPassword();
            }

            else
            {
                HidePassword();          
            }
        }

        private void pbPasswordIcon_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility();
        }

        private bool ISValidUsernameAndPassword()
        {
            Users user = Users.Find(txtUsername.Text, txtPassword.Text);

            if(user != null)
            {
                _username = txtUsername.Text;

                return true;
            }

            return false;
        }

        private void OpenMainForm()
        {
            frmMainMenu mainMenu = new frmMainMenu(_username);
            mainMenu.Show();

            this.Hide();
        }

        private void ShowLockoutMessage()
        {
            byte remainingTrials = Users.GetRemainingTrials();

            string LockoutMessage = $"Locked after {remainingTrials} failed trials, You can try after {_waitDurationPerSeconds} seconds";

            ShowMessage(LockoutMessage, "");
        }

        private void UnvisibleLoginMessageLabel()
        {
            lblLoginMessage.Visible = false;
        }

        private void VisibleLoginMessageLabel()
        {
            lblLoginMessage.Visible = true;
        }

        private void UpdateSelectedTime()
        {
            _selectedTime = new TimeSpan(0, 0, 10);
        }

        private void DisableInputFields()
        {
            DisableUsernameText();

            DisablePasswordText();
        }

        private void SetInputFieldsBordersColor()
        {
            ColoringPanel(pnlLineForPassword, Color.White);

            ColoringPanel(pnlLineForUsername, Color.White);
        }

        private void ResetTimer()
        {
            VisibleTrialTimerLabel();

            UpdateSelectedTime();

            StartTrialTimer();
        }

        private void ClearUsernameText()
        {
            txtUsername.Text = string.Empty;
        }

        private void ClearPasswordText()
        {
            txtPassword.Text = string.Empty;
        }

        private void ClearInputFields()
        {
            ClearUsernameText();

            ClearPasswordText();
        }

        private void ResetInputFields()
        {
            ClearInputFields();

            DisableInputFields();

            SetInputFieldsBordersColor();
        }

        private void DisableLoginButton()
        {
            btnLogin.Enabled = false;
        }

        private void HandleLockout()
        {
            UnvisibleLoginMessageLabel();

            ShowLockoutMessage();

            ResetInputFields();

            DisableLoginButton();

            ResetTimer();
        }

        private void ShowLoginMessage()
        {
            byte remainingTrials = Users.GetRemainingTrials();

            string _loginMessage = $"Invalid username or password\r\nYou have {remainingTrials} trials to login\r\n\r\n";

            lblLoginMessage.Text = _loginMessage;

            VisibleLoginMessageLabel();
        }

        private void HandleFailedLogin()
        {
            Users.DecrementTrialCounter();

            if (Users.IsLockedOut())
            {
                Users.ResetTrialCounter();

                HandleLockout();

                return;
            }

            ShowLoginMessage();
        }

        private void HandleLogin()
        {
            try
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

            catch(Exception ex)
            {
                MessageBox.Show("An error occurred during the login process: " + ex.Message);
            }
            
        }
       
        private bool ValidateControlText(TextBox control, string messageValue)
        {

            if (string.IsNullOrWhiteSpace(control.Text))
            {
                errorProvider1.SetError(control, messageValue);

                return false;
            }

            //Show error message if the control was txtPassword
            if(control == txtPassword && !IsValidPasswordLength())
            {
                byte minimumPasswordLength = Users.GetMinimumPasswordLength();
                byte maximumPasswordLength = Users.GetMaximumPasswordLength();

                string passwordMessage = $"The password must be between {minimumPasswordLength} and {maximumPasswordLength} characters long.";

                errorProvider1.SetError(control, passwordMessage);

                return false;
            }

            errorProvider1.SetError(control, "");

            return true;
        }

        private bool IsValidPasswordLength()
        {
            byte passwordLength = (Byte)txtPassword.Text.Length;

            return (Users.IsValidPasswordLength(passwordLength));            
        }

        private bool IsValidInputFields()
        {
            if (!ValidateControlText(txtUsername, "The username should not be empty"))
                return false;

            else if (!ValidateControlText(txtPassword, "The password should not be empty"))
                return false;
              
            
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!IsValidInputFields())
                return;

            HandleLogin();       
        }

        private void TrialTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                StartTimer();
            }

            catch (Exception ex)
            {
                StopTrialTimer();

                MessageBox.Show("An error occurred while updating the timer: " + ex.Message);           
            }
            
        }

    }
}
