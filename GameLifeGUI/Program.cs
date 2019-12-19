using System;
using System.Windows.Forms;

namespace GameLifeGUI
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
            MainForm form = new MainForm()
            {
                GameLatency = 100
            };
            Application.Run(form);
        }
    }
}
