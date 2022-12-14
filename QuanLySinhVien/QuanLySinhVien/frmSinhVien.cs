
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmSinhVien : Form
    {
        private string maSV;
        public frmSinhVien(string maSV)
        {
            this.maSV = maSV;
            InitializeComponent();
           
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Mã sinh viên: " + maSV);
            if (string.IsNullOrEmpty(maSV))
            {
                this.Text = "Thêm mới sinh viên";
                groupBox1.Text= "Thêm mới sinh viên";
            }
            else
            {
                this.Text = "Cập nhật thông tin sinh viên";
                groupBox1.Text = "Cập nhật sinh viên";
                //lấy thông tin sinh viên
                var r = new Database().Select("detailSV '" + maSV + "'");
                txtTen.Text = r["ten"].ToString();
                txtHo.Text = r["ho"].ToString();
                txtTenDem.Text = r["tendem"].ToString();
                mskNgaySinh.Text = r["ngaysinh"].ToString();
                //gioitinh
                if (int.Parse(r["gioitinh"].ToString()) == 0)
                {
                    rdoNam.Checked = true;
                }
                else
                {
                    rdoNu.Checked = true;
                }
                txtDiaChi.Text = r["diachi"].ToString();
                txtDienThoai.Text = r["dienthoai"].ToString();
                txtEmail.Text = r["email"].ToString();
                Console.WriteLine(r["avatar"].ToString());
                pictureBox1.ImageLocation = r["avatar"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Luu co 2 truong hop 
            //1:la truong hop cap nhat
            //2:la truong hop them moi
            string sql = "";
            string ho = txtHo.Text;
            string tendem = txtTenDem.Text;
            string ten = txtTen.Text;

            //vì mskbox . chúng ta theo dạng dd/MM/yyyy
            //nhưng trong cơ sở dữ liệu là yyyy/MM/dd
            //chúng ta phải convert lại
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(mskNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ");
                mskNgaySinh.Select();
                return;//dừng việc thực thực hiện các câu lệnh
            }
            int gioitinh = rdoNam.Checked ? 0 : 1;
            string diachi = txtDiaChi.Text;
            string dienthoai = txtDienThoai.Text;
            string email = txtEmail.Text;
            string avatar;
            if(pictureBox1.ImageLocation == null)
            {
                avatar = @"D:\C#\images\avatar.jpg";
            }
            else
            {
                avatar = pictureBox1.ImageLocation.ToString();
            }
            List<CustomParameter> lstPara = new List<CustomParameter>();

            if (string.IsNullOrEmpty(maSV))
            {
               // this.Text = "Thêm mới sinh viên";
                sql = "ThemMoiSV";

            }
            else
            {
               // this.Text = "Cập nhật sinh viên";
                sql = "capnhatSV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@Masinhvien",
                    value = maSV
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@Ho",
                value = ho
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Tendem",
                value = tendem
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Ten",
                value = ten
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Ngaysinh",
                value = ngaysinh.ToString("yyyy-MM-dd")
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Gioitinh",
                value = gioitinh.ToString()
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Diachi",
                value = diachi
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Dienthoai",
                value = dienthoai
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Email",
                value = email
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Avatar",
                value = avatar
            });
            var rs= new Database().ExeCute(sql,lstPara);
            if (rs == 1)
            {
                
                if (string.IsNullOrEmpty(maSV))
                {
                    MessageBox.Show("Thêm mới thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi thất bại");
            }

        }

        

        private void llbImageSinhVien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Anhr";
            var rs = openFileDialog.ShowDialog();
            if (rs == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                pictureBox1.ImageLocation = file;
                Console.WriteLine(file.ToString());
                
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
