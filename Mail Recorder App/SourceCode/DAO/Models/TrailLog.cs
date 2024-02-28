using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_Recorder_App.DAO
{
    public class TrailLog
    {
        public string AddedByUser { get; set; }
        public string UpdatedByUser { get; set; }
        public DateTime TimeAdded { get; set; }
        public DateTime TimeUpdated { get; set; }
    }
}
