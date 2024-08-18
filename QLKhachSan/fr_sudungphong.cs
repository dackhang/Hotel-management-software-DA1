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
    public partial class fr_sudungphong : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        private string strcon;
        public string mhd,mdv;
        public fr_sudungphong()
        {
            InitializeComponent();
            strcon = @"Data Source=" + connect.Instance.server + ";Initial Catalog=" + connect.Instance.database + ";Integrated Security=True";
        }
        void load_dv()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select MaDV,TenDV,DonGia,Solansd from Dich_Vu";
            adt.SelectCommand = cmd;
            dt1.Clear();
            adt.Fill(dt1);
            dgv.DataSource = dt1;
        }
        void load_hd()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from Hoat_Dong";
            adt.SelectCommand = cmd;
            dt2.Clear();
            adt.Fill(dt2);
            dgv1.DataSource = dt2;
        }
        private void fr_sudungphong_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(strcon);
            con.Open();
            load_dv();
            load_hd();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv.CurrentRow.Index;
            dv.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tdv.Text = dgv.Rows[i].Cells[2].Value.ToString();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv1.CurrentRow.Index;
            mhd = dgv1.Rows[i].Cells[0].Value.ToString();
            mkh.Text = dgv1.Rows[i].Cells[1].Value.ToString();
            tkh.Text = dgv1.Rows[i].Cells[2].Value.ToString();
            mp.Text = dgv1.Rows[i].Cells[3].Value.ToString();
            mdv = dgv1.Rows[i].Cells[4].Value.ToString();
        }

        private void them_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Hoat_Dong(MaKH,TenKH,MaPhong,DichVu,TienDichVu,Gio,Ngay) VALUES (" + mkh.Text + ",N'" + tkh.Text + "',N'" + mp.Text + "',"+dv.Text+","+tdv.Text+",'" + gio.Text + "','" + ngay.Text + "')";
            cmd.ExecuteNonQuery();
            cmd = con.CreateCommand();
            cmd.CommandText = "Update Dich_Vu SET Solansd = Solansd+1 Where MaDV = "+dv.Text;
            cmd.ExecuteNonQuery();
            load_dv();
            load_hd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from Hoat_Dong where MaKH LIKE @MaKH AND TenKH LIKE @TenKH AND MaPhong LIKE @MaPhong AND DichVu LIKE @DichVu";
            cmd.Parameters.AddWithValue("@MaKH","%"+mkh.Text+"%");
            cmd.Parameters.AddWithValue("@TenKH", "%" + tkh.Text + "%");
            cmd.Parameters.AddWithValue("@Maphong", "%" + mp.Text + "%");
            cmd.Parameters.AddWithValue("@DichVu", "%" + dv.Text + "%");
            adt.SelectCommand = cmd;
            dt2.Clear();
            adt.Fill(dt2);
            dgv1.DataSource = dt2;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            gio.Text = now.ToString("HH:mm:ss");
            ngay.Text = now.Date.ToString();
        }

        private void huy_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Delete Hoat_Dong WHERE MaHD = " + mhd;
            cmd.ExecuteNonQuery();
            cmd = con.CreateCommand();
            cmd.CommandText = "Update Dich_Vu SET Solansd = Solansd-1 Where MaDV = " + mdv;
            cmd.ExecuteNonQuery();
            cmd = con.CreateCommand();
            cmd.CommandText = "Update Dich_Vu SET Solansd = 0 Where MaDV = " + mdv + "And Solansd < 0 ";
            cmd.ExecuteNonQuery();
            load_dv();
            load_hd();
        }
    }
}
