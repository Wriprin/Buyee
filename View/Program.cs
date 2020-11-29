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


            frmUsers frmUsers = new frmUsers();

            frmGoods frmGoods = new frmGoods();

            Application.Run(frmL);

            if (frmL.LoginOk == true)
            {
                Application.Run(new frmMain());
            }

            if (frmL.LoginYes == true)
            {
                Application.Run(new frmUserMain());
            }
            
        }
    }
}
