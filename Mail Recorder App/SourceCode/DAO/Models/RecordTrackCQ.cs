using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_Recorder_App.DAO
{
    [Serializable]
    public class RecordTrackCQ
    {
        [BsonId]
        public int Id { get; set; }
        public int OperatorId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? Monthly { get; set; } = null;
        public string Memo { get; set; }
        public string FileType { get; set; }
        public string FileName { get; set; }
        public List<int> NewPoints { get; set; }
        public List<int> PendPoints { get; set; }
        public List<int> ClosePoints { get; set; }

    }
}
