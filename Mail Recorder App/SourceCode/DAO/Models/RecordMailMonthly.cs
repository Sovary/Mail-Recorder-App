using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_Recorder_App.DAO
{
    [Serializable]
    public class RecordMailMonthly
    {
        [BsonId]
        public int Id { get; set; }
        public DateTime Monthly { get; set; }
        public DateTime Date { get; set; }
        public string Memo { get; set; }
        [BsonRef("RecordMail")]
        public List<RecordMail> RecordMails { get; set; }
    }
}
