using Mail_Recorder_App.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Recorder_App
{
    public partial class OperatorLookupForm : Form
    {
        Facade facade => Facade.Instance;
        ILookup ilookup;
        public OperatorLookupForm(ILookup ilookup)
        {
            InitializeComponent();
            this.ilookup = ilookup;
        }

        private void OperatorLookupForm_Load(object sender, EventArgs e)
        {
            List<Operator> list = facade.GetOperators();
            list.Sort((x,y)=>string.CompareOrdinal(x.Name,y.Name));
            foreach(var o in list)
            {
                var index = grid.Rows.Add();
                grid.Rows[index].Cells["ColumnName"].Value = o.Name;
                grid.Rows[index].Cells["ColumnType"].Value = o.Type;
                grid.Rows[index].Tag = o;
            }
        }
        void DropItem()
        {
            if (grid.SelectedRows.Count > 1) return;
            DialogResult = DialogResult.OK;
            ilookup.Lookup(grid.SelectedRows[0].Tag);
        }
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            DropItem();
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DropItem();
        }
    }
}
