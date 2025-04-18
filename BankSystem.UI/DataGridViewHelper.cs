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

        static private void EditColumnsNames(DataGridView dgv, string columnName0, string columnName1, string columnName2,
            string columnName3, string columnName4, string name0, string name1, string name2, string name3, string name4)
        {
            dgv.Columns[columnName0].HeaderText = name0;
            dgv.Columns[columnName1].HeaderText = name1;
            dgv.Columns[columnName2].HeaderText = name2;
            dgv.Columns[columnName3].HeaderText = name3;
            dgv.Columns[columnName4].HeaderText = name4;
        }

        static private void EditColumnsWidth(DataGridView dgv, int value1, int value2, int value3, int value4, int value5, int value6,
            int value7, int value8)
        {
            dgv.Columns[0].Width = value1;
            dgv.Columns[1].Width = value2;
            dgv.Columns[2].Width = value3;
            dgv.Columns[3].Width = value4;
            dgv.Columns[4].Width = value5;
            dgv.Columns[5].Width = value6;
            dgv.Columns[6].Width = value7;
            dgv.Columns[7].Width = value8;
        }

        static public void ConfigureDataGridView(DataGridView dgv, string columnName0, string columnName1,
            string columnName2, string columnName3, string columnName4, string name0, string name1, string name2, 
            string name3, string name4, int widthValue0, int widthValue1, int widthValue2, int widthValue3, int widthValue4,
            int widthValue5, int widthValue6, int widthValue7)
        {
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.Font = new Font("Arial", 12, FontStyle.Bold);
            dgv.RowTemplate.Height = 30;
            dgv.ColumnHeadersHeight = 300;
            dgv.DefaultCellStyle.Font = new Font("Arial", 11);

            EditColumnsNames(dgv, columnName0, columnName1, columnName2, columnName3, columnName4, name0, name1, name2,
                name3, name4);

            EditColumnsWidth(dgv, widthValue0, widthValue1, widthValue2, widthValue3, widthValue4, widthValue5, 
                widthValue6, widthValue7);

            dgv.ClearSelection();
        }

    }
}
