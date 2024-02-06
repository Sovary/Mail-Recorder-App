using Mail_Recorder_App.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Recorder_App
{
    public partial class FileTransferCheckingForm : Form
    {
        public FileTransferCheckingForm()
        {
            InitializeComponent();
            textBoxLocation.Text = Path;
        }
        private string path;
        string Path { 
            get
            {
                return ConfigurationManager.AppSettings.Get("FileTransferCheckPath");
            }
            set { path = value; }
        }
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            var open = new FolderBrowserDialog();
            if (open.ShowDialog() != DialogResult.OK) { return; }
            Path = open.SelectedPath;
            textBoxLocation.Text = Path;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            try
            {
                grid.Rows.Clear();
                if (string.IsNullOrEmpty(Path)) throw new ValidatingException("Path is empty");
                var dirs = Directory.GetDirectories(Path);
                foreach (var dir in dirs)
                {
                    string op_name = new DirectoryInfo(dir).Name;
                    string path_cust = string.Empty;
                    string[] list_suffix = radioButtonCust_Info.Checked ? textBoxCustomerInfo.Text.Split(',') 
                        : textBoxUpstream.Text.Split(',');

                    var funct = new Action<string, string>((name, sufix) =>
                    {
                        foreach (string suffix in list_suffix)
                        {
                            var folder = Directory.GetDirectories(dir)
                            .Where(p => p.Contains(suffix.Trim()) && p.Contains(sufix))
                            .LastOrDefault();
                            if (folder == null) continue;
                            path_cust = folder; break;
                        }

                        int index = grid.Rows.Add();
                        var row = grid.Rows[index];
                        row.Cells[ColumnNo.Name].Value = index + 1;
                        row.Cells[ColumnOperator.Name].Value = name;
                        if (string.IsNullOrEmpty(path_cust)) return;

                        var fileInfo = new DirectoryInfo(path_cust).GetFiles()
                        .Where(p=>p.Name.ToLower().EndsWith(".xls")
                        || p.Name.ToLower().EndsWith(".xlsx")
                        || p.Name.ToLower().EndsWith(".csv"))
                        .OrderByDescending(p => p.LastWriteTime)
                        .FirstOrDefault();

                        string filename = fileInfo?.Name + string.Empty;
                        row.Cells[ColumnFilename.Name].Value = filename;
                        
                        Match match = new Regex(@"(\d{4})(\d{2})").Match(filename);
                        if (match.Success)
                        {
                            // Extract year and month from the matched groups
                            int year = int.Parse(match.Groups[1].Value);
                            int month = int.Parse(match.Groups[2].Value);
                            string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(month);

                            // Output the formatted month and year
                            string formattedDate = $"{monthName}-{year}";
                            row.Cells[ColumnMonth.Name].Value = formattedDate;
                        }

                        row.Cells[ColumnDate.Name].Value = fileInfo?.LastWriteTime + string.Empty;
                        row.Cells[ColumnSize.Name].Value = string.Format("{0} KB", Math.Ceiling(Convert.ToDecimal(fileInfo?.Length / 1024)));
                    });

                    if(op_name.Contains("telcotech"))
                    {
                        funct("telcotech", "_tt");
                        funct("ezecom", "_ez");
                    }
                    else
                    {
                        funct(op_name,string.Empty);
                    }    
                    
                }
            }
            catch (ValidatingException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            var fileDialog = new SaveFileDialog();
            fileDialog.Filter = ".xlsx Files (*.xlsx)|*.xlsx";
            DateTime today = DateTime.Today;
            fileDialog.FileName = string.Format($"{today.Year}_{today.Month}_{today.Day}_FileTransfer");
            if (fileDialog.ShowDialog() != DialogResult.OK) return;
            var excelMgr = new ExcelManager();
            excelMgr.ExportExcel(fileDialog.FileName, grid.ToDataTable());
            if (MessageBox.Show("Do you want to open the file?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes) return;
            System.Diagnostics.Process.Start(fileDialog.FileName);
        }
    }
}
