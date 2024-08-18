using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class fr_main : Form
    {
        public fr_main()
        {
            InitializeComponent();
            IsMdiContainer = true;
            fr_connect form = new fr_connect();
            form.MdiParent = this;
            form.Show();
            if (!form.IsDisposed)
                menuStrip1.Enabled = false;
            form.FormClosed += (sender, e) =>
            {
                // Thực hiện các xử lý khi form đã đóng
                menuStrip1.Enabled = true;
            };
        }

        private void cậpNhậtKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_khachhang form = new fr_khachhang();
            form.MdiParent = this;
            form.Show();
        }

        private void cậpNhậtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_phong form = new fr_phong();
            form.MdiParent = this;
            form.Show();
        }

        private void cậpNhậtDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_dichvu form = new fr_dichvu();
            form.MdiParent = this;
            form.Show();
        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_datphong form = new fr_datphong();
            form.MdiParent = this;
            form.Show();
        }

        private void sửDụngDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_sudungphong form = new fr_sudungphong();
            form.MdiParent = this;
            form.Show();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_thanhtoan form = new fr_thanhtoan();
            form.MdiParent = this;
            form.Show();
        }

        private void thốngKêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_tkphong form = new fr_tkphong();
            form.MdiParent = this;
            form.Show();
        }

        private void thốngKêDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_tkdichvu form = new fr_tkdichvu();
            form.MdiParent = this;
            form.Show();
        }

        private void thốngKêChungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_tkchung form = new fr_tkchung();
            form.MdiParent = this;
            form.Show();
        }
    }
}
