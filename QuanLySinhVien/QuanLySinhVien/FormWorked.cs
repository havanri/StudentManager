using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FormWorked : Form
    {
        public FormWorked()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += Bw_DoWork;
            bw.ProgressChanged += Bw_ProgressChanged;
            bw.RunWorkerCompleted += Bw_RunWorked;
            bw.RunWorkerAsync();
        }

        private void Bw_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            label1.Text=e.ProgressPercentage.ToString()+"%";
        }

        private void Bw_RunWorked(object? sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void Bw_DoWork(object? sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                var percent = (i + 1) * 10;
                Thread.Sleep(1000);

            }
        }
    }
}
