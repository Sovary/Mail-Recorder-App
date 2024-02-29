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
    public class RecordMailCQSummaryQuickReportImp : IQuickReport
    {
        private DataGridView grid;
        private RecordMailMonthlyEnquiryParam param;
        Facade facade => Facade.Instance;
        Dictionary<int, Operator> dicOp = new Dictionary<int, Operator>();
        public RecordMailCQSummaryQuickReportImp(RecordMailMonthlyEnquiryParam para)
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
                        Width = 200,
                        Type = typeof(string)
                    },
                    new ColumnGrid()
                    {
                        Name = "Pending Points",
                        Title = "Pending Points",
                        Width = 200,
                        Type = typeof(string)
                    },
                    new ColumnGrid()
                    {
                        Name = "Closed Points",
                        Title = "Closed Points",
                        Width = 150,
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
                        Name = "Filename",
                        Title = "Filename",
                        Width = 100,
                        Type = typeof(string)
                    }
                }.ToArray();

        public string FormCaption => "Record Mail CQ Summary Quick Report";

        public async void OnPublishGrid(DataGridView grid)
        {
            this.grid = grid;   
            var monthly = await facade.GetRecordMailMonthlyAsync(param.Month);
            if (monthly?.RecordMails?.Any() != true) return;
            List<RecordMail> list = monthly.RecordMails.Where(p=>p.IsCQ).ToList();
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

            foreach (var g in list.GroupBy(p => p.OperatorId, p => p))
            {
                if (!dicOp.ContainsKey(g.Key)) continue;
                var pendingpoints = g.Where(p => !string.IsNullOrWhiteSpace(p.PendingPoints)).OrderBy(p=>p.Date).LastOrDefault();
                var pend = pendingpoints?.PendingPoints
                    ?.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                    ?.GetRangeInt();
                var newpoints = g
                    .SelectMany(p => p.NewPoints.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)).ToArray()
                    .GetRangeInt();
                var closepoints = g
                    .SelectMany(p => p.ClosePoints.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries)).ToArray()
                    .GetRangeInt();

                foreach(var close in closepoints)
                {
                    if(pend.Contains(close))
                    {
                        pend.Remove(close);
                    }
                }
                Operator op = dicOp[g.Key];
                int index = grid.Rows.Add();
                grid.Rows[index].Cells["No"].Value = index + 1;
                grid.Rows[index].Cells["Operator"].Value = $"{op.Name}";
                grid.Rows[index].Cells["Pending Points"].Value = $"{pend.GetStrRange()}";
                grid.Rows[index].Cells["Closed Points"].Value = $"{closepoints.GetStrRange()}";
                grid.Rows[index].Cells["New Points"].Value = $"{newpoints.GetStrRange()}";
            }
        }

        public void OnGridDrillDown(DataGridViewCellEventArgs cell, DataGridViewRow row)
        {
            //if (cell.ColumnIndex == -1)
            //{
            //    var o = (int)row.Tag;
            //    var exist = facade.GetRecordMail(o);
            //    if (exist == null) return;
            //    var f = Form1.OpenForm<RecordMailForm>();
            //    f.PopulateForm(exist);
            //}
            //else if(cell.ColumnIndex == grid.Columns.IndexOf(grid.Columns["Memo"]))
            //{
            //    var month = (RecordMailMonthly)row.Cells[cell.ColumnIndex].Tag;
            //    var exist = facade.GetRecordMailMonthly(month.Id);
            //    if (exist == null) return;
            //    var f = Form1.OpenForm<RecordMailMonthlyForm>();
            //    f.PopulateForm(exist);
            //}
        }
    }
}
