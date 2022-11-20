using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmMonHoc : Form
    {
        private string mamh;
        public frmMonHoc(string mamh)
        {
            this.mamh = mamh;
            InitializeComponent();
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mamh))
            {
                this.Text = "Thêm mới môn học";
            }
            else
            {
                this.Text = "Cập nhật thông tin môn học";
                var r = new Database().Select("detailMH '" + mamh + "'");
                txtTenMonHoc.Text = r["tenmonhoc"].ToString();
                txtTinChi.Text = r["sotinchi"].ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            try
            {
                var stc = int.Parse(txtTinChi.Text);
                if (stc <= 0)
                {
                    MessageBox.Show("Số tín chỉ phải lớn hơn 0");
                    txtTinChi.Select();
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Số tín chỉ phải là số nguyên");
                txtTinChi.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtTenMonHoc.Text))
            {
                MessageBox.Show("Tên môn học không được để trống");
                txtTenMonHoc.Select();
                return ;
            }
            //Luu co 2 truong hop 
            //1:la truong hop cap nhat
            //2:la truong hop them moi
            string sql = "";
            string nguoitao = "admin";
            string tenmonhoc = txtTenMonHoc.Text;
            string sotinchi = txtTinChi.Text;

            List<CustomParameter> lstPara = new List<CustomParameter>();

            if (string.IsNullOrEmpty(mamh))
            {
                //this.Text = "Thêm mới sinh viên";
                sql = "insertMH";
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoitao
                });

            }
            else
            {
                sql = "updateMH";
                lstPara.Add(new CustomParameter()
                {
                    key = "@mamonhoc",
                    value = mamh
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = "admin"
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@tenmonhoc",
                value = tenmonhoc
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@sotinchi",
                value = sotinchi
            });
            var rs = new Database().ExeCute(sql, lstPara);
            if (rs == 1)
            {

                if (string.IsNullOrEmpty(mamh))
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
    }
}
