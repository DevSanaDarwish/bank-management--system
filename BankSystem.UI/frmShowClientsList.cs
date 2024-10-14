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
    public partial class frmShowClientsList : Form
    {
        public frmShowClientsList()
        {
            InitializeComponent();
        }

        private void RefreshClientsList()
        {
            dgvAllClients.DataSource = Clients.GetAllClients();
        }

        private void ConfigureDataGridView()
        {
            dgvAllClients.AllowUserToAddRows = false;
            dgvAllClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllClients.MultiSelect = false;
            dgvAllClients.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvAllClients.RowTemplate.Height = 30;
            dgvAllClients.ColumnHeadersHeight = 300;
            dgvAllClients.DefaultCellStyle.Font = new Font("Arial", 11);

            dgvAllClients.Columns["FirstName"].HeaderText = "First Name";
            dgvAllClients.Columns["LastName"].HeaderText = "Last Name";
            dgvAllClients.Columns["Email"].HeaderText = "Email";
            dgvAllClients.Columns["PinCode"].HeaderText = "PIN Code";
            dgvAllClients.Columns["Balance"].HeaderText = "Balance";
            dgvAllClients.Columns["AccountNumber"].HeaderText = "Account Number";
            dgvAllClients.Columns["PhoneNumbers"].HeaderText = "Phone Number";

            dgvAllClients.Columns[0].Width = 110;
            dgvAllClients.Columns[1].Width = 140;
            dgvAllClients.Columns[2].Width = 140;
            dgvAllClients.Columns[3].Width = 160;
            dgvAllClients.Columns[4].Width = 130;
            dgvAllClients.Columns[5].Width = 140;
            dgvAllClients.Columns[6].Width = 191;
            dgvAllClients.Columns[7].Width = 180;

            dgvAllClients.ClearSelection();
        }
        private void frmShowClientsList_Load(object sender, EventArgs e)
        {
            RefreshClientsList();

            ConfigureDataGridView();
        }
    }
}
