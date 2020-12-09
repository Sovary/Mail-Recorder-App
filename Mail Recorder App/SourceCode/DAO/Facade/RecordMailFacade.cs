using LiteDB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Mail_Recorder_App.DAO
{
    public partial class RecordMailFacade : RecordMailAttachmentFacade
    {

        public RecordMail GetRecordMail(int id)
        {
            RecordMail o = null;
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordMail>(typeof(RecordMail).Name);
                o = col.FindById(id);
            }
            return o;
        }

        public void ImportRecordMails_Validating(RecordMail[] os)
        {
            if (os.Length > 4000) throw new ValidatingException("Exeed bulk insert! recommend less then 4000 records");
            foreach(var o in os)
            {
                if (o == null) throw new ValidatingException("Invalid object!");
                if (string.IsNullOrWhiteSpace(o.Detail)) throw new ValidatingException($"Invalid Detail!");
            }
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordMail>(typeof(RecordMail).Name);
                col.InsertBulk(os);
            }
        }

        public void AddRecordMail_Validating(List<AttachHelp> attachHelp, RecordMail o)
        {
            AddUpdateRecordMail_Validating(o);
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordMail>(typeof(RecordMail).Name);
                if (attachHelp.Count > 0)
                {
                    var addfiles = attachHelp.Where(p => p.Todo == AttachHelp.State.Add).Select(p => p.Attach);
                    UploadFileMailAttach(addfiles,o);
                }
                col.Insert(o);
            }
        }

        void AddUpdateRecordMail_Validating(RecordMail o)
        {
            if (o == null) throw new ValidatingException("Invalid object");
            if (string.IsNullOrWhiteSpace(o.Detail)) throw new ValidatingException("Invalid Detail");
            if (o.Monthly.HasValue)
            {
                RecordMailMonthlySaved_IsValid(o.Monthly.Value, true);
            }
        }

        public void UpdateRecordMail_Validating(List<AttachHelp> attachHelp, RecordMail o)
        {
            AddUpdateRecordMail_Validating(o);
            var exist = GetRecordMail(o.Id);
            if(exist == null) throw new ValidatingException("Item does not exist");
            AddUpdateRecordMail_Validating(exist);
            if (exist.Date.Month != o.Date.Month || exist.Date.Year != o.Date.Year)
                throw new ValidatingException("Date record of Month and Year can't modified!");
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordMail>(typeof(RecordMail).Name);
                if (attachHelp.Count > 0)
                {
                    var addfiles = attachHelp.Where(p => p.Todo == AttachHelp.State.Add).Select(p => p.Attach);
                    UploadFileMailAttach(addfiles, o);
                    var removeFile = attachHelp.Where(p => p.Todo == AttachHelp.State.Remove).Select(p => p.Attach)?.ToArray();
                    DeleteFileMailAttach(removeFile);
                }
                col.Update(o);
            }
        }

        public bool RemoveRecordMail(int id)
        {
            bool state = false;
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordMail>(typeof(RecordMail).Name);
                RecordMail m = col.FindById(id);
                if (m == null) throw new ValidatingException("Item does not exist!");
                if (m.Monthly.HasValue) 
                {
                    RecordMailMonthlySaved_IsValid(m.Monthly.Value, true);
                }
                DeleteFileMailAttach(m.Attach);
                state = col.Delete(id);
            }
            return state;
        }

        internal List<RecordMail> GetRecordMails()
        {
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordMail>(typeof(RecordMail).Name);
                return col.FindAll().ToList();
            }
        }

        internal Task<List<RecordMail>> GetRecordMailsAsync()
        {
            return Task.Run(() =>
            {
                return GetRecordMails();
            });
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">operator id</param>
        /// <returns></returns>
        internal List<RecordMail> GetLast5RecordMails(int id)
        {
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordMail>(typeof(RecordMail).Name);
                return col.Find(p => p.OperatorId == id).OrderByDescending(p=>p.Date).Take(5).ToList();
            }
        }

        public RecordMail Next_RecordMail(RecordMail m)
        {
            var list = GetRecordMails();
            if (m == null) return list.LastOrDefault();
            int index = list.IndexOf(list.SingleOrDefault(p => p.Id == m.Id)) + 1;
            if (index < list.Count)
            {
                return list[index];
            }
            return null;
        }

        public RecordMail Prev_RecordMail(RecordMail m)
        {
            var list = GetRecordMails();
            if (m == null) return list.LastOrDefault();
            int index = list.IndexOf(list.SingleOrDefault(p => p.Id == m.Id)) - 1;
            if (index > -1)
            {
                return list[index];
            }
            return null;
        }

        public Task<List<RecordMail>> GetRecordMailsDateRangeAsync(DateTime from, DateTime to)
        {
            return Task.Run(() =>
            {
                using (var con = Connection)
                {
                    from = from.Date;
                    to = to.Date.AddDays(1).AddTicks(-1);
                    var col = con.GetCollection<RecordMail>(typeof(RecordMail).Name);
                    return col.Find(p => from <= p.Date && p.Date <= to)
                    .ToList();
                }
            });
        }

        public IEnumerable<RecordMail> GetRecordMailsInMonth(DateTime month)
        {
            var list = new List<RecordMail>();
            using (var con = Connection)
            {                
                var col = con.GetCollection<RecordMail>(typeof(RecordMail).Name);
                list.AddRange(col.Find(p=>p.Monthly.HasValue && (p.Monthly.Value.Month == month.Month && p.Monthly.Value.Year == month.Year)));
            }
            return list;
        }
    }
}
