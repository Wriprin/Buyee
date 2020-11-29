namespace View
{
    partial class frmGoods
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoods));
            this.查找 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtGprice = new System.Windows.Forms.TextBox();
            this.txtGname = new System.Windows.Forms.TextBox();
            this.txtGtype = new System.Windows.Forms.TextBox();
            this.txtGid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGmodify = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGallSearch = new System.Windows.Forms.Button();
            this.btnGdelete = new System.Windows.Forms.Button();
            this.btnGsearch = new System.Windows.Forms.Button();
            this.txtGsearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataSet1 = new System.Data.DataSet();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnAllSearch = new System.Windows.Forms.Button();
            this.查找.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // 查找
            // 
            this.查找.Controls.Add(this.tabPage1);
            this.查找.Controls.Add(this.tabPage2);
            this.查找.Controls.Add(this.tabPage3);
            this.查找.Cursor = System.Windows.Forms.Cursors.Default;
            this.查找.Font = new System.Drawing.Font("方正粗黑宋简体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.查找.Location = new System.Drawing.Point(0, 0);
            this.查找.Name = "查找";
            this.查找.SelectedIndex = 0;
            this.查找.Size = new System.Drawing.Size(857, 513);
            this.查找.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.txtGprice);
            this.tabPage1.Controls.Add(this.txtGname);
            this.tabPage1.Controls.Add(this.txtGtype);
            this.tabPage1.Controls.Add(this.txtGid);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(849, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "添加商品";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Timer";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PowderBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("方正粗黑宋简体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(585, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 45);
            this.button2.TabIndex = 11;
            this.button2.Text = "添加";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtGprice
            // 
            this.txtGprice.Location = new System.Drawing.Point(328, 324);
            this.txtGprice.Name = "txtGprice";
            this.txtGprice.Size = new System.Drawing.Size(232, 34);
            this.txtGprice.TabIndex = 10;
            // 
            // txtGname
            // 
            this.txtGname.Location = new System.Drawing.Point(328, 248);
            this.txtGname.Name = "txtGname";
            this.txtGname.Size = new System.Drawing.Size(232, 34);
            this.txtGname.TabIndex = 9;
            // 
            // txtGtype
            // 
            this.txtGtype.Location = new System.Drawing.Point(328, 183);
            this.txtGtype.Name = "txtGtype";
            this.txtGtype.Size = new System.Drawing.Size(232, 34);
            this.txtGtype.TabIndex = 8;
            // 
            // txtGid
            // 
            this.txtGid.Location = new System.Drawing.Point(328, 119);
            this.txtGid.Name = "txtGid";
            this.txtGid.Size = new System.Drawing.Size(232, 34);
            this.txtGid.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Font = new System.Drawing.Font("方正粗黑宋简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(238, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "价格";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("方正粗黑宋简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("方正粗黑宋简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("方正粗黑宋简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "编号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("方正粗黑宋简体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(321, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "商品添加表";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("方正粗黑宋简体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(758, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "主界面";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::View.Properties.Resources.banner03;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1254, 593);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGmodify);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.btnGallSearch);
            this.tabPage2.Controls.Add(this.btnGdelete);
            this.tabPage2.Controls.Add(this.btnGsearch);
            this.tabPage2.Controls.Add(this.txtGsearch);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(849, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "商品详情";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGmodify
            // 
            this.btnGmodify.Font = new System.Drawing.Font("方正粗黑宋简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGmodify.Location = new System.Drawing.Point(431, 22);
            this.btnGmodify.Name = "btnGmodify";
            this.btnGmodify.Size = new System.Drawing.Size(103, 39);
            this.btnGmodify.TabIndex = 6;
            this.btnGmodify.Text = "修改";
            this.btnGmodify.UseVisualStyleBackColor = true;
            this.btnGmodify.Click += new System.EventHandler(this.btnGmodify_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(857, 410);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnGallSearch
            // 
            this.btnGallSearch.Font = new System.Drawing.Font("方正粗黑宋简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGallSearch.Location = new System.Drawing.Point(667, 22);
            this.btnGallSearch.Name = "btnGallSearch";
            this.btnGallSearch.Size = new System.Drawing.Size(144, 39);
            this.btnGallSearch.TabIndex = 4;
            this.btnGallSearch.Text = "全部商品查询";
            this.btnGallSearch.UseVisualStyleBackColor = true;
            this.btnGallSearch.Click += new System.EventHandler(this.btnGallSearch_Click);
            // 
            // btnGdelete
            // 
            this.btnGdelete.Font = new System.Drawing.Font("方正粗黑宋简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGdelete.Location = new System.Drawing.Point(549, 22);
            this.btnGdelete.Name = "btnGdelete";
            this.btnGdelete.Size = new System.Drawing.Size(103, 39);
            this.btnGdelete.TabIndex = 3;
            this.btnGdelete.Text = "删除";
            this.btnGdelete.UseVisualStyleBackColor = true;
            this.btnGdelete.Click += new System.EventHandler(this.btnGdelete_Click);
            // 
            // btnGsearch
            // 
            this.btnGsearch.Font = new System.Drawing.Font("方正粗黑宋简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGsearch.Location = new System.Drawing.Point(313, 22);
            this.btnGsearch.Name = "btnGsearch";
            this.btnGsearch.Size = new System.Drawing.Size(103, 39);
            this.btnGsearch.TabIndex = 2;
            this.btnGsearch.Text = "查询";
            this.btnGsearch.UseVisualStyleBackColor = true;
            this.btnGsearch.Click += new System.EventHandler(this.btnGsearch_Click);
            // 
            // txtGsearch
            // 
            this.txtGsearch.Font = new System.Drawing.Font("方正粗黑宋简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtGsearch.Location = new System.Drawing.Point(128, 26);
            this.txtGsearch.Name = "txtGsearch";
            this.txtGsearch.Size = new System.Drawing.Size(162, 32);
            this.txtGsearch.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("方正粗黑宋简体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(8, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "商品编号";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "Dataset1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAllSearch);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(849, 485);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "总表联合查询";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(849, 439);
            this.dataGridView2.TabIndex = 0;
            // 
            // btnAllSearch
            // 
            this.btnAllSearch.Font = new System.Drawing.Font("方正粗黑宋简体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAllSearch.Location = new System.Drawing.Point(271, 3);
            this.btnAllSearch.Name = "btnAllSearch";
            this.btnAllSearch.Size = new System.Drawing.Size(309, 45);
            this.btnAllSearch.TabIndex = 1;
            this.btnAllSearch.Text = "总表联合查询";
            this.btnAllSearch.UseVisualStyleBackColor = true;
            this.btnAllSearch.Click += new System.EventHandler(this.btnAllSearch_Click);
            // 
            // frmGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 512);
            this.Controls.Add(this.查找);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "校园内部在线购物管理系统";
            this.Load += new System.EventHandler(this.frmGoods_Load);
            this.查找.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl 查找;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGid;
        private System.Windows.Forms.TextBox txtGprice;
        private System.Windows.Forms.TextBox txtGname;
        private System.Windows.Forms.TextBox txtGtype;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGsearch;
        private System.Windows.Forms.TextBox txtGsearch;
        private System.Windows.Forms.Button btnGallSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGdelete;
        private System.Windows.Forms.Button btnGmodify;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnAllSearch;
    }
}