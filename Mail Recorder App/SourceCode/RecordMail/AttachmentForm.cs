using Mail_Recorder_App.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mail_Recorder_App
{
    public partial class AttachmentForm : Form
    {
        public List<AttachHelp> HelperAttachments = new List<AttachHelp>();
        private List<AttachHelp> RemoveAttachments = new List<AttachHelp>();
        public AttachmentForm(List<AttachHelp> attach)
        {
            InitializeComponent();
            if (attach?.Any() == true)
            {
                foreach (var at in attach.GroupBy(p=>p.Attach.GetHashCode()))
                {
                    if (at.Count() > 1)
                    {
                        RemoveAttachments.Add(at.Last(p => p.Todo == AttachHelp.State.Remove));
                        continue;
                    }
                    AddGrid(at.Last());
                }
            }
        }

        void AddGrid(AttachHelp att)
        {
            int index = grid.Rows.Add();
            grid.Rows[index].Cells["ColumnName"].Value = att.Attach.Name;
            grid.Rows[index].Tag = att;
        }

        private void buttonAttach_Click(object sender, EventArgs e)
        {
            var filedialog = new OpenFileDialog();
            if (filedialog.ShowDialog() != DialogResult.OK) return;
            AddGrid(new AttachHelp()
            {
                Todo = AttachHelp.State.Add,
                Attach =new RecordMailAttachment()
                {
                    Name = Path.GetFileName(filedialog.FileName),
                    Path = filedialog.FileName
                }
            });
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            foreach (DataGridViewRow row in grid.Rows)
            {
                var ra = row.Tag as AttachHelp;
                if (ra.Todo == AttachHelp.State.NA) continue;
                HelperAttachments.Add(ra);
            }
            HelperAttachments.AddRange(RemoveAttachments);
        }

        private void grid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete) return;
            if (grid.SelectedRows.Count < 1) return;
            for(int i=grid.SelectedRows.Count-1;i>=0;i--)
            {
                var row = grid.SelectedRows[i];
                var ra = row.Tag as AttachHelp;
                if (ra == null) continue;
                
                if(HelperAttachments.Any())
                {
                    int index = HelperAttachments.FindIndex(p => p.GetHashCode() == ra.GetHashCode());
                    if (index > 0)
                    {
                        if (ra.Todo == AttachHelp.State.Add)
                        {
                            HelperAttachments.RemoveAt(index);
                        }
                    }
                }
                if(ra.Todo == AttachHelp.State.NA)
                {
                    ra.Todo = AttachHelp.State.Remove;
                    RemoveAttachments.Add(ra);
                }
                grid.Rows.RemoveAt(row.Index);
            }
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var atthelp = grid.Rows[e.RowIndex].Tag as AttachHelp;
            if (atthelp == null) return;
            if (atthelp.Todo != AttachHelp.State.NA) return;
            System.Diagnostics.Process.Start(Path.Combine(Facade.FilePath, atthelp.Attach.Path));
        }
    }
}
