using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace UI_PTTKHT
{
    public partial class FrmAdSuaThongTinGiaoVien : Form
    {
        public FrmAdSuaThongTinGiaoVien()
        {
            InitializeComponent();
        }
        private void ShowForm(Form frm)
        {
            Thread thread = new Thread(new ThreadStart(() =>
            {
                frm.ShowDialog();
            }));
            thread.Start();
            Thread.Sleep(10);
            this.Close();
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FrmAdGiaoVien frmAdGiaoVien = new FrmAdGiaoVien();
            ShowForm(frmAdGiaoVien);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng cập nhật đang bảo trì !");
            FrmAdGiaoVien frmAdGiaoVien = new FrmAdGiaoVien();
            ShowForm(frmAdGiaoVien);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = true;

        }

        private void lsbAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbAdmin.SelectedIndex == 0)
            {
                MessageBox.Show("Phần sửa thông tin admin chưa được cập nhật !");
                lsbAdmin.Visible = false;
            }
            else if (lsbAdmin.SelectedIndex == 1)
            {
                MessageBox.Show("Phần đổi mật khẩu chưa được cập nhật !");
                lsbAdmin.Visible = false;
            }
            else if (lsbAdmin.SelectedIndex == 2)
            {
                FrmDangNhap frm = new FrmDangNhap();
                ShowForm(frm);
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void FrmAdSuaThongTinGiaoVien_Load(object sender, EventArgs e)
        {

        }
    }
}
