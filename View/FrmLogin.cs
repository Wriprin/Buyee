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

            this.pictureBox2.Parent = pictureBox1;
            this.pictureBox2.BackColor = Color.FromArgb(0, Color.Transparent);
            this.pictureBox3.Parent = pictureBox1;
            this.pictureBox3.BackColor = Color.FromArgb(0, Color.Transparent);
            this.pictureBox4.Parent = pictureBox1;
            this.pictureBox4.BackColor = Color.FromArgb(0, Color.Transparent);
            this.label3.Parent = pictureBox1;
            this.label3.BackColor = Color.FromArgb(0, Color.Transparent);
            this.label4.Parent = pictureBox1;
            this.label4.BackColor = Color.FromArgb(0, Color.Transparent);
            this.label5.Parent = pictureBox1;
            this.label5.BackColor = Color.FromArgb(0, Color.Transparent);
            this.label7.Parent = pictureBox1;
            this.label7.BackColor = Color.FromArgb(0, Color.Transparent);

        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    BLL.AdminBLL objUB = new BLL.AdminBLL();
        //    BLL.UsersBLL objUU = new BLL.UsersBLL();
        //    if (objUB.Login(textBox1.Text, textBox2.Text))
        //    {
        //        LoginOk = true;
        //        this.Close();
        //    }
        //    else if (objUU.Login(textBox1.Text, textBox2.Text))
        //    {
        //        LoginYes = true;
        //        this.Close();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Access Denied!");
        //        LoginOk = false;
        //    }
        //}

        /// <summary>
        /// 是否登录成功标志
        /// </summary>
        public bool LoginOk
        {
            get;
            set;
        }

        public bool LoginYes
        {
            get;
            set;
        }


        
        
        private void frmLogin_Load(object sender, EventArgs e)
        {

            this.LoginOk = false;
            this.LoginYes = false;

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


        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        //public event Action<string> SetTxtEvent;


        private void label7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "https://wriprin.gitee.io");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.AdminBLL objUB = new BLL.AdminBLL();
            BLL.UsersBLL objUU = new BLL.UsersBLL();
            if (objUB.Login(textBox1.Text, textBox2.Text))
            {
                LoginOk = true;
                this.Close();
            }
            else if (objUU.Login(textBox1.Text, textBox2.Text))
            {
                LoginYes = true;
                this.Close();
                //SetTxtEvent(textBox1.Text);
            }
            else
            {
                MessageBox.Show("Access Denied!");
                LoginOk = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginYes = true;
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "https://github.com/Wriprin/Eshop/tree/master");
        }
    }
}
