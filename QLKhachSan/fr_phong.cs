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
    public partial class fr_phong : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        private string strcon;
        public fr_phong()
        {
            InitializeComponent();
            strcon = @"Data Source=" + connect.Instance.server + ";Initial Catalog=" + connect.Instance.database + ";Integrated Security=True";
        }
        void Load_data()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from Phong";
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            dgv.DataSource = dt;
        }
        private void fr_phong_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(strcon);
            con.Open();
            Load_data();
        }

        private void them_Click(object sender, EventArgs e)
        {
            string loai = lp.Text.Substring(0, lp.Text.IndexOf('-') - 1);
            string gia = lp.Text.Substring(lp.Text.IndexOf('-') + 2, lp.Text.Length - lp.Text.IndexOf('-') - 2);
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Phong VALUES(N'"+mp.Text+"',N'"+loai+"',"+gia+",N'Chưa đặt')";
            cmd.ExecuteNonQuery();
            Load_data();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            string loai = lp.Text.Substring(0, lp.Text.IndexOf('-') - 1);
            string gia = lp.Text.Substring(lp.Text.IndexOf('-') + 2, lp.Text.Length - lp.Text.IndexOf('-') - 2);
            cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE Phong SET MaPhong = N'" + mp.Text + "',LoaiPhong = N'" + loai + "',GiaPhong = " + gia + " WHERE MaPhong = N'"+mp.Text+"'";
            cmd.ExecuteNonQuery();
            Load_data();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv.CurrentRow.Index;
            mp.Text = dgv.Rows[i].Cells[0].Value.ToString();
            lp.Text = dgv.Rows[i].Cells[1].Value.ToString() + " - " + dgv.Rows[i].Cells[2].Value.ToString();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM Phong WHERE MaPhong = N'" + mp.Text + "'";
            cmd.ExecuteNonQuery();
            Load_data();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            string loai = "";
            if (lp.Text != "")
                loai = lp.Text.Substring(0, lp.Text.IndexOf('-') - 1);
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from Phong Where Maphong LIKE @MaPhong AND LoaiPhong LIKE @LoaiPhong";
            cmd.Parameters.AddWithValue("@MaPhong", "%" + mp.Text + "%");
            cmd.Parameters.AddWithValue("@LoaiPhong", "%" + loai + "%");
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            dgv.DataSource = dt;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            mp.Text = string.Empty;
            lp.Text = string.Empty;
        }
    }
}
