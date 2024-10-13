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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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

        TimeSpan _selectedTime = new TimeSpan(0, 10, 0);

        StringBuilder _formattedSelectedTime = new StringBuilder();


        private void GetFormattedTime(TimeSpan time)
        {
            _formattedSelectedTime.AppendFormat("{0:0}:{1:00}", time.Minutes, time.Seconds);
        }

        private void ClearFormattedTime()
        {
            _formattedSelectedTime.Clear();
        }

        private void DecrementSelectedTime()
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

        private void HandleTrialTimeUp(TimeSpan zero)
        {
            UpdateTime(zero);

            TrialTimer.Stop();

            string notificationText = "Time's up .. you can try now";

            MessageBox.Show(notificationText, "Notification");

            UnvisibleTrialTimerLabel();

            EnableUsernameText();

            EnablePasswordText();
        }
        private void StartTimer()
        {
            DecrementSelectedTime();

            UpdateTime(_selectedTime);

            TimeSpan zero = TimeSpan.Zero;

            if (_selectedTime <= zero)
            {
                HandleTrialTimeUp(zero);
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

        private void ShowLockoutMessage()
        {
            string LockoutMessage = "Locked after" + _trialCounter.ToString() + " failed trials, You can try after 10 seconds";

            MessageBox.Show(LockoutMessage);
        }

        private void HandleLockout()
        {
            lblLoginMessage.Visible = false;

            ShowLockoutMessage();

            DisableUsernameText();
            DisablePasswordText();

            ColoringPanel(pnlLineForPassword, Color.White);
            ColoringPanel(pnlLineForUsername, Color.White);

            VisibleTrialTimerLabel();

            _selectedTime = new TimeSpan(0, 10, 0);

            TrialTimer.Start();
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
                _trialCounter = 3;

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

        private void TrialTimer_Tick(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
