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

        private DataGridViewConfig GetClientsGridConfig()
        {
            return new DataGridViewConfig
            {
                lstColumns = new List<ColumnConfig>
                {
                    new ColumnConfig { ColumnName = "ClientID", Width = 110 },
                    new ColumnConfig { ColumnName = "FirstName", DisplayName = "First Name", Width = 140 },
                    new ColumnConfig { ColumnName = "LastName", DisplayName = "Last Name", Width = 140 },
                    new ColumnConfig { ColumnName = "Email", Width = 160 },
                    new ColumnConfig { ColumnName = "PinCode", DisplayName = "PIN Code", Width = 130 },
                    new ColumnConfig { ColumnName = "Balance", Width = 140 },
                    new ColumnConfig { ColumnName = "AccountNumber", DisplayName = "Account Number", Width = 191 },
                    new ColumnConfig { ColumnName = "PhoneNumbers", DisplayName = "Phone Numbers", Width = 310 }
                }
            };
        }

        private void ConfigureDataGridView()
        {
            //DataGridViewHelper.ConfigureDataGridView(dgvAllClients, "FirstName", "LastName", "PinCode", "AccountNumber",
            //   "PhoneNumbers", "First Name", "Last Name", "PIN Code", "Account Number", "Phone Number",
            //   110, 140, 140, 160, 130, 140, 191, 310);

            DataGridViewHelper.ConfigureDataGridView(dgvAllClients, GetClientsGridConfig());
        }

        private void frmShowClientsList_Load(object sender, EventArgs e)
        {
            RefreshClientsList();

            ConfigureDataGridView();
        }
    }
}
