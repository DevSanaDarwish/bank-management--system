using System;
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

        int _userID { get; set; }


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

            ControlHelper.ShowMessage(notificationText, title);
        }

        private void EnableInputFields()
        {
            ControlHelper.EnableControl(txtUsername);

            ControlHelper.EnableControl(txtPassword);
        }

        private void StopTrialTimer()
        {
            TrialTimer.Stop();
        }

        private void StartTrialTimer()
        {
            TrialTimer.Start();
        }

        private void HandleTrialTimeIsUp(TimeSpan zero)
        {
            UpdateTime(zero);

            StopTrialTimer();

            ShowNotificationMessage();

            ControlHelper.HideControl(lblTrialTimer);

            EnableInputFields();

            ControlHelper.EnableControl(btnLogin);
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

        private void ColoringPasswordAndUsernamePanel(Color passwordLineColor, Color usernameLineColor)
        {
            ControlHelper.ColoringPanel(pnlLineForPassword, passwordLineColor);

            ControlHelper.ColoringPanel(pnlLineForUsername, usernameLineColor);
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            ColoringPasswordAndUsernamePanel(Color.White, Color.MidnightBlue);
        }
        
        private void txtPassword_Click(object sender, EventArgs e)
        {
            ColoringPasswordAndUsernamePanel(Color.MidnightBlue, Color.White);
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

        private bool IsValidUsernameAndPassword()
        {
            Users user = Users.Find(txtUsername.Text, txtPassword.Text);

            if(user != null)
            {
                _username = txtUsername.Text;
                _userID = Users.GetUserIDByUsername(_username);

                return true;
            }

            return false;
        }

        private void OpenMainForm()
        {
            frmMainMenu mainMenu = new frmMainMenu(_username, _userID);
            mainMenu.Show();

            this.Hide();
        }

        private void ShowLockoutMessage()
        {
            byte remainingTrials = Users.GetRemainingTrials();

            string LockoutMessage = $"Locked after {remainingTrials} failed trials, You can try after {_waitDurationPerSeconds} seconds";

            ControlHelper.ShowMessage(LockoutMessage, "");
        }

        private void UpdateSelectedTime()
        {
            _selectedTime = new TimeSpan(0, 0, 10);
        }

        private void DisableInputFields()
        {
            ControlHelper.DisableControl(txtUsername);

            ControlHelper.DisableControl(txtPassword);
        }

        private void SetInputFieldsBordersColor()
        {
            ControlHelper.ColoringPanel(pnlLineForPassword, Color.White);

            ControlHelper.ColoringPanel(pnlLineForUsername, Color.White);
        }

        private void ResetTimer()
        {
            ControlHelper.VisibleControl(lblTrialTimer);

            UpdateSelectedTime();

            StartTrialTimer();
        }

        private void ClearInputFields()
        {
            ControlHelper.ClearTextBox(txtUsername);

            ControlHelper.ClearTextBox(txtPassword);
        }

        private void ResetInputFields()
        {
            ClearInputFields();

            DisableInputFields();

            SetInputFieldsBordersColor();
        }

        private void HandleLockout()
        {
            ControlHelper.HideControl(lblLoginMessage);

            ShowLockoutMessage();

            ResetInputFields();

            ControlHelper.DisableControl(btnLogin);

            ResetTimer();
        }

        private void ShowLoginMessage()
        {
            byte remainingTrials = Users.GetRemainingTrials();

            string _loginMessage = $"Invalid username or password\r\nYou have {remainingTrials} trials to login\r\n\r\n";

            lblLoginMessage.Text = _loginMessage;

            ControlHelper.VisibleControl(lblLoginMessage);
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

        private void FillLoginRegisterObject()
        {

        }

        private bool AddLoginRegisters()
        {
            LoginRegisters loginRegister = new LoginRegisters(DateTime.Now, _userID);

            return loginRegister.AddLoginRegisters();
        }

        private void HandleLogin()
        {
            try
            {
                if (IsValidUsernameAndPassword())
                {
                    OpenMainForm();

                    AddLoginRegisters();               
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
            if(control == txtPassword)
            {
                byte minimumPasswordLength = Users.GetMinimumPasswordLength();
                byte maximumPasswordLength = Users.GetMaximumPasswordLength();

                if(!IsValidPasswordLength(maximumPasswordLength, minimumPasswordLength))
                {
                    string passwordMessage = $"The password must be between {minimumPasswordLength} and {maximumPasswordLength} characters long.";

                    errorProvider1.SetError(control, passwordMessage);

                    return false;
                }            
            }

            errorProvider1.SetError(control, "");

            return true;
        }

        private bool IsValidPasswordLength(int maxValue, int minValue)
        {
            byte passwordLength = (Byte)txtPassword.Text.Length;

            return (PresentationInputValidator.ValidationValue(passwordLength, maxValue, minValue));            
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
