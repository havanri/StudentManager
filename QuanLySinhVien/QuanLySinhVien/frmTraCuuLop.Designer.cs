namespace QuanLySinhVien
{
    partial class frmTraCuuLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraCuuLop));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTraCuu = new System.Windows.Forms.TextBox();
            this.btnTraCuu = new System.Windows.Forms.Button();
            this.dgvDSLH = new System.Windows.Forms.DataGridView();
            this.btnChamDiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // txtTraCuu
            // 
            this.txtTraCuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTraCuu.Location = new System.Drawing.Point(425, 32);
            this.txtTraCuu.Name = "txtTraCuu";
            this.txtTraCuu.Size = new System.Drawing.Size(173, 27);
            this.txtTraCuu.TabIndex = 1;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTraCuu.Location = new System.Drawing.Point(604, 27);
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(114, 37);
            this.btnTraCuu.TabIndex = 2;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btnTraCuu_Click);
            // 
            // dgvDSLH
            // 
            this.dgvDSLH.AllowUserToAddRows = false;
            this.dgvDSLH.AllowUserToDeleteRows = false;
            this.dgvDSLH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSLH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLH.Location = new System.Drawing.Point(0, 84);
            this.dgvDSLH.Name = "dgvDSLH";
            this.dgvDSLH.ReadOnly = true;
            this.dgvDSLH.RowHeadersWidth = 51;
            this.dgvDSLH.RowTemplate.Height = 29;
            this.dgvDSLH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSLH.Size = new System.Drawing.Size(898, 366);
            this.dgvDSLH.TabIndex = 3;
            // 
            // btnChamDiem
            // 
            this.btnChamDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChamDiem.BackColor = System.Drawing.Color.Lime;
            this.btnChamDiem.ForeColor = System.Drawing.Color.White;
            this.btnChamDiem.Image = ((System.Drawing.Image)(resources.GetObject("btnChamDiem.Image")));
            this.btnChamDiem.Location = new System.Drawing.Point(744, 22);
            this.btnChamDiem.Name = "btnChamDiem";
            this.btnChamDiem.Size = new System.Drawing.Size(143, 47);
            this.btnChamDiem.TabIndex = 4;
            this.btnChamDiem.Text = "Chấm điểm";
            this.btnChamDiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChamDiem.UseVisualStyleBackColor = false;
            this.btnChamDiem.Click += new System.EventHandler(this.ChamDiem_Click);
            // 
            // frmTraCuuLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.btnChamDiem);
            this.Controls.Add(this.dgvDSLH);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.txtTraCuu);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmTraCuuLop";
            this.Text = "Tra Cứu Lớp Học";
            this.Load += new System.EventHandler(this.frmTraCuuLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtTraCuu;
        private Button btnTraCuu;
        private DataGridView dgvDSLH;
        private Button btnChamDiem;
    }
}