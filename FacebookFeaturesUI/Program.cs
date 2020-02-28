using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FacebookFeaturesUI
{
     // $G$ THE-001 (-6) your grade on diagrams document - 94. please see comments inside the document. 50% of your grade).
     public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(MainForm.Instance);
        }
    }
}
