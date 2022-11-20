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
    public partial class frmLopHoc : Form
    {
        private string malophoc;
        public frmLopHoc(string malophoc)
        {
            this.malophoc = malophoc;
            InitializeComponent();
        }
        private Database db;
        private string nguoithuchien = "admin";
        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            db= new Database(); 
            List<CustomParameter> lst = new List<CustomParameter>() { 
                new CustomParameter()
                {
                    key="@tukhoa",
                    value=""
                }
            };
            //
            cbMonHoc.DataSource =  db.SelectData("selectAllMonHoc", lst);
            cbMonHoc.DisplayMember = "tenmonhoc";
            cbMonHoc.ValueMember = "mamonhoc";
            cbMonHoc.SelectedIndex = -1;
            //
            cbGiaoVien.DataSource =  db.SelectData("SelectAllGiaoVien", lst);
            cbGiaoVien.DisplayMember = "hoten";
            cbGiaoVien.ValueMember = "magiaovien";
            cbGiaoVien.SelectedIndex = -1;
            //MessageBox.Show("Mã sinh viên: " + maSV);


            if (string.IsNullOrEmpty(malophoc))
            {
                this.Text = "Mở lớp học";
            }
            else
            {
                this.Text = "Cập nhật thông tin lớp học";
                var r =  db.Select("detailLop '" + malophoc + "'");
                cbGiaoVien.SelectedValue = r["magiaovien"].ToString();
                cbMonHoc.SelectedValue = r["mamonhoc"].ToString();
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbGiaoVien.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn giáo viên");
                return;
            }
            if (cbMonHoc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn môn học");
                return;
            }
            string sql = "";
            List<CustomParameter> lstPara = new List<CustomParameter>();
           
            if (string.IsNullOrEmpty(malophoc))
            {
                //this.Text = "Thêm mới sinh viên";
                sql = "insertLopHoc";
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoithuchien
                });

            }
            else
            {
                sql = "updateLopHoc";
                lstPara.Add(new CustomParameter()
                {
                    key = "@malophoc",
                    value = malophoc
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = nguoithuchien
                });
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@magiaovien",
                value = cbGiaoVien.SelectedValue.ToString()

            });
            lstPara.Add(new CustomParameter()
            {
                key = "@mamonhoc",
                value = cbMonHoc.SelectedValue.ToString()
            });
            var rs = new Database().ExeCute(sql, lstPara);
            if (rs == 1)
            {

                if (string.IsNullOrEmpty(malophoc))
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
