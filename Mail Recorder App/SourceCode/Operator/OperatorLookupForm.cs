using Mail_Recorder_App.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Recorder_App
{
    public partial class OperatorLookupForm : Form
    {
        Facade facade => Facade.Instance;
        ILookup ilookup;
        static List<Operator> op = new List<Operator>();
        static int indexRemeber = 0;
        public OperatorLookupForm(ILookup ilookup)
        {
            InitializeComponent();
            this.ilookup = ilookup;
        }

        private void OperatorLookupForm_Load(object sender, EventArgs e)
        {
            if (!op.Any()) op.AddRange(facade.GetOperators());
            op.Sort((x,y)=>string.CompareOrdinal(x.Name,y.Name));
            foreach(var o in op)
            {
                if(ilookup.GetType() != typeof(ManageOperatorForm))
                {
                    if (o.Status == "Deactive") continue;
                }

                var index = grid.Rows.Add();
                var row = grid.Rows[index];
                row.Cells[ColumnName.Name].Value = o.Name;
                row.Cells[ColumnType.Name].Value = o.Type;
                row.Cells[ColumnStatus.Name].Value = o.Status;

                grid.Rows[index].Tag = o;
            }
            grid.Rows[indexRemeber].Selected = true;
        }
        void DropItem()
        {
            if (grid.SelectedRows.Count > 1) return;
            DialogResult = DialogResult.OK;
            var op = grid.SelectedRows[0].Tag as Operator;
            ilookup.Lookup(facade.GetOperator(op.Id));
        }
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            DropItem();
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DropItem();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape | Keys.Shift))
            {
                op.Clear();
                Close();
                return true;
            }
            else if(keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            else if (keyData == Keys.Enter)
            {
                DropItem();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void grid_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach(DataGridViewRow row in grid.Rows)
            {
                var op = row.Tag as Operator;
                if (!op.Name.ToLower().StartsWith(Char.ToString(e.KeyChar))) continue;
                row.Selected = true;
                grid.FirstDisplayedScrollingRowIndex = row.Index;
                break;
            }
        }

        private void OperatorLookupForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (grid.SelectedRows.Count > 1) return;
            DialogResult = DialogResult.OK;
            var op = grid.SelectedRows[0].Tag as Operator;
            var f = Form1.OpenForm<ManageOperatorForm>();
            f.Lookup(facade.GetOperator(op.Id));
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            var fileDialog = new SaveFileDialog();
            fileDialog.Filter = ".xlsx Files (*.xlsx)|*.xlsx";
            DateTime today = DateTime.Today;
            fileDialog.FileName = string.Format($"{today.Year}_{today.Month}_{today.Day}_Operators");
            if (fileDialog.ShowDialog() != DialogResult.OK) return;
            var excelMgr = new ExcelManager();
            excelMgr.ExportExcel(fileDialog.FileName, grid.ToDataTable());
            if (MessageBox.Show("Do you want to open the file?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != DialogResult.Yes) return;
            System.Diagnostics.Process.Start(fileDialog.FileName);
        }
    }
}
