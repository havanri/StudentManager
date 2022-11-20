using System.Runtime.InteropServices;

namespace QuanLySinhVien
{
    public partial class frmMain : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        public frmMain()
        {
            AllocConsole();
            InitializeComponent();
        }
        private string taikhoan;
        private string loaitaikhoan;
        private void frmMain_Load_1(object sender, EventArgs e)
        {
            
            var fn = new frmDangNhap();
            fn.ShowDialog();
            taikhoan = fn.tendangnhap;
            loaitaikhoan = fn.loaitk;

            if (loaitaikhoan.Equals("admin"))
            {
                this.Text = "TRANG QUẢN TRỊ VIÊN";
                btnTraCuuDiem.Visible = false;
                btnDangKyMonHoc.Visible = false;

                btnTraCuuLop.Visible = false;
                Console.WriteLine("VÀO");
                frmDSSV f = new frmDSSV();
                addForm(f);
            }
            else
            {
                quanlyToolStripMenuItem.Visible = false;
                if (loaitaikhoan.Equals("gv"))
                {
                    this.Text = "TRANG GIÁO VIÊN";
                    btnLopHoc.Visible = false;
                    btnSinhVien.Visible = false;
                    btnGiaoVien.Visible = false;
                    btnMonHoc.Visible = false;
                    btnNhapDiem.Visible = false;

                    btnTraCuuDiem.Visible = false;
                    btnDangKyMonHoc.Visible = false;



                    frmWelcome f = new frmWelcome();
                    addForm(f);
                }
                else if(loaitaikhoan.Equals("sv"))//sinh vien
                {
                    this.Text = "TRANG SINH VIÊN";
                    btnLopHoc.Visible = false;
                    btnSinhVien.Visible = false;
                    btnGiaoVien.Visible = false;
                    btnMonHoc.Visible = false;

                    btnTraCuuLop.Visible = false;
                    btnNhapDiem.Visible = false;

                    frmWelcome f = new frmWelcome();
                    addForm(f);
                }
                else
                {
                    Application.Exit();
                }
            }
           
            
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void addForm(Form f)
        {
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.pnlContent.Controls.Add(f);
            f.Show();
        }
        private void doimatkhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fr = new frmDoiMatKhau(taikhoan,loaitaikhoan);
            fr.ShowDialog();
        }

        private void sinhvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSSV f = new frmDSSV();
            addForm(f);
        }

        private void monhocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSMH f = new frmDSMH();
            addForm(f);
        }

        private void giaovienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSGV f = new frmDSGV();
            addForm(f);
        }

        private void lophocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSLH f = new frmDSLH();
            addForm(f);
        }


        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            gbTrangDanhSach.Text = "Danh Sách Sinh Viên";
            frmDSSV f = new frmDSSV();
            addForm(f);
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            gbTrangDanhSach.Text = "Danh Sách Giáo Viên";
            frmDSGV f = new frmDSGV();
            addForm(f);
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            gbTrangDanhSach.Text = "Danh Sách Các Học Phần";
            frmDSLH f = new frmDSLH();
            addForm(f);
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            gbTrangDanhSach.Text = "Danh Sách Môn Học";
            frmDSMH f = new frmDSMH();
            addForm(f);
        }

        private void btnDangKyMonHoc_Click(object sender, EventArgs e)
        {
            gbTrangDanhSach.Text = "Danh Sách Môn Học Đã Đăng ký";
            var f = new frmDSMonHocDaDangKy(taikhoan);
            addForm(f);
        }

        private void btnTraCuuDiem_Click(object sender, EventArgs e)
        {
            gbTrangDanhSach.Text = "Kết Quả Học Tập";
            var f = new frmTraCuuKQHocTap(taikhoan);
            addForm(f);
        }

        private void btnTraCuuLop_Click(object sender, EventArgs e)
        {
            gbTrangDanhSach.Text = "Danh Sách Lớp Học";
            var f = new frmTraCuuLop(taikhoan);
            addForm(f);
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            gbTrangDanhSach.Text = "Danh Sách Học Phần Hoàn Thành";
            var f = new frmHocPhanDaKetThuc();
            addForm(f);
        }
    }
}