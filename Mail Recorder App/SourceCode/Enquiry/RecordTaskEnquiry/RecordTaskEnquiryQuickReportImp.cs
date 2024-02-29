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
    public class RecordTaskQuickReportImp : IQuickReport
    {
        private DataGridView grid;
        private RecordTaskEnquiryParam param;
        Facade facade => Facade.Instance;
        Dictionary<int, Operator> dicOp = new Dictionary<int, Operator>();
        public RecordTaskQuickReportImp(RecordTaskEnquiryParam para)
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
                        Name = "Task Date",
                        Title = "Task Date",
                        Width = 100,
                        Type = typeof(string)
                    },
                    new ColumnGrid()
                    {
                        Name = "Subject",
                        Title = "Subject",
                        Width = 100,
                        Type = typeof(string)
                    },
                    new ColumnGrid()
                    {
                        Name = "Meeting Date",
                        Title = "Meeting Date",
                        Width = 100,
                        Type = typeof(string)
                    },
                    new ColumnGrid()
                    {
                        Name = "Description",
                        Title = "Description",
                        Width = 250,
                        Type = typeof(string)
                    },
                    new ColumnGrid()
                    {
                        Name = "Last Followup Date",
                        Title = "Last Followup Date",
                        Width = 100,
                        Type = typeof(string)
                    },
                    new ColumnGrid()
                    {
                        Name = "Expire Day",
                        Title = "Expire Day",
                        Width = 100,
                        Type = typeof(string)
                    },
                    new ColumnGrid()
                    {
                        Name = "Date Done",
                        Title = "Date Done",
                        Width = 100,
                        Type = typeof(string)
                    }
                }.ToArray();

        public string FormCaption => "Record Task Quick Report";

        public async void OnPublishGrid(DataGridView grid)
        {
            this.grid = grid;
            var list = await facade.GetRecordTasksAsync();
            list.Sort((x, y) =>
            {
                DateTime xdate = x.NextTaskDate.HasValue ? x.NextTaskDate.Value : x.TaskDate;
                DateTime ydate = y.NextTaskDate.HasValue ? y.NextTaskDate.Value : y.TaskDate;
                return DateTime.Compare(xdate, ydate);
            });


            void Perform(List<RecordTask> rtask)
            {
                foreach (var r in rtask)
                {
                    if (!dicOp.ContainsKey(r.OperatorId)) continue;
                    Operator op = dicOp[r.OperatorId];
                    if (param.OperatorId != -1)
                    {
                        if (op.Id != param.OperatorId) continue;
                    }
                    if (param.State != RecordTaskEnquiryParam.Status.All)
                    {
                        if (param.State == RecordTaskEnquiryParam.Status.Done)
                        {
                            if (!r.IsDone) continue;
                        }
                        else
                        {
                            if (r.IsDone) continue;
                        }
                    }
                    DateTime lastDate = r.NextTaskDate.HasValue ? r.NextTaskDate.Value : r.TaskDate;
                    if(param.From.HasValue && param.To.HasValue)
                    {
                        if (lastDate < param.From.Value) continue;
                        if (lastDate > param.To.Value) continue;
                    }

                    if (param.DateAlert.HasValue)
                    {
                        if (r.IsDone) continue;
                        if (!r.LastFollowupDate.HasValue)
                        {
                            if (DateTime.Today.AddDays(param.DateAlert.Value) < lastDate) continue;
                        }
                    }

                    int index = grid.Rows.Add();
                    grid.Rows[index].Cells["No"].Value = index + 1;
                    grid.Rows[index].Cells["Operator"].Value = $"{op.Name}";
                    grid.Rows[index].Cells["Task Date"].Value = lastDate.ToString("dd-MMM-yyyy");
                    grid.Rows[index].Cells["Meeting Date"].Value = r.MeetDate?.ToString("dd-MMM-yyyy");
                    grid.Rows[index].Cells["Subject"].Value = r.Subject;
                    grid.Rows[index].Cells["Description"].Value = r.Description;
                    grid.Rows[index].Cells["Last Followup Date"].Value = r.LastFollowupDate?.ToString("dd-MMM-yyyy");
                    grid.Rows[index].Cells["Date Done"].Value = r.DoneDate?.ToString("dd-MMM-yyyy");
                    grid.Rows[index].Cells["Expire Day"].Value = $"{(lastDate - DateTime.Today).Days} Days";
                    grid.Rows[index].Tag = r.Id;
                }
            }
            if (param.Group == RecordTaskEnquiryParam.Sorted.Operator)
            {
                list.Sort((x, y) =>
                {
                    return string.CompareOrdinal(dicOp[x.OperatorId].Name, dicOp[y.OperatorId].Name);
                });
                Perform(list);
            }
            else
            {
                Perform(list);
            }
        }

        public void OnGridDrillDown(DataGridViewCellEventArgs cell, DataGridViewRow row)
        {
            if (cell.ColumnIndex == -1)
            {
                var o = (int)row.Tag;
                var exist = facade.GetRecordTask(o);
                if (exist == null) return;
                var f = Form1.OpenForm<RecordTaskForm>();
                f.PopulateForm(exist);
            }
        }
    }
}

