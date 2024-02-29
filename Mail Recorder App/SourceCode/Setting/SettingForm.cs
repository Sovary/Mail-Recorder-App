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
    public partial class SettingForm : Form
    {
        Facade facade = Facade.Instance;
        Setting setting;
        public SettingForm()
        {
            InitializeComponent();
            setting = facade.GetSetting();
            if (setting == null) return;
            dateTimePickerMonth.Value = setting?.RecMailMonthly;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                facade.AddSetting(new Setting()
                {
                    RecMailMonthly = (DateTime)dateTimePickerMonth.Value,
                    DayAlert = (int)numberTextBoxDayAlert.DecimalValue.Value,
                });
                Msg.ShowInfo("Done");
            }
            catch(ValidatingException v)
            {
                Msg.ShowException(v);
            }
            
        }
    }
}
