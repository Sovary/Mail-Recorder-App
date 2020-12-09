using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_Recorder_App.DAO
{
    public class MonthlyPeriod
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }

        public override string ToString()
        {
            return $"{From:dd-MMM-yyyy} To {To:dd-MMM-yyyy}";
        }
    }
}
