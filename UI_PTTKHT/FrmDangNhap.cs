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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "admin" && txtPassword.Text == "admin")
            {
                Thread thread = new Thread(new ThreadStart(() =>
                {
                    FrmAdTrangChu frm = new FrmAdTrangChu();
                    frm.ShowDialog();
                }));
                thread.Start();
                Thread.Sleep(10);
                this.Close();
            }
            else if (txtTenDangNhap.Text == "teacher" && txtPassword.Text == "teacher")
            {
                Thread thread = new Thread(new ThreadStart(() =>
                {
                    FrmGVTrangChu frm = new FrmGVTrangChu();
                    frm.ShowDialog();
                }));
                thread.Start();
                Thread.Sleep(10);
                this.Close();
            }
            else if (txtTenDangNhap.Text == "student" && txtPassword.Text == "student")
            {
                Thread thread = new Thread(new ThreadStart(() =>
                {
                    FrmHSTrangChu frm = new FrmHSTrangChu();
                    frm.ShowDialog();
                }));
                thread.Start();
                Thread.Sleep(10);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng ! Vui lòng liên hệ anh Chu Thương để biết thêm chi tiết.");
            }
        }
    }
}
