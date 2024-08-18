namespace QLKhachSan
{
    partial class fr_khachhang
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reset = new System.Windows.Forms.Button();
            this.timkiem = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.qq = new System.Windows.Forms.TextBox();
            this.sdt = new System.Windows.Forms.TextBox();
            this.cccd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gt = new System.Windows.Forms.ComboBox();
            this.ns = new System.Windows.Forms.DateTimePicker();
            this.tkh = new System.Windows.Forms.TextBox();
            this.mkh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT KHÁCH HÀNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reset);
            this.panel1.Controls.Add(this.timkiem);
            this.panel1.Controls.Add(this.xoa);
            this.panel1.Controls.Add(this.sua);
            this.panel1.Controls.Add(this.them);
            this.panel1.Controls.Add(this.qq);
            this.panel1.Controls.Add(this.sdt);
            this.panel1.Controls.Add(this.cccd);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.gt);
            this.panel1.Controls.Add(this.ns);
            this.panel1.Controls.Add(this.tkh);
            this.panel1.Controls.Add(this.mkh);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 178);
            this.panel1.TabIndex = 1;
            // 
            // reset
            // 
            this.reset.Image = global::QLKhachSan.Properties.Resources.undo;
            this.reset.Location = new System.Drawing.Point(401, 132);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(114, 32);
            this.reset.TabIndex = 18;
            this.reset.Text = "Reset";
            this.reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // timkiem
            // 
            this.timkiem.Image = global::QLKhachSan.Properties.Resources.search;
            this.timkiem.Location = new System.Drawing.Point(668, 136);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(114, 32);
            this.timkiem.TabIndex = 17;
            this.timkiem.Text = "Tìm kiếm";
            this.timkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.timkiem.UseVisualStyleBackColor = true;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // xoa
            // 
            this.xoa.Image = global::QLKhachSan.Properties.Resources.eraser;
            this.xoa.Location = new System.Drawing.Point(668, 98);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(114, 32);
            this.xoa.TabIndex = 16;
            this.xoa.Text = "Xoá";
            this.xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.Image = global::QLKhachSan.Properties.Resources.pencil;
            this.sua.Location = new System.Drawing.Point(668, 60);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(114, 32);
            this.sua.TabIndex = 15;
            this.sua.Text = "Sửa";
            this.sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.Image = global::QLKhachSan.Properties.Resources.plus;
            this.them.Location = new System.Drawing.Point(668, 22);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(114, 32);
            this.them.TabIndex = 14;
            this.them.Text = "Thêm";
            this.them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // qq
            // 
            this.qq.Location = new System.Drawing.Point(455, 94);
            this.qq.Name = "qq";
            this.qq.Size = new System.Drawing.Size(142, 26);
            this.qq.TabIndex = 13;
            // 
            // sdt
            // 
            this.sdt.Location = new System.Drawing.Point(455, 53);
            this.sdt.Name = "sdt";
            this.sdt.Size = new System.Drawing.Size(142, 26);
            this.sdt.TabIndex = 12;
            // 
            // cccd
            // 
            this.cccd.Location = new System.Drawing.Point(455, 18);
            this.cccd.Name = "cccd";
            this.cccd.Size = new System.Drawing.Size(142, 26);
            this.cccd.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(343, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 19);
            this.label8.TabIndex = 10;
            this.label8.Text = "Quê Quán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(343, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "CCCD/CMND";
            // 
            // gt
            // 
            this.gt.FormattingEnabled = true;
            this.gt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.gt.Location = new System.Drawing.Point(131, 138);
            this.gt.Name = "gt";
            this.gt.Size = new System.Drawing.Size(121, 27);
            this.gt.TabIndex = 7;
            // 
            // ns
            // 
            this.ns.CustomFormat = "MM-dd-yyyy";
            this.ns.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ns.Location = new System.Drawing.Point(130, 96);
            this.ns.Name = "ns";
            this.ns.Size = new System.Drawing.Size(122, 26);
            this.ns.TabIndex = 6;
            // 
            // tkh
            // 
            this.tkh.Location = new System.Drawing.Point(131, 55);
            this.tkh.Name = "tkh";
            this.tkh.Size = new System.Drawing.Size(152, 26);
            this.tkh.TabIndex = 5;
            // 
            // mkh
            // 
            this.mkh.Location = new System.Drawing.Point(130, 19);
            this.mkh.Name = "mkh";
            this.mkh.Size = new System.Drawing.Size(152, 26);
            this.mkh.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khách hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 265);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(7, 26);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(802, 233);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // fr_khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(860, 522);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fr_khachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.fr_khachhang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker ns;
        private System.Windows.Forms.TextBox tkh;
        private System.Windows.Forms.TextBox mkh;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.TextBox qq;
        private System.Windows.Forms.TextBox sdt;
        private System.Windows.Forms.TextBox cccd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox gt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
    }
}