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
    public partial class RecordTaskForm : Form, ILookup
    {
        Facade facade => Facade.Instance;
        Dictionary<int, Operator> dicOper = new Dictionary<int, Operator>();
        RecordTask curr = null;
        public RecordTaskForm()
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
            transactionControl1.Button_Prev.Visible = transactionControl1.Button_Next.Visible = false;
        }
        private void Button_Next_Click(object sender, EventArgs e)
        {
            //PopulateForm(Next);
        }

        private void Button_Prev_Click(object sender, EventArgs e)
        {
            //PopulateForm(Prev);
        }
        private void Button_Edit_Click(object sender, EventArgs e)
        {
            Enable(true);
        }

        private void ButtonLookup_Click(object sender, EventArgs e)
        {
            Form1.OpenForm<OperatorLookupForm>(this);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {

                var o = GetFromForm();
                if (curr == null)
                {
                    facade.AddRecordTask_Validating(o);
                }
                else
                {
                    o.Id = curr.Id;
                    facade.UpdateRecordTask_Validating(o);
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

        RecordTask GetFromForm()
        {
            if (Operator == null) throw new ValidatingException("Operator is invalid item!");
            var o = new RecordTask()
            {
                Subject = textBoxSubject.Text,
                Description = textBoxDescription.Text,
                TaskDate = dateTimePickerTaskDate.Value,
                MeetDate = dateTimePickerMeet.Value,
                OperatorId = Operator.Id,
                LastFollowupDate = dateTimePickerDmcLastFollowupDate?.Value,
                IsDone = checkBoxIsDone.Checked,
                DoneDate = dateTimePickerDmcDoneDate.Value,
                NextTaskDate = dateTimePickerDmcNextTask.Value,
                FollowupDescription= textBoxFollowupDescription.Text,
                Memo1 = textBoxMemo1.Text,
                Memo2 = textBoxMemo2.Text,
            };
            return o;
        }


        void Clear()
        {
            curr = null;
            lookupControl1.LookupTextBox.Text = string.Empty;
            dateTimePickerTaskDate.Value = DateTime.Today;
            textBoxDescription.Text = string.Empty;
            textBoxSubject.Text = string.Empty;
            Operator = null;
            checkBoxIsDone.Checked = false;
            dateTimePickerDmcLastFollowupDate.Value = null;
            dateTimePickerDmcDoneDate.Value = null;
            textBoxFollowupDescription.Text = string.Empty;
            textBoxMemo1.Text = textBoxMemo2.Text = string.Empty;
            grid.Rows.Clear();
            buttonAdd.Text = "Add";
            Enable(true);
        }

        public void PopulateForm(RecordTask m)
        {
            if (m == null)
            {
                Clear();
                return;
            }
            curr = m;
            Operator = dicOper.ContainsKey(m.OperatorId) ? dicOper[m.OperatorId] : null;
            textBoxSubject.Text = m.Subject;
            textBoxDescription.Text = m.Description;
            dateTimePickerMeet.Value = m.MeetDate;
            dateTimePickerTaskDate.Value = m.TaskDate;

            dateTimePickerDmcLastFollowupDate.Value = m.LastFollowupDate;
            checkBoxIsDone.Checked = m.IsDone;
            dateTimePickerDmcDoneDate.Value = m.DoneDate;
            textBoxFollowupDescription.Text = m.FollowupDescription;
            dateTimePickerDmcNextTask.Value = m.NextTaskDate;
            textBoxMemo1.Text = m.Memo1;
            textBoxMemo2.Text = m.Memo2;
            buttonAdd.Text = "Update";
            Enable(false);
        }
        public void Lookup(object o)
        {
            if (o is Operator op)
            {
                Operator = op;
                AddGridOperator(op);
            }
        }

        void AddGridOperator(Operator o)
        {
            grid.Rows.Clear();
            var list = facade.GetLast5RecordTasks(o.Id);
            foreach (var m in list)
            {
                DateTime lastDate = m.NextTaskDate.HasValue ? m.NextTaskDate.Value : m.TaskDate;
                int index = grid.Rows.Add();
                grid.Rows[index].Cells["ColumnTaskDate"].Value = lastDate.ToString("dd-MMM-yyyy");
                grid.Rows[index].Cells["ColumnTaskDescription"].Value = m.Description;
                grid.Rows[index].Cells["ColumnDone"].Value = m.IsDone;
                grid.Rows[index].Tag = m;
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
                if (curr == null) throw new ValidatingException("Invalid item");
                facade.RemoveRecordTask_Validating(curr.Id);
                Clear();
            }
            catch(ValidatingException ex)
            {
                Msg.ShowException(ex);
            }
        }

        void Enable(bool enable)
        {
            lookupControl1.Enabled = enable;
            textBoxSubject.ReadOnly = !enable;
            textBoxDescription.ReadOnly = !enable;
            dateTimePickerDmcLastFollowupDate.Enabled = enable;
            dateTimePickerTaskDate.Enabled = enable;
            checkBoxIsDone.Enabled = enable;
            dateTimePickerDmcDoneDate.Enabled = enable;
            buttonAdd.Enabled = enable;
            textBoxFollowupDescription.ReadOnly = !enable;
            textBoxMemo1.ReadOnly = !enable;
            textBoxMemo2.ReadOnly = !enable;
            dateTimePickerMeet.Enabled = enable;
            dateTimePickerDmcNextTask.Enabled = enable;
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var m = grid.Rows[e.RowIndex].Tag as RecordTask;
            PopulateForm(m);
        }
    }
}
