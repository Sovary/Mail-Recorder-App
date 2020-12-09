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
    public partial class Form1 : Form
    {
        public static Form InstanceRoot;
        public Form1()
        {
            InitializeComponent();
            InstanceRoot = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var s = DataAccess.BasePath;
            var init1 = DataAccess.SystemConfigPath;
            var init2 = DataAccess.FilePath;
            
            SetupMenu(menuStrip1.Items);
        }

        public void SetupMenu(ToolStripItemCollection items)
        {
            foreach (var menu in items)
            {
                if (!(menu is ToolStripMenuItem)) continue;
                var sub = menu as ToolStripMenuItem;
                if (sub.HasDropDownItems)
                {
                    SetupMenu(sub.DropDownItems);
                }
                else
                {
                    var className = sub.Tag + string.Empty;
                    sub.Click += (s, o) =>
                    {
                        OpenForm<Form>(className);
                    };
                }
            }
        }

        public static T OpenQuickReport<T>(IQuickReport q) where T : Form
        {
            return OpenForm<T>(typeof(T).Name, q);
        }
        public static T OpenForm<T>() where T : Form
        {
            return OpenForm<T>(typeof(T).Name);
        }
        public static T OpenForm<T>(ILookup look) where T : Form
        {
            Form obj = (T)Activator.CreateInstance(typeof(T),look);
            obj.ShowDialog();
            return (T)(object)obj;
        }
        private static T OpenForm<T>(string classForm,params object[] param)where T:Form
        {
            Type objectType = Type.GetType($"Mail_Recorder_App.{classForm},Mail_Recorder_App", true);
            foreach (Form opened in Application.OpenForms)
            {
                if (objectType.BaseType.Name == typeof(QuickReportForm).Name) continue;
                if (opened.GetType() == objectType)
                {
                    opened.Activate();

                    return (T)(object)opened;
                }
            }
            Form formToOpen;
            if (objectType.BaseType.Name == typeof(QuickReportForm).Name)
            {
                formToOpen = Activator.CreateInstance(objectType,param[0] as IQuickReport) as QuickReportForm;
                formToOpen.WindowState = FormWindowState.Maximized;
            }
            else
            {
                formToOpen = Activator.CreateInstance(objectType) as Form;
            }
            
            formToOpen.MdiParent = InstanceRoot;
            formToOpen.Show();
            return (T)(object)formToOpen;
        }
    }
}
