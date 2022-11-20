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
    public partial class frmTraCuuKQHocTap : Form
    {
        private string masv;
        public frmTraCuuKQHocTap(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }

        private void frmTraCuuKQHocTap_Load(object sender, EventArgs e)
        {
            LoadKQHT();
        }
        private string tukhoa = "";
        private void LoadKQHT()
        {
            List<CustomParameter> lst = new List<CustomParameter>();

            lst.Add(
                    new CustomParameter(){
                        key ="@masinhvien",
                        value=masv
                    }
            );

            lst.Add(
                    new CustomParameter()
                    {
                        key = "@tukhoa",
                        value = txtTraCuu.Text
                    }
            );
            dgvKQHT.DataSource = new Database().SelectData("tracuudiem", lst);
            dgvKQHT.Columns["mamonhoc"].HeaderText = "Mã môn học";
            dgvKQHT.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvKQHT.Columns["lanhoc"].HeaderText = "Lần học";
            dgvKQHT.Columns["giaovien"].HeaderText = "Giáo viên";
            dgvKQHT.Columns["diemquatrinh"].HeaderText = "Điểm quá trình";
            dgvKQHT.Columns["diemlan1"].HeaderText = "Điểm thi lần 1";
            dgvKQHT.Columns["diemlan2"].HeaderText = "Điểm thi lần 2";
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            tukhoa=txtTraCuu.Text;
            LoadKQHT();
        }
    }
}
