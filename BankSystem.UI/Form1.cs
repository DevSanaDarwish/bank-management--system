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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image _hidePassword = Properties.Resources.HideEye;
        Image _showPassword = Properties.Resources.visible;

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
            if (pbPasswordIcon.Image == _hidePassword)
            {
                pbPasswordIcon.Image = _showPassword;
                txtPassword.PasswordChar = '';
            }

            else if (pbPasswordIcon.Image == _showPassword)
            {
                pbPasswordIcon.Image = _hidePassword;
                txtPassword.PasswordChar = '*';
            }

        }
    }
}
