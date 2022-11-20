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
    public partial class frmTraCuuLop : Form
    {
        private string magv;
        public frmTraCuuLop(string magv)
        {
            InitializeComponent();
            this.magv = magv;
        }
        private string tukhoa = "";
        private void frmTraCuuLop_Load(object sender, EventArgs e)
        {
            loadDSLH();
        }
        private void loadDSLH()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(
                new CustomParameter()
                {
                    key="@magiaovien",
                    value=magv
                }
                );
            lst.Add(
                new CustomParameter()
                {
                    key = "@tukhoa",
                    value = txtTraCuu.Text
                }
             );
            dgvDSLH.DataSource = new Database().SelectData("tracuulop", lst);
            dgvDSLH.Columns["malophoc"].HeaderText = "Mã học phần";
            dgvDSLH.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dgvDSLH.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDSLH.Columns["sotinchi"].HeaderText = "Số tín chỉ";
            dgvDSLH.Columns["siso"].HeaderText = "Sỉ số";
        }


        private void ChamDiem_Click(object sender, EventArgs e)
        {
            if (dgvDSLH.RowCount != 0)
            {
                int index = dgvDSLH.CurrentCell.RowIndex;
                string malophoc = dgvDSLH.Rows[index].Cells["malophoc"].Value.ToString();
                //MessageBox.Show("Mã sinh viên: " + dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString);
                new frmDSSVCuaLopHoc(malophoc).ShowDialog();
                //khi frmSinhVien đóng lại thì ta load lại danh sách sinh viên
                loadDSLH();
            }
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {

        }
    }
}
