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
    public partial class ManageOperatorForm : Form, ILookup
    {
        Facade facade =Facade.Instance;
        public ManageOperatorForm()
        {
            InitializeComponent();
            lookupControl1.ButtonLookup.Click += ButtonLookup_Click;
            comboBoxType.Items.AddRange(facade.GetOperatorTypes());
        }

        private void ButtonLookup_Click(object sender, EventArgs e)
        {
            Form1.OpenForm<OperatorLookupForm>(this).ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Operator o= GetFromForm();
                var curr = CurrentOp;
                if (curr != null)
                {
                    o.Id = curr.Id;
                    facade.UpdateOperator_Validating(o);
                }
                else
                {
                    facade.AddOperator_Validating(o);
                }
                Clear();

            }
            catch (ValidatingException ex)
            {
                Msg.ShowException(ex);
            }
        }

        Operator GetFromForm()
        {
            var o = new Operator()
            {
                Name = lookupControl1.LookupTextBox.Text,
                Type = comboBoxType.SelectedItem as string,
            };
            return o;
        }


        void Clear()
        {
            CurrentOp = null;
            lookupControl1.LookupTextBox.Text = string.Empty;
            comboBoxType.SelectedIndex = -1;
            buttonAdd.Text = "Add";
        }

        Operator CurrentOp
        {
            get
            {
                return lookupControl1.Tag as Operator;
            }
            set
            {
                lookupControl1.Tag = value;
                if(value == null)
                {
                    lookupControl1.LookupTextBox.Text = string.Empty;
                }
                else
                {
                    lookupControl1.LookupTextBox.Text = value.Name;
                    comboBoxType.SelectedItem = value.Type;
                    buttonAdd.Text = "Update";
                }
            }
        }
        public void Lookup(object o)
        {
            if (o is Operator)
            {
                CurrentOp = (Operator)o;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (Msg.ShowDelete() != DialogResult.Yes) return;
                if (CurrentOp == null) throw new ValidatingException("Item does not exist!");
                facade.RemoveOperator_Validating(CurrentOp.Id);
                Clear();
            }
            catch(ValidatingException ex)
            {
                Msg.ShowException(ex);
            }
        }
    }
}
