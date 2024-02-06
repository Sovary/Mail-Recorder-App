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
    public partial class RecordMailForm : Form, ILookup
    {
        Setting setting;
        
        Operator DMC;
        RecordMail curr;
        Facade facade => Facade.Instance;
        Dictionary<int, Operator> dicOper = new Dictionary<int, Operator>();
        public RecordMailForm()
        {
            InitializeComponent();
            lookupControl1.ButtonLookup.Click += ButtonLookup_Click;
            lookupControl1.LookupTextBox.DoubleClick += ButtonLookup_Click;
            transactionControl1.Button_Prev.Click += Button_Prev_Click;
            transactionControl1.Button_Next.Click += Button_Next_Click;
            transactionControl1.Button_Edit.Click += Button_Edit_Click;
            transactionControl1.Button_Remove.Click += Button_Remove_Click;
            var list = facade.GetOperators();
            for(int i = 0; i < list.Count; i++)
            {
               if (list[i].Name == "DMC") DMC = list[i];
                dicOper[list[i].Id] = list[i];
              //  comboBoxSender.Items.Add(list[i]);
            }
            comboBoxSender.DisplayMember = "Name";
            setting = facade.GetSetting();
            Clear();
        }

        private void Button_Remove_Click(object sender, EventArgs e)
        {
            if (Msg.ShowDelete() != DialogResult.Yes) return;
            try
            {
                if (curr == null) throw new ValidatingException("Invalid item");
                facade.RemoveRecordMail(curr.Id);
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

        private void ButtonLookup_Click(object sender, EventArgs e)
        {
            Form1.OpenForm<OperatorLookupForm>(this);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var r = GetFromForm();
                if (curr == null)
                {
                    facade.AddRecordMail_Validating(FileInMemory, r);
                }
                else
                {
                    r.Id = curr.Id;
                    r.Attach = curr.Attach;
                    facade.UpdateRecordMail_Validating(FileInMemory, r);
                }
                Clear();
            }
            catch(ValidatingException ex)
            {
                Msg.ShowException(ex);
            }
        }

        public void PopulateForm(RecordMail m)
        {
            if (m == null)
            {
                Clear();
                return;
            }
            
            curr = m;
            Operator = dicOper.ContainsKey(m.OperatorId) ? dicOper[m.OperatorId] : null ;
            textBoxDetail.Text = m.Detail;
            textBoxMemo.Text = m.Memo;
            dateTimePickerDmcDate.Value = m.Date;
            dateTimePickerMonth.Value = m.Monthly;
            transactionControl1.Button_Prev.Enabled = Prev != null;
            transactionControl1.Button_Next.Enabled = true;
            checkBoxCQ.Checked = m.IsCQ;
            textBoxNew.Text = m.NewPoints;
            textBoxPending.Text = m.PendingPoints;
            textBoxAnalyze.Text = m.AnalyzePoints;
            textBoxClose.Text = m.ClosePoints;
            buttonAdd.Text = "Update";
            if (dicOper.ContainsKey(m.OperatorSendId))
            {
                comboBoxSender.SelectedItem = dicOper[m.OperatorSendId];
            }
            else
            {
                comboBoxSender.SelectedIndex = -1;
            }
            Enable(false);

        }

        private void Clear()
        {
            curr = null;
            transactionControl1.Button_Next.Enabled = false;
            transactionControl1.Button_Prev.Enabled = Prev != null;
            Operator = null;
            comboBoxSender.SelectedIndex = -1;
            textBoxDetail.Text = string.Empty;
            textBoxMemo.Text = string.Empty;
            dateTimePickerMonth.Value = setting is null? DateTime.Today: setting.RecMailMonthly;
            dateTimePickerDmcDate.Value = DateTime.Now;
            checkBoxCQ.Checked = false;
            buttonAdd.Text = "Add";
            grid.Rows.Clear();
            FileInMemory.Clear();
            textBoxNew.Text = string.Empty;
            textBoxPending.Text = string.Empty;
            textBoxAnalyze.Text = string.Empty;
            textBoxClose.Text = string.Empty;
            Enable(true);
        }

        RecordMail GetFromForm()
        {
            if (comboBoxSender.SelectedItem ==null) throw new ValidatingException("Selected invalid item!");
            if (Operator == null) throw new ValidatingException("Operator is invalid item!");
            if(curr!=null)
            {
                if (curr.Date.Month != dateTimePickerDmcDate.Value.Month 
                    || curr.Date.Year != dateTimePickerDmcDate.Value.Year)
                    throw new ValidatingException("Cannot change month or year!");
            }
            return new RecordMail()
            {
                Monthly = dateTimePickerMonth?.Value?.GetFirstDateOfMonth(),
                Date = dateTimePickerDmcDate.Value,
                Detail = textBoxDetail.Text,
                Memo = textBoxMemo.Text,
                OperatorId = Operator.Id,
                IsCQ = checkBoxCQ.Checked,
                OperatorSendId = ((Operator)(comboBoxSender.SelectedItem)).Id,
                NewPoints = textBoxNew.Text+string.Empty,
                PendingPoints = textBoxPending.Text+string.Empty,
                AnalyzePoints = textBoxAnalyze.Text+string.Empty,
                ClosePoints = textBoxClose.Text+string.Empty,
            };
        }
        
        RecordMail Prev
        {
            get
            {
                return facade.Prev_RecordMail(curr);
            }
        }
        RecordMail Next
        {
            get
            {
                return facade.Next_RecordMail(curr);
            }
        }

        private void RecordMailForm_Load(object sender, EventArgs e)
        {

            //await Task.Run(() =>
            // {
            //for (int j = 0; j < 3; j++)
            //{
            //    var list = new List<RecordMail>();
            //    for (int i = 0; i < 4000; i++)
            //    {
            //        var ran = new Random();
            //        var x = new RecordMail()
            //        {
            //            Date = new DateTime(2021, 1, 1).AddDays(i),
            //            Detail = $"Test loop {i}",
            //            OperatorId = ran.Next(3, 4),
            //            OperatorSendId = new Random().Next(1, 4),
            //        };
            //        list.Add(x);

            //    }
            //    facade.ImportRecordMails_Validating(list.ToArray());
            //}
            //MessageBox.Show("Done");
            // });

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Enable(bool enable)
        {
            lookupControl1.Enabled = enable;
            this.comboBoxSender.Enabled = enable;
            textBoxDetail.ReadOnly = !enable;
            textBoxMemo.ReadOnly = !enable;
            dateTimePickerDmcDate.Enabled = enable;
            dateTimePickerMonth.Enabled = enable;
            buttonAdd.Enabled = enable;
            buttonAttachment.Enabled = enable;
            checkBoxCQ.Enabled = enable;
            textBoxNew.ReadOnly = !enable;
            textBoxPending.ReadOnly = !enable;
            textBoxAnalyze.ReadOnly = !enable;
            textBoxClose.ReadOnly = !enable;
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
                comboBoxSender.Items.Clear();
                if (value == null)
                {
                    lookupControl1.LookupTextBox.Text = string.Empty;
                }
                else
                {
                    lookupControl1.LookupTextBox.Text = value.Name;
                    if(DMC!=null) comboBoxSender.Items.Add(DMC);
                    if (dicOper.ContainsKey(value.Id))
                    {
                        comboBoxSender.Items.Add(dicOper[value.Id]);
                    }
                }
            }
        }
        public void Lookup(object o)
        {
            if (o is Operator)
            {
                Operator = (Operator)o;
                AddGridOperator(Operator);
            }
        }


        void AddGridOperator(Operator o)
        {
            grid.Rows.Clear();
            var list = facade.GetLast5RecordMails(o.Id);
            foreach (RecordMail m in list)
            {
                int index= grid.Rows.Add();
                grid.Rows[index].Cells["ColumnDate"].Value = m.Date.ToString("dd-MMM-yyyy");
                grid.Rows[index].Cells["ColumnDetail"].Value = m.Detail;
                grid.Rows[index].Tag = m;
            }
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var m = grid.Rows[e.RowIndex].Tag as RecordMail;
            PopulateForm(m);
        }
        List<AttachHelp> FileInMemory = new List<AttachHelp>();
        private void buttonAttachment_Click(object sender, EventArgs e)
        {
            var temp = new List<AttachHelp>();
            if (curr?.Attach != null)
            {
                foreach (var att in curr.Attach)
                {
                    var atthelp = new AttachHelp()
                    {
                        Attach = att,
                        Todo = AttachHelp.State.NA,
                    };
                    temp.Add(atthelp);
                }
            }
            if(FileInMemory.Any())
            {
                temp.AddRange(FileInMemory);
            }
            var attachForm = new AttachmentForm(temp);
            if (attachForm.ShowDialog() != DialogResult.OK) return;
            if(attachForm.HelperAttachments.Any())
            {
                FileInMemory.Clear();
                FileInMemory.AddRange(attachForm.HelperAttachments);
            }
        }

        private void checkBoxCQ_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
