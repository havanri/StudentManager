using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmDSSVCuaLopHoc : Form
    {
        private string malophoc;
        public frmDSSVCuaLopHoc(string malophoc)
        {
            InitializeComponent();
            this.malophoc = malophoc;
        }

        private void frmDSSVCuaLopHoc_Load(object sender, EventArgs e)
        {
            loadDSLH();
        }
        private void loadDSLH()
        {
            List<CustomParameter> lst = new List<CustomParameter>();
            lst.Add(new CustomParameter()
            {
                key = "@malophoc",
                value = malophoc
            });
            lst.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDSSV.DataSource = new Database().SelectData("danhsachSVcuaLop", lst);
            if (dgvDSSV.Rows.Count > 0)
            {
                this.dgvDSSV.CurrentCell = this.dgvDSSV.Rows[currentIndex].Cells[0];//vị trí con trỏ(index) trong datagridview(-_-)
            }
            dgvDSSV.EditMode = DataGridViewEditMode.EditOnEnter;

            dgvDSSV.Columns["masinhvien"].ReadOnly = true;
            dgvDSSV.Columns["tensinhvien"].ReadOnly = true;

            dgvDSSV.Columns["masinhvien"].HeaderText = "Mã sinh viên";
            dgvDSSV.Columns["tensinhvien"].HeaderText = "Tên sinh viên";
            dgvDSSV.Columns["diemquatrinh"].HeaderText = "Điểm quá trình";
            
        }
        private string tukhoa = "";
        private void btnSearch_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            tukhoa = txtTimKiem.Text;
            loadDSLH();
        }
        private int currentIndex = 0;
        private void dgvDSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("ố zề");
            currentIndex = e.RowIndex;
            string masv = dgvDSSV.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
            var r = new Database().Select("detailSV '" + masv + "'");
            pictureBox1.ImageLocation = r["avatar"].ToString();
            currentIndex = dgvDSSV.CurrentCell.RowIndex;
        }
        private void dgvDSSV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           MessageBox.Show("ố zề");
         

        }

        private void dgvDSSV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = e.RowIndex;
            String diem= Microsoft.VisualBasic.Interaction.InputBox("Vui lòng nhập số điểm sinh viên", "Điểm:");
            if (diem == "")
            {
                this.dgvDSSV.CurrentCell = this.dgvDSSV.Rows[currentIndex].Cells[0];//vị trí con trỏ(index) trong datagridview(-_-)
                return;
            }
            if (float.Parse(diem) < 0 || float.Parse(diem) > 10)
            {
                MessageBox.Show("Mức điểm thấp nhất là 0 tối đa là 10");
                this.dgvDSSV.CurrentCell = this.dgvDSSV.Rows[currentIndex].Cells[0];
                return;
            }
            List<CustomParameter> lst = new List<CustomParameter>();
            string maSV = dgvDSSV.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
            string loaidiem = "diemquatrinh";
            lst.Add(new CustomParameter()
            {
                key="@masinhvien",
                value=maSV
            });
            lst.Add(new CustomParameter()
            {
                key="@malophoc",
                value=malophoc
            });
            lst.Add(new CustomParameter()
            {
                key="@diem",
                value=diem
            });
            lst.Add(new CustomParameter()
            {
                key = "@loaidiem",
                value = loaidiem
            });

            var r = new Database().ExeCute("capnhatDiem", lst);
            Console.WriteLine(r);
            if (r == 1)
            {
                MessageBox.Show("Cập nhật điểm sinh viên thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật điểm sinh viên thất bại");
            }
            loadDSLH();

        }
    }
}
