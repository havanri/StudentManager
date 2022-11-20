namespace QuanLySinhVien
{
    partial class frmDSGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSGV));
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiemGiaoVien = new System.Windows.Forms.Button();
            this.btnThemGiaoVien = new System.Windows.Forms.Button();
            this.dgvGiaoVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(619, 47);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(73, 20);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(705, 44);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(198, 27);
            this.txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiemGiaoVien
            // 
            this.btnTimKiemGiaoVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiemGiaoVien.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemGiaoVien.Image")));
            this.btnTimKiemGiaoVien.Location = new System.Drawing.Point(909, 44);
            this.btnTimKiemGiaoVien.Name = "btnTimKiemGiaoVien";
            this.btnTimKiemGiaoVien.Size = new System.Drawing.Size(45, 29);
            this.btnTimKiemGiaoVien.TabIndex = 2;
            this.btnTimKiemGiaoVien.UseVisualStyleBackColor = true;
            this.btnTimKiemGiaoVien.Click += new System.EventHandler(this.btnTimKiemGiaoVien_Click);
            // 
            // btnThemGiaoVien
            // 
            this.btnThemGiaoVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemGiaoVien.Image = ((System.Drawing.Image)(resources.GetObject("btnThemGiaoVien.Image")));
            this.btnThemGiaoVien.Location = new System.Drawing.Point(990, 38);
            this.btnThemGiaoVien.Name = "btnThemGiaoVien";
            this.btnThemGiaoVien.Size = new System.Drawing.Size(113, 41);
            this.btnThemGiaoVien.TabIndex = 3;
            this.btnThemGiaoVien.Text = "Thêm mới";
            this.btnThemGiaoVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemGiaoVien.UseVisualStyleBackColor = true;
            this.btnThemGiaoVien.Click += new System.EventHandler(this.btnThemGiaoVien_Click);
            // 
            // dgvGiaoVien
            // 
            this.dgvGiaoVien.AllowUserToAddRows = false;
            this.dgvGiaoVien.AllowUserToDeleteRows = false;
            this.dgvGiaoVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaoVien.Location = new System.Drawing.Point(0, 108);
            this.dgvGiaoVien.Name = "dgvGiaoVien";
            this.dgvGiaoVien.ReadOnly = true;
            this.dgvGiaoVien.RowHeadersWidth = 51;
            this.dgvGiaoVien.RowTemplate.Height = 29;
            this.dgvGiaoVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGiaoVien.Size = new System.Drawing.Size(1133, 417);
            this.dgvGiaoVien.TabIndex = 4;
            this.dgvGiaoVien.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaoVien_CellDoubleClick);
            // 
            // frmDSGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 525);
            this.Controls.Add(this.dgvGiaoVien);
            this.Controls.Add(this.btnThemGiaoVien);
            this.Controls.Add(this.btnTimKiemGiaoVien);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblTimKiem);
            this.Name = "frmDSGV";
            this.Text = "Danh sách giáo viên";
            this.Load += new System.EventHandler(this.frmDSGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaoVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTimKiem;
        private TextBox txtTimKiem;
        private Button btnTimKiemGiaoVien;
        private Button btnThemGiaoVien;
        private DataGridView dgvGiaoVien;
    }
}