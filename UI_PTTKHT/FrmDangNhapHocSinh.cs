using System;
using System.Threading;
using System.Windows.Forms;

namespace UI_PTTKHT
{
    public partial class FrmDangNhapHocSinh : Form
    {
        public FrmDangNhapHocSinh()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtID.Text !=string.Empty && txtTen.Text !=string.Empty && (radNam.Checked || radNu.Checked))
            {
                Thread thread = new Thread(new ThreadStart(ShowForm));
                thread.Start();
                Thread.Sleep(100);
                this.Close();
            }
        }
        private void ShowForm()
        {
            FrmHocSinh frmHocSinh = new FrmHocSinh();
            frmHocSinh.ShowDialog();
        }

        private void FrmDangNhapHocSinh_Load(object sender, EventArgs e)
        {
            txtID.Focus();
            radNam.Checked = true;
        }
    }
}
