using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DataTable = System.Data.DataTable;

namespace QuanLySinhVien
{
    public partial class frmDSSV : Form
    {
        public frmDSSV()
        {
            InitializeComponent();
        }

        private void frmDSSV_Load(object sender, EventArgs e)
        {
            //load toàn bộ danh sách sinh viên
            LoadDSSinhVien();
        }
        private string tukhoa = "";

        private int currentIndex = 0;
        private string maSV;
        private DataTable dataTable;
        private void LoadDSSinhVien()
        {
            //load toàn bộ danh sách sinh viên

            //khai báo list ctPara
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter
            {
                key="@tukhoa",
                value=tukhoa
            });


            //dgvSinhVien.DataSource = new Database().SelectData("SelectAllSinhVien", lstPara);
            //int itemFound = DSSVBinding.Find("masinhvien", "19SV1101");
           
            //
            //int index = dataGridView1.CurrentRow.Index;

            /*
             * Your Refresh Code
             */

            
            dgvSinhVien.DataSource = new Database().SelectData("SelectAllSinhVien", lstPara);
            dataTable= new Database().SelectData("SelectAllSinhVien", lstPara);
            if (dgvSinhVien.Rows.Count > 0)
            {
                this.dgvSinhVien.CurrentCell = this.dgvSinhVien.Rows[currentIndex].Cells[0];//vị trí con trỏ(index) trong datagridview(-_-)
            }
            //đặt tên cột
            dgvSinhVien.Columns["masinhvien"].HeaderText = "Mã sinh viên";
            dgvSinhVien.Columns["hoten"].HeaderText = "Họ tên";
            dgvSinhVien.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgvSinhVien.Columns["gioitinh"].HeaderText = "Giới tính";
            dgvSinhVien.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvSinhVien.Columns["dienthoai"].HeaderText = "Điện thoại";
            dgvSinhVien.Columns["email"].HeaderText = "Email";

        }
        
        private void dgvSinhVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //chinh sua thong tin sinh vien khi ta double click 
            if (e.RowIndex >= 0)
            {
                maSV = dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                currentIndex = e.RowIndex;
                //MessageBox.Show("Mã sinh viên: " + dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString);
                new frmSinhVien(maSV).ShowDialog();
                //khi frmSinhVien đóng lại thì ta load lại danh sách sinh viên
                LoadDSSinhVien();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new frmSinhVien(null).ShowDialog();
            currentIndex = dgvSinhVien.CurrentCell.RowIndex;
            LoadDSSinhVien();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            tukhoa = txtTuKhoa.Text;
            LoadDSSinhVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnXemHocPhan_Click(object sender, EventArgs e)
        {
            int index = dgvSinhVien.CurrentCell.RowIndex;
            if (index >= 0)
            {
                maSV = dgvSinhVien.Rows[index].Cells["masinhvien"].Value.ToString();
                currentIndex = index;
                //MessageBox.Show("Mã sinh viên: " + dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString);
                new frmHocPhan(maSV).ShowDialog();
                //khi frmSinhVien đóng lại thì ta load lại danh sách sinh viên
                LoadDSSinhVien();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string filePath = "";

            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "Excel | *.xlsx";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Invalid!!!");
                return;
            }
            ExcelPackage.LicenseContext= OfficeOpenXml.LicenseContext.NonCommercial;
            try
            {
                using (ExcelPackage p = new ExcelPackage())
                {
                    p.Workbook.Properties.Author = "Hà Văn Ri";
                    p.Workbook.Properties.Title = "Report File";
                    p.Workbook.Worksheets.Add("Sheet 1");

                    ExcelWorksheet ws = p.Workbook.Worksheets[0];

                    ws.Name = "Sheet 1";
                    ws.Cells.Style.Font.Size = 12;
                    ws.Cells.Style.Font.Bold = true;
                    ws.Cells.Style.Font.Name = "Times New Roman";

                    string[] arrColumnHeader =
                    {
                        "Mã sinh viên","Họ tên","Ngày sinh","Giới tính","Địa chỉ","Điện thoại","Email"//headerText
                    };
                    var countColHeader = arrColumnHeader.Count();
                    ws.Cells[1, 1].Value = "Danh sách sinh viên";
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment=OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                    int colHeader = 1;
                    int rowHeader = 2;
                    foreach(var header in arrColumnHeader)
                    {
                        
                        var cell = ws.Cells[rowHeader, colHeader];

                        var fill = cell.Style.Fill;
                        fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);


                        cell.Value = header;
                        colHeader++;
                    }

                    int colIndex = 1;
                    int rowIndex = 2;

                    foreach (DataRow dr in dataTable.Rows)//fields in obj
                    {
                        colIndex = 1;
                        rowIndex++;
                        ws.Cells[rowIndex, colIndex++].Value = dr["masinhvien"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["hoten"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["ngaysinh"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["gioitinh"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["diachi"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["dienthoai"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["email"].ToString();


                    }
                    Byte[] bin =p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Thành công");
            }
            catch (Exception ex )
            {
                MessageBox.Show("thất bại: "+ex);
            }


        }
    }
}
