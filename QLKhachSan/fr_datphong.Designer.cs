namespace QLKhachSan
{
    partial class fr_datphong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ngay = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.gio = new System.Windows.Forms.DateTimePicker();
            this.gp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.them = new System.Windows.Forms.Button();
            this.pmd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tkh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mkh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timkiem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lp = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cccd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tenkh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.reset);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.ngay);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.gio);
            this.panel1.Controls.Add(this.gp);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.them);
            this.panel1.Controls.Add(this.pmd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tkh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mkh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 349);
            this.panel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(87, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "ĐẶT PHÒNG";
            // 
            // reset
            // 
            this.reset.Image = global::QLKhachSan.Properties.Resources.undo;
            this.reset.Location = new System.Drawing.Point(175, 306);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(114, 32);
            this.reset.TabIndex = 22;
            this.reset.Text = "Refresh";
            this.reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ngày";
            // 
            // ngay
            // 
            this.ngay.CustomFormat = "MM-dd-yyyy";
            this.ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngay.Location = new System.Drawing.Point(129, 256);
            this.ngay.Name = "ngay";
            this.ngay.Size = new System.Drawing.Size(115, 26);
            this.ngay.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Giờ";
            // 
            // gio
            // 
            this.gio.CustomFormat = "HH:mm:ss";
            this.gio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.gio.Location = new System.Drawing.Point(129, 224);
            this.gio.Name = "gio";
            this.gio.Size = new System.Drawing.Size(96, 26);
            this.gio.TabIndex = 18;
            this.gio.Value = new System.DateTime(2024, 1, 3, 10, 10, 43, 0);
            // 
            // gp
            // 
            this.gp.Location = new System.Drawing.Point(129, 185);
            this.gp.Name = "gp";
            this.gp.Size = new System.Drawing.Size(160, 26);
            this.gp.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Giá phòng";
            // 
            // them
            // 
            this.them.Image = global::QLKhachSan.Properties.Resources.plus;
            this.them.Location = new System.Drawing.Point(27, 306);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(114, 32);
            this.them.TabIndex = 15;
            this.them.Text = "Đặt phòng";
            this.them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // pmd
            // 
            this.pmd.Location = new System.Drawing.Point(129, 138);
            this.pmd.Name = "pmd";
            this.pmd.Size = new System.Drawing.Size(160, 26);
            this.pmd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Phòng muốn đặt";
            // 
            // tkh
            // 
            this.tkh.Location = new System.Drawing.Point(129, 91);
            this.tkh.Name = "tkh";
            this.tkh.Size = new System.Drawing.Size(160, 26);
            this.tkh.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách hàng";
            // 
            // mkh
            // 
            this.mkh.Location = new System.Drawing.Point(129, 49);
            this.mkh.Name = "mkh";
            this.mkh.Size = new System.Drawing.Size(160, 26);
            this.mkh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timkiem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lp);
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(344, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 344);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // timkiem
            // 
            this.timkiem.Image = global::QLKhachSan.Properties.Resources.search;
            this.timkiem.Location = new System.Drawing.Point(211, 69);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(114, 32);
            this.timkiem.TabIndex = 18;
            this.timkiem.Text = "Tìm kiếm";
            this.timkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.timkiem.UseVisualStyleBackColor = true;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Trạng thái phòng";
            // 
            // tt
            // 
            this.tt.FormattingEnabled = true;
            this.tt.Items.AddRange(new object[] {
            "Chưa đặt",
            "Đang sử dụng"});
            this.tt.Location = new System.Drawing.Point(368, 28);
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(121, 27);
            this.tt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại phòng";
            // 
            // lp
            // 
            this.lp.FormattingEnabled = true;
            this.lp.Items.AddRange(new object[] {
            "Đơn",
            "Đôi",
            "VIP"});
            this.lp.Location = new System.Drawing.Point(101, 31);
            this.lp.Name = "lp";
            this.lp.Size = new System.Drawing.Size(121, 27);
            this.lp.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 122);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(487, 207);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cccd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.tenkh);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dgv1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 368);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(824, 369);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // cccd
            // 
            this.cccd.Location = new System.Drawing.Point(495, 40);
            this.cccd.Name = "cccd";
            this.cccd.Size = new System.Drawing.Size(147, 26);
            this.cccd.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "CCCD/CMND";
            // 
            // button1
            // 
            this.button1.Image = global::QLKhachSan.Properties.Resources.search;
            this.button1.Location = new System.Drawing.Point(688, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 32);
            this.button1.TabIndex = 19;
            this.button1.Text = "Tìm kiếm";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tenkh
            // 
            this.tenkh.Location = new System.Drawing.Point(129, 40);
            this.tenkh.Name = "tenkh";
            this.tenkh.Size = new System.Drawing.Size(241, 26);
            this.tenkh.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên khách hàng";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(6, 80);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(811, 289);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // fr_datphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fr_datphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt phòng";
            this.Load += new System.EventHandler(this.fr_datphong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pmd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tkh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mkh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox lp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox tt;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tenkh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.TextBox cccd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.TextBox gp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker ngay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker gio;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label11;
    }
}