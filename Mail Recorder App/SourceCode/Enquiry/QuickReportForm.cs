using Mail_Recorder_App.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Recorder_App
{
    public partial class QuickReportForm : Form
    {
        private IQuickReport quickReport;
        public QuickReportForm(IQuickReport q)
        {
            InitializeComponent();
            this.quickReport = q;
            this.Text = q.FormCaption;
            gradientControl1.Title = q.FormCaption;
            
        }
        
        private void QuickReportForm_Load(object sender, EventArgs e)
        {
            var style = new DataGridViewCellStyle()
            {
                Font = new Font("Tahoma", 10F, System.Drawing.FontStyle.Bold),
                BackColor = SystemColors.GrayText,
            };
            
            for (int i = 0; i < quickReport.Columns.Length; i++)
            {
                ColumnGrid col = quickReport.Columns[i];
                var gridCol = new DataGridViewColumn()
                {
                    Name = col.Name,
                    HeaderText = col.Title,
                    ValueType = col.Type,
                    Width = col.Width,
                    SortMode = DataGridViewColumnSortMode.Automatic,
                };
                if(col.Type == typeof(bool))
                {
                    gridCol.CellTemplate = new DataGridViewCheckBoxCell();
                }
                else
                {
                    gridCol.CellTemplate = new DataGridViewTextBoxCell();
                }
                grid.Columns.Add(gridCol);
            }
            grid.ColumnHeadersDefaultCellStyle = style;
            grid.Columns[grid.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            quickReport.OnPublishGrid(grid);
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            quickReport.OnGridDrillDown(e, grid.Rows[e.RowIndex]);
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            var fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Excel 97-2003(*.xls)|*.xls";
            if (fileDialog.ShowDialog() != DialogResult.OK) return;
            var excelMgr = new ExcelManager();
            excelMgr.ExportExcel(fileDialog.FileName, grid.ToDataTable());
            if(MessageBox.Show("Do you want to open the file?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information)!= DialogResult.Yes)return;
            System.Diagnostics.Process.Start(fileDialog.FileName);
        }

        public DataGridView Grid { get => grid; }
    }

    
}
