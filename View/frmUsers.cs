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

        private void BindGrid()
        {
            BLL.UsersBLL objB = new BLL.UsersBLL();
            dataGridView2.DataSource = objB.GetList(x => x.uid == int.Parse(txtUsearch.Text));
            dataGridView2.Refresh();
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

        /// <summary>
        /// 添加新用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                MessageBox.Show("添加失败，用户ID已存在，已经返回主窗体并请重新进入");
                frmMain frmMain = new frmMain();
                this.Hide();
                frmMain.ShowDialog();
                Application.ExitThread();
            }
        }

        /// <summary>
        /// 根据学号查询学生订单信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("请输入要查询的学生的学号");
            }
            else
            {

                BLL.UserGoodsBLL objU = new BLL.UserGoodsBLL();
                dataGridView1.DataSource = objU.GetList(x => x.uid == Convert.ToInt32(txtSearch.Text.ToString()));
                dataGridView1.Refresh();
            }
        }


        private void btnUdelete_Click(object sender, EventArgs e)
        {
            BLL.UserGoodsBLL objU = new BLL.UserGoodsBLL();
            dataGridView1.DataSource = objU.GetList(x => true);
            dataGridView1.Refresh();
        }

        /// <summary>
        /// 用户账户查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>W
        private void btnUsearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsearch.Text))
            {
                MessageBox.Show("请输入要查询的学生的学号");
            }
            else
            {
                BLL.UsersBLL objU = new BLL.UsersBLL();
                dataGridView2.DataSource = objU.GetList(x => x.uid == Convert.ToInt32(txtUsearch.Text.ToString()));
                dataGridView2.Refresh();
            }
        }


        /// <summary>
        /// 用户删除操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUdelete2_Click(object sender, EventArgs e)
        {
            BLL.UsersBLL objUB = new BLL.UsersBLL();
            if (dataGridView2.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("确认要删除该行数据吗？", "删除确认",MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int rst = dataGridView2.SelectedRows.Count;
                    foreach (DataGridViewRow dr in dataGridView2.SelectedRows)
                    {
                        DAL.Users objU = new DAL.Users();
                        objU.uid = (int)dr.Cells["uid"].Value;
                        rst -= objUB.Delete(objU);

                    }
                    if (rst == 0)
                    {
                        MessageBox.Show("删除成功");
                        BLL.UsersBLL objU = new BLL.UsersBLL();
                        dataGridView2.DataSource = objU.GetList(x => true);
                        dataGridView2.Refresh();
                    }
                    else
                        MessageBox.Show("删除失败");
                }
            }
            else
            {
                MessageBox.Show("请先选中要删除的数据");
            }
        }


        private void btnUModify_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 1)
            {
                frmUserUpdate frmUserUpdate = new frmUserUpdate();
                frmUserUpdate.ID = (int)(dataGridView2.SelectedRows[0].Cells["uid"].Value);
                frmUserUpdate.ShowDialog();
                BLL.UsersBLL objU = new BLL.UsersBLL();
                dataGridView2.DataSource = objU.GetList(x => true);
                dataGridView2.Refresh();
            }
            else
            {
                MessageBox.Show("请先选中要修改的一行数据");
            }

        }


        private void frmUsers_Load(object sender, EventArgs e)
        {
            this.label1.Parent = pictureBox1;
            this.label1.BackColor = Color.FromArgb(0, Color.Transparent);
            this.label2.Parent = pictureBox1;
            this.label2.BackColor = Color.FromArgb(0, Color.Transparent);
            this.label3.Parent = pictureBox1;
            this.label3.BackColor = Color.FromArgb(0, Color.Transparent);
            this.label4.Parent = pictureBox1;
            this.label4.BackColor = Color.FromArgb(0, Color.Transparent);
            this.label5.Parent = pictureBox1;
            this.label5.BackColor = Color.FromArgb(0, Color.Transparent);
            this.label6.Parent = pictureBox1;
            this.label6.BackColor = Color.FromArgb(0, Color.Transparent);
            this.label9.Parent = pictureBox1;
            this.label9.BackColor = Color.FromArgb(0, Color.Transparent);

            this.rbMale.Parent = pictureBox1;
            this.rbMale.BackColor = Color.FromArgb(0, Color.Transparent);

            this.rbFemale.Parent = pictureBox1;
            this.rbFemale.BackColor = Color.FromArgb(0, Color.Transparent);

            BLL.UsersBLL objU = new BLL.UsersBLL();
            dataGridView2.DataSource = objU.GetList(x => true);
            dataGridView2.Refresh();

            BLL.UserGoodsBLL objUB = new BLL.UserGoodsBLL();
            dataGridView1.DataSource = objUB.GetList(x => true);
            dataGridView1.Refresh();

            dataGridView2.Columns[0].HeaderCell.Value = "学生ID";
            dataGridView2.Columns[1].HeaderCell.Value = "姓名";
            dataGridView2.Columns[2].HeaderCell.Value = "性别";
            dataGridView2.Columns[3].HeaderCell.Value = "密码";
            dataGridView2.Columns[4].HeaderCell.Value = "学校";


            dataGridView1.Columns[0].HeaderCell.Value = "学生ID";
            dataGridView1.Columns[1].HeaderCell.Value = "商品ID";
            dataGridView1.Columns[2].HeaderCell.Value = "商品类别";
            dataGridView1.Columns[3].HeaderCell.Value = "商品名称";
            dataGridView1.Columns[4].HeaderCell.Value = "商品价格";
            dataGridView1.Columns[5].HeaderCell.Value = "商品状态";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void button4_Click(object sender, EventArgs e)
        {


            BLL.UsersBLL objU = new BLL.UsersBLL();
            dataGridView2.DataSource = objU.GetList(x => true);
            dataGridView2.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int uid = (int)(dataGridView1.SelectedRows[0].Cells["uid"].Value);
            int gid = (int)(dataGridView1.SelectedRows[0].Cells["gid"].Value);

            string SQL = String.Format("delete from UserGoods where uid = {0} and gid = {1}",uid,gid);

            if (SqlHelper.ExcuteSQL(SQL) > 0)
            {
                MessageBox.Show("删除成功");
                BLL.UserGoodsBLL objUB = new BLL.UserGoodsBLL();
                dataGridView1.DataSource = objUB.GetList(x => true);
                dataGridView1.Refresh();

            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private string Note1 = "示例：黑龙江东方学院";
        private string Note2 = "示例：18140123";
        private string Note3 = "示例：王友斌";
        private string Note4 = "示例：wriprin";

        private void txtSchool_Enter(object sender, EventArgs e)
        {
            //  进入时，清空
            if (txtSchool.Text == Note1)
                this.txtSchool.Text = "";
        }

        private void txtSchool_Leave(object sender, EventArgs e)
        {
            //  退出时，重新显示
            if (string.IsNullOrEmpty(txtSchool.Text))
                this.txtSchool.Text = Note1;
        }

        private void txtId_Enter(object sender, EventArgs e)
        {
            //  进入时，清空
            if (txtId.Text == Note2)
                this.txtId.Text = "";
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            //  退出时，重新显示
            if (string.IsNullOrEmpty(txtId.Text))
                this.txtId.Text = Note2;
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            //  进入时，清空
            if (txtName.Text == Note3)
                this.txtName.Text = "";
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            //  退出时，重新显示
            if (string.IsNullOrEmpty(txtName.Text))
                this.txtName.Text = Note3;
        }

        private void txtPwd_Enter(object sender, EventArgs e)
        {
            //  进入时，清空
            if (txtPwd.Text == Note4)
                this.txtPwd.Text = "";
        }

        private void txtPwd_Leave(object sender, EventArgs e)
        {
            //  退出时，重新显示
            if (string.IsNullOrEmpty(txtPwd.Text))
                this.txtPwd.Text = Note4;
        }
    }
}
