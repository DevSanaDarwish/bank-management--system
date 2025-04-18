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
            DataGridViewHelper.RefreshDataSource(dgvTransferLogs, TransferLogs.GetTransferLogsList());
        }

        private void ConfigureDataGridView()
        {
            DataGridViewHelper.ConfigureDataGridView(dgvTransferLogs, "TransferLogID", "SourceAcc", "DestinationAcc", 
                "SourceBalance", "DestinationBalance", "ID", "Source Acc", "Destination Acc", "Source Balance", 
                "Destination Balance", 90, 200, 130, 170, 140, 190, 230, 220);
        }

        private void frmTransferLogsList_Load(object sender, EventArgs e)
        {
            RefreshTransferLogsList();

            ConfigureDataGridView();
        }
    }
}
