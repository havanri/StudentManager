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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            
            InitializeComponent();
            customForm(btnDangNhap);
            customForm(btnThoat);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void customForm(Button btn)
        {
            btn.TabStop = false;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        public string tendangnhap = "";
        public string loaitk = "";
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //validate

            if (cbPhanQuyen.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản");
                return;
            }
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản");
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }
            //
            tendangnhap = txtUsername.Text;
            switch (cbPhanQuyen.Text)
            {
                case "Quản trị viên":
                    loaitk = "admin";
                    break;
                case "Giáo viên":
                    loaitk = "gv";
                    break;
                case "Sinh viên":
                    loaitk = "sv";
                    break;
            }


            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key="@loaitaikhoan",
                    value=loaitk
                },
                new CustomParameter()
                {
                    key="@taikhoan",
                    value=txtUsername.Text
                },
                new CustomParameter()
                {
                    key="@matkhau",
                    value=txtPassword.Text
                }
            };
            var rs = new Database().SelectData("dangnhap", lst);

            if (rs.Rows.Count > 0)
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai ");
            }    
        }
    }
}
