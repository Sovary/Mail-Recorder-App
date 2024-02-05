using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_Recorder_App.DAO
{
    public class RecordTaskFacade : RecordTrackCQFacade
    {
        public RecordTask GetRecordTask(int id)
        {
            RecordTask o = null;
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordTask>(typeof(RecordTask).Name);
                o = col.FindById(id);
            }
            return o;
        }

        public List<RecordTask> GetLast5RecordTasks(int id)
        {
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordTask>(typeof(RecordTask).Name);
                return col.Find(p => p.OperatorId == id).Take(5).ToList();
            }
        }

        public void AddRecordTask_Validating(RecordTask o)
        {
            AddUpdateRecordTask_Validating(o);
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordTask>(typeof(RecordTask).Name);
                col.Insert(o);
            }
        }
        public void RemoveRecordTask_Validating(int id)
        {
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordTask>(typeof(RecordTask).Name);
                RecordTask m = col.FindById(id);
                if (m == null) throw new ValidatingException("Item does not exist!");
                col.Delete(id);
            }
        }
        
        private void AddUpdateRecordTask_Validating(RecordTask o)
        {
            if (o == null) throw new ValidatingException("Invalid object");
            if (string.IsNullOrWhiteSpace(o.Description)) throw new ValidatingException("Invalid description");
        }

        public void UpdateRecordTask_Validating(RecordTask o)
        {
            AddUpdateRecordTask_Validating(o);
            var exist = GetRecordTask(o.Id);
            if (exist == null) throw new ValidatingException("Item does not exist");
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordTask>(typeof(RecordTask).Name);
                col.Update(o);
            }
        }

        public bool RemoveRecordMail(int id)
        {
            bool state = false;
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordTask>(typeof(RecordTask).Name);
                RecordTask m = col.FindById(id);
                if (m == null) throw new ValidatingException("Item does not exist!");
                state = col.Delete(id);
            }
            return state;
        }

        internal List<RecordTask> GetRecordTasks()
        {
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordTask>(typeof(RecordTask).Name);
                return col.FindAll().ToList();
            }
        }

        public Task<List<RecordTask>> GetRecordTasksAsync()
        {
            return Task.Run(() =>
            {
                return GetRecordTasks();
            });
        }
    }
}
