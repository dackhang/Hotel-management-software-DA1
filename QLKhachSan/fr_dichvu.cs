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
    public partial class fr_dichvu : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        private string strcon;
        public fr_dichvu()
        {
            InitializeComponent();
            strcon = @"Data Source=" + connect.Instance.server + ";Initial Catalog=" + connect.Instance.database + ";Integrated Security=True";
        }
        void Load_data()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select MaDV,TenDV,DonGia from Dich_Vu";
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            dgv.DataSource = dt;
        }
        private void fr_dichvu_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(strcon);
            con.Open();
            Load_data();
        }

        private void them_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Dich_Vu VAlUES ("+mdv.Text+",N'"+tdv.Text+"',"+dg.Text+",0,0)";
            cmd.ExecuteNonQuery();
            Load_data();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "UPDATE Dich_Vu SET TenDV = N'" + tdv.Text + "', Dongia = " + dg.Text + " WHERE MaDV = " + mdv.Text;
            cmd.ExecuteNonQuery();
            Load_data();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "DELETE FROM Dich_Vu WHERE MaDV = " + mdv.Text;
            cmd.ExecuteNonQuery();
            Load_data();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv.CurrentRow.Index;
            mdv.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tdv.Text = dgv.Rows[i].Cells[1].Value.ToString();
            dg.Text = dgv.Rows[i].Cells[2].Value.ToString();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "select MaDV,TenDV,DonGia from Dich_Vu WHERE MaDV LIKE @MaDV AND TenDv LIKE @TenDV";
            cmd.Parameters.AddWithValue("@MaDV", "%" + mdv.Text + "%");
            cmd.Parameters.AddWithValue("@TenDV", "%" + tdv.Text + "%");
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            dgv.DataSource = dt;
        }
    }
}
