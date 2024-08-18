using OfficeOpenXml.Style;
using OfficeOpenXml;
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

namespace QLKhachSan
{
    public partial class fr_tkchung : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        private string strcon;
        public fr_tkchung()
        {
            InitializeComponent();
            strcon = @"Data Source=" + connect.Instance.server + ";Initial Catalog=" + connect.Instance.database + ";Integrated Security=True";
        }
        void Load_data()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT COUNT(MaKH) AS SLKH, SUM(TienPhong) AS TongTienPhong, SUM(TienDichVu) AS TongTienDichVu FROM Hoa_Don;\r\n";
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            dgv.DataSource = dt;
        }
        private void fr_tkchung_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(strcon);
            con.Open();
            Load_data();
        }
        public bool IsNumeric(object value)
        {
            return value is int || value is double || value is float || value is decimal;
        }
        private void thongke_Click(object sender, EventArgs e)
        {
            using (var excelPackage = new ExcelPackage())
            {
                // Tạo một bảng Excel 
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");
                worksheet.Cells["B1"].Value = "THỐNG KÊ";
                worksheet.Cells["B1"].Style.Font.Name = "Times New Roman";
                worksheet.Cells["B1"].Style.Font.Size = 14;
                worksheet.Cells["B1"].Style.Font.Bold = true;
                worksheet.Cells["B1:G1"].Merge = true;
                worksheet.Cells["B1:G1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                worksheet.Cells["B2"].Value = "Sử dụng tất cả dịch vụ và phòng tại khách sạn";
                worksheet.Cells["B2"].Style.Font.Name = "Times New Roman";
                worksheet.Cells["B2"].Style.Font.Size = 11;
                worksheet.Cells["B2"].Style.Font.Bold = true;
                worksheet.Cells["B2"].Style.Font.Italic = true;
                worksheet.Cells["B2:G2"].Merge = true;
                worksheet.Cells["B2:G2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                // Ghi dữ liệu từ DataTable vào bảng Excel
                //worksheet.Cells["C12"].LoadFromDataTable(dt, true);
     

                worksheet.Cells["C5"].Value = "Số lượng khách hàng";
                worksheet.Cells["C5"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["C5"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["C5"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["C5"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["C5"].Style.Font.Bold = true;
                worksheet.Cells["C5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                worksheet.Cells["D5"].Value = "Tổng tiền phòng";
                worksheet.Cells["D5"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["D5"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["D5"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["D5"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["D5"].Style.Font.Bold = true;
                worksheet.Cells["D5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                worksheet.Cells["E5"].Value = "Tổng tiền dịch vụ";
                worksheet.Cells["E5"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["E5"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["E5"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["E5"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["E5"].Style.Font.Bold = true;
                worksheet.Cells["E5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                
                worksheet.Column(3).Width = 20;
                worksheet.Column(4).Width = 20;
                worksheet.Column(5).Width = 20;

                // Lấy số dòng và số cột từ DataGridView
                int rowCount = dgv.Rows.Count - 1;
                int colCount = dgv.Columns.Count;

                // Bắt đầu ghi dữ liệu từ ô C6
                int startRow = 6;
                int startCol = 3;
                int i = 1;

                for (int row = 1; row <= rowCount; row++)
                {
                    for (int col = 1; col <= colCount; col++)
                    {
                        // Ghi giá trị từ DataGridView vào ô tương ứng trong Excel
                        ExcelRange cell = worksheet.Cells[startRow + row - 1, startCol + col - 1];
                        cell.Value = dgv.Rows[row - 1].Cells[col - 1].Value;
                        cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        cell.Style.Border.Top.Style = ExcelBorderStyle.Thin;
                        cell.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        cell.Style.Border.Left.Style = ExcelBorderStyle.Thin;
                        cell.Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    }
                }
                
                worksheet.Cells[startRow + rowCount, 3].Value = "Tổng tiền";
                worksheet.Cells[startRow + rowCount, 3].Style.Font.Bold = true;
                worksheet.Cells[startRow + rowCount, 3].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[startRow + rowCount, 3].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount, 3].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount, 3].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount, 3].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount, 4].Formula = "D6+E6";
                worksheet.Cells[startRow + rowCount, 4, startRow + rowCount, 5].Merge = true;
                worksheet.Cells[startRow + rowCount, 4, startRow + rowCount, 5].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[startRow + rowCount, 4, startRow + rowCount, 5].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount, 4, startRow + rowCount, 5].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount, 4, startRow + rowCount, 5].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                worksheet.Cells[startRow + rowCount, 4, startRow + rowCount, 5].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;

                worksheet.Cells[startRow + rowCount + 4, 5].Value = "NHÂN VIÊN BÁO CÁO";
                worksheet.Cells[startRow + rowCount + 4, 5].Style.Font.Bold = true;
                worksheet.Cells[startRow + rowCount + 4, 5, startRow + rowCount + 4, 8].Merge = true;
                worksheet.Cells[startRow + rowCount + 4, 5, startRow + rowCount + 4, 8].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[startRow + rowCount + 6, 5].Value = "Đã ký";
                worksheet.Cells[startRow + rowCount + 6, 5].Style.Font.Italic = true;
                worksheet.Cells[startRow + rowCount + 6, 5, startRow + rowCount + 6, 8].Merge = true;
                worksheet.Cells[startRow + rowCount + 6, 5, startRow + rowCount + 6, 8].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.View.ShowGridLines = false;
                // Lưu tệp Excel
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx|All Files|*.*";
                saveFileDialog.DefaultExt = "xlsx";
                saveFileDialog.Title = "Chọn vị trí để lưu tệp Excel";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    excelPackage.SaveAs(new System.IO.FileInfo(saveFileDialog.FileName));
                    Process.Start(saveFileDialog.FileName);
                }

            }
        }
    }
}
