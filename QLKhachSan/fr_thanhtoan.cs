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
    public partial class fr_thanhtoan : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        private string strcon;
        public string mhd, mdv;
        public fr_thanhtoan()
        {
            InitializeComponent();
            strcon = @"Data Source=" + connect.Instance.server + ";Initial Catalog=" + connect.Instance.database + ";Integrated Security=True";
        }
        void load_hd()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from Hoat_Dong";
            adt.SelectCommand = cmd;
            dt1.Clear();
            adt.Fill(dt1);
            dgv.DataSource = dt1;
        }
        void load_hdon()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from Hoa_Don";
            adt.SelectCommand = cmd;
            dt2.Clear();
            adt.Fill(dt2);
            dgv1.DataSource = dt2;
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv.CurrentRow.Index;
            mkh.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tkh.Text = dgv.Rows[i].Cells[2].Value.ToString();
            mp.Text = dgv.Rows[i].Cells[3].Value.ToString();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from Hoat_Dong where MaKH LIKE @MaKH AND TenKH LIKE @TenKH AND MaPhong LIKE @MaPhong";
            cmd.Parameters.AddWithValue("@MaKH", "%" + mkh.Text + "%");
            cmd.Parameters.AddWithValue("@TenKH", "%" + tkh.Text + "%");
            cmd.Parameters.AddWithValue("@Maphong", "%" + mp.Text + "%");
            adt.SelectCommand = cmd;
            dt1.Clear();
            adt.Fill(dt1);
            dgv.DataSource = dt1;
        }

        private void thanhtoan_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string gio = now.ToString("HH:mm:ss");
            string ngay = now.Date.ToString("MM-dd-yyyy");
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Hoat_Dong(MaKH,TenKH,MaPhong,DichVu,TienDichVu,Gio,Ngay) VALUES (" + mkh.Text + ",N'" + tkh.Text + "',N'" + mp.Text + "',-1,0,'" + gio + "','" + ngay + "')";
            cmd.ExecuteNonQuery();
            cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE Phong SET TrangThai = N'Chưa đặt' WHERE MaPhong = N'" + mp.Text + "'";
            cmd.ExecuteNonQuery();
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Hoa_Don(MaKH, TenKH, MaPhong, TienPhong, TienDichVu, TongTien) VALUES (" + mkh.Text + ", N'" + tkh.Text + "', N'" + mp.Text + "', (SELECT TOP 1 Phong.GiaPhong FROM Phong INNER JOIN Hoat_Dong ON Phong.MaPhong = Hoat_Dong.MaPhong WHERE Phong.MaPhong = N'" + mp.Text + "' AND Hoat_Dong.Ngay >= '" + nd.Text + "' AND Hoat_Dong.Ngay <= '" + ndi.Text + "'), (SELECT ISNULL(SUM(TienDichVu), 0) FROM Hoat_Dong WHERE MaKH = " + mkh.Text + " AND Hoat_Dong.Ngay >= '" + nd.Text + "' AND Hoat_Dong.Ngay <= '" + ndi.Text + "'), 0)";
            cmd.ExecuteNonQuery();
            cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE Hoa_Don SET TongTien = TienPhong + TienDichVu WHERE MaKH = "+mkh.Text;
            cmd.ExecuteNonQuery();
            load_hd();
            load_hdon();
        }

        private void inhoadon_Click(object sender, EventArgs e)
        {
            fr_hoadon form = new fr_hoadon();
            form.Show();
        }

        private void fr_thanhtoan_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(strcon);
            con.Open();
            load_hd();
            load_hdon();
        }
    }
}
