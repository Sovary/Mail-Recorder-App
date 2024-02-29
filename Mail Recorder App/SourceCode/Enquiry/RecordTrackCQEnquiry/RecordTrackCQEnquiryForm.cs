using Mail_Recorder_App.DAO;
using System;
using System.Windows.Forms;

namespace Mail_Recorder_App
{
    public partial class RecordTrackCQEnquiryForm : Form
    {
        Facade facade => Facade.Instance;
        public RecordTrackCQEnquiryForm()
        {
            InitializeComponent();
        }
        private void buttonRun_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.OpenQuickReport<RecordMailQuickReportForm>(new RecordTrackCQQuickReportImp(Param));
            }
            catch(ValidatingException ex)
            {
                Msg.ShowException(ex);
            }
        }

        RecordTrackCQEnquiryParam Param
        {
            get
            {
                DateTime month = dateTimePickerMonth.Value;
                var param= new RecordTrackCQEnquiryParam()
                {
                   Month = month,
                };
                return param;
            }
        }
    }
}
