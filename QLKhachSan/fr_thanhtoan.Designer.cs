namespace QLKhachSan
{
    partial class fr_thanhtoan
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
            this.ndi = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.nd = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.inhoadon = new System.Windows.Forms.Button();
            this.timkiem = new System.Windows.Forms.Button();
            this.thanhtoan = new System.Windows.Forms.Button();
            this.mp = new System.Windows.Forms.TextBox();
            this.tkh = new System.Windows.Forms.TextBox();
            this.mkh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.ndi);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.nd);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.inhoadon);
            this.panel1.Controls.Add(this.timkiem);
            this.panel1.Controls.Add(this.thanhtoan);
            this.panel1.Controls.Add(this.mp);
            this.panel1.Controls.Add(this.tkh);
            this.panel1.Controls.Add(this.mkh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(22, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 279);
            this.panel1.TabIndex = 0;
            // 
            // ndi
            // 
            this.ndi.CustomFormat = "MM-dd-yyyy";
            this.ndi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ndi.Location = new System.Drawing.Point(143, 163);
            this.ndi.Name = "ndi";
            this.ndi.Size = new System.Drawing.Size(143, 26);
            this.ndi.TabIndex = 54;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 19);
            this.label13.TabIndex = 53;
            this.label13.Text = "Ngày đi";
            // 
            // nd
            // 
            this.nd.CustomFormat = "MM-dd-yyyy";
            this.nd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.nd.Location = new System.Drawing.Point(143, 131);
            this.nd.Name = "nd";
            this.nd.Size = new System.Drawing.Size(143, 26);
            this.nd.TabIndex = 52;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 19);
            this.label12.TabIndex = 51;
            this.label12.Text = "Ngày đến";
            // 
            // inhoadon
            // 
            this.inhoadon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.inhoadon.Image = global::QLKhachSan.Properties.Resources.printer;
            this.inhoadon.Location = new System.Drawing.Point(113, 237);
            this.inhoadon.Name = "inhoadon";
            this.inhoadon.Size = new System.Drawing.Size(114, 32);
            this.inhoadon.TabIndex = 29;
            this.inhoadon.Text = "In hoá đơn";
            this.inhoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inhoadon.UseVisualStyleBackColor = true;
            this.inhoadon.Click += new System.EventHandler(this.inhoadon_Click);
            // 
            // timkiem
            // 
            this.timkiem.Image = global::QLKhachSan.Properties.Resources.search;
            this.timkiem.Location = new System.Drawing.Point(188, 199);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(114, 32);
            this.timkiem.TabIndex = 28;
            this.timkiem.Text = "Tìm kiếm";
            this.timkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.timkiem.UseVisualStyleBackColor = true;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // thanhtoan
            // 
            this.thanhtoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.thanhtoan.Image = global::QLKhachSan.Properties.Resources.check;
            this.thanhtoan.Location = new System.Drawing.Point(37, 199);
            this.thanhtoan.Name = "thanhtoan";
            this.thanhtoan.Size = new System.Drawing.Size(114, 32);
            this.thanhtoan.TabIndex = 27;
            this.thanhtoan.Text = "Thanh toán";
            this.thanhtoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.thanhtoan.UseVisualStyleBackColor = true;
            this.thanhtoan.Click += new System.EventHandler(this.thanhtoan_Click);
            // 
            // mp
            // 
            this.mp.Location = new System.Drawing.Point(143, 90);
            this.mp.Name = "mp";
            this.mp.Size = new System.Drawing.Size(177, 26);
            this.mp.TabIndex = 5;
            // 
            // tkh
            // 
            this.tkh.Location = new System.Drawing.Point(143, 55);
            this.tkh.Name = "tkh";
            this.tkh.Size = new System.Drawing.Size(177, 26);
            this.tkh.TabIndex = 4;
            // 
            // mkh
            // 
            this.mkh.Location = new System.Drawing.Point(143, 19);
            this.mkh.Name = "mkh";
            this.mkh.Size = new System.Drawing.Size(177, 26);
            this.mkh.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(384, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 289);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hoạt động";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(7, 26);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(455, 254);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(22, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(830, 271);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hoá đơn";
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(7, 26);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(817, 239);
            this.dgv1.TabIndex = 0;
            // 
            // fr_thanhtoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 591);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fr_thanhtoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Thanh toán";
            this.Load += new System.EventHandler(this.fr_thanhtoan_Load);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mp;
        private System.Windows.Forms.TextBox tkh;
        private System.Windows.Forms.TextBox mkh;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.Button thanhtoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button inhoadon;
        private System.Windows.Forms.DateTimePicker ndi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker nd;
        private System.Windows.Forms.Label label12;
    }
}