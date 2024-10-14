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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        DateTime _timeNow = DateTime.Now;

        StringBuilder _formattedSelectedTime = new StringBuilder();

        private void GetFormattedTime()
        {
            _formattedSelectedTime.AppendFormat(_timeNow.ToString("hh:mm:ss tt"));
        }

        private void ClearFormattedTime()
        {
            _formattedSelectedTime.Clear();
        }

        private void EncrementSelectedTimeOneSecond()
        {
            TimeSpan oneSecond = new TimeSpan(0, 0, 1);

            _timeNow += oneSecond;
        }

        private void StopTrialTimer()
        {
            TimeNow.Stop();
        }

        private void StartTrialTimer()
        {
            TimeNow.Start();
        }

        private void UpdateTime()
        {
            GetFormattedTime();

            SetFormattedTimeInLabel();

            ClearFormattedTime();
        }

        private void UpdateDate()
        {
            lblDate.Text = _timeNow.ToString("dddd, MMMM dd, yyyy");
        }

        private void SetFormattedTimeInLabel()
        {
            lblTimeNow.Text = _formattedSelectedTime.ToString();
        }

        private void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title);
        }

        private void ShowNotificationMessage()
        {
            string notificationText = "Time's up .. you can try now", title = "Notification";

            ShowMessage(notificationText, title);
        }

        private void StartTimer()
        {
            EncrementSelectedTimeOneSecond();

            UpdateTime();
        }

        private void TimeNow_Tick(object sender, EventArgs e)
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

        private void frmHome_Load(object sender, EventArgs e)
        {
            UpdateTime();

            StartTrialTimer();

            UpdateDate();
        }
    }
}
