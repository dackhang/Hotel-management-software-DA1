using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;


namespace QLKhachSan
{
    public partial class fr_hoadon : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        private string strcon;
        public string mhd;
        public fr_hoadon()
        {
            InitializeComponent();
            strcon = @"Data Source=" + connect.Instance.server + ";Initial Catalog=" + connect.Instance.database + ";Integrated Security=True";
            inhoadon.Enabled = false;
        }
        void load_hd()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Hoat_Dong.DichVu,Dich_Vu.TenDV,Hoat_Dong.TienDichVu,Hoat_Dong.Gio,Hoat_Dong.Ngay FROM Hoat_Dong INNER JOIN Dich_Vu ON Hoat_Dong.DichVu = Dich_Vu.MaDV";
            adt.SelectCommand = cmd;
            dt1.Clear();
            adt.Fill(dt1);
            dgv.DataSource = dt1;
        }
        void load_hdon()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Hoa_Don.MaHDon, Hoa_Don.MaKH,Hoa_Don.TenKH,Khach_Hang.NgaySinh,Khach_Hang.GioiTinh,Khach_Hang.CCCD,Khach_Hang.SDT,Khach_Hang.QueQuan,Hoa_Don.MaPhong,Hoa_Don.TienPhong,Hoa_Don.TienDichVu,Hoa_Don.TongTien FROM Hoa_Don INNER JOIN Khach_Hang ON Hoa_Don.MaKH = Khach_Hang.MaKH";
            adt.SelectCommand = cmd;
            dt2.Clear();
            adt.Fill(dt2);
            dgv1.DataSource = dt2;
        }
        private void fr_hoadon_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(strcon);
            con.Open();
            load_hd();
            load_hdon();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv1.CurrentRow.Index;
            mhd = dgv1.Rows[i].Cells[0].Value.ToString();
            mkh.Text = dgv1.Rows[i].Cells[1].Value.ToString();
            tkh.Text = dgv1.Rows[i].Cells[2].Value.ToString();
            ns.Text = dgv1.Rows[i].Cells[3].Value.ToString();
            gt.Text = dgv1.Rows[i].Cells[4].Value.ToString();
            cccd.Text = dgv1.Rows[i].Cells[5].Value.ToString();
            sdt.Text = dgv1.Rows[i].Cells[6].Value.ToString();
            qq.Text = dgv1.Rows[i].Cells[7].Value.ToString();
            mp.Text = dgv1.Rows[i].Cells[8].Value.ToString();
            tp.Text = dgv1.Rows[i].Cells[9].Value.ToString();
            tdv.Text = dgv1.Rows[i].Cells[10].Value.ToString();
            tt.Text = dgv1.Rows[i].Cells[11].Value.ToString();
        }

        private void thanhtoan_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT Hoat_Dong.DichVu,Dich_Vu.TenDV,Hoat_Dong.TienDichVu,Hoat_Dong.Gio,Hoat_Dong.Ngay FROM Hoat_Dong INNER JOIN Dich_Vu ON Hoat_Dong.DichVu = Dich_Vu.MaDV WHERE MaKH LIKE @MaKH AND Hoat_Dong.Ngay >= '"+nd.Text+"' AND Hoat_Dong.Ngay <= '"+ndi.Text+"'";
            cmd.Parameters.AddWithValue("@MaKH","%"+mkh.Text+"%");
            adt.SelectCommand = cmd;
            dt1.Clear();
            adt.Fill(dt1);
            dgv.DataSource = dt1;
            inhoadon.Enabled = true;
        }

        private void inhoadon_Click(object sender, EventArgs e)
        {
            using (var excelPackage = new ExcelPackage())
            {
                // Tạo một bảng Excel 
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");
                worksheet.Cells["B1"].Value = "HOÁ ĐƠN";
                worksheet.Cells["B1"].Style.Font.Name = "Times New Roman";
                worksheet.Cells["B1"].Style.Font.Size = 14;
                worksheet.Cells["B1"].Style.Font.Bold = true;
                worksheet.Cells["B1:G1"].Merge = true;
                worksheet.Cells["B1:G1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                worksheet.Cells["B2"].Value = "Sử dụng khách sạn";
                worksheet.Cells["B2"].Style.Font.Name = "Times New Roman";
                worksheet.Cells["B2"].Style.Font.Size = 11;
                worksheet.Cells["B2"].Style.Font.Bold = true;
                worksheet.Cells["B2"].Style.Font.Italic = true;
                worksheet.Cells["B2:G2"].Merge = true;
                worksheet.Cells["B2:G2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                worksheet.Cells["B5"].Value = "Kính gửi: ";
                worksheet.Cells["B5"].Style.Font.Name = "Times New Roman";
                worksheet.Cells["B5"].Style.Font.Size = 11;
                worksheet.Cells["B5"].Style.Font.Bold = true;
                worksheet.Column(2).Width = 15;

                worksheet.Cells["C5"].Value = tkh.Text;
                worksheet.Cells["C5"].Style.Font.Name = "Times New Roman";
                worksheet.Cells["C5"].Style.Font.Size = 11;

                worksheet.Cells["B6"].Value = "Ngày sinh: ";
                worksheet.Cells["B6"].Style.Font.Name = "Times New Roman";
                worksheet.Cells["B6"].Style.Font.Size = 11;

                worksheet.Cells["C6"].Value = ns.Text;
                worksheet.Cells["C6"].Style.Font.Name = "Times New Roman";
                worksheet.Cells["C6"].Style.Font.Size = 11;

                worksheet.Cells["E6"].Value = "Giới tính: ";
                worksheet.Cells["E6"].Style.Font.Name = "Times New Roman";
                worksheet.Cells["E6"].Style.Font.Size = 11;

                worksheet.Cells["F6"].Value = gt.Text;
                worksheet.Cells["F6"].Style.Font.Name = "Times New Roman";
                worksheet.Cells["F6"].Style.Font.Size = 11;

                worksheet.Cells["B7"].Value = "CCCD/CMND: ";
                worksheet.Cells["B7"].Style.Font.Name = "Times New Roman";
                worksheet.Cells["B7"].Style.Font.Size = 11;

                worksheet.Cells["C7"].Value = cccd.Text;
                worksheet.Cells["C7"].Style.Font.Name = "Times New Roman";
                worksheet.Cells["C7"].Style.Font.Size = 11;

                worksheet.Cells["E7"].Value = "SDT: ";
                worksheet.Cells["E7"].Style.Font.Name = "Times New Roman";
                worksheet.Cells["E7"].Style.Font.Size = 11;

                worksheet.Cells["F7"].Value = sdt.Text;
                worksheet.Cells["F7"].Style.Font.Name = "Times New Roman";
                worksheet.Cells["F7"].Style.Font.Size = 11;

                worksheet.Cells["B8"].Value = "Quê quán: ";
                worksheet.Cells["B8"].Style.Font.Name = "Times New Roman";
                worksheet.Cells["B8"].Style.Font.Size = 11;

                worksheet.Cells["C8"].Value = qq.Text;
                worksheet.Cells["C8"].Style.Font.Name = "Times New Roman";
                worksheet.Cells["C8"].Style.Font.Size = 11;

                worksheet.Cells["E8"].Value = "Phòng: ";
                worksheet.Cells["E8"].Style.Font.Name = "Times New Roman";
                worksheet.Cells["E8"].Style.Font.Size = 11;

                worksheet.Cells["F8"].Value = mp.Text;
                worksheet.Cells["F8"].Style.Font.Name = "Times New Roman";
                worksheet.Cells["F8"].Style.Font.Size = 11;
                // Ghi dữ liệu từ DataTable vào bảng Excel
                //worksheet.Cells["C12"].LoadFromDataTable(dt, true);
                worksheet.Cells["B10"].Value = "STT";
                worksheet.Cells["B10"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["B10"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["B10"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["B10"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["B10"].Style.Font.Bold = true;
                worksheet.Cells["B10"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                worksheet.Column(3).Width = 28;

                worksheet.Cells["C10"].Value = "Mã Dịch Vụ";
                worksheet.Cells["C10"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["C10"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["C10"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["C10"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["C10"].Style.Font.Bold = true;
                worksheet.Cells["C10"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Column(4).Width = 30;

                worksheet.Cells["D10"].Value = "Tên dịch vụ";
                worksheet.Cells["D10"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["D10"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["D10"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["D10"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["D10"].Style.Font.Bold = true;
                worksheet.Cells["D10"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Column(5).Width = 15;

                worksheet.Cells["E10"].Value = "Đơn giá";
                worksheet.Cells["E10"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["E10"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["E10"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["E10"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["E10"].Style.Font.Bold = true;
                worksheet.Cells["E10"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                worksheet.Cells["F10"].Value = "Giờ";
                worksheet.Cells["F10"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["F10"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["F10"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["F10"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["F10"].Style.Font.Bold = true;
                worksheet.Cells["F10"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                worksheet.Cells["G10"].Value = "Ngày";
                worksheet.Cells["G10"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["G10"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["G10"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["G10"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["G10"].Style.Font.Bold = true;
                worksheet.Cells["G10"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells["G10"].Style.Numberformat.Format = "dd/MM/yyyy";
                worksheet.Column(7).Width = 12;
                // Lấy số dòng và số cột từ DataGridView
                int rowCount = dgv.Rows.Count-1;
                int colCount = dgv.Columns.Count;

                // Bắt đầu ghi dữ liệu từ ô B11
                int startRow = 11;
                int startCol = 3;
                int i = 1;
                
                for (int row = 1; row <= rowCount; row++)
                {
                    worksheet.Cells[startRow + row - 1, 2].Value = i;
                    worksheet.Cells[startRow + row - 1, 2].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells[startRow + row - 1, 2].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells[startRow + row - 1, 2].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells[startRow + row - 1, 2].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    for (int col = 1; col <= colCount; col++)
                    {
                        // Ghi giá trị từ DataGridView vào ô tương ứng trong Excel
                        ExcelRange cell = worksheet.Cells[startRow + row - 1, startCol + col - 1];
                        cell.Value = dgv.Rows[row - 1].Cells[col - 1].Value;
                        cell.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        cell.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        cell.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        cell.Style.Border.Right.Style = ExcelBorderStyle.Thin; 
                    }
                    i++;
                }
                // Đặt định dạng giờ cho cột F (từ hàng 11 đến cuối bảng)
                using (var range = worksheet.Cells[startRow,6, startRow + rowCount-1,6])
                {
                    range.Style.Numberformat.Format = "HH:mm:ss"; // Định dạng ngày theo ý muốn của bạn
                }
                // Đặt định dạng ngày cho cột G (từ hàng 11 đến hết)
                using (var range = worksheet.Cells[startRow, 7, startRow + rowCount - 1, 7])
                {
                    range.Style.Numberformat.Format = "dd/MM/yyyy"; // Định dạng ngày theo ý muốn của bạn
                }
                // Ghi dữ liệu từ DataGridView vào Excel
                worksheet.Cells[startRow + rowCount, 2].Value = "Tiền dịch vụ";
                worksheet.Cells[startRow + rowCount, 2, startRow + rowCount, 4].Merge = true;
                worksheet.Cells[startRow + rowCount, 2, startRow + rowCount, 4].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[startRow + rowCount, 2, startRow + rowCount, 4].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount, 2, startRow + rowCount, 4].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount, 2, startRow + rowCount, 4].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount, 2, startRow + rowCount, 4].Style.Border.Right.Style = ExcelBorderStyle.Thin;

                worksheet.Cells[startRow + rowCount, 5].Value = tdv.Text;
                worksheet.Cells[startRow + rowCount, 5, startRow + rowCount, 7].Merge = true;
                worksheet.Cells[startRow + rowCount, 5, startRow + rowCount, 7].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[startRow + rowCount, 5, startRow + rowCount, 7].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[startRow + rowCount, 5, startRow + rowCount, 7].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount, 5, startRow + rowCount, 7].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount, 5, startRow + rowCount, 7].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount, 5, startRow + rowCount, 7].Style.Border.Right.Style = ExcelBorderStyle.Thin;

                worksheet.Cells[startRow + rowCount + 1, 2].Value = "Tiền Phòng";
                worksheet.Cells[startRow + rowCount + 1, 2, startRow + rowCount + 1, 4].Merge = true;
                worksheet.Cells[startRow + rowCount + 1, 2, startRow + rowCount + 1, 4].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[startRow + rowCount + 1, 2, startRow + rowCount + 1, 4].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount + 1, 2, startRow + rowCount + 1, 4].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount + 1, 2, startRow + rowCount + 1, 4].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount + 1, 2, startRow + rowCount + 1, 4].Style.Border.Right.Style = ExcelBorderStyle.Thin;

                worksheet.Cells[startRow + rowCount + 1, 5].Value = tp.Text;
                worksheet.Cells[startRow + rowCount + 1, 5, startRow + rowCount + 1, 7].Merge = true;
                worksheet.Cells[startRow + rowCount + 1, 5, startRow + rowCount + 1, 7].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[startRow + rowCount + 1, 5, startRow + rowCount + 1, 7].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[startRow + rowCount + 1, 5, startRow + rowCount + 1, 7].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount + 1, 5, startRow + rowCount + 1, 7].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount + 1, 5, startRow + rowCount + 1, 7].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount + 1, 5, startRow + rowCount + 1, 7].Style.Border.Right.Style = ExcelBorderStyle.Thin;

                worksheet.Cells[startRow + rowCount + 2, 2].Value = "Tổng tiền";
                worksheet.Cells[startRow + rowCount + 2, 2, startRow + rowCount + 2, 4].Merge = true;
                worksheet.Cells[startRow + rowCount + 2, 2, startRow + rowCount + 2, 4].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[startRow + rowCount + 2, 2, startRow + rowCount + 2, 4].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount + 2, 2, startRow + rowCount + 2, 4].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount + 2, 2, startRow + rowCount + 2, 4].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount + 2, 2, startRow + rowCount + 2, 4].Style.Border.Right.Style = ExcelBorderStyle.Thin;

                worksheet.Cells[startRow + rowCount + 2, 5].Value = tt.Text;
                worksheet.Cells[startRow + rowCount + 2, 5, startRow + rowCount + 2, 7].Merge = true;
                worksheet.Cells[startRow + rowCount + 2, 5, startRow + rowCount + 2, 7].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[startRow + rowCount + 2, 5, startRow + rowCount + 2, 7].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[startRow + rowCount + 2, 5, startRow + rowCount + 2, 7].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount + 2, 5, startRow + rowCount + 2, 7].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount + 2, 5, startRow + rowCount + 2, 7].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount + 2, 5, startRow + rowCount + 2, 7].Style.Border.Right.Style = ExcelBorderStyle.Thin;

                worksheet.Cells[startRow + rowCount + 5, 5].Value = "BAN QUẢN LÝ KHÁCH SẠN";
                worksheet.Cells[startRow + rowCount + 5, 5].Style.Font.Bold = true;
                worksheet.Cells[startRow + rowCount + 5, 5, startRow + rowCount + 5, 8].Merge = true;
                worksheet.Cells[startRow + rowCount + 5, 5, startRow + rowCount + 5, 8].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[startRow + rowCount + 7, 5].Value = "Đã ký";
                worksheet.Cells[startRow + rowCount + 7, 5].Style.Font.Italic = true;
                worksheet.Cells[startRow + rowCount + 7, 5, startRow + rowCount + 7, 8].Merge = true;
                worksheet.Cells[startRow + rowCount + 7, 5, startRow + rowCount + 7, 8].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.View.ShowGridLines = false;
                // Lưu tệp Excel
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx|All Files|*.*";
                saveFileDialog.DefaultExt = "xlsx";
                saveFileDialog.Title = "Chọn vị trí để lưu tệp Excel";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    excelPackage.SaveAs(new System.IO.FileInfo(saveFileDialog.FileName));
                }
                Process.Start(saveFileDialog.FileName);
            }
        }
    }
}
