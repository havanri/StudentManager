namespace QuanLySinhVien
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hethongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doimatkhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhvienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monhocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaovienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lophocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.btnGiaoVien = new System.Windows.Forms.Button();
            this.btnLopHoc = new System.Windows.Forms.Button();
            this.btnMonHoc = new System.Windows.Forms.Button();
            this.btnDangKyMonHoc = new System.Windows.Forms.Button();
            this.btnTraCuuDiem = new System.Windows.Forms.Button();
            this.btnTraCuuLop = new System.Windows.Forms.Button();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.gbTrangDanhSach = new System.Windows.Forms.GroupBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gbTrangDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hethongToolStripMenuItem,
            this.quanlyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1289, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hethongToolStripMenuItem
            // 
            this.hethongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doimatkhauToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.hethongToolStripMenuItem.Name = "hethongToolStripMenuItem";
            this.hethongToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hethongToolStripMenuItem.Text = "Hệ thống";
            // 
            // doimatkhauToolStripMenuItem
            // 
            this.doimatkhauToolStripMenuItem.Name = "doimatkhauToolStripMenuItem";
            this.doimatkhauToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.doimatkhauToolStripMenuItem.Text = "Đổi mật khẩu";
            this.doimatkhauToolStripMenuItem.Click += new System.EventHandler(this.doimatkhauToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // quanlyToolStripMenuItem
            // 
            this.quanlyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhvienToolStripMenuItem,
            this.monhocToolStripMenuItem,
            this.giaovienToolStripMenuItem,
            this.lophocToolStripMenuItem});
            this.quanlyToolStripMenuItem.Name = "quanlyToolStripMenuItem";
            this.quanlyToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.quanlyToolStripMenuItem.Text = "Quản lý";
            // 
            // sinhvienToolStripMenuItem
            // 
            this.sinhvienToolStripMenuItem.Name = "sinhvienToolStripMenuItem";
            this.sinhvienToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.sinhvienToolStripMenuItem.Text = "Sinh viên";
            this.sinhvienToolStripMenuItem.Click += new System.EventHandler(this.sinhvienToolStripMenuItem_Click);
            // 
            // monhocToolStripMenuItem
            // 
            this.monhocToolStripMenuItem.Name = "monhocToolStripMenuItem";
            this.monhocToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.monhocToolStripMenuItem.Text = "Môn học";
            this.monhocToolStripMenuItem.Click += new System.EventHandler(this.monhocToolStripMenuItem_Click);
            // 
            // giaovienToolStripMenuItem
            // 
            this.giaovienToolStripMenuItem.Name = "giaovienToolStripMenuItem";
            this.giaovienToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.giaovienToolStripMenuItem.Text = "Giáo viên";
            this.giaovienToolStripMenuItem.Click += new System.EventHandler(this.giaovienToolStripMenuItem_Click);
            // 
            // lophocToolStripMenuItem
            // 
            this.lophocToolStripMenuItem.Name = "lophocToolStripMenuItem";
            this.lophocToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.lophocToolStripMenuItem.Text = "Lớp học";
            this.lophocToolStripMenuItem.Click += new System.EventHandler(this.lophocToolStripMenuItem_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMenu.Controls.Add(this.button1);
            this.pnlMenu.Controls.Add(this.flowLayoutPanel1);
            this.pnlMenu.Location = new System.Drawing.Point(0, 35);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(304, 515);
            this.pnlMenu.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(300, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "MENU";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSinhVien);
            this.flowLayoutPanel1.Controls.Add(this.btnGiaoVien);
            this.flowLayoutPanel1.Controls.Add(this.btnLopHoc);
            this.flowLayoutPanel1.Controls.Add(this.btnMonHoc);
            this.flowLayoutPanel1.Controls.Add(this.btnDangKyMonHoc);
            this.flowLayoutPanel1.Controls.Add(this.btnTraCuuDiem);
            this.flowLayoutPanel1.Controls.Add(this.btnTraCuuLop);
            this.flowLayoutPanel1.Controls.Add(this.btnNhapDiem);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 80);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 510);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSinhVien.ForeColor = System.Drawing.Color.Blue;
            this.btnSinhVien.Image = ((System.Drawing.Image)(resources.GetObject("btnSinhVien.Image")));
            this.btnSinhVien.Location = new System.Drawing.Point(3, 3);
            this.btnSinhVien.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(297, 46);
            this.btnSinhVien.TabIndex = 0;
            this.btnSinhVien.Text = "Sinh Viên";
            this.btnSinhVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSinhVien.UseVisualStyleBackColor = true;
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGiaoVien.ForeColor = System.Drawing.Color.Blue;
            this.btnGiaoVien.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaoVien.Image")));
            this.btnGiaoVien.Location = new System.Drawing.Point(3, 72);
            this.btnGiaoVien.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnGiaoVien.Name = "btnGiaoVien";
            this.btnGiaoVien.Size = new System.Drawing.Size(297, 46);
            this.btnGiaoVien.TabIndex = 1;
            this.btnGiaoVien.Text = "Giáo Viên";
            this.btnGiaoVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGiaoVien.UseVisualStyleBackColor = true;
            this.btnGiaoVien.Click += new System.EventHandler(this.btnGiaoVien_Click);
            // 
            // btnLopHoc
            // 
            this.btnLopHoc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLopHoc.ForeColor = System.Drawing.Color.Blue;
            this.btnLopHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnLopHoc.Image")));
            this.btnLopHoc.Location = new System.Drawing.Point(3, 141);
            this.btnLopHoc.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnLopHoc.Name = "btnLopHoc";
            this.btnLopHoc.Size = new System.Drawing.Size(297, 46);
            this.btnLopHoc.TabIndex = 2;
            this.btnLopHoc.Text = "Học Phần";
            this.btnLopHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLopHoc.UseVisualStyleBackColor = true;
            this.btnLopHoc.Click += new System.EventHandler(this.btnLopHoc_Click);
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMonHoc.ForeColor = System.Drawing.Color.Blue;
            this.btnMonHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnMonHoc.Image")));
            this.btnMonHoc.Location = new System.Drawing.Point(3, 210);
            this.btnMonHoc.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.Size = new System.Drawing.Size(297, 46);
            this.btnMonHoc.TabIndex = 3;
            this.btnMonHoc.Text = "Môn Học";
            this.btnMonHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMonHoc.UseVisualStyleBackColor = true;
            this.btnMonHoc.Click += new System.EventHandler(this.btnMonHoc_Click);
            // 
            // btnDangKyMonHoc
            // 
            this.btnDangKyMonHoc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDangKyMonHoc.ForeColor = System.Drawing.Color.Blue;
            this.btnDangKyMonHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnDangKyMonHoc.Image")));
            this.btnDangKyMonHoc.Location = new System.Drawing.Point(3, 279);
            this.btnDangKyMonHoc.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnDangKyMonHoc.Name = "btnDangKyMonHoc";
            this.btnDangKyMonHoc.Size = new System.Drawing.Size(297, 46);
            this.btnDangKyMonHoc.TabIndex = 4;
            this.btnDangKyMonHoc.Text = "Đăng ký môn học";
            this.btnDangKyMonHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangKyMonHoc.UseVisualStyleBackColor = true;
            this.btnDangKyMonHoc.Click += new System.EventHandler(this.btnDangKyMonHoc_Click);
            // 
            // btnTraCuuDiem
            // 
            this.btnTraCuuDiem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTraCuuDiem.ForeColor = System.Drawing.Color.Blue;
            this.btnTraCuuDiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTraCuuDiem.Image")));
            this.btnTraCuuDiem.Location = new System.Drawing.Point(3, 348);
            this.btnTraCuuDiem.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnTraCuuDiem.Name = "btnTraCuuDiem";
            this.btnTraCuuDiem.Size = new System.Drawing.Size(297, 46);
            this.btnTraCuuDiem.TabIndex = 5;
            this.btnTraCuuDiem.Text = "Tra cứu điểm";
            this.btnTraCuuDiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraCuuDiem.UseVisualStyleBackColor = true;
            this.btnTraCuuDiem.Click += new System.EventHandler(this.btnTraCuuDiem_Click);
            // 
            // btnTraCuuLop
            // 
            this.btnTraCuuLop.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTraCuuLop.ForeColor = System.Drawing.Color.Blue;
            this.btnTraCuuLop.Image = ((System.Drawing.Image)(resources.GetObject("btnTraCuuLop.Image")));
            this.btnTraCuuLop.Location = new System.Drawing.Point(3, 417);
            this.btnTraCuuLop.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnTraCuuLop.Name = "btnTraCuuLop";
            this.btnTraCuuLop.Size = new System.Drawing.Size(297, 46);
            this.btnTraCuuLop.TabIndex = 6;
            this.btnTraCuuLop.Text = "Tra cứu lớp";
            this.btnTraCuuLop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraCuuLop.UseVisualStyleBackColor = true;
            this.btnTraCuuLop.Click += new System.EventHandler(this.btnTraCuuLop_Click);
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNhapDiem.ForeColor = System.Drawing.Color.Blue;
            this.btnNhapDiem.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapDiem.Image")));
            this.btnNhapDiem.Location = new System.Drawing.Point(3, 486);
            this.btnNhapDiem.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(297, 46);
            this.btnNhapDiem.TabIndex = 7;
            this.btnNhapDiem.Text = "Nhập Điểm";
            this.btnNhapDiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapDiem.UseVisualStyleBackColor = true;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // gbTrangDanhSach
            // 
            this.gbTrangDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTrangDanhSach.Controls.Add(this.pnlContent);
            this.gbTrangDanhSach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbTrangDanhSach.Location = new System.Drawing.Point(307, 35);
            this.gbTrangDanhSach.Name = "gbTrangDanhSach";
            this.gbTrangDanhSach.Size = new System.Drawing.Size(982, 515);
            this.gbTrangDanhSach.TabIndex = 4;
            this.gbTrangDanhSach.TabStop = false;
            this.gbTrangDanhSach.Text = "Danh Sách";
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlContent.Location = new System.Drawing.Point(6, 26);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(970, 483);
            this.pnlContent.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 550);
            this.Controls.Add(this.gbTrangDanhSach);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.gbTrangDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hethongToolStripMenuItem;
        private ToolStripMenuItem doimatkhauToolStripMenuItem;
        private ToolStripMenuItem thoatToolStripMenuItem;
        private ToolStripMenuItem quanlyToolStripMenuItem;
        private ToolStripMenuItem sinhvienToolStripMenuItem;
        private ToolStripMenuItem monhocToolStripMenuItem;
        private ToolStripMenuItem giaovienToolStripMenuItem;
        private ToolStripMenuItem lophocToolStripMenuItem;
        private Panel pnlMenu;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSinhVien;
        private Button btnGiaoVien;
        private Button btnLopHoc;
        private Button btnMonHoc;
        private Button button1;
        private GroupBox groupBox1;
        private Panel pnlContent;
        private GroupBox gbTrangDanhSach;
        private Button btnDangKyMonHoc;
        private Button btnTraCuuDiem;
        private Button btnTraCuuLop;
        private Button btnNhapDiem;
    }
}