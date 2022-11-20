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
    public partial class frmDSLH : Form
    {
        public frmDSLH()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void frmDSLH_Load(object sender, EventArgs e)
        {
            loadDSLH();
        }
        private void loadDSLH()
        {
            string sql = "selectAllLopHoc";
            List<CustomParameter> lstPara = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key="@tukhoa",
                    value=tukhoa
                }
            };
            dgvLopHoc.DataSource = new Database().SelectData(sql, lstPara);
            dgvLopHoc.Columns["malophoc"].HeaderText = "Mã học phần";
            dgvLopHoc.Columns["gv"].HeaderText = "Giáo viên";
            dgvLopHoc.Columns["tenmonhoc"].HeaderText = "Tên môn học";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            loadDSLH();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new frmLopHoc(null).ShowDialog();
            loadDSLH(); 
        }

        private void dgvLopHoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var malophoc = dgvLopHoc.Rows[e.RowIndex].Cells["malophoc"].Value.ToString();
                //MessageBox.Show("Mã sinh viên: " + dgvSinhVien.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString);
                new frmLopHoc(malophoc).ShowDialog();
                //khi frmSinhVien đóng lại thì ta load lại danh sách sinh viên
                loadDSLH();
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (dgvLopHoc.RowCount != 0)
            {
                int index = dgvLopHoc.CurrentCell.RowIndex;
                if (DialogResult.Yes == MessageBox.Show("Xác nhận kết thúc học phần [" + dgvLopHoc.Rows[index].Cells["malophoc"].Value.ToString() + "]",
                        "Xác nhân kết thúc học phần",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question))
                {
                    List<CustomParameter> lst = new List<CustomParameter>();

                    lst.Add(new CustomParameter()
                    {
                        key="@malophoc",
                        value= dgvLopHoc.Rows[index].Cells["malophoc"].Value.ToString()
                    });
                    int rs =new Database().ExeCute("ketthuchocphan",lst);
                    loadDSLH();
                    if (rs == 1)
                    {
                        MessageBox.Show("Kết thúc học phần thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không thể kết thúc học phần");
                    }
                }
            }
        }
    }
}
