using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_Recorder_App.DAO
{
    public class AttachHelp
    {
        public State Todo { get; set; }
        public RecordMailAttachment Attach { get; set; }

        public enum State
        {
            NA, Add, Remove,
        }
    }
}
