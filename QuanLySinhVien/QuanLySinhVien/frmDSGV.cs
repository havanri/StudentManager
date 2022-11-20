using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmDSGV : Form
    {
        public frmDSGV()
        {
            InitializeComponent();
        }

        private void frmDSGV_Load(object sender, EventArgs e)
        {
            LoadDSGiaoVien();
        }
        private string tukhoa = "";
        private void LoadDSGiaoVien()
        {
            //load toàn bộ danh sách sinh viên

            //khai báo list ctPara
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter
            {
                key = "@tukhoa",
                value = tukhoa
            });

            dgvGiaoVien.DataSource = new Database().SelectData("SelectAllGiaoVien", lstPara);

            //đặt tên cột
            dgvGiaoVien.Columns["magiaovien"].HeaderText = "Mã giáo viên";
            dgvGiaoVien.Columns["hoten"].HeaderText = "Họ tên";
            dgvGiaoVien.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgvGiaoVien.Columns["gioitinh"].HeaderText = "Giới tính";
            dgvGiaoVien.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvGiaoVien.Columns["dienthoai"].HeaderText = "Điện thoại";
            dgvGiaoVien.Columns["email"].HeaderText = "Email";
        }

        private void btnTimKiemGiaoVien_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            LoadDSGiaoVien();
        }

        private void btnThemGiaoVien_Click(object sender, EventArgs e)
        {
            new frmGiaoVien(null).ShowDialog();
            LoadDSGiaoVien();
        }

        private void dgvGiaoVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //chinh sua thong tin sinh vien khi ta double click 
            if (e.RowIndex >= 0)
            {
                var maGV = dgvGiaoVien.Rows[e.RowIndex].Cells["magiaovien"].Value.ToString();
                //MessageBox.Show("Mã sinh viên: " + dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString);
                new frmGiaoVien(maGV).ShowDialog();
                //khi frmSinhVien đóng lại thì ta load lại danh sách sinh viên
                LoadDSGiaoVien();
            }
        }
    }
}
