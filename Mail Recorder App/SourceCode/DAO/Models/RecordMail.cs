using LiteDB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_Recorder_App.DAO
{
    [Serializable]
    public class RecordMail
    {
        [BsonId]
        public int Id { get; set; }
        public int OperatorId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? Monthly { get; set; } = null;
        public int OperatorSendId { get; set; }
        public string Detail { get; set; }
        public string Memo { get; set; }
        public RecordMailAttachment[] Attach { get; set; }
        
    }
}
