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
    public partial class fr_connect : Form
    {
        public fr_connect()
        {
            InitializeComponent();
        }

        private void ketnoi_Click(object sender, EventArgs e)
        {
            connect.Instance.server = sv.Text; ;
            connect.Instance.database = db.Text;
            this.Close();
        }
    }
}
