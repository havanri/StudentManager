namespace QuanLySinhVien
{
    partial class frmDangKyMonHoc
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
            this.dgvDSLHOpen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLHOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSLHOpen
            // 
            this.dgvDSLHOpen.AllowUserToAddRows = false;
            this.dgvDSLHOpen.AllowUserToDeleteRows = false;
            this.dgvDSLHOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSLHOpen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSLHOpen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLHOpen.Location = new System.Drawing.Point(-1, 2);
            this.dgvDSLHOpen.MultiSelect = false;
            this.dgvDSLHOpen.Name = "dgvDSLHOpen";
            this.dgvDSLHOpen.ReadOnly = true;
            this.dgvDSLHOpen.RowHeadersWidth = 51;
            this.dgvDSLHOpen.RowTemplate.Height = 29;
            this.dgvDSLHOpen.Size = new System.Drawing.Size(712, 416);
            this.dgvDSLHOpen.TabIndex = 0;
            this.dgvDSLHOpen.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLHOpen_CellDoubleClick);
            // 
            // frmDangKyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 418);
            this.Controls.Add(this.dgvDSLHOpen);
            this.Name = "frmDangKyMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký môn học";
            this.Load += new System.EventHandler(this.frmDangKyMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLHOpen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvDSLHOpen;
    }
}