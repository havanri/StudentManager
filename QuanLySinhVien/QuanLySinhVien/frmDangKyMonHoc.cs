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
    public partial class frmDangKyMonHoc : Form
    {
        private string masv;
        public frmDangKyMonHoc(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }

        private void frmDangKyMonHoc_Load(object sender, EventArgs e)
        {
            this.Text = "Đăng ký môn học";
            LoadDSLHOpen();
            dgvDSLHOpen.Columns["malophoc"].HeaderText = "Mã học phần";
            dgvDSLHOpen.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dgvDSLHOpen.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDSLHOpen.Columns["sotinchi"].HeaderText = "Số tín chỉ";
            dgvDSLHOpen.Columns["giaovien"].HeaderText = "Giáo viên giảng dạy";
        }
        private void LoadDSLHOpen()
        {
            List<CustomParameter> lst = new List<CustomParameter>();

            lst.Add(
                new CustomParameter()
                {
                    key="@masinhvien",
                    value=masv
                }
            );
            dgvDSLHOpen.DataSource = new Database().SelectData("dslhmo",lst);
        }

        private void dgvDSLHOpen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDSLHOpen.Rows[e.RowIndex].Index >= 0)
            {
                if(DialogResult.Yes==MessageBox.Show("Bạn muốn đăng ký học phần [" + dgvDSLHOpen.Rows[e.RowIndex].Cells["tenmonhoc"].Value.ToString()+"]",
                    "Xác nhân đăng ký học phần",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                {
                    List<CustomParameter> lst = new List<CustomParameter>();
                    lst.Add(
                        new CustomParameter()
                        {
                             key="@masinhvien",
                             value=masv
                        }
                        );
                    lst.Add(
                        new CustomParameter()
                        {
                            key = "@malophoc",
                            value = dgvDSLHOpen.Rows[e.RowIndex].Cells["malophoc"].Value.ToString()
                        }
                        );
                    var rs = new Database().ExeCute("dangkyhoc", lst);
                    if (rs == -1)
                    {
                        MessageBox.Show("Học phần này đã đăng ký");
                        return;
                    }
                    if (rs == 1)
                    {
                        MessageBox.Show("Đăng ký thành công");
                        return;
                    }
                }
            }
        }
    }
}
