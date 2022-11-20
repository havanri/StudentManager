namespace QuanLySinhVien
{
    partial class frmHocPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocPhan));
            this.dgvDSHP = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDangKyHP = new System.Windows.Forms.Button();
            this.txtHoTen = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnXoaHocPhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHP)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSHP
            // 
            this.dgvDSHP.AllowUserToAddRows = false;
            this.dgvDSHP.AllowUserToDeleteRows = false;
            this.dgvDSHP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSHP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHP.Location = new System.Drawing.Point(1, 124);
            this.dgvDSHP.MultiSelect = false;
            this.dgvDSHP.Name = "dgvDSHP";
            this.dgvDSHP.ReadOnly = true;
            this.dgvDSHP.RowHeadersWidth = 51;
            this.dgvDSHP.RowTemplate.Height = 29;
            this.dgvDSHP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSHP.Size = new System.Drawing.Size(799, 325);
            this.dgvDSHP.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDangKyHP);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnXoaHocPhan);
            this.groupBox1.Location = new System.Drawing.Point(1, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnDangKyHP
            // 
            this.btnDangKyHP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangKyHP.BackColor = System.Drawing.Color.Lime;
            this.btnDangKyHP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDangKyHP.ForeColor = System.Drawing.Color.White;
            this.btnDangKyHP.Image = ((System.Drawing.Image)(resources.GetObject("btnDangKyHP.Image")));
            this.btnDangKyHP.Location = new System.Drawing.Point(476, 39);
            this.btnDangKyHP.Name = "btnDangKyHP";
            this.btnDangKyHP.Size = new System.Drawing.Size(169, 42);
            this.btnDangKyHP.TabIndex = 8;
            this.btnDangKyHP.Text = "Đăng ký học phần";
            this.btnDangKyHP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangKyHP.UseVisualStyleBackColor = false;
            this.btnDangKyHP.Click += new System.EventHandler(this.btnDangKyHP_Click);
            // 
            // txtHoTen
            // 
            this.txtHoTen.AutoSize = true;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtHoTen.Location = new System.Drawing.Point(188, 61);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(59, 23);
            this.txtHoTen.TabIndex = 7;
            this.txtHoTen.Text = "label4";
            // 
            // txtMaSV
            // 
            this.txtMaSV.AutoSize = true;
            this.txtMaSV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMaSV.Location = new System.Drawing.Point(225, 20);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(59, 23);
            this.txtMaSV.TabIndex = 6;
            this.txtMaSV.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã sinh viên:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnXoaHocPhan
            // 
            this.btnXoaHocPhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaHocPhan.BackColor = System.Drawing.Color.Red;
            this.btnXoaHocPhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoaHocPhan.ForeColor = System.Drawing.Color.White;
            this.btnXoaHocPhan.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHocPhan.Image")));
            this.btnXoaHocPhan.Location = new System.Drawing.Point(651, 39);
            this.btnXoaHocPhan.Name = "btnXoaHocPhan";
            this.btnXoaHocPhan.Size = new System.Drawing.Size(136, 42);
            this.btnXoaHocPhan.TabIndex = 2;
            this.btnXoaHocPhan.Text = "Xóa học phần";
            this.btnXoaHocPhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaHocPhan.UseVisualStyleBackColor = false;
            this.btnXoaHocPhan.Click += new System.EventHandler(this.btnXoaHocPhan_Click);
            // 
            // frmHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDSHP);
            this.Name = "frmHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Học Phần";
            this.Load += new System.EventHandler(this.frmHocPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvDSHP;
        private GroupBox groupBox1;
        private Label txtHoTen;
        private Label txtMaSV;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnXoaHocPhan;
        private Button btnDangKyHP;
    }
}