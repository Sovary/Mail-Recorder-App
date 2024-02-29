using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_Recorder_App.DAO
{
    public class RecordTrackCQFacade : RecordMailAttachmentFacade
    {

        public RecordTrackCQ GetRecordTrackCQ(int id)
        {
            RecordTrackCQ o = null;
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordTrackCQ>(typeof(RecordTrackCQ).Name);
                o = col.FindById(id);
            }
            return o;
        }

        internal List<RecordTrackCQ> GetRecordTrackCQs()
        {
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordTrackCQ>(typeof(RecordTrackCQ).Name);
                return col.FindAll().ToList();
            }
        }

        public RecordTrackCQ Next_RecordTrackCQ(RecordTrackCQ m)
        {
            var list = GetRecordTrackCQs();
            if (m == null) return list.LastOrDefault();
            int index = list.IndexOf(list.SingleOrDefault(p => p.Id == m.Id)) + 1;
            if (index < list.Count)
            {
                return list[index];
            }
            return null;
        }

        public RecordTrackCQ Prev_RecordTrackCQ(RecordTrackCQ m)
        {
            var list = GetRecordTrackCQs();
            if (m == null) return list.LastOrDefault();
            int index = list.IndexOf(list.SingleOrDefault(p => p.Id == m.Id)) - 1;
            if (index > -1)
            {
                return list[index];
            }
            return null;
        }

        public void AddRecordTrackCQ_Validating(RecordTrackCQ o)
        {
            if (o is null) throw new ValidatingException("Item not exist!");
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordTrackCQ>(typeof(RecordTrackCQ).Name);
                col.Insert(o);
            }
        }
        public void UpdateRecordTrackCQ_Validating(RecordTrackCQ o)
        {
            if (o is null) throw new ValidatingException("Item not exist!");
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordTrackCQ>(typeof(RecordTrackCQ).Name);
                col.Update(o);
            }
        }

        public bool RemoveRecordTrackCQ_Validating(int id)
        {
            bool state = false;
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordTrackCQ>(typeof(RecordTrackCQ).Name);
                RecordTrackCQ m = col.FindById(id);
                if (m == null) throw new ValidatingException("Item does not exist!");
                state = col.Delete(id);
            }
            return state;
        }

        internal List<RecordTrackCQ> GetLast5RecordTrackCQs(int id)
        {
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordTrackCQ>(typeof(RecordTrackCQ).Name);
                return col.Find(p => p.OperatorId == id).OrderByDescending(p => p.Date).Take(5).ToList();
            }
        }

        public IEnumerable<RecordTrackCQ> GetRecordTrackCQInMonthEnquiry(DateTime month)
        {
            var list = new List<RecordTrackCQ>();
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordTrackCQ>(typeof(RecordTrackCQ).Name);
                list.AddRange(col.Find(p => p.Monthly.HasValue && (p.Monthly.Value.Month == month.Month && p.Monthly.Value.Year == month.Year)));
            }
            return list;
        }
    }
}
