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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            pictureBox1.SendToBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.UserBLL objUB = new BLL.UserBLL();
            if (objUB.Login(textBox1.Text, textBox2.Text))
            {
                //MessageBox.Show("Access Ok");
                LoginOk = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Access Denied!");
                LoginOk = false;
            }
        }

        /// <summary>
        /// 是否登录成功标志
        /// </summary>
        public bool LoginOk
        {
            get;
            set;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            this.LoginOk = false;
        }

        /// <summary>
        /// 将焦点放在textBox1上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmLogin_Activated(object sender, EventArgs e)
        {
            this.textBox1.Focus();
        }

        /// <summary>
        /// GM 外链跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "https://wriprin.gitee.io");
        }
    }
}
