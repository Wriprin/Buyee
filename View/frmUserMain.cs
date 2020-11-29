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
    public partial class frmUserMain : Form
    {
        private BLL.UserGoodsBLL objUB = new BLL.UserGoodsBLL();

        public frmUserMain()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLL.GoodsBLL objU = new BLL.GoodsBLL();
            dataGridView1.DataSource = objU.GetList(x => true);
            dataGridView1.Refresh();
        }
        //public int ID { get; set; }
        //public string tb1 { get; set; }




        private void button2_Click(object sender, EventArgs e)
        {
            int uid = int.Parse(txtuid.Text);
            int gid = (int)(dataGridView1.SelectedRows[0].Cells["gid"].Value);
            string gtype = (dataGridView1.SelectedRows[0].Cells["gtype"].Value).ToString();
            string gname = (dataGridView1.SelectedRows[0].Cells["gname"].Value).ToString();
            double gprice = (double)(dataGridView1.SelectedRows[0].Cells["gprice"].Value);
            string gstatus = "待付款";

            label3.Text = gid + gtype + gname + gprice;

            string SQL = String.Format("Insert into UserGoods (uid,gid,gtype,gname,gprice,gstatus) values('{0}','{1}','{2}','{3}','{4}','{5}')", uid,gid,gtype,gname,gprice,gstatus);

            if (SqlHelper.ExcuteSQL(SQL) > 0)
            {
                MessageBox.Show("购买成功");
            }
            else
            {
                MessageBox.Show("购买失败");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //public event Action<string> SetTxtEvent;
        //private void button4_Click(object sender, EventArgs e)
        //{
        //    frmLogin frmLogin = new frmLogin();
        //    frmLogin.SetTxtEvent += SetTxt;
        //    frmLogin.Show();
        //}


        //private void SetTxt(string txt1)
        //{
        //    label1.Text = txt1;
        //}

    }
}
