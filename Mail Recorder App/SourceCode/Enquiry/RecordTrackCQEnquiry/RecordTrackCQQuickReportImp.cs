using Mail_Recorder_App.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Recorder_App
{
    public class RecordTrackCQQuickReportImp : IQuickReport
    {
        private DataGridView grid;
        private RecordTrackCQEnquiryParam param;
        Facade facade => Facade.Instance;
        Dictionary<int, Operator> dicOp = new Dictionary<int, Operator>();
        public RecordTrackCQQuickReportImp(RecordTrackCQEnquiryParam para)
        {
            this.param = para;
            dicOp = facade.GetOperators().ToDictionary(p => p.Id);
        }

        public ColumnGrid[] Columns => new List<ColumnGrid>()
                {
                    new ColumnGrid()
                    {
                        Name = "No",
                        Title = "No",
                        Width = 50,
                        Type = typeof(int)
                    },
                    new ColumnGrid()
                    {
                        Name = "Operator",
                        Title = "Operator",
                        Width = 100,
                        Type = typeof(string)
                    },
                    new ColumnGrid()
                    {
                        Name = "Month",
                        Title = "Month",
                        Width = 100,
                        Type = typeof(string)
                    },
                    new ColumnGrid()
                    {
                        Name = "New Points",
                        Title = "New Points",
                        Width = 100,
                        Type = typeof(string)
                    },
                    new ColumnGrid()
                    {
                        Name = "Pending Points",
                        Title = "Pending Points",
                        Width = 100,
                        Type = typeof(string)
                    },
                    new ColumnGrid()
                    {
                        Name = "Close Points",
                        Title = "Close Points",
                        Width = 100,
                        Type = typeof(string)
                    }
                }.ToArray();

        public string FormCaption => "Record Track CQ Quick Report";

        public void OnPublishGrid(DataGridView grid)
        {
            this.grid = grid;    
            List<RecordTrackCQ> list = facade.GetRecordTrackCQInMonthEnquiry(param.Month).ToList();
            list.Sort((x, y) =>
            {
                int i = 0;
                if(dicOp.ContainsKey(x.OperatorId) 
                    && dicOp.ContainsKey(y.OperatorId))
                {
                    i = string.CompareOrdinal(dicOp[x.OperatorId].Name, dicOp[y.OperatorId].Name);
                }
                if (i == 0)
                {
                    i = DateTime.Compare(x.Date, y.Date);
                }
                return i;
            });

            foreach (var r in list)
            {
                if (!dicOp.ContainsKey(r.OperatorId)) continue;
                Operator op = dicOp[r.OperatorId];
                int index = grid.Rows.Add();
                grid.Rows[index].Cells["No"].Value = index + 1;
                grid.Rows[index].Cells["Operator"].Value = $"{op.Name}";
                grid.Rows[index].Cells["Month"].Value = r.Date.ToString("dd-MMM-yyyy");
                grid.Rows[index].Cells["New Points"].Value = r.NewPoints.GetStrRange();
                grid.Rows[index].Cells["Pending Points"].Value = r.PendPoints.GetStrRange();
                grid.Rows[index].Cells["Close Points"].Value = r.ClosePoints.GetStrRange();
                grid.Rows[index].Tag = r.Id;
            }
        }

        public void OnGridDrillDown(DataGridViewCellEventArgs cell, DataGridViewRow row)
        {
            if (cell.ColumnIndex == -1)
            {
                var o = (int)row.Tag;
                var exist = facade.GetRecordTrackCQ(o);
                if (exist == null) return;
                var f = Form1.OpenForm<RecordTrackTQCQForm>();
                f.PopulateForm(exist);
            }
        }
    }
}
