using Mail_Recorder_App.DAO;
using System;
using System.Windows.Forms;

namespace Mail_Recorder_App
{
    public partial class RecordMailEnquiryForm : Form
    {
        Facade facade => Facade.Instance;
        public RecordMailEnquiryForm()
        {
            InitializeComponent();
            comboBoxType.Items.Add("");
            comboBoxType.Items.AddRange(facade.GetOperatorTypes());
            comboBoxOperator.Items.Add(new Operator()
            {
                Id = -1,
                Name = ""
            });
            var ops = facade.GetOperators();
            ops.Sort((x, y) => string.CompareOrdinal(x.Name, y.Name));
            comboBoxOperator.Items.AddRange(ops.ToArray());
            comboBoxOperator.DisplayMember = "Name";
        }



        private void buttonRun_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.OpenQuickReport<RecordMailQuickReportForm>(new RecordMailQuickReportImp(Param));
            }
            catch(ValidatingException ex)
            {
                Msg.ShowException(ex);
            }
        }

        RecordMailEnquiryParam Param
        {
            get
            {
                string type = comboBoxType.SelectedItem as string;
                DateTime from = dateTimePickerFrom.Value.Date;
                DateTime to = dateTimePickerTo.Value.Date;
                if (from > to) throw new ValidatingException("Invalid date range selected");
                int idOperator = -1;
                if (comboBoxOperator.SelectedItem != null)
                {
                    idOperator = ((Operator)comboBoxOperator.SelectedItem).Id;
                }
                var param= new RecordMailEnquiryParam()
                {
                   From = from,
                   To = to,
                   Type = type,
                   OperatorId = idOperator
                };
                return param;
            }
        }
    }
}
