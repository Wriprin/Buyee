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
    public partial class frmGoodUpdate : Form
    {
        private BLL.GoodsBLL objUB = new BLL.GoodsBLL();
        private void frmGoodUpdate_Load(object sender, EventArgs e)
        {
            DAL.Goods objU = objUB.GetModel(ID);

            txtGidModify.Text = (objU.gid).ToString();
            txtGtypeModify.Text = objU.gtype;
            txtGnameModify.Text = objU.gname;
            txtGpriceModify.Text = (objU.gprice).ToString();
        }

        public int ID
        {
            get;
            set;
        }
        public frmGoodUpdate()
        {
            InitializeComponent();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            DAL.Goods objU = new DAL.Goods();
            objU.gid = int.Parse(txtGidModify.Text);
            objU.gtype = txtGtypeModify.Text;
            objU.gname = txtGnameModify.Text;
            objU.gprice = double.Parse(txtGpriceModify.Text);

            if (objUB.Update(objU) > 0)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }


    }
}
