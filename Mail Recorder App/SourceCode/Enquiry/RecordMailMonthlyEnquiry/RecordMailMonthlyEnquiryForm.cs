using Mail_Recorder_App.DAO;
using System;
using System.Windows.Forms;

namespace Mail_Recorder_App
{
    public partial class RecordMailMonthlyEnquiryForm : Form
    {
        Facade facade => Facade.Instance;
        public RecordMailMonthlyEnquiryForm()
        {
            InitializeComponent();
            comboBoxType.Items.Add("");
            comboBoxType.Items.AddRange(facade.GetOperatorTypes());
            comboBoxReportType.SelectedIndex = 0;
        }
        private void buttonRun_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxReportType.SelectedIndex == 1)
                {
                    Form1.OpenQuickReport<RecordMailCQSummaryQuickReportForm>(new RecordMailCQSummaryQuickReportImp(Param));
                }
                else
                {
                    Form1.OpenQuickReport<RecordMailQuickReportForm>(new RecordMailMonthlyQuickReportImp(Param));
                }
            }
            catch(ValidatingException ex)
            {
                Msg.ShowException(ex);
            }
        }

        RecordMailMonthlyEnquiryParam Param
        {
            get
            {
                string type = comboBoxType.SelectedItem as string;
                DateTime month = dateTimePickerMonth.Value;
                var param= new RecordMailMonthlyEnquiryParam()
                {
                   Type = type,
                   Month = month,
                };
                return param;
            }
        }
    }
}
