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
using Guna.UI2.WinForms;

namespace BankSystem
{
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        Image _hidePassword = Properties.Resources.HideEye;
        Image _showPassword = Properties.Resources.visible;

        bool _isShowPassword = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.R;

            panel2.BackColor = Color.FromArgb(200, 0, 0, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            pnlLineForPassword.BackColor = Color.White;
            pnlLineForUsername.BackColor = Color.MidnightBlue;
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            pnlLineForUsername.BackColor = Color.White;
            pnlLineForPassword.BackColor = Color.MidnightBlue;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbPasswordIcon_Click(object sender, EventArgs e)
        {
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
    }
}
