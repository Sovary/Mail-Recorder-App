using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Recorder_App.DAO
{
    public class Msg
    {
        public static DialogResult ShowException(Exception ex)
        {
           return MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult ShowDelete()
        {
            return MessageBox.Show("Do you want to deleted?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
        }
    }
}
