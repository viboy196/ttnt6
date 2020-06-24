using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlikhohang.NghiepVu
{
    public static class Utilities
    {
        public static void HideAllColumns(DataGridView gridView)
        {
            foreach(DataGridViewColumn column in gridView.Columns)
            {
                column.Visible = false;
            }
        }

        public static void SetColumnsHeaderText(DataGridView gridView, params Tuple<string, string>[] columnsInfo)
        {
            foreach(var columnInfo in columnsInfo)
            {
                string columnName = columnInfo.Item1,
                    columnText = columnInfo.Item2;
                gridView.Columns[columnName].HeaderText = columnText;
                gridView.Columns[columnName].Visible = true;
            }
        }

        public static void SetColumnsFormat(DataGridView gridView, params Tuple<string,string>[] columnsInfo)
        {
            foreach (var columnInfo in columnsInfo)
            {
                string columnName = columnInfo.Item1,
                    columnFormat = columnInfo.Item2;
                gridView.Columns[columnName].DefaultCellStyle.Format = columnFormat;
            }
        }

        public static void SetColumnsOrder(DataGridView gridView, params string[] columnNames)
        {
            int i = 0;
            foreach(string columnName in columnNames)
                gridView.Columns[columnName].DisplayIndex = i++;
        }

        public static void SetControlsEnabled(bool enabled, params Control[] controls)
        {
            foreach(Control control in controls)
            {
                control.Enabled = enabled;
            }
        }

        public static int GetSelectedIndex(DataGridView gridView)
        {
            return gridView.SelectedCells[0].RowIndex;
        }
    }
}
