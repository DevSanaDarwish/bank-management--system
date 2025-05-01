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
            DataGridViewHelper.RefreshDataSource(dgvTotalBalances, Clients.GetTotalBalances());
        }

        private DataGridViewConfig GetBalancesGridConfig()
        {
            return new DataGridViewConfig
            { 
                lstColumns = new List<ColumnConfig>
                { 
                    new ColumnConfig {ColumnName = "AccountNumber", DisplayName = "Acc.Number", Width = 190},
                    new ColumnConfig {ColumnName = "FirstName", DisplayName = "First Name", Width = 190},
                    new ColumnConfig {ColumnName = "LastName", DisplayName = "Last Name", Width = 190},
                    new ColumnConfig {ColumnName = "Balance",  Width = 190},
                }
            };
        }

        private void ConfigureDataGridView()
        {         
            DataGridViewHelper.ConfigureDataGridView(dgvTotalBalances, GetBalancesGridConfig());
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
