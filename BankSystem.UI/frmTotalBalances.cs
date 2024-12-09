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

namespace BankSystem
{
    public partial class frmTotalBalances : Form
    {
        public frmTotalBalances()
        {
            InitializeComponent();
        }

        private void RefreshBalancesList()
        {
            dgvTotalBalances.DataSource = Clients.GetTotalBalances();
        }

        private void EditColumnsNames()
        {
            dgvTotalBalances.Columns["AccountNumber"].HeaderText = "Acc.Number";
            dgvTotalBalances.Columns["FirstName"].HeaderText = "First Name";
            dgvTotalBalances.Columns["LastName"].HeaderText = "Last Name";
            dgvTotalBalances.Columns["Balance"].HeaderText = "Balance";  
        }

        private void EditColumnsWidth()
        {
            dgvTotalBalances.Columns[0].Width = 190;
            dgvTotalBalances.Columns[1].Width = 190;
            dgvTotalBalances.Columns[2].Width = 190;
            dgvTotalBalances.Columns[3].Width = 190;
        }

        private void ConfigureDataGridView()
        {
            dgvTotalBalances.AllowUserToAddRows = false;
            dgvTotalBalances.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTotalBalances.MultiSelect = false;
            dgvTotalBalances.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvTotalBalances.RowTemplate.Height = 30;
            dgvTotalBalances.ColumnHeadersHeight = 300;
            dgvTotalBalances.DefaultCellStyle.Font = new Font("Arial", 11);

            EditColumnsNames();

            EditColumnsWidth();

            dgvTotalBalances.ClearSelection();
        }

        private void frmTotalBalances_Load(object sender, EventArgs e)
        {
            RefreshBalancesList();

            ConfigureDataGridView();

            PrintSumOfBalances();
        }

        private void PrintSumOfBalances()
        {
            lblTotalBalances.Text = Clients.GetSumOfBalances().ToString() + " $";
        }
    }
}
