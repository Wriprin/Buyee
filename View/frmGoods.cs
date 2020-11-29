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
    public partial class frmGoods : Form
    {
        private BLL.GoodsBLL objRB = new BLL.GoodsBLL();

        public frmGoods()
        {
            InitializeComponent();
        }

        private void BindGrid()
        {
            BLL.UsersBLL objB = new BLL.UsersBLL();
            dataGridView1.DataSource = objB.GetList(x => x.uid == int.Parse(txtGsearch.Text));
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            this.Hide();
            frmMain.ShowDialog();
            Application.ExitThread();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DAL.Goods objR = new DAL.Goods();
            objR.gid = Convert.ToInt32(txtGid.Text);
            objR.gtype = txtGtype.Text;
            objR.gname = txtGname.Text;
            objR.gprice = Convert.ToDouble(txtGprice.Text);

            if (objRB.Add(objR) > 0)
            {
                MessageBox.Show("商品添加成功");
            }
            else
            {
                MessageBox.Show("添加失败，商品ID已存在，已经返回主窗体并请重新进入");
                frmMain frmMain = new frmMain();
                this.Hide();
                frmMain.ShowDialog();
                Application.ExitThread();
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }

        private void btnGsearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGsearch.Text))
            {
                MessageBox.Show("请输入要查询的商品的ID");
            }
            else
            {
                BLL.GoodsBLL objU = new BLL.GoodsBLL();
                dataGridView1.DataSource = objU.GetList(x => x.gid == Convert.ToInt32(txtGsearch.Text.ToString()));
                dataGridView1.Refresh();
            }
            
        }

        private void btnGallSearch_Click(object sender, EventArgs e)
        {
            BLL.GoodsBLL objU = new BLL.GoodsBLL();
            dataGridView1.DataSource = objU.GetList(x => true);
            dataGridView1.Refresh();
        }

        private void btnGmodify_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                frmGoodUpdate frmGoodUpdate = new frmGoodUpdate();
                frmGoodUpdate.ID = (int)(dataGridView1.SelectedRows[0].Cells["gid"].Value);
                frmGoodUpdate.ShowDialog();

                BLL.GoodsBLL objB = new BLL.GoodsBLL();
                dataGridView1.DataSource = objB.GetList(x => true);
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("请先选中要修改的一行数据");
            }
        }


        private void btnGdelete_Click(object sender, EventArgs e)
        {
            BLL.GoodsBLL objUB = new BLL.GoodsBLL();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("确认要删除该行数据吗？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    int rst = dataGridView1.SelectedRows.Count;
                    foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                    {
                        DAL.Goods objU = new DAL.Goods();
                        objU.gid = (int)dr.Cells["gid"].Value;
                        rst -= objUB.Delete(objU);
                    }

                    if (rst == 0)
                    {
                        MessageBox.Show("删除成功");
                        BLL.GoodsBLL objB = new BLL.GoodsBLL();
                        dataGridView1.DataSource = objB.GetList(x => true);
                        dataGridView1.Refresh();
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

        private void frmGoods_Load(object sender, EventArgs e)
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
            this.label9.Parent = pictureBox1;
            this.label9.BackColor = Color.FromArgb(0, Color.Transparent);

            BLL.GoodsBLL objU = new BLL.GoodsBLL();
            dataGridView1.DataSource = objU.GetList(x => true);
            dataGridView1.Refresh();


            string SQL = "select Users.uid as 学生ID,uname as 学生姓名,usex as 学生性别," +
             "upwd as 学生密码,uschool as 学生学校,gid as 商品ID,gtype as 商品类型," +
             "gname as 商品名称,gprice as 商品价格,gstatus as 商品状态 " +
             "from Users inner join UserGoods on Users.uid = UserGoods.uid";
            DataSet objDs = SqlHelper.CreateDataSet(SQL);
            dataGridView2.DataSource = objDs.Tables[0];

            dataGridView1.Columns[0].HeaderCell.Value = "商品ID";
            dataGridView1.Columns[1].HeaderCell.Value = "商品类别";
            dataGridView1.Columns[2].HeaderCell.Value = "商品名称";
            dataGridView1.Columns[3].HeaderCell.Value = "商品价格";


            dataGridView2.Columns[0].HeaderCell.Value = "学生ID";
            dataGridView2.Columns[1].HeaderCell.Value = "姓名";
            dataGridView2.Columns[2].HeaderCell.Value = "性别";
            dataGridView2.Columns[3].HeaderCell.Value = "密码";
            dataGridView2.Columns[4].HeaderCell.Value = "学校";
            dataGridView2.Columns[5].HeaderCell.Value = "商品ID";
            dataGridView2.Columns[6].HeaderCell.Value = "商品类别";
            dataGridView2.Columns[7].HeaderCell.Value = "商品名称";
            dataGridView2.Columns[8].HeaderCell.Value = "商品价格";
            dataGridView2.Columns[9].HeaderCell.Value = "商品状态";


        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void btnAllSearch_Click(object sender, EventArgs e)
        {
            string SQL = "select Users.uid as 学生ID,uname as 学生姓名,usex as 学生性别," +
                         "upwd as 学生密码,uschool as 学生学校,gid as 商品ID,gtype as 商品类型," +
                         "gname as 商品名称,gprice as 商品价格,gstatus as 商品状态 " +
                         "from Users inner join UserGoods on Users.uid = UserGoods.uid";
            DataSet objDs = SqlHelper.CreateDataSet(SQL);
            dataGridView2.DataSource = objDs.Tables[0];
        }



        private string Note1 = "示例：5001";
        private string Note2 = "示例：生活用品";
        private string Note3 = "示例：笔记本";
        private string Note4 = "示例：5";


        private void txtGid_Enter(object sender, EventArgs e)
        {
            //  进入时，清空
            if (txtGid.Text == Note1)
                this.txtGid.Text = "";
        }

        private void txtGid_Leave(object sender, EventArgs e)
        {
            //  退出时，重新显示
            if (string.IsNullOrEmpty(txtGid.Text))
                this.txtGid.Text = Note1;
        }

        private void txtGtype_Enter(object sender, EventArgs e)
        {
            //  进入时，清空
            if (txtGtype.Text == Note2)
                this.txtGtype.Text = "";
        }

        private void txtGtype_Leave(object sender, EventArgs e)
        {
            //  退出时，重新显示
            if (string.IsNullOrEmpty(txtGtype.Text))
                this.txtGtype.Text = Note2;
        }

        private void txtGname_Enter(object sender, EventArgs e)
        {
            //  进入时，清空
            if (txtGname.Text == Note3)
                this.txtGname.Text = "";
        }

        private void txtGname_Leave(object sender, EventArgs e)
        {
            //  退出时，重新显示
            if (string.IsNullOrEmpty(txtGname.Text))
                this.txtGname.Text = Note3;
        }

        private void txtGprice_Enter(object sender, EventArgs e)
        {
            //  进入时，清空
            if (txtGprice.Text == Note4)
                this.txtGprice.Text = "";
        }

        private void txtGprice_Leave(object sender, EventArgs e)
        {
            //  退出时，重新显示
            if (string.IsNullOrEmpty(txtGprice.Text))
                this.txtGprice.Text = Note4;
        }
    }
}
