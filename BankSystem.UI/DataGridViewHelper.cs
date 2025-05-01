using BankSystemBusinessLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.SessionState;
using System.Windows.Forms;

namespace BankSystem
{
    static public class DataGridViewHelper
    {
        static public void RefreshDataSource(DataGridView dgv, object dataSource)
        {
            dgv.DataSource = dataSource;
        }
       
        static private void EditColumnsNames(DataGridView dgv, ColumnConfig column)
        {
            if(!string.IsNullOrWhiteSpace(column.DisplayName))
            {
                dgv.Columns[column.ColumnName].HeaderText = column.DisplayName;
            }         
        }

        static private void EditColumnsWidth(DataGridView dgv, ColumnConfig column)
        {
            dgv.Columns[column.ColumnName].Width = column.Width;
        }

        static public void ConfigureDataGridView(DataGridView dgv, DataGridViewConfig config)
        {
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.Font = new Font("Arial", 12, FontStyle.Bold);
            dgv.RowTemplate.Height = 30;
            dgv.ColumnHeadersHeight = 300;
            dgv.DefaultCellStyle.Font = new Font("Arial", 11);

            foreach(ColumnConfig column in config.lstColumns)
            {
                if(dgv.Columns.Contains(column.ColumnName))
                {
                    EditColumnsNames(dgv, column);
                    EditColumnsWidth(dgv, column);
                }
            }

            dgv.ClearSelection();
        }
    }
}
