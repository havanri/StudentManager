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
    public partial class frmHocPhan : Form
    {
        private string masv;
        public frmHocPhan(string masv)
        {
            this.masv = masv;
            InitializeComponent();
        }
        private int currentIndex=0;
        private void frmHocPhan_Load(object sender, EventArgs e)
        {
            loadDSDaDangKy();
        }
        private string tukhoa = "";
        private void loadDSDaDangKy()
        {

            var r = new Database().Select("detailSV '" + masv + "'");
            pictureBox1.ImageLocation = r["avatar"].ToString();
            txtMaSV.Text =masv;
            if (r["tendem"].ToString() == null || r["tendem"].ToString().Equals(""))
            {
                txtHoTen.Text = r["ho"].ToString() + " " + r["ten"].ToString();
            }
            else
            {
                txtHoTen.Text = r["ho"].ToString() + " " +r["tendem"].ToString()+" "+ r["ten"].ToString();
            }
            
            //
            List<CustomParameter> lst = new List<CustomParameter>() {
                new CustomParameter()
                {
                    key="@masinhvien",
                    value=masv
                },
                new CustomParameter()
                {
                    key="@tukhoa",
                    value=tukhoa
                }
            };
            dgvDSHP.DataSource = new Database().SelectData("mondadangky", lst);
            if (dgvDSHP.Rows.Count > 0)
            {
                this.dgvDSHP.CurrentCell = this.dgvDSHP.Rows[currentIndex].Cells[0];//vị trí con trỏ(index) trong datagridview(-_-)
            }
            dgvDSHP.Columns["malophoc"].HeaderText = "Mã học phần";
            dgvDSHP.Columns["tenmonhoc"].HeaderText = "Tên môn học";
            dgvDSHP.Columns["sotinchi"].HeaderText = "Số tín chỉ";
            dgvDSHP.Columns["giaovien"].HeaderText = "Giáo viên";
            //dgvDSHP.Columns["diemlan1"].HeaderText = "Điểm thi lần 1";
            //dgvDSHP.Columns["diemlan2"].HeaderText = "Điểm thi lần 2";


        }

        private void btnXoaHocPhan_Click(object sender, EventArgs e)
        {
            if(dgvDSHP.RowCount!=0)
            {
                int index = dgvDSHP.CurrentCell.RowIndex; 
                currentIndex = index;
                if (DialogResult.Yes == MessageBox.Show("Bạn chắc chắn muốn xóa học phần [" + dgvDSHP.Rows[index].Cells["tenmonhoc"].Value.ToString() + "]",
                        "Xác nhân xóa học phần",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question))
                {
                    string malophoc = dgvDSHP.Rows[index].Cells["malophoc"].Value.ToString();

                    List<CustomParameter> lst = new List<CustomParameter>();
                    lst.Add(
                        new CustomParameter()
                        {
                            key = "@masinhvien",
                            value = masv
                        }
                        );
                    lst.Add(
                        new CustomParameter()
                        {
                            key = "@malophoc",
                            value = malophoc
                        }
                        );
                    var rs = new Database().ExeCute("xoahocphandadangky", lst);
                    if (rs == 1)
                    {
                        MessageBox.Show("Học phần đã được xóa");
                        if (dgvDSHP.RowCount-1 == index)
                        {
                            //last element
                            currentIndex = index - 1;
                            Console.WriteLine("xóa thằng cuối" + currentIndex);
                        }
                        else
                        {
                            //không phải last element
                            currentIndex = index;
                            Console.WriteLine("xóa bình thường" + currentIndex);
                        }
                        if (dgvDSHP.RowCount - 1 == 0)
                        {
                            currentIndex = 0;
                        }
                        loadDSDaDangKy();
                        return;
                    }
                    if (rs == 0)
                    {
                        MessageBox.Show("Học phần này đã có điểm");
                        return;
                    }  
                }
            }  
        }

        private void btnDangKyHP_Click(object sender, EventArgs e)
        {
            new frmDangKyMonHoc(masv).ShowDialog();
            currentIndex= dgvDSHP.CurrentCell.RowIndex;
            loadDSDaDangKy();
        }
    }
}
