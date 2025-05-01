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

        private DataGridViewConfig GetTransferLogsGridConfig()
        {
            return new DataGridViewConfig
            {
                lstColumns = new List<ColumnConfig>
                {
                    new ColumnConfig { ColumnName = "TransferLogID", DisplayName = "ID", Width = 90 },
                    new ColumnConfig { ColumnName = "Date", Width = 200 },
                    new ColumnConfig { ColumnName = "SourceAcc", DisplayName = "Source Acc", Width = 130 },
                    new ColumnConfig { ColumnName = "DestinationAcc", DisplayName = "Destination Acc", Width = 170 },
                    new ColumnConfig { ColumnName = "Amount",  Width = 140 },
                    new ColumnConfig { ColumnName = "SourceBalance", DisplayName = "Source Balance", Width = 190 },
                    new ColumnConfig { ColumnName = "DestinationBalance", DisplayName = "Destination Balance", Width = 230 },
                    new ColumnConfig { ColumnName = "Username", Width = 220 }
                }
            };
        }

        private void ConfigureDataGridView()
        {
            DataGridViewHelper.ConfigureDataGridView(dgvTransferLogs, GetTransferLogsGridConfig());
        }

        private void frmTransferLogsList_Load(object sender, EventArgs e)
        {
            RefreshTransferLogsList();

            ConfigureDataGridView();
        }
    }
}
