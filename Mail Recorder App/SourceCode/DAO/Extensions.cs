using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Recorder_App.DAO
{
    public static class Extensions
    {
        public static DataTable ToDataTable(this DataGridView grid)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn col in grid.Columns)
            {
                dt.Columns.Add(col.HeaderText);
            }
            foreach (DataGridViewRow row in grid.Rows)
            {
                var dr = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dr[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public static DateTime GetFirstDateOfMonth(this DateTime d)
        {
            return new DateTime(d.Year, d.Month, 1);
        }
        public static DateTime GetLastDateOfMonth(this DateTime d)
        {
            return new DateTime(d.Year, d.Month, DateTime.DaysInMonth(d.Year, d.Month));
        }

        /// <summary>
        /// format string 1,2-6,5
        /// </summary>
        /// <param name="colls"></param>
        /// <returns></returns>
		public static List<int> GetRangeInt(this string[] colls)
        {
            var list = new List<int>();
            void Check(string[] texts)
            {
                foreach (var text in texts)
                {
                    //if (text.Contains("-"))
                    //{
                    //    Check(text.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries));
                    //    continue;
                    //}
                    if(text.Contains("-"))
                    {
                        var twovalues = text.Split(new string[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
                        for(int i = Convert.ToInt32(twovalues[0]);i <= Convert.ToInt32(twovalues[1]);i++)
                        {
                            list.Add(i);
                        }
                    }
                    else
                    {
                        list.Add(Convert.ToInt32(text.Trim()));
                    }

                }
            }
            Check(colls);
            list.Sort();
            return list;
        }

        public static string GetStrRange(this List<int> lists)
        {
            if (lists?.Any() != true) return string.Empty;
			var list = lists.Distinct().ToList();
			list.Sort();
			var strs = new List<string>();
			for (int i = 0; i < list.Count; i++)
			{
				var temp = new List<int>();
				var ti = -1;
				for (int j = i; j < list.Count; j++)
				{
					if (ti == -1)
					{
						temp.Add(list[j]);
						ti = list[j];
						continue;
					}
					if (list[j] == list[j - 1] + 1)
					{
						temp.Add(list[j]);
						i = j;
					}
					else
					{
						i = j - 1;
						break;
					}
				}
				if (temp.Count > 2)
				{
					strs.Add(temp.First() + "-" + temp.Last());
				}
				else
				{
					strs.Add(string.Join(",", temp));
				}
			}
			return string.Join(",", strs);
		}
    }
}
