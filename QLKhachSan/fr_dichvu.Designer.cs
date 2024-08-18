namespace QLKhachSan
{
    partial class fr_dichvu
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
            this.reset = new System.Windows.Forms.Button();
            this.timkiem = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.sua = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.TextBox();
            this.tdv = new System.Windows.Forms.TextBox();
            this.mdv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reset);
            this.panel1.Controls.Add(this.timkiem);
            this.panel1.Controls.Add(this.xoa);
            this.panel1.Controls.Add(this.sua);
            this.panel1.Controls.Add(this.them);
            this.panel1.Controls.Add(this.dg);
            this.panel1.Controls.Add(this.tdv);
            this.panel1.Controls.Add(this.mdv);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(16, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 325);
            this.panel1.TabIndex = 0;
            // 
            // reset
            // 
            this.reset.Image = global::QLKhachSan.Properties.Resources.undo;
            this.reset.Location = new System.Drawing.Point(145, 160);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(114, 32);
            this.reset.TabIndex = 23;
            this.reset.Text = "Reset";
            this.reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reset.UseVisualStyleBackColor = true;
            // 
            // timkiem
            // 
            this.timkiem.Image = global::QLKhachSan.Properties.Resources.search;
            this.timkiem.Location = new System.Drawing.Point(203, 252);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(114, 32);
            this.timkiem.TabIndex = 22;
            this.timkiem.Text = "Tìm kiếm";
            this.timkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.timkiem.UseVisualStyleBackColor = true;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // xoa
            // 
            this.xoa.Image = global::QLKhachSan.Properties.Resources.eraser;
            this.xoa.Location = new System.Drawing.Point(61, 252);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(114, 32);
            this.xoa.TabIndex = 21;
            this.xoa.Text = "Xoá";
            this.xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // sua
            // 
            this.sua.Image = global::QLKhachSan.Properties.Resources.pencil;
            this.sua.Location = new System.Drawing.Point(203, 198);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(114, 32);
            this.sua.TabIndex = 20;
            this.sua.Text = "Sửa";
            this.sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sua.UseVisualStyleBackColor = true;
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // them
            // 
            this.them.Image = global::QLKhachSan.Properties.Resources.plus;
            this.them.Location = new System.Drawing.Point(61, 198);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(114, 32);
            this.them.TabIndex = 19;
            this.them.Text = "Thêm";
            this.them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // dg
            // 
            this.dg.Location = new System.Drawing.Point(111, 109);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(206, 26);
            this.dg.TabIndex = 5;
            // 
            // tdv
            // 
            this.tdv.Location = new System.Drawing.Point(111, 62);
            this.tdv.Name = "tdv";
            this.tdv.Size = new System.Drawing.Size(206, 26);
            this.tdv.TabIndex = 4;
            // 
            // mdv
            // 
            this.mdv.Location = new System.Drawing.Point(111, 16);
            this.mdv.Name = "mdv";
            this.mdv.Size = new System.Drawing.Size(206, 26);
            this.mdv.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Dịch Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Dịch Vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(391, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 325);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 25);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(449, 294);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "CẬP NHẬT DỊCH VỤ";
            // 
            // fr_dichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fr_dichvu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập nhật dịch vụ";
            this.Load += new System.EventHandler(this.fr_dichvu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dg;
        private System.Windows.Forms.TextBox tdv;
        private System.Windows.Forms.TextBox mdv;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button sua;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label4;
    }
}