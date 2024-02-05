using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_Recorder_App.DAO
{
    [Serializable]
    public class RecordTask
    {
        [BsonId]
        public int Id { get; set; }
        public int OperatorId { get; set; }
        public DateTime? MeetDate { get; set; }
        public DateTime TaskDate { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }

        public DateTime? LastFollowupDate { get; set; }
        public DateTime? NextTaskDate { get; set; }
        public bool IsDone { get; set; }
        public DateTime? DoneDate { get; set; }
        public string FollowupDescription { get; set; }

        public string Memo1 { get; set; }
        public string Memo2 { get; set; }

    }
}
