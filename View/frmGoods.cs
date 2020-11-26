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
                MessageBox.Show("添加失败");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {

        }

        private void btnGsearch_Click(object sender, EventArgs e)
        {
            if (txtGsearch.Text.ToString() == null)
            {
                MessageBox.Show("请输入要查询的商品的ID");
            }
            BLL.GoodsBLL objU = new BLL.GoodsBLL();
            dataGridView1.DataSource = objU.GetList(x => x.gid == Convert.ToInt32(txtGsearch.Text.ToString()));
            dataGridView1.Refresh();
        }

        private void btnGallSearch_Click(object sender, EventArgs e)
        {
            BLL.GoodsBLL objU = new BLL.GoodsBLL();
            dataGridView1.DataSource = objU.GetList(x => true);
            dataGridView1.Refresh();
        }

        private void btnGmodify_Click(object sender, EventArgs e)
        {
            //TabControl tabControl = new TabControl();
            //MessageBox.Show((tabControl.SelectedIndex).ToString());
            //this.tabPage3.Show();
            //tabControl.SelectedIndex = -1;
            
        }
    }
}
