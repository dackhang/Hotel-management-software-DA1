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
    public partial class fr_tkdichvu : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adt = new SqlDataAdapter();
        DataTable dt = new DataTable();
        private string strcon;
        public fr_tkdichvu()
        {
            InitializeComponent();
            strcon = @"Data Source=" + connect.Instance.server + ";Initial Catalog=" + connect.Instance.database + ";Integrated Security=True";
        }
        void Load_data()
        {
            cmd = con.CreateCommand();
            cmd.CommandText = "Select * from Dich_Vu Where MaDV <> 0 AND MaDV <> -1";
            adt.SelectCommand = cmd;
            dt.Clear();
            adt.Fill(dt);
            dgv.DataSource = dt;
        }
        private void fr_tkdichvu_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(strcon);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText="UPDATE Dich_Vu SET TongTien = Solansd*Dongia";
            cmd.ExecuteNonQuery();
            Load_data();
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

                worksheet.Cells["B2"].Value = "Sử dụng dịch vụ khách sạn";
                worksheet.Cells["B2"].Style.Font.Name = "Times New Roman";
                worksheet.Cells["B2"].Style.Font.Size = 11;
                worksheet.Cells["B2"].Style.Font.Bold = true;
                worksheet.Cells["B2"].Style.Font.Italic = true;
                worksheet.Cells["B2:G2"].Merge = true;
                worksheet.Cells["B2:G2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                // Ghi dữ liệu từ DataTable vào bảng Excel
                //worksheet.Cells["C12"].LoadFromDataTable(dt, true);
                worksheet.Cells["B5"].Value = "STT";
                worksheet.Cells["B5"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["B5"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["B5"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["B5"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["B5"].Style.Font.Bold = true;
                worksheet.Cells["B5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                worksheet.Cells["C5"].Value = "Mã Dịch vụ";
                worksheet.Cells["C5"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["C5"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["C5"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["C5"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["C5"].Style.Font.Bold = true;
                worksheet.Cells["C5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                worksheet.Cells["D5"].Value = "Tên dịch vụ";
                worksheet.Cells["D5"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["D5"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["D5"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["D5"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["D5"].Style.Font.Bold = true;
                worksheet.Cells["D5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                worksheet.Cells["E5"].Value = "Đơn giá";
                worksheet.Cells["E5"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["E5"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["E5"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["E5"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["E5"].Style.Font.Bold = true;
                worksheet.Cells["E5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                worksheet.Cells["F5"].Value = "Số Lượt SD";
                worksheet.Cells["F5"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["F5"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["F5"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["F5"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["F5"].Style.Font.Bold = true;
                worksheet.Cells["F5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                worksheet.Cells["G5"].Value = "Tổng Tiền";
                worksheet.Cells["G5"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["G5"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["G5"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["G5"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                worksheet.Cells["G5"].Style.Font.Bold = true;
                worksheet.Cells["G5"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Column(2).Width = 9;
                worksheet.Column(3).Width = 14;
                worksheet.Column(4).Width = 20;
                worksheet.Column(5).Width = 12;
                worksheet.Column(6).Width = 12;
                worksheet.Column(7).Width = 12;

                // Lấy số dòng và số cột từ DataGridView
                int rowCount = dgv.Rows.Count - 1;
                int colCount = dgv.Columns.Count;

                // Bắt đầu ghi dữ liệu từ ô B6
                int startRow = 6;
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

                worksheet.Cells[startRow + rowCount + 3, 5].Value = "NHÂN VIÊN BÁO CÁO";
                worksheet.Cells[startRow + rowCount + 3, 5].Style.Font.Bold = true;
                worksheet.Cells[startRow + rowCount + 3, 5, startRow + rowCount + 3, 8].Merge = true;
                worksheet.Cells[startRow + rowCount + 3, 5, startRow + rowCount + 3, 8].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                worksheet.Cells[startRow + rowCount + 5, 5].Value = "Đã ký";
                worksheet.Cells[startRow + rowCount + 5, 5].Style.Font.Italic = true;
                worksheet.Cells[startRow + rowCount + 5, 5, startRow + rowCount + 5, 8].Merge = true;
                worksheet.Cells[startRow + rowCount + 5, 5, startRow + rowCount + 5, 8].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
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
