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
    public partial class fr_datphong : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        private string strcon;
        public fr_datphong()
        {
            InitializeComponent();
            strcon = @"Data Source=" + connect.Instance.server + ";Initial Catalog=" + connect.Instance.database + ";Integrated Security=True";
        }

        void Load_kh()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from Khach_Hang";
            adt.SelectCommand = cmd;
            dt1.Clear();
            adt.Fill(dt1);
            dgv1.DataSource = dt1;
        }
        void Load_ph()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from Phong";
            adt.SelectCommand = cmd;
            dt2.Clear();
            adt.Fill(dt2);
            dgv.DataSource = dt2;
        }
        private void fr_datphong_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(strcon);
            con.Open();
            Load_kh();
            Load_ph();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv.CurrentRow.Index;
            pmd.Text = dgv.Rows[i].Cells[0].Value.ToString();
            gp.Text = dgv.Rows[i].Cells[2].Value.ToString();

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv1.CurrentRow.Index;
            mkh.Text = dgv1.Rows[i].Cells[0].Value.ToString();
            tkh.Text = dgv1.Rows[i].Cells[1].Value.ToString();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from Phong WHERE LoaiPhong LIKE @LoaiPhong AND TrangThai LIKE @TrangThai";
            cmd.Parameters.AddWithValue("@LoaiPhong", "%" + lp.Text + "%");
            cmd.Parameters.AddWithValue("@TrangThai", "%" + tt.Text + "%");
            adt.SelectCommand = cmd;
            dt2.Clear();
            adt.Fill(dt2);
            dgv.DataSource = dt2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from Khach_Hang Where TenKH LIKE @TenKH AND CCCD LIKE @CCCD";
            cmd.Parameters.AddWithValue("@TenKH", "%" + tenkh.Text + "%");
            cmd.Parameters.AddWithValue("@CCCD", "%" + cccd.Text + "%");
            adt.SelectCommand = cmd;
            dt1.Clear();
            adt.Fill(dt1);
            dgv1.DataSource = dt1;
        }

        private void them_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Hoat_Dong(MaKH,TenKH,MaPhong,DichVu,TienDichVu,Gio,Ngay) VALUES ("+mkh.Text+",N'"+tkh.Text+"',N'"+pmd.Text+"',0,0,'"+gio.Text+"','"+ngay.Text+"')";
            cmd.ExecuteNonQuery();
            cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE Phong SET TrangThai = N'Đang sử dụng' WHERE MaPhong = N'"+pmd.Text+"'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã đặt phòng thành công","Thông báo");
            Load_ph();   
        }

        private void reset_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            gio.Text = now.ToString("HH:mm:ss");
            ngay.Text = now.Date.ToString();
        }
    }
}
