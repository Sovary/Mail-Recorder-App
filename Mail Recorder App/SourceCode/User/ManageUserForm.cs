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
    public partial class ManageUserForm : Form
    {
        Facade facade => Facade.Instance;
        User curr;
        public ManageUserForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var r = GetFromForm();
                if (curr == null)
                {
                    facade.AddUser_Validating(r);
                }
                else
                {
                    r.Id = curr.Id;
                    facade.UpdateUser_Validating(r);
                }
                Clear();
                RefreshGrid();
            }
            catch (ValidatingException ex)
            {
                Msg.ShowException(ex);
            }
        }

        User GetFromForm()
        {
            if (string.IsNullOrWhiteSpace(textBoxTGId.Text)) throw new ValidatingException("Telegram ID is invalid item!");
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text)) throw new ValidatingException("Username is invalid item!");
            return new User()
            {
               Password = textBoxPassword.Text,
               UserName = textBoxUsername.Text,
               TelegramId = textBoxTGId.Text,
               Role = comboBoxRole.SelectedItem.ToString(),
            };
        }

        void Clear()
        {
            textBoxUsername.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxTGId.Text = string.Empty;
            buttonAdd.Text = "Add";
        }

        private void ManageUserForm_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshGrid();
            }catch(ValidatingException ex)
            {
                Msg.ShowException(ex);
            }
        }

        void RefreshGrid()
        {
            grid.Rows.Clear();
            var list = facade.GetUsers();
            foreach (User m in list)
            {
                int index = grid.Rows.Add();
                grid.Rows[index].Cells["ColumnUsername"].Value = m.UserName;
                grid.Rows[index].Cells["ColumnRole"].Value = m.Role;
                grid.Rows[index].Tag = m;
            }
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var m = grid.Rows[e.RowIndex].Tag as User;
            PopulateForm(m);
        }

        private void PopulateForm(User m)
        {
            if (m == null)
            {
                Clear();
                return;
            }
            curr = m;
            if(m.UserName==UserFacade.super)
            {
                textBoxPassword.Enabled = false;
                textBoxUsername.Enabled = false;
                textBoxTGId.Enabled = false;
                comboBoxRole.Enabled = false;
            }
            else
            {
                textBoxPassword.Enabled = true;
                textBoxUsername.Enabled = true;
                textBoxTGId.Enabled = true;
                comboBoxRole.Enabled = true;
            }
            textBoxUsername.Text = curr.UserName;
            textBoxTGId.Text = curr.TelegramId;
            comboBoxRole.SelectedItem = curr.Role;
            buttonAdd.Text = "Update";
        }
    }
}
