using Mail_Recorder_App.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Recorder_App
{
    public partial class ImportRecordMailForm : Form
    {
        string path;
        Facade facade => Facade.Instance;
        public ImportRecordMailForm()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            var open =new OpenFileDialog();
            open.Filter = "Excel 97-2003 (*.xls) | *.xls;";
            if (open.ShowDialog() != DialogResult.OK) return;
            path = open.FileName;
            textBox1.Text = path;
        }

        List<RecordMail> GetExcel()
        {
            if (string.IsNullOrWhiteSpace(path)) return null;
            Dictionary<string, Operator> dicOperators = facade.GetOperators().ToDictionary(p => p.Name.ToLower());
            var mails = new List<RecordMail>();
            var excelmgr = new ExcelManager();
            DataTable dt = excelmgr.ReadExcel(path);
            foreach(DataRow dr in dt.Rows)
            {
                string op = $"{dr["operator"]}".ToLower();
                string send = $"{dr["sender"]}".ToLower();
                string detail = $"{dr["detail"]}";
                if (!dicOperators.ContainsKey(op))
                {
                    throw new ValidatingException($"operator {op} not found");
                }
                if (!dicOperators.ContainsKey(send))
                {
                    throw new ValidatingException($"sender {send} not found");
                }

                DateTime date;
                if (!DateTime.TryParse($"{dr["date"]:dd-MMM-yyyy}", out date))
                {
                    throw new ValidatingException($"Invalid date format! on row operator {op}");
                }
                var rec = new RecordMail()
                {
                    OperatorId = dicOperators[op].Id,
                    OperatorSendId = dicOperators[send].Id,
                    Detail = detail,
                    Date = date,
                };
                mails.Add(rec);
            }
            return mails;
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            try
            {
                var excels = GetExcel();
                if (excels?.Any() != true) throw new ValidatingException("No data to import!");
                excels.Sort((x, y) => x.Date.Date.CompareTo(y.Date.Date));
                facade.ImportRecordMails_Validating(excels.ToArray());
                MessageBox.Show($"Import {excels.Count} items completed");
            }
            catch (ValidatingException ex)
            {
                Msg.ShowException(ex);
            }
        }
    }
}
