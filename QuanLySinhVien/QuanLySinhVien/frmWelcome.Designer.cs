namespace QuanLySinhVien
{
    partial class frmWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcome));
            this.pbWelcome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWelcome
            // 
            this.pbWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbWelcome.Image = ((System.Drawing.Image)(resources.GetObject("pbWelcome.Image")));
            this.pbWelcome.Location = new System.Drawing.Point(0, 0);
            this.pbWelcome.Name = "pbWelcome";
            this.pbWelcome.Size = new System.Drawing.Size(1117, 570);
            this.pbWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWelcome.TabIndex = 0;
            this.pbWelcome.TabStop = false;
            // 
            // frmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 570);
            this.Controls.Add(this.pbWelcome);
            this.Name = "frmWelcome";
            this.Text = "Trang chủ";
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pbWelcome;
    }
}