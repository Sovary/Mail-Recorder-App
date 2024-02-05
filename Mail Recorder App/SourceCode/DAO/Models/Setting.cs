using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_Recorder_App.DAO
{
    [Serializable]
    public class Setting
    {
        [BsonId]
        public int Id { get; set; }
        public DateTime RecMailMonthly { get; set; }
        public int DayAlert { get; set; } = 4;
    }
}
