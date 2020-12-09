using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_Recorder_App.DAO
{
    public class RecordMailMonthlyEnquiryParam
    {
        public string Type { get; set; }
        public DateTime Month { get; set; }
        public bool AnyType => string.IsNullOrWhiteSpace(Type);
    }
}
