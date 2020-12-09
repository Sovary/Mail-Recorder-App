using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Mail_Recorder_App.DAO
{
    public class ExcelManager
    {
        public System.Data.DataTable ReadExcel(string filepath)
        {
            System.Data.DataTable dt = new System.Data.DataTable();

            Excel.Application app = null;
            Excel.Workbook wb = null;
            Excel.Worksheet sheet = null;
            Excel.Range range = null;
            try
            {
                
                app = new Excel.Application();
                wb = app.Workbooks.Open(filepath);
                sheet = (Excel.Worksheet)wb.Worksheets[1];
                range = sheet.Cells[1, 1];
                var numRows = sheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing).Row;
                var numCols = sheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing).Column;

                for (int i = 0; i < numCols; i++)
                {
                    range = sheet.Cells[1, i + 1];
                    dt.Columns.Add($"{range.Value}");
                }
                for (int i = 1; i < numRows; i++)
                {
                    List<string> values = new List<string>();
                    for (int j = 0; j < numCols; j++)
                    {
                        values.Add($"{sheet.Cells[i + 1, j + 1].Value}");
                    }
                    dt.Rows.Add(values.ToArray());
                }

                wb.Close(false, Type.Missing, Type.Missing);
                app.Quit();
            }
            finally
            {
                if (range != null) Marshal.ReleaseComObject(range);
                if (sheet != null) Marshal.ReleaseComObject(sheet);
                if (wb != null) Marshal.ReleaseComObject(wb);
                if (app != null) Marshal.ReleaseComObject(app);
            }
            return dt;
        }

        public void ExportExcel(string filePath, System.Data.DataTable dt)
        {
            Excel.Application app = null;
            Excel.Workbooks wbs = null;
            Excel.Workbook wb = null;
            Excel.Sheets sheets = null;
            Excel.Worksheet sheet = null;
            Excel.Range range = null;
            try
            {

                app = new Excel.Application();
                wbs = app.Workbooks;
                wb = wbs.Add();
                sheets = wb.Sheets;
                sheet = sheets[1];
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    range = sheet.Cells[1, i + 1];
                    range.Value = dt.Columns[i].Caption;
                    range.Font.Bold = true;
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        range = sheet.Cells[i + 2, j + 1];
                        range.Value = $"{dt.Rows[i][j]}";
                    }
                }
                try
                {
                    app.DisplayAlerts = false;
                    wb.SaveAs(filePath);
                    wb.Close(true, filePath, Type.Missing);
                    app.DisplayAlerts = true;
                }
                catch (COMException ex) { }

                

            }
            finally
            {
                app.Quit();
                if (range != null) Marshal.ReleaseComObject(range);
                if (sheet != null) Marshal.ReleaseComObject(sheet);
                if (wb != null) Marshal.ReleaseComObject(wb);
                if (app != null) Marshal.ReleaseComObject(app);

                range = null;
                sheet = null;
                wb = null;
                app = null;
                GC.Collect();
            }
        }

    }
}
