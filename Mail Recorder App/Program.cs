using Mail_Recorder_App.DAO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Recorder_App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += myHandler;
            Application.Run(new Form1());
        }

        private static void myHandler(object sender, ThreadExceptionEventArgs e)
        {
            
            Exception ex = e.Exception;
            using (StreamWriter writer = new StreamWriter($"{Path.Combine(DataAccess.BasePath, "errorlog.txt")}", true))
            {
                writer.WriteLine("-----------------------------------------------------------------------------");
                writer.WriteLine("Date : " + DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt"));
                while (ex != null)
                {
                    writer.WriteLine(ex.GetType().FullName);
                    writer.WriteLine("Message : " + ex.Message);
                    writer.WriteLine("StackTrace : " + ex.StackTrace);
                    ex = ex.InnerException;
                }
            }
            string iotype = e?.Exception?.InnerException?.GetType()?.Name;
            string iomsg = e?.Exception?.InnerException?.Message;
            MessageBox.Show($"Unexpected error!\n\n{iotype}\n\n{iomsg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
    }
}
