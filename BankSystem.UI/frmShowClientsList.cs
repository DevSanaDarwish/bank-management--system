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
            DataGridViewHelper.RefreshDataSource(dgvAllClients, Clients.GetAllClients());
        }

        private void ConfigureDataGridView()
        {
            DataGridViewHelper.ConfigureDataGridView(dgvAllClients, "FirstName", "LastName", "PinCode", "AccountNumber",
               "PhoneNumbers", "First Name", "Last Name", "PIN Code", "Account Number", "Phone Number",
               110, 140, 140, 160, 130, 140, 191, 310);
        }

        private void frmShowClientsList_Load(object sender, EventArgs e)
        {
            RefreshClientsList();

            ConfigureDataGridView();
        }
    }
}
