using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    static class Program
    {
        public static MainForm mainForm { get; set; }
        public static EndForm endForm { get; set; }
        public static StartForm startForm { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainForm();
            endForm = new EndForm();
            startForm = new StartForm();
            Application.Run(new StartForm());
        }
    }
}
