using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSan
{
    public partial class fr_khachhang : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        private string strcon;
        public fr_khachhang()
        {
            InitializeComponent();
            strcon = @"Data Source=" + connect.Instance.server + ";Initial Catalog=" + connect.Instance.database + ";Integrated Security=True";
        }
        void Load_data()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from Khach_Hang";
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            dgv.DataSource = dt;
        }
        private void fr_khachhang_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(strcon);
            con.Open();
            Load_data();
        }
        private void them_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Khach_Hang VALUES ('" + mkh.Text + "',N'" + tkh.Text + "','" + ns.Text + "',N'" + gt.Text + "',N'" + cccd.Text + "',N'" + sdt.Text + "',N'" + qq.Text + "')";
            cmd.ExecuteNonQuery();
            Load_data();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE Khach_Hang SET TenKH = N'" + tkh.Text + "',NgaySinh='" + ns.Text + "',GioiTinh=N'" + gt.Text + "',CCCD=N'" + cccd.Text + "',SDT = '" + sdt.Text + "',QueQuan = N'" + qq.Text + "' WHERE MaKH = " + mkh.Text;
            cmd.ExecuteNonQuery();
            Load_data();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv.CurrentRow.Index;
            mkh.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tkh.Text = dgv.Rows[i].Cells[1].Value.ToString();
            ns.Text = dgv.Rows[i].Cells[2].Value.ToString();
            gt.Text = dgv.Rows[i].Cells[3].Value.ToString();
            cccd.Text = dgv.Rows[i].Cells[4].Value.ToString();
            sdt.Text = dgv.Rows[i].Cells[5].Value.ToString();
            qq.Text = dgv.Rows[i].Cells[6].Value.ToString();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM Khach_Hang WHERE MaKH = " + mkh.Text;
            cmd.ExecuteNonQuery();
            Load_data();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM Khach_Hang WHERE MaKH LIKE @MaKH AND TenKH LIKE @TenKH AND GioiTinh LIKE @GioiTinh AND CCCD LIKE @CCCD AND SDT LIKE @SDT AND QueQuan LIKE @QueQuan";
            cmd.Parameters.AddWithValue("@MaKH", "%" + mkh.Text + "%");
            cmd.Parameters.AddWithValue("@TenKH", "%" + tkh.Text + "%");
            cmd.Parameters.AddWithValue("@GioiTinh", "%" + gt.Text + "%");
            cmd.Parameters.AddWithValue("@CCCD", "%" + cccd.Text + "%");
            cmd.Parameters.AddWithValue("@SDT", "%" + sdt.Text + "%");
            cmd.Parameters.AddWithValue("@QueQuan", "%" + qq.Text + "%");
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            dgv.DataSource = dt;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            mkh.Text = string.Empty;
            tkh.Text = string.Empty;
            gt.Text = string.Empty;
            cccd.Text = string.Empty;
            sdt.Text = string.Empty;
            qq.Text = string.Empty;
        }
    }
}
