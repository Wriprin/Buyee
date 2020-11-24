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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.ShowDialog();
            Application.ExitThread();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BLL.UsersBLL objRB = new BLL.UsersBLL();

            DAL.Users objR = new DAL.Users();
            objR.uschool = txtSchool.Text;
            objR.uid = Convert.ToInt32(txtId.Text);
            objR.uname = txtName.Text;
            objR.upwd = txtPwd.Text;
            objR.usex = (rbMale.Checked ? '男' : '女').ToString();

            if (objRB.Add(objR) > 0)
            {
                MessageBox.Show("用户注册成功");
            }
            else
            {
                MessageBox.Show("注册失败");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BLL.UserGoodsBLL objU = new BLL.UserGoodsBLL();
            dataGridView1.DataSource = objU.GetList(x => true);
            dataGridView1.Refresh();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            BLL.UserGoodsBLL objUB = new BLL.UserGoodsBLL();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rst = dataGridView1.SelectedRows.Count;
                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    DAL.UserGoods objU = new DAL.UserGoods();
                    objU.uid = (int)dr.Cells["uid"].Value;
                    rst -= objUB.Delete(objU);

                }
                if (rst == 0)
                    MessageBox.Show("删除成功");
                else
                    MessageBox.Show("删除失败");
            }
            else
            {
                MessageBox.Show("请先选中要删除的数据");
            }
        }
    }
}
