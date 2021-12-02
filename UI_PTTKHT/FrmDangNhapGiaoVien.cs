using System;
using System.Threading;
using System.Windows.Forms;

namespace UI_PTTKHT
{
    public partial class FrmDangNhapGiaoVien : Form
    {
        public FrmDangNhapGiaoVien()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //if (txtID.Text != string.Empty && txtTen.Text != string.Empty && (radNam.Checked || radNu.Checked))
            //{
                
            //}
            Thread thread = new Thread(() =>
            {
                string gender = "";
                if (radNam.Checked)
                    gender = "Nam";
                else
                    gender = "Nữ";
                FrmGiaoVien f = new FrmGiaoVien(txtID.Text, txtTen.Text, gender);
                f.ShowDialog();
            });
            thread.Start();
            Thread.Sleep(100);
            this.Close();
        }
        private void ShowFrmGiaoVien()
        {
            string gender = "";
            if (radNam.Checked)
                gender = "Nam";
            else
                gender = "Nữ";
            FrmGiaoVien f = new FrmGiaoVien(txtID.Text, txtTen.Text, gender);
            f.ShowDialog();
        }

        private void FrmDangNhapGiaoVien_Load(object sender, EventArgs e)
        {
            txtID.Focus();
            radNam.Checked = true;
        }
    }
}
