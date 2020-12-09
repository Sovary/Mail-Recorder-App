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
    public class RecordMailMonthlyQuickReportImp : IQuickReport
    {
        private DataGridView grid;
        private RecordMailMonthlyEnquiryParam param;
        Facade facade => Facade.Instance;
        Dictionary<int, Operator> dicOp = new Dictionary<int, Operator>();
        public RecordMailMonthlyQuickReportImp(RecordMailMonthlyEnquiryParam para)
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
                        Name = "Date",
                        Title = "Date",
                        Width = 100,
                        Type = typeof(string)
                    },
                    new ColumnGrid()
                    {
                        Name = "Sender",
                        Title = "Sender",
                        Width = 100,
                        Type = typeof(string)
                    },
                    new ColumnGrid()
                    {
                        Name = "Description",
                        Title = "Description",
                        Width = 100,
                        Type = typeof(string)
                    },
                    new ColumnGrid()
                    {
                        Name = "Type",
                        Title = "Type",
                        Width = 50,
                        Type = typeof(string)
                    },
                    new ColumnGrid()
                    {
                        Name = "Memo",
                        Title = "Memo",
                        Width = 100,
                        Type = typeof(string)
                    }
                }.ToArray();

        public string FormCaption => "Record Mail Monthly Quick Report";

        public async void OnPublishGrid(DataGridView grid)
        {
            this.grid = grid;   
            var monthly = await facade.GetRecordMailMonthlyAsync(param.Month);
            if (monthly?.RecordMails?.Any() != true) return;
            List<RecordMail> list = monthly.RecordMails;
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
                if (!dicOp.ContainsKey(r.OperatorSendId)) continue;
                Operator op = dicOp[r.OperatorId];
                Operator opsend = dicOp[r.OperatorSendId];
                if (!param.AnyType)
                {
                    if (op.Type != param.Type) continue;
                }

                int index = grid.Rows.Add();
                grid.Rows[index].Cells["No"].Value = index + 1;
                grid.Rows[index].Cells["Operator"].Value = $"{op.Name}";
                grid.Rows[index].Cells["Date"].Value = r.Date.ToString("dd-MMM-yyyy");
                grid.Rows[index].Cells["Sender"].Value = (opsend?.Name) + string.Empty;
                grid.Rows[index].Cells["Description"].Value = r.Detail;
                grid.Rows[index].Cells["Memo"].Value = $"{monthly.Memo}";
                grid.Rows[index].Cells["Type"].Value = $"{op.Type}";
                grid.Rows[index].Tag = r.Id;
                grid.Rows[index].Cells["Memo"].Tag = monthly;
            }
        }

        public void OnGridDrillDown(DataGridViewCellEventArgs cell, DataGridViewRow row)
        {
            if (cell.ColumnIndex == -1)
            {
                var o = (int)row.Tag;
                var exist = facade.GetRecordMail(o);
                if (exist == null) return;
                var f = Form1.OpenForm<RecordMailForm>();
                f.PopulateForm(exist);
            }
            else if(cell.ColumnIndex == grid.Columns.IndexOf(grid.Columns["Memo"]))
            {
                var month = (RecordMailMonthly)row.Cells[cell.ColumnIndex].Tag;
                var exist = facade.GetRecordMailMonthly(month.Id);
                if (exist == null) return;
                var f = Form1.OpenForm<RecordMailMonthlyForm>();
                f.PopulateForm(exist);
            }
        }
    }
}
