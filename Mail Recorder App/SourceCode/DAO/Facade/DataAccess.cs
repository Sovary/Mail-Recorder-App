using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace Mail_Recorder_App.DAO
{
    public class DataAccess
    {
        protected Facade facade => Facade.Instance;
        public static string BasePath
        {
            get
            {
                return GetPath(ConfigurationManager.AppSettings.Get("BasePath"));
            }
        }

        public static string FilePath
        {
            get
            {
                return GetPath(Path.Combine(BasePath, "Files"));
            }
        }
        public static string SystemConfigPath
        {
            get
            {
                return GetPath(Path.Combine(BasePath, "SystemConfiguration"));
            }
        }

        private static  string GetPath(string path)
        {
            if (!File.Exists(path))
            {
                DirectoryInfo x = Directory.CreateDirectory(path);
                return x.FullName;
            }
            return path;
        }

        public LiteDatabase Connection=> new LiteDatabase(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);

        public string[] GetOperatorTypes()
        {
            return File.ReadAllLines(Path.Combine(SystemConfigPath, "types.txt"));
        }

        public Operator GetOperator(int id)
        {
            Operator o = null;
            using (var con = Connection)
            {
                var op = con.GetCollection<Operator>(typeof(Operator).Name);
                o = op.FindById(id);
            }
            return o;
        }

        internal List<Operator> GetOperators()
        {
            List<Operator> os = new List<Operator>();
            using (var con = Connection)
            {
                var ops = con.GetCollection<Operator>(typeof(Operator).Name);
                os.AddRange(ops.FindAll());
            }

            if(!os.Any(p => p.Name.ToLower() == "dmc"))
            {
                var dmc = new Operator()
                {
                    Name = "DMC",
                    Type = "Unknown",
                };
                AddOperator(dmc);
                os.Add(dmc);
            }
            return os;
        }

        public void AddOperator_Validating(Operator o)
        {
            AddUpdateOperator_Validating(o);
            AddOperator(o);
        }

        private void AddOperator(Operator o)
        {
            using (var con = Connection)
            {
                var ops = con.GetCollection<Operator>(typeof(Operator).Name);
                ops.Insert(o);
            }
        }
        
        public void UpdateOperator_Validating(Operator o)
        {
            AddUpdateOperator_Validating(o);
            using (var con = Connection)
            {
                var ops = con.GetCollection<Operator>(typeof(Operator).Name);
                ops.Update(o.Id, o);
            }
        }
        void AddUpdateOperator_Validating(Operator o)
        {
            if (o == null) throw new ValidatingException("Invalid object");
            if (string.IsNullOrWhiteSpace(o.Name)) throw new ValidatingException("Invalid Name");
            if (string.IsNullOrWhiteSpace(o.Type)) throw new ValidatingException("Invalid Type");
            if (GetOperators().Any(p => p.Name == o.Name)) throw new ValidatingException("Duplicated name!");
        }

        public bool RemoveOperator_Validating(int id)
        {
            var last = facade.GetRecordMails().LastOrDefault(p => p.OperatorId == id || p.OperatorSendId == id);
            if (last != null)
            { throw new ValidatingException("Operator is in used!"); }
            if (facade.GetOperator(id)?.Name.ToLower() == "dmc") throw new ValidatingException("Can not remove this Operator");
            bool state = false;
            using (var con = Connection)
            {
                var ops = con.GetCollection<Operator>(typeof(Operator).Name);
                state = ops.Delete(id);
            }
            return state;
        }
        
    }
}
