using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VİZE2011011014
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SENCE());
        }
    }
}
