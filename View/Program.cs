using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace View
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

            frmLogin frmL = new frmLogin();

            Application.Run(frmL);

            if (frmL.LoginOk == true)
            {
                Application.Run(new Form1());
            }
            
        }
    }
}
