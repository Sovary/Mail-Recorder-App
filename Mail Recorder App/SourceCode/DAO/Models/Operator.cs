using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace Mail_Recorder_App.DAO
{
    [Serializable]
    public class Operator
    {
        [BsonId]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime? ConnectedDate { get; set; }
        public DateTime? TransferedDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
