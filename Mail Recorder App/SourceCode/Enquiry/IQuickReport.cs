using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Recorder_App
{
    public interface IQuickReport
    {
        ColumnGrid[] Columns { get; }
        string FormCaption { get; }
        void OnPublishGrid(DataGridView grid);

        void OnGridDrillDown(DataGridViewCellEventArgs cellEv, DataGridViewRow row);
    }
}
