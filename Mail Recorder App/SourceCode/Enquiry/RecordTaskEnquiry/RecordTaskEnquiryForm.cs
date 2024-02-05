using Mail_Recorder_App.DAO;
using System;
using System.Windows.Forms;

namespace Mail_Recorder_App
{
    public partial class RecordTaskEnquiryForm : Form
    {
        Facade facade => Facade.Instance;
        public RecordTaskEnquiryForm()
        {
            InitializeComponent();
            comboBoxOperator.Items.Add(new Operator()
            {
                Id = -1,
                Name = ""
            });
            var ops = facade.GetOperators();
            ops.Sort((x, y) => string.CompareOrdinal(x.Name, y.Name));
            comboBoxOperator.Items.AddRange(ops.ToArray());
            comboBoxOperator.DisplayMember = "Name";
            foreach (var g in Enum.GetValues(typeof(RecordTaskEnquiryParam.Sorted)))
            {
                comboBoxGroupby.Items.Add(g);
            }
            comboBoxGroupby.SelectedItem = RecordTaskEnquiryParam.Sorted.Default;
        }
        private void buttonRun_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.OpenQuickReport<RecordTaskEnquiryQuickReportForm>(new RecordTaskQuickReportImp(Param));
            }
            catch(ValidatingException ex)
            {
                Msg.ShowException(ex);
            }
        }

        RecordTaskEnquiryParam Param
        {
            get
            {
                int idOperator = -1;
                if (comboBoxOperator.SelectedItem != null)
                {
                    idOperator = ((Operator)comboBoxOperator.SelectedItem).Id;
                }

                var param= new RecordTaskEnquiryParam()
                {
                   OperatorId = idOperator,
                   Group = (RecordTaskEnquiryParam.Sorted)comboBoxGroupby.SelectedItem,
                   From = dateTimePickerFrom.Value,
                   To = dateTimePickerTo.Value,
                };
                if (param.From > param.To) throw new ValidatingException("Invalid date range!");
                if(radioButtonAll.Checked)
                    param.State = RecordTaskEnquiryParam.Status.All;
                else if(radioButtonDone.Checked)
                    param.State = RecordTaskEnquiryParam.Status.Done;
                else
                    param.State = RecordTaskEnquiryParam.Status.Undone;
                return param;
            }
        }
    }
}
