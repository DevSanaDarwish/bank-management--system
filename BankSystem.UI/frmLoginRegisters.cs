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
    public partial class frmLoginRegisters : Form
    {
        public frmLoginRegisters()
        {
            InitializeComponent();
        }

        private void RefreshLoginRegistersList()
        {
            DataGridViewHelper.RefreshDataSource(dgvLoginRegisters, LoginRegisters.GetLoginRegistersList());
        }

        private DataGridViewConfig GetLoginRegistersGridConfig()
        {
            return new DataGridViewConfig
            {
                lstColumns = new List<ColumnConfig>
                {
                    new ColumnConfig { ColumnName = "DateTime", Width = 520 },
                    new ColumnConfig { ColumnName = "Username", Width = 250 },
                    new ColumnConfig { ColumnName = "Password", Width = 300 },
                    new ColumnConfig { ColumnName = "Permissions", Width = 250 },
                }
            };
        }

        private void ConfigureDataGridView()
        {
            DataGridViewHelper.ConfigureDataGridView(dgvLoginRegisters, GetLoginRegistersGridConfig());
        }

        private void frmLoginRegisters_Load(object sender, EventArgs e)
        {
            RefreshLoginRegistersList();

            ConfigureDataGridView();
        }
    }
}
