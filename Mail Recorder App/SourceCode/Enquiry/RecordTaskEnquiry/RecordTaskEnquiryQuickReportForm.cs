using Mail_Recorder_App.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Recorder_App
{
    public partial class RecordTaskEnquiryQuickReportForm : QuickReportForm
    {
        public RecordTaskEnquiryQuickReportForm(IQuickReport q) : base(q)
        {
        }
    }
}
