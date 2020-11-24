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
    }
}
