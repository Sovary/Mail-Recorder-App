using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Recorder_App.DAO
{
    public static class Extensions
    {
        public static DataTable ToDataTable(this DataGridView grid)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn col in grid.Columns)
            {
                dt.Columns.Add(col.HeaderText);
            }
            foreach (DataGridViewRow row in grid.Rows)
            {
                var dr = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dr[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public static DateTime GetFirstDateOfMonth(this DateTime d)
        {
            return new DateTime(d.Year, d.Month, 1);
        }
        public static DateTime GetLastDateOfMonth(this DateTime d)
        {
            return new DateTime(d.Year, d.Month, DateTime.DaysInMonth(d.Year, d.Month));
        }
    }
}
