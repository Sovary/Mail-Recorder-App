using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_Recorder_App.DAO
{
    public class RecordTaskEnquiryParam
    {
        public int OperatorId { get; set; } = -1;
        public Status State { get; set; } = Status.Undone;
        public Sorted Group { get; set; } = Sorted.Default;
        public DateTime? From { get;set; }
        public DateTime? To { get; set; }
        public enum Sorted
        {
            Default,
            Operator,
        }
        public enum Status
        {
            All,
            Done,
            Undone,
        }

        //Alert
        public int? DateAlert { get; set; }
    }
}
