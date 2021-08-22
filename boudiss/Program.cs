using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace boudiss
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// ///boudiss mod1
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
