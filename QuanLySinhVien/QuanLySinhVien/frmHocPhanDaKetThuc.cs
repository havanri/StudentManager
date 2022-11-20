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
    public partial class frmHocPhanDaKetThuc : Form
    {
        public frmHocPhanDaKetThuc()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        int currentIndex = 0;
        private void frmHocPhanDaKetThuc_Load(object sender, EventArgs e)
        {
            LoadDSHPComplete();
        }
        private void LoadDSHPComplete()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter
            {
                key = "@tukhoa",
                value = tukhoa
            });


            //dgvSinhVien.DataSource = new Database().SelectData("SelectAllSinhVien", lstPara);
            //int itemFound = DSSVBinding.Find("masinhvien", "19SV1101");

            //
            //int index = dataGridView1.CurrentRow.Index;

            /*
             * Your Refresh Code
             */


            dgvHocPhanKetThuc.DataSource = new Database().SelectData("selectAllLopHocComplete", lstPara);
            if (dgvHocPhanKetThuc.Rows.Count > 0)
            {
                this.dgvHocPhanKetThuc.CurrentCell = this.dgvHocPhanKetThuc.Rows[currentIndex].Cells[0];//vị trí con trỏ(index) trong datagridview(-_-)
            }
            //đặt tên cột
            dgvHocPhanKetThuc.Columns["malophoc"].HeaderText = "Mã học phần";
            dgvHocPhanKetThuc.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvHocPhanKetThuc.Columns["gv"].HeaderText = "Giảng viên";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            tukhoa = txtTimKiem.Text;
            LoadDSHPComplete();
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            if (dgvHocPhanKetThuc.RowCount != 0)
            {
                int index = dgvHocPhanKetThuc.CurrentCell.RowIndex;
                string malophoc = dgvHocPhanKetThuc.Rows[index].Cells["malophoc"].Value.ToString();
                //MessageBox.Show("Mã sinh viên: " + dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString);
                new frmDSSVCuaLopHocHoanThanh(malophoc).ShowDialog();
                //khi frmSinhVien đóng lại thì ta load lại danh sách sinh viên
                LoadDSHPComplete();
            }
        }
    }
}
