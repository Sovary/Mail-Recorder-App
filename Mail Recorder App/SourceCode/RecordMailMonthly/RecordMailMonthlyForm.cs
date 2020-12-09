using Mail_Recorder_App.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Recorder_App
{
    public partial class RecordMailMonthlyForm : Form
    {
        
        RecordMailMonthly curr;
        Facade facade => Facade.Instance;
        Dictionary<int, Operator> dicOper = new Dictionary<int, Operator>();
        public RecordMailMonthlyForm()
        {
            InitializeComponent();
            transactionControl1.Button_Prev.Click += Button_Prev_Click;
            transactionControl1.Button_Next.Click += Button_Next_Click;
            transactionControl1.Button_Edit.Visible = false;
            transactionControl1.Button_Remove.Click += Button_Remove_Click;
            dicOper = facade.GetOperators().ToDictionary(p => p.Id);
            labelDateRange.Text = string.Empty;
            Clear();
        }

        private void Button_Remove_Click(object sender, EventArgs e)
        {
            if (Msg.ShowDelete() != DialogResult.Yes) return;
            try
            {
                if (curr == null) throw new ValidatingException("Invalid item");
                facade.RemoveRecordMailMonthly_Validating(curr.Id);
                Clear();
            }
            catch (ValidatingException ex)
            {
                Msg.ShowException(ex);
            }
        }

        private void Button_Edit_Click(object sender, EventArgs e)
        {
            Enable(true);
        }

        private void Button_Next_Click(object sender, EventArgs e)
        {
            PopulateForm(Next);
        }

        private void Button_Prev_Click(object sender, EventArgs e)
        {
            PopulateForm(Prev);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                facade.AddRecordMailMonthly_Validating(GetFromForm());
                Clear();
            }
            catch(ValidatingException ex)
            {
                Msg.ShowException(ex);
            }
        }

        public void PopulateForm(RecordMailMonthly m)
        {
            if (m == null)
            {
                Clear();
                return;
            }
            
            curr = m;
            textBoxMemo.Text = m.Memo;
            dateTimePickerMonth.Value = m.Monthly;
            dateTimePickerDate.Value = m.Date;
            transactionControl1.Button_Prev.Enabled = Prev != null;
            transactionControl1.Button_Next.Enabled = true;
            RecordMails = m.RecordMails;
            Enable(false);

        }

        private void Clear()
        {
            curr = null;
            transactionControl1.Button_Next.Enabled = false;
            transactionControl1.Button_Prev.Enabled = Prev != null;
            dateTimePickerDate.Value = DateTime.Today;
            dateTimePickerMonth.Value = DateTime.Today;
            textBoxMemo.Text = string.Empty;
            RecordMails = null;
            Enable(true);
        }

        RecordMailMonthly GetFromForm()
        {
            var r = new RecordMailMonthly()
            {
                Monthly = dateTimePickerMonth.Value.Date.GetFirstDateOfMonth(),
                Date = dateTimePickerDate.Value.Date,
                Memo = textBoxMemo.Text,
                RecordMails = RecordMails
            };
            return r;
        }

        RecordMailMonthly Prev=> facade.Prev_RecordMailMonthly(curr);
        RecordMailMonthly Next => facade.Next_RecordMailMonthly(curr);

        private void RecordMailForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            PopulateForm(Prev);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            PopulateForm(Next);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Enable(bool enable)
        {
            textBoxMemo.ReadOnly = !enable;
            dateTimePickerMonth.Enabled = enable;
            dateTimePickerDate.Enabled = enable;
            buttonRefresh.Enabled = enable;
            buttonAdd.Enabled = enable;
        }
        List<RecordMail> RecordMails
        {
            get
            {
                var list = new List<RecordMail>();
                foreach(DataGridViewRow row in grid.Rows)
                {
                    if (!(row.Tag is RecordMail r)) continue;
                    list.Add(r);
                }
                return list;
            }
            set
            {
                grid.Rows.Clear();
                labelDateRange.Text = string.Empty;
                if (value?.Any() != true) return;
                DateTime from = value.Select(p=>p.Date).Min();
                DateTime to = value.Select(p => p.Date).Max();
                var period = new MonthlyPeriod()
                {
                    From = from,
                    To = to,
                };
                labelDateRange.Text = $"Period: [{period}]";
                foreach (RecordMail m in value)
                {
                    int index = grid.Rows.Add();
                    grid.Rows[index].Cells[ColumnNo.Name].Value = index + 1;
                    if (dicOper.TryGetValue(m.OperatorId, out Operator op))
                        grid.Rows[index].Cells[ColumnOperator.Name].Value = op.Name;
                    if (dicOper.TryGetValue(m.OperatorSendId, out Operator send))
                        grid.Rows[index].Cells[ColumnSender.Name].Value = send.Name;
                    grid.Rows[index].Cells[ColumnDate.Name].Value = m.Date.ToString("dd-MMM-yyyy");
                    grid.Rows[index].Cells[ColumnDetail.Name].Value = m.Detail;
                    grid.Rows[index].Tag = m;
                }
                
            }
        }


        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grid.CellDoubleClick -= grid_CellDoubleClick;
            if (e.RowIndex < 0) return;
            var r = grid.Rows[e.RowIndex].Tag as RecordMail;
            if (r is null) return;
            RecordMailForm f= Form1.OpenForm<RecordMailForm>();
            f.PopulateForm(facade.GetRecordMail(r.Id));
            grid.CellDoubleClick += grid_CellDoubleClick;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            buttonRefresh.Click -= buttonRefresh_Click;
            var list = facade.GetRecordMailsInMonth(dateTimePickerMonth.Value);
            RecordMails = list.ToList();
            dateTimePickerMonth.Enabled = false;
            buttonRefresh.Enabled = false;
            buttonRefresh.Click += buttonRefresh_Click;
        }
    }
}
