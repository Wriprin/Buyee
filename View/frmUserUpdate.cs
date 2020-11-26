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
    public partial class frmUserUpdate : Form
    {
        private BLL.UsersBLL objUB = new BLL.UsersBLL();

        public frmUserUpdate()
        {
            InitializeComponent();
        }

        private void frmUserUpdate_Load(object sender, EventArgs e)
        {
            DAL.Users objU = objUB.GetModel(ID);

            txtId.Text = (objU.uid).ToString();
            txtName.Text = objU.uname;
            txtPwd.Text = objU.upwd;
            txtSchool.Text = objU.uschool;
            if (objU.usex == '男'.ToString())
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;
        }

        public int ID { get; set; }


        private void btnUmodify_Click(object sender, EventArgs e)
        {
            DAL.Users objU = new DAL.Users();
            objU.uid = int.Parse(txtId.Text);
            objU.uname = txtName.Text;
            objU.upwd = txtPwd.Text;
            objU.uschool = txtSchool.Text;
            objU.usex = (rbMale.Checked ? '男' : '女').ToString();

            if (objUB.Update(objU) > 0)
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败，学号已存在");
            }
        }

        
    }
}
