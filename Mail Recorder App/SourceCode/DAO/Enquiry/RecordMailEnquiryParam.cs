using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_Recorder_App.DAO
{
    public class RecordMailEnquiryParam
    {
        public int OperatorId { get; set;}
        public bool AnyType { get => string.IsNullOrWhiteSpace(Type); }
        public string Type { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
