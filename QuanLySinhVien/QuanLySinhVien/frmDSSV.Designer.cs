namespace QuanLySinhVien
{
    partial class frmDSSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSSV));
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.lblKeyWord = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.DSSVBinding = new System.Windows.Forms.BindingSource(this.components);
            this.btnXemHocPhan = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSSVBinding)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(0, 133);
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 29;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(1207, 465);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellDoubleClick);
            // 
            // lblKeyWord
            // 
            this.lblKeyWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKeyWord.AutoSize = true;
            this.lblKeyWord.Location = new System.Drawing.Point(830, 25);
            this.lblKeyWord.Name = "lblKeyWord";
            this.lblKeyWord.Size = new System.Drawing.Size(75, 20);
            this.lblKeyWord.TabIndex = 1;
            this.lblKeyWord.Text = "Tìm Kiếm:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(1052, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 48);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTuKhoa.Location = new System.Drawing.Point(911, 22);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(180, 27);
            this.txtTuKhoa.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(1097, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnXemHocPhan
            // 
            this.btnXemHocPhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXemHocPhan.Image = ((System.Drawing.Image)(resources.GetObject("btnXemHocPhan.Image")));
            this.btnXemHocPhan.Location = new System.Drawing.Point(830, 64);
            this.btnXemHocPhan.Name = "btnXemHocPhan";
            this.btnXemHocPhan.Size = new System.Drawing.Size(189, 48);
            this.btnXemHocPhan.TabIndex = 5;
            this.btnXemHocPhan.Text = "Danh sách học phần";
            this.btnXemHocPhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemHocPhan.UseVisualStyleBackColor = true;
            this.btnXemHocPhan.Click += new System.EventHandler(this.btnXemHocPhan_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.Lime;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(675, 64);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(128, 48);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Xuất dữ liệu";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // frmDSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1207, 598);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnXemHocPhan);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblKeyWord);
            this.Controls.Add(this.dgvSinhVien);
            this.Name = "frmDSSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.frmDSSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSSVBinding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvSinhVien;
        private Label lblKeyWord;
        private Button btnAdd;
        private TextBox txtTuKhoa;
        private Button btnSearch;
        private BindingSource DSSVBinding;
        private Button btnXemHocPhan;
        private Button btnExport;
    }
}