namespace QuanLySinhVien
{
    partial class frmHocPhanDaKetThuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocPhanDaKetThuc));
            this.dgvHocPhanKetThuc = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNhapDiem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhanKetThuc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHocPhanKetThuc
            // 
            this.dgvHocPhanKetThuc.AllowUserToAddRows = false;
            this.dgvHocPhanKetThuc.AllowUserToDeleteRows = false;
            this.dgvHocPhanKetThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHocPhanKetThuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocPhanKetThuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocPhanKetThuc.Location = new System.Drawing.Point(0, 155);
            this.dgvHocPhanKetThuc.MultiSelect = false;
            this.dgvHocPhanKetThuc.Name = "dgvHocPhanKetThuc";
            this.dgvHocPhanKetThuc.ReadOnly = true;
            this.dgvHocPhanKetThuc.RowHeadersWidth = 51;
            this.dgvHocPhanKetThuc.RowTemplate.Height = 29;
            this.dgvHocPhanKetThuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHocPhanKetThuc.Size = new System.Drawing.Size(1281, 454);
            this.dgvHocPhanKetThuc.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnNhapDiem);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1254, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnNhapDiem
            // 
            this.btnNhapDiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNhapDiem.BackColor = System.Drawing.Color.Lime;
            this.btnNhapDiem.ForeColor = System.Drawing.Color.White;
            this.btnNhapDiem.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapDiem.Image")));
            this.btnNhapDiem.Location = new System.Drawing.Point(1089, 40);
            this.btnNhapDiem.Name = "btnNhapDiem";
            this.btnNhapDiem.Size = new System.Drawing.Size(122, 48);
            this.btnNhapDiem.TabIndex = 2;
            this.btnNhapDiem.Text = "Nhập điểm";
            this.btnNhapDiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapDiem.UseVisualStyleBackColor = false;
            this.btnNhapDiem.Click += new System.EventHandler(this.btnNhapDiem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(920, 50);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(57, 29);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(740, 50);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(173, 27);
            this.txtTimKiem.TabIndex = 0;
            // 
            // frmHocPhanDaKetThuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 609);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvHocPhanKetThuc);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmHocPhanDaKetThuc";
            this.Text = "Danh sách học phần hoàn thành";
            this.Load += new System.EventHandler(this.frmHocPhanDaKetThuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocPhanKetThuc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvHocPhanKetThuc;
        private GroupBox groupBox1;
        private Button btnNhapDiem;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
    }
}