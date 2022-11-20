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
    public partial class frmDSMH : Form
    {
        public frmDSMH()
        {
            InitializeComponent();
        }

        private void dgvMonHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mamh = dgvMonHoc.Rows[e.RowIndex].Cells["mamonhoc"].Value.ToString();
                //MessageBox.Show("Mã sinh viên: " + dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString);
                new frmMonHoc(mamh).ShowDialog();
                //khi frmSinhVien đóng lại thì ta load lại danh sách sinh viên
                LoadDSMonHoc();
            } 
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTuKhoa.Text;
            LoadDSMonHoc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new frmMonHoc(null).ShowDialog();
            LoadDSMonHoc();
        }
        private string tukhoa = "";
        private void LoadDSMonHoc()
        {
            //load toàn bộ danh sách sinh viên

            //khai báo list ctPara
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter
            {
                key = "@tukhoa",
                value = tukhoa
            });

            dgvMonHoc.DataSource = new Database().SelectData("selectAllMonHoc", lstPara);
            dgvMonHoc.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dgvMonHoc.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvMonHoc.Columns["sotinchi"].HeaderText = "Số tín chỉ";

            //đặt tên cột
        }

        private void frmDSMH_Load(object sender, EventArgs e)
        {
            LoadDSMonHoc();
        }
    }
}
