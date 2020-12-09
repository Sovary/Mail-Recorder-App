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
    public class RecordMailQuickReportImp : IQuickReport
    {
        private RecordMailEnquiryParam param;
        Facade facade => Facade.Instance;
        Dictionary<int, Operator> dicOp = new Dictionary<int, Operator>();
        public RecordMailQuickReportImp(RecordMailEnquiryParam para)
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
                        Name = "Send",
                        Title = "Send",
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
                        Width = 100,
                        Type = typeof(string)
                    },
                    new ColumnGrid()
                    {
                        Name = "File",
                        Title = "File",
                        Width = 100,
                        Type = typeof(string)
                    }
                }.ToArray();

        public string FormCaption => "Record Mail Quick Report";

        public async void OnPublishGrid(DataGridView grid)
        {
            
            List<RecordMail> list = await facade.GetRecordMailsDateRangeAsync(param.From,param.To);
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
                  i = x.Date.CompareTo(y.Date);
                }
                return i;
            });

            foreach (var r in list)
            {
                if (!dicOp.ContainsKey(r.OperatorId)) continue;
                if (!dicOp.ContainsKey(r.OperatorSendId)) continue;
                Operator op = dicOp[r.OperatorId];
                Operator opsend = dicOp[r.OperatorSendId];
                if (param.OperatorId != -1)
                {
                    if (r.OperatorId != param.OperatorId) continue;
                }
                if (!param.AnyType)
                {
                    if (op.Type != param.Type) continue;
                }

                int index = grid.Rows.Add();
                grid.Rows[index].Cells["No"].Value = index + 1;
                grid.Rows[index].Cells["Operator"].Value = $"{op.Name}";
                grid.Rows[index].Cells["Date"].Value = r.Date.ToString("dd-MMM-yyyy");
                grid.Rows[index].Cells["Send"].Value = (opsend?.Name) + string.Empty;
                grid.Rows[index].Cells["Description"].Value = r.Detail;
                grid.Rows[index].Cells["Type"].Value = $"{op.Type}";
                if (r.Attach != null)
                {
                    grid.Rows[index].Cells["File"].Value = $"{string.Join(";", r.Attach.Select(p => p.Path))}";
                }
                grid.Rows[index].Tag = r.Id;

            }
        }

        public void OnGridDrillDown(DataGridViewCellEventArgs cell, DataGridViewRow row)
        {
            var o = (int)row.Tag;
            var exist = facade.GetRecordMail(o);
            if (exist == null) return;
            var f = Form1.OpenForm<RecordMailForm>();
            f.PopulateForm(exist);
        }
    }
}
