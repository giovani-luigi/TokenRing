using System;
using System.Windows.Forms;
using TokenRingDemo.GUI;

namespace TokenRingDemo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var formStart = new FormNewNode();
            
            Application.Run(formStart);

            if (formStart.Start) {
                Application.Run(new CustomApplicationContext(formStart.NodeCount));
            }
        }
    }
}
