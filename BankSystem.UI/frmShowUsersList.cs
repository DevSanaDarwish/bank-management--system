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
    public partial class frmShowUsersList : Form
    {
        public frmShowUsersList()
        {
            InitializeComponent();
        }

        private void RefreshUsersList()
        {
            DataGridViewHelper.RefreshDataSource(dgvAllUsers, Users.GetAllUsers());
        }

        private DataGridViewConfig GetClientsGridConfig()
        {
            return new DataGridViewConfig
            {
                lstColumns = new List<ColumnConfig>
                {
                    new ColumnConfig { ColumnName = "UserID", Width = 110 },
                    new ColumnConfig { ColumnName = "Username", Width = 150 },
                    new ColumnConfig { ColumnName = "FullName", DisplayName = "Full Name", Width = 240 },
                    new ColumnConfig { ColumnName = "Email", Width = 200 },
                    new ColumnConfig { ColumnName = "PhoneNumbers", DisplayName = "Phone Numbers", Width = 330 },
                    new ColumnConfig { ColumnName = "Password", Width = 130 },
                    new ColumnConfig { ColumnName = "Permissions", Width = 160 }             
                }
            };
        }

        private void ConfigureDataGridView()
        {
            DataGridViewHelper.ConfigureDataGridView(dgvAllUsers, GetClientsGridConfig());
        }

        private void frmShowUsersList_Load(object sender, EventArgs e)
        {
            RefreshUsersList();

            ConfigureDataGridView();
        }
    }
}
