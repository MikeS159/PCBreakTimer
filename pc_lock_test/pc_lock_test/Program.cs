using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PCBreakTimer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainProgramForm());
        }

        static void Application_ApplicationExit(object sender, EventArgs e)
        {
        }
    }
}
