using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PrintingViaReports {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.Run(new Form1());
        }
    }
}