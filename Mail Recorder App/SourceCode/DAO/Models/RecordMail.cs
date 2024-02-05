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
        public bool IsCQ { get; set; }
        public DateTime? Monthly { get; set; } = null;
        public int OperatorSendId { get; set; }
        public string Detail { get; set; }
        public string Memo { get; set; }
        public RecordMailAttachment[] Attach { get; set; }

        private string newpoints = string.Empty;
        public string NewPoints { get { return newpoints+string.Empty; } set { newpoints = value; } }
        private string pendingpoints = string.Empty;
        public string PendingPoints { get { return pendingpoints + string.Empty; } set { pendingpoints = value; } }
        private string closepoints = string.Empty;
        public string ClosePoints { get { return closepoints + string.Empty; } set { closepoints = value; } }
        private string analyzepoints = string.Empty;
        public string AnalyzePoints { get { return analyzepoints + string.Empty; } set { analyzepoints = value; } }
    }
}
