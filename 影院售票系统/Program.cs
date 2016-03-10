using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using 影院售票系统.CinemaUI;

namespace 影院售票系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
