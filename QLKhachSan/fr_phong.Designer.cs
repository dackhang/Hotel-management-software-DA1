namespace QLKhachSan
{
    partial class fr_phong
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
            this.lp = new System.Windows.Forms.ComboBox();
            this.mp = new System.Windows.Forms.TextBox();
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
            this.label1.Location = new System.Drawing.Point(296, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT PHÒNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reset);
            this.panel1.Controls.Add(this.timkiem);
            this.panel1.Controls.Add(this.xoa);
            this.panel1.Controls.Add(this.sua);
            this.panel1.Controls.Add(this.them);
            this.panel1.Controls.Add(this.lp);
            this.panel1.Controls.Add(this.mp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 279);
            this.panel1.TabIndex = 1;
            // 
            // reset
            // 
            this.reset.Image = global::QLKhachSan.Properties.Resources.undo;
            this.reset.Location = new System.Drawing.Point(121, 115);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(103, 32);
            this.reset.TabIndex = 23;
            this.reset.Text = "Reset";
            this.reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // timkiem
            // 
            this.timkiem.Image = global::QLKhachSan.Properties.Resources.search;
            this.timkiem.Location = new System.Drawing.Point(185, 204);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(103, 32);
            this.timkiem.TabIndex = 22;
            this.timkiem.Text = "Tìm kiếm";
            this.timkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.timkiem.UseVisualStyleBackColor = true;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // xoa
            // 
            this.xoa.Image = global::QLKhachSan.Properties.Resources.eraser;
            this.xoa.Location = new System.Drawing.Point(50, 204);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(103, 32);
            this.xoa.TabIndex = 21;
            this.xoa.Text = "Xoá";
            this.xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.Image = global::QLKhachSan.Properties.Resources.pencil;
            this.sua.Location = new System.Drawing.Point(185, 153);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(103, 32);
            this.sua.TabIndex = 20;
            this.sua.Text = "Sửa";
            this.sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.Image = global::QLKhachSan.Properties.Resources.plus;
            this.them.Location = new System.Drawing.Point(50, 153);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(103, 32);
            this.them.TabIndex = 19;
            this.them.Text = "Thêm";
            this.them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // lp
            // 
            this.lp.FormattingEnabled = true;
            this.lp.Items.AddRange(new object[] {
            "Đơn - 500000",
            "Đôi - 1000000",
            "VIP - 2000000"});
            this.lp.Location = new System.Drawing.Point(93, 68);
            this.lp.Name = "lp";
            this.lp.Size = new System.Drawing.Size(183, 27);
            this.lp.TabIndex = 3;
            // 
            // mp
            // 
            this.mp.Location = new System.Drawing.Point(93, 20);
            this.mp.Name = "mp";
            this.mp.Size = new System.Drawing.Size(183, 26);
            this.mp.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(332, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 288);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(7, 21);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(460, 261);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // fr_phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 368);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fr_phong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật phòng";
            this.Load += new System.EventHandler(this.fr_phong_Load);
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
        private System.Windows.Forms.ComboBox lp;
        private System.Windows.Forms.TextBox mp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
    }
}