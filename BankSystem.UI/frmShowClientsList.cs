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

            dgvAllClients.Columns[0].Width = 100;
            dgvAllClients.Columns[1].Width = 140;
            dgvAllClients.Columns[2].Width = 140;
            dgvAllClients.Columns[3].Width = 180;
            dgvAllClients.Columns[4].Width = 110;
            dgvAllClients.Columns[5].Width = 170;
            dgvAllClients.Columns[6].Width = 175;



            dgvAllClients.ClearSelection();
        }
        private void frmShowClientsList_Load(object sender, EventArgs e)
        {
            

            RefreshClientsList();

            ConfigureDataGridView();

            //dgvAllClients.DefaultCellStyle.Font = 
        }
    }
}
