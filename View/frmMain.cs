using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        //跳转界面
        /*
         * Application.ExitThread();退出当前线程。
         * this.hide();把当前窗体隐藏起来了，
         * another.showdialog();模态弹出新窗口。
         * 模拟弹出窗口后线程不会继续执行（被阻塞了），
         * 直到我们关闭了新弹出来的模态窗口后，程序才会继续执行Application.ExitThread();
         * 此时线程关闭，所有一切都关闭了，隐藏的窗口也关闭了。
         */


        private void button1_Click(object sender, EventArgs e)
        {
            frmGoods frmGoods = new frmGoods();
            this.Hide();
            frmGoods.ShowDialog();
            Application.ExitThread();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUsers frmUsers = new frmUsers();
            this.Hide();
            frmUsers.ShowDialog();
            Application.ExitThread();
        }


    }
}
