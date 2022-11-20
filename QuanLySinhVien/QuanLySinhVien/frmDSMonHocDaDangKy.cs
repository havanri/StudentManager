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
    
    public partial class frmDSMonHocDaDangKy : Form
    {
        private string masv;
        public frmDSMonHocDaDangKy(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }

        private void frmDSMonHocDaDangKy_Load(object sender, EventArgs e)
        {
            loadDSDaDangKy();
           
        }
        private String tukhoa = "";

        private void loadDSDaDangKy()
        {
            List<CustomParameter> lst = new List<CustomParameter>() {
                new CustomParameter()
                {
                    key="@masinhvien",
                    value=masv
                }
            };
            lst.Add(new CustomParameter()
            {
                key="@tukhoa",
                value=tukhoa
            });
            Console.WriteLine(tukhoa);
            dgvDanhSachMon.DataSource = new Database().SelectData("mondadangky", lst);
            dgvDanhSachMon.Columns["malophoc"].HeaderText = "Mã học phần";
            dgvDanhSachMon.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDanhSachMon.Columns["sotinchi"].HeaderText = "Số tín chỉ";
            dgvDanhSachMon.Columns["giaovien"].HeaderText = "Giáo viên";
            //dgvDanhSachMon.Columns["diemlan1"].HeaderText = "Điểm thi lần 1";
            //dgvDanhSachMon.Columns["diemlan2"].HeaderText = "Điểm thi lần 2";
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            new frmDangKyMonHoc(masv).ShowDialog();
            loadDSDaDangKy();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            loadDSDaDangKy();
        }
    }
}
