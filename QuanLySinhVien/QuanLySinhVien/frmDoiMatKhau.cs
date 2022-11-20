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
    public partial class frmDoiMatKhau : Form
    {
        private string taikhoan;
        private string loaitaikhoan;
        public frmDoiMatKhau(string taikhoan, string loaitaikhoan)
        {
            this.taikhoan = taikhoan;           
            this.loaitaikhoan = loaitaikhoan;
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            lblMatKhau.Text = "";
            lblXacNhanMatKhau.Text = "";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            Console.WriteLine(taikhoan+ "|"+loaitaikhoan+"|" +txtMatKhau.Text);
            lblMatKhau.Text = "";
            lblXacNhanMatKhau.Text = "";
            if(txtMatKhau.Text == null || txtMatKhau.Text=="")
            {
                lblMatKhau.Text = "Vui lòng nhập mật khẩu mới";
                return;
            }
            if(txtMatKhau.Text != txtXacNhanMatKhau.Text)
            {
                lblXacNhanMatKhau.Text = "Mật khẩu xác nhận không khớp";
                txtXacNhanMatKhau.Text = "";
                return;
            }
            List<CustomParameter> lst = new List<CustomParameter>();

            lst.Add(new CustomParameter()
            {
                key="@taikhoan",
                value=taikhoan
            });
            lst.Add(new CustomParameter()
            {
                key = "@loaitaikhoan",
                value = loaitaikhoan
            });
            lst.Add(new CustomParameter()
            {
                key = "@matkhaumoi",
                value = txtMatKhau.Text
            });

            var rs = new Database().SelectData("doimatkhau", lst);

            MessageBox.Show("Cập nhật mật khẩu thành công");
            this.Hide();
  

        }
    }
}
