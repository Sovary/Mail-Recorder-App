using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mail_Recorder_App.DAO
{
    partial class RecordMailFacade
    {


        public RecordMailMonthly GetRecordMailMonthly(int id)
        {
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordMailMonthly>(typeof(RecordMailMonthly).Name);
                return col.Include(p=>p.RecordMails).FindById(id);
            }
        }

        public RecordMailMonthly GetRecordMailMonthly(DateTime month)
        {
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordMailMonthly>(typeof(RecordMailMonthly).Name);
                return col
                    .Include(p => p.RecordMails)
                    .Find(p => p.Monthly.Month == month.Month && p.Monthly.Year == month.Year)
                    .FirstOrDefault();
            }
        }
        public async Task<RecordMailMonthly> GetRecordMailMonthlyAsync(DateTime month)
        {
            return await Task.Run(() =>
            {
                return GetRecordMailMonthly(month);
            });
        }

        public List<RecordMailMonthly> GetRecordMailMonthlies()
        {
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordMailMonthly>(typeof(RecordMailMonthly).Name);
                return col.Include(p => p.RecordMails).FindAll().ToList();
            }
        }

        public Task<List<RecordMailMonthly>> GetRecordMailMonthliesAsync()
        {
            return Task.Run(() =>
            {
                return GetRecordMailMonthlies();
            });
        }

        public RecordMailMonthly Next_RecordMailMonthly(RecordMailMonthly m)
        {
            var list = GetRecordMailMonthlies();
            if (m == null) return list.LastOrDefault();
            int index = list.IndexOf(list.SingleOrDefault(p => p.Id == m.Id)) + 1;
            if (index < list.Count)
            {
                return list[index];
            }
            return null;
        }

        public RecordMailMonthly Prev_RecordMailMonthly(RecordMailMonthly m)
        {
            var list = GetRecordMailMonthlies();
            if (m == null) return list.LastOrDefault();
            int index = list.IndexOf(list.SingleOrDefault(p => p.Id == m.Id)) - 1;
            if (index > -1)
            {
                return list[index];
            }
            return null;
        }

        public void AddRecordMailMonthly_Validating(RecordMailMonthly o)
        {
            if (o is null) throw new ValidatingException("Item invalid!");
            if (o.RecordMails?.Any() != true) throw new ValidatingException("Record mails have no items to record");
            var r = GetRecordMailMonthly(o.Monthly);
            if (r != null) throw new ValidatingException("Can not save in duplicated month!");
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordMailMonthly>(typeof(RecordMailMonthly).Name);
                col.Insert(o);
            }
        }
        public void RemoveRecordMailMonthly_Validating(int id)
        {
            var exist = GetRecordMailMonthly(id);
            if (exist is null) throw new ValidatingException("Item does not exist!");
            using (var con = Connection)
            {
                var col = con.GetCollection<RecordMailMonthly>(typeof(RecordMailMonthly).Name);
                col.Delete(id);
            }
        }

        public bool RecordMailMonthlySaved_IsValid(DateTime month,bool throwerr=false)
        {
            var val = GetRecordMailMonthly(month);
            if (val == null) return true;
            if (throwerr)
            {
                throw new ValidatingException("Cannot perform this action the record has been saved in MONTHLY PERIOD!");
            }
            return false;
        }
    }
}
