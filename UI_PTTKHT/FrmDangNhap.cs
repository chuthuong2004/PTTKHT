using System;
using System.Threading;
using System.Windows.Forms;

namespace UI_PTTKHT
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhapGV_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowFormDangNhapGiaoVien));
            thread.Start();
            Thread.Sleep(100);
            this.Close();
        }
        private void ShowFormDangNhapGiaoVien()
        {
            FrmDangNhapGiaoVien f = new FrmDangNhapGiaoVien();
            f.ShowDialog();
        }
        private void ShowFormDangNhapHocSinh()
        {
            FrmDangNhapHocSinh f = new FrmDangNhapHocSinh();
            f.ShowDialog();
        }
        private void btnDangNhapHs_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowFormDangNhapHocSinh));
            thread.Start();
            Thread.Sleep(100);
            this.Close();
        }
    }
}
