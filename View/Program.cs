﻿using System;
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

            Application.Run(frmUsers);

            if (frmL.LoginOk == true)
            {
                Application.Run(new frmMain());
            }
            
        }
    }
}
