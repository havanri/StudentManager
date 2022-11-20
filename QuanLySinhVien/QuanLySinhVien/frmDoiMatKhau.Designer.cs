namespace QuanLySinhVien
{
    partial class frmDoiMatKhau
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblXacNhanMatKhau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xác nhận mật khẩu:";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(234, 180);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(94, 29);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(180, 42);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(207, 27);
            this.txtMatKhau.TabIndex = 4;
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(180, 119);
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(207, 27);
            this.txtXacNhanMatKhau.TabIndex = 5;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMatKhau.ForeColor = System.Drawing.Color.Red;
            this.lblMatKhau.Location = new System.Drawing.Point(180, 72);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(43, 17);
            this.lblMatKhau.TabIndex = 6;
            this.lblMatKhau.Text = "label1";
            // 
            // lblXacNhanMatKhau
            // 
            this.lblXacNhanMatKhau.AutoSize = true;
            this.lblXacNhanMatKhau.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblXacNhanMatKhau.ForeColor = System.Drawing.Color.Red;
            this.lblXacNhanMatKhau.Location = new System.Drawing.Point(180, 147);
            this.lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            this.lblXacNhanMatKhau.Size = new System.Drawing.Size(43, 17);
            this.lblXacNhanMatKhau.TabIndex = 7;
            this.lblXacNhanMatKhau.Text = "label1";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(548, 221);
            this.Controls.Add(this.lblXacNhanMatKhau);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.txtXacNhanMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label3;
        private Button btnXacNhan;
        private TextBox txtMatKhau;
        private TextBox txtXacNhanMatKhau;
        private Label lblMatKhau;
        private Label lblXacNhanMatKhau;
    }
}