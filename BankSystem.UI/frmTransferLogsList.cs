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
    public partial class frmTransferLogsList : Form
    {
        public frmTransferLogsList()
        {
            InitializeComponent();
        }

        private void RefreshTransferLogsList()
        {
            dgvTransferLogs.DataSource = TransferLogs.GetTransferLogsList();
        }

        private void EditColumnsNames()
        {
            dgvTransferLogs.Columns["TransferLogID"].HeaderText = "ID";
            dgvTransferLogs.Columns["Date"].HeaderText = "Date";
            dgvTransferLogs.Columns["SourceAcc"].HeaderText = "Source Acc";
            dgvTransferLogs.Columns["DestinationAcc"].HeaderText = "Destination Acc";
            dgvTransferLogs.Columns["Amount"].HeaderText = "Amount";
            dgvTransferLogs.Columns["SourceBalance"].HeaderText = "Source Balance";
            dgvTransferLogs.Columns["DestinationBalance"].HeaderText = "Destination Balance";
            dgvTransferLogs.Columns["Username"].HeaderText = "Username";
        }

        private void EditColumnsWidth()
        {
            dgvTransferLogs.Columns[0].Width = 110;
            dgvTransferLogs.Columns[1].Width = 140;
            dgvTransferLogs.Columns[2].Width = 140;
            dgvTransferLogs.Columns[3].Width = 160;
            dgvTransferLogs.Columns[4].Width = 130;
            dgvTransferLogs.Columns[5].Width = 140;
            dgvTransferLogs.Columns[6].Width = 191;
            dgvTransferLogs.Columns[7].Width = 310;
        }

        private void ConfigureDataGridView()
        {
            dgvTransferLogs.AllowUserToAddRows = false;
            dgvTransferLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransferLogs.MultiSelect = false;
            dgvTransferLogs.Font = new Font("Arial", 12, FontStyle.Bold);
            dgvTransferLogs.RowTemplate.Height = 30;
            dgvTransferLogs.ColumnHeadersHeight = 300;
            dgvTransferLogs.DefaultCellStyle.Font = new Font("Arial", 11);

            EditColumnsNames();

            EditColumnsWidth();

            dgvTransferLogs.ClearSelection();
        }

        private void frmTransferLogsList_Load(object sender, EventArgs e)
        {
            RefreshTransferLogsList();

            ConfigureDataGridView();
        }
    }
}
