namespace QLKhachSan
{
    partial class fr_sudungphong
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
            this.huy = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ngay = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.gio = new System.Windows.Forms.DateTimePicker();
            this.tdv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.them = new System.Windows.Forms.Button();
            this.dv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tkh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mkh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.panel1.Controls.Add(this.huy);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.mp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.reset);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.ngay);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.gio);
            this.panel1.Controls.Add(this.tdv);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.them);
            this.panel1.Controls.Add(this.dv);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tkh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mkh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(21, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 361);
            this.panel1.TabIndex = 1;
            // 
            // huy
            // 
            this.huy.Image = global::QLKhachSan.Properties.Resources.close;
            this.huy.Location = new System.Drawing.Point(278, 297);
            this.huy.Name = "huy";
            this.huy.Size = new System.Drawing.Size(114, 32);
            this.huy.TabIndex = 27;
            this.huy.Text = "Huỷ";
            this.huy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.huy.UseVisualStyleBackColor = true;
            this.huy.Click += new System.EventHandler(this.huy_Click);
            // 
            // button2
            // 
            this.button2.Image = global::QLKhachSan.Properties.Resources.search;
            this.button2.Location = new System.Drawing.Point(149, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 32);
            this.button2.TabIndex = 26;
            this.button2.Text = "Tìm kiếm";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mp
            // 
            this.mp.Location = new System.Drawing.Point(167, 111);
            this.mp.Name = "mp";
            this.mp.Size = new System.Drawing.Size(160, 26);
            this.mp.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Mã phòng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(134, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "ĐẶT PHÒNG";
            // 
            // reset
            // 
            this.reset.Image = global::QLKhachSan.Properties.Resources.undo;
            this.reset.Location = new System.Drawing.Point(282, 220);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(110, 32);
            this.reset.TabIndex = 22;
            this.reset.Text = "Refresh";
            this.reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ngày";
            // 
            // ngay
            // 
            this.ngay.CustomFormat = "MM-dd-yyyy";
            this.ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngay.Location = new System.Drawing.Point(167, 254);
            this.ngay.Name = "ngay";
            this.ngay.Size = new System.Drawing.Size(115, 26);
            this.ngay.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Giờ";
            // 
            // gio
            // 
            this.gio.CustomFormat = "HH:mm:ss";
            this.gio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.gio.Location = new System.Drawing.Point(167, 221);
            this.gio.Name = "gio";
            this.gio.Size = new System.Drawing.Size(96, 26);
            this.gio.TabIndex = 18;
            this.gio.Value = new System.DateTime(2024, 1, 3, 21, 16, 16, 0);
            // 
            // tdv
            // 
            this.tdv.Location = new System.Drawing.Point(167, 183);
            this.tdv.Name = "tdv";
            this.tdv.Size = new System.Drawing.Size(160, 26);
            this.tdv.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Tiền dịch vụ";
            // 
            // them
            // 
            this.them.Image = global::QLKhachSan.Properties.Resources.plus;
            this.them.Location = new System.Drawing.Point(13, 297);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(114, 32);
            this.them.TabIndex = 15;
            this.them.Text = "Đặt dịch vụ";
            this.them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // dv
            // 
            this.dv.Location = new System.Drawing.Point(167, 149);
            this.dv.Name = "dv";
            this.dv.Size = new System.Drawing.Size(160, 26);
            this.dv.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dịch vụ";
            // 
            // tkh
            // 
            this.tkh.Location = new System.Drawing.Point(167, 79);
            this.tkh.Name = "tkh";
            this.tkh.Size = new System.Drawing.Size(160, 26);
            this.tkh.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên khách hàng";
            // 
            // mkh
            // 
            this.mkh.Location = new System.Drawing.Point(167, 47);
            this.mkh.Name = "mkh";
            this.mkh.Size = new System.Drawing.Size(160, 26);
            this.mkh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(449, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 358);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(16, 26);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(494, 312);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(21, 379);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(938, 315);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hoạt động";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(7, 26);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(925, 283);
            this.dgv1.TabIndex = 0;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // fr_sudungphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 706);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fr_sudungphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Đặt dịch vụ";
            this.Load += new System.EventHandler(this.fr_sudungphong_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox mp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker ngay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker gio;
        private System.Windows.Forms.TextBox tdv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.TextBox dv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tkh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mkh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button huy;
    }
}