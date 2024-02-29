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
    public partial class RecordTrackTQCQForm : Form, ILookup
    {
        RecordTrackCQ curr;
        Facade facade =Facade.Instance;
        Dictionary<int, Operator> dicOper = new Dictionary<int, Operator>();
        public RecordTrackTQCQForm()
        {
            InitializeComponent();
            lookupControl1.ButtonLookup.Click += ButtonLookup_Click;
            transactionControl1.Button_Prev.Click += Button_Prev_Click;
            transactionControl1.Button_Next.Click += Button_Next_Click;
            transactionControl1.Button_Edit.Click += Button_Edit_Click;
            transactionControl1.Button_Remove.Click += buttonRemove_Click;
            var list = facade.GetOperators();
            for (int i = 0; i < list.Count; i++)
            {
                dicOper[list[i].Id] = list[i];
            }
            Clear();
        }

        RecordTrackCQ Prev
        {
            get
            {
                return facade.Prev_RecordTrackCQ(curr);
            }
        }
        RecordTrackCQ Next
        {
            get
            {
                return facade.Next_RecordTrackCQ(curr);
            }
        }
        private void Button_Next_Click(object sender, EventArgs e)
        {
            PopulateForm(Next);
        }

        private void Button_Prev_Click(object sender, EventArgs e)
        {
            PopulateForm(Prev);
        }
        private void Button_Edit_Click(object sender, EventArgs e)
        {
            Enable(true);
        }

        private void ButtonLookup_Click(object sender, EventArgs e)
        {
            var f = new OperatorLookupForm(this);
            f.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                RecordTrackCQ o = GetFromForm();
                var curr = this.curr;
                if (curr != null)
                {
                    o.Id = curr.Id;
                    facade.UpdateRecordTrackCQ_Validating(o);
                }
                else
                {
                    facade.AddRecordTrackCQ_Validating(o);
                }
                Clear();

            }
            catch (ValidatingException ex)
            {
                Msg.ShowException(ex);
            }
        }

        Operator Operator
        {
            get
            {
                return lookupControl1.Tag as Operator;
            }
            set
            {
                lookupControl1.Tag = value;                
                if (value == null)
                {
                    lookupControl1.LookupTextBox.Text = string.Empty;
                }
                else
                {
                    lookupControl1.LookupTextBox.Text = value.Name;
                }
            }
        }

        RecordTrackCQ GetFromForm()
        {
            string[] valsNew = textBoxNew.Text.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            string[] valsPend = textBoxPending.Text.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            string[] valsClose = textBoxClose.Text.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            if (Operator == null) throw new ValidatingException("Operator is invalid item!");
            var o = new RecordTrackCQ()
            {
                OperatorId = Operator.Id,
                Date = dateTimePickerDmcDate.Value,
                Monthly = dateTimePickerMonth?.Value?.GetFirstDateOfMonth(),
                Memo = textBoxMemo.Text,
                FileName = textBoxFilename.Text,
                NewPoints = valsNew.GetRangeInt(),
                PendPoints = valsPend.GetRangeInt(),
                ClosePoints = valsClose.GetRangeInt(),
                FileType = comboBoxFileType.SelectedItem+string.Empty,
            };
            return o;
        }


        void Clear()
        {

            curr = null;
            transactionControl1.Button_Next.Enabled = false;
            transactionControl1.Button_Prev.Enabled = Prev != null;
            lookupControl1.LookupTextBox.Text = string.Empty;
            dateTimePickerDmcDate.Value = DateTime.Today;
            dateTimePickerMonth.Value = DateTime.Today;
            comboBoxFileType.SelectedIndex = 0;
            textBoxClose.Text = string.Empty;
            textBoxNew.Text = string.Empty;
            textBoxPending.Text = string.Empty;
            textBoxMemo.Text = string.Empty;
            textBoxFilename.Text = string.Empty;
            grid.Rows.Clear();
            buttonAdd.Text = "Add";
            Enable(true);
        }

        public void PopulateForm(RecordTrackCQ m)
        {
            if (m == null)
            {
                Clear();
                return;
            }
            curr = m;
            Operator = dicOper.ContainsKey(m.OperatorId) ? dicOper[m.OperatorId] : null;
            textBoxMemo.Text = m.Memo;
            dateTimePickerDmcDate.Value = m.Date;
            dateTimePickerMonth.Value = m.Monthly;
            textBoxFilename.Text = m.FileName;
            textBoxNew.Text = m.NewPoints.GetStrRange();
            textBoxPending.Text = m.PendPoints.GetStrRange();
            textBoxClose.Text = m.ClosePoints.GetStrRange();
            transactionControl1.Button_Prev.Enabled = Prev != null;
            transactionControl1.Button_Next.Enabled = true;
            buttonAdd.Text = "Update";
            Enable(false);

        }

        void AddGridOperator(Operator o)
        {
            grid.Rows.Clear();
            var list = facade.GetLast5RecordTrackCQs(o.Id);
            foreach (RecordTrackCQ m in list)
            {
                int index = grid.Rows.Add();
                grid.Rows[index].Cells[ColumnDate.Name].Value = m.Date.ToString("dd-MMM-yyyy");
                grid.Rows[index].Cells[ColumnNew.Name].Value = m.NewPoints.GetStrRange();
                grid.Rows[index].Cells[ColumnPending.Name].Value = m.PendPoints.GetStrRange();
                grid.Rows[index].Cells[ColumnClose.Name].Value = m.ClosePoints.GetStrRange();
                grid.Rows[index].Tag = m;
            }
        }

        void Enable(bool enable)
        {
            lookupControl1.Enabled = enable;
            this.comboBoxFileType.Enabled = enable;
            textBoxMemo.ReadOnly = !enable;
            textBoxFilename.ReadOnly = !enable;
            textBoxPending.ReadOnly = !enable;
            textBoxNew.ReadOnly = !enable;
            textBoxClose.ReadOnly = !enable;
            dateTimePickerDmcDate.Enabled = enable;
            dateTimePickerMonth.Enabled = enable;
            buttonAdd.Enabled = enable;
        }
        public void Lookup(object o)
        {
            if (o is Operator op)
            {
                Operator = op;
                AddGridOperator(Operator);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (Msg.ShowDelete() != DialogResult.Yes) return;
                if (curr == null) throw new ValidatingException("Item does not exist!");
                facade.RemoveRecordTrackCQ_Validating(curr.Id);
                Clear();
            }
            catch(ValidatingException ex)
            {
                Msg.ShowException(ex);
            }
        }
    }
}
