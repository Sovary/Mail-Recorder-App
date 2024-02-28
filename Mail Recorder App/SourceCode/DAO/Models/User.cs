using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_Recorder_App.DAO
{
    [Serializable]
    public class User
    {
        [BsonId]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string TelegramId { get; set; }
        public string Role { get; set; }
        public string Code { get; set; }

    }
}
