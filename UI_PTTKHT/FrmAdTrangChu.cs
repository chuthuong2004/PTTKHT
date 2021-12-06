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
    public partial class FrmAdTrangChu : Form
    {
        public FrmAdTrangChu()
        {
            InitializeComponent();
        }

        private void lblPhongHoc_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowFormDanhSachPhongHoc));
            thread.Start();
            Thread.Sleep(100);
            this.Close();
        }
        private void ShowFormDanhSachPhongHoc()
        {
            FrmAdDanhSachPhongHoc frm = new FrmAdDanhSachPhongHoc();
            frm.ShowDialog();
        }
        private void ShowFormToBoMon()
        {
            FrmAdDanhSachToBoMon frm = new FrmAdDanhSachToBoMon();
            frm.ShowDialog();
        }

        private void ShowFormThongBao()
        {
            FrmAdThongBao frm = new FrmAdThongBao();
            frm.ShowDialog();
        }

        private void ShowFormThongBaoChung()
        {
            FrmAdThongBaoChung frmAdThongBaoChung = new FrmAdThongBaoChung();
            frmAdThongBaoChung.ShowDialog();
        }

        private void lblToBoMon_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowFormToBoMon));
            thread.Start();
            Thread.Sleep(100);
            this.Close();
        }

        private void lblThongBao_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowFormThongBao));
            thread.Start();
            Thread.Sleep(100);
            this.Close();
        }


        private void lblTrangChu_Click(object sender, EventArgs e)
        {

        }

        private void lblThongBaoChung_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowFormThongBaoChung));
            thread.Start();
            Thread.Sleep(100);
            this.Close();
        }


        private void lblThongTinTruong_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowFormThongTinTruong));
            thread.Start();
            Thread.Sleep(100);
            this.Close();
        }

        private void ShowFormThongTinTruong()
        {
            FrmAdThongTinTruong frm = new FrmAdThongTinTruong();
            frm.ShowDialog();
        }

        private void lblQuanLyTruongHoc_Click(object sender, EventArgs e)
        {

        }

        private void lblLopHoc_Click(object sender, EventArgs e)
        {

        }

        private void lblGiaoVien_Click(object sender, EventArgs e)
        {

        }

        private void lblHocSinh_Click(object sender, EventArgs e)
        {

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
            else if(lsbAdmin.SelectedIndex == 1)
            {
                MessageBox.Show("Phần đổi mật khẩu chưa được cập nhật !");
                lsbAdmin.Visible = false;
            }
            else if (lsbAdmin.SelectedIndex == 2)
            {
                Thread thread = new Thread(new ThreadStart(() =>
                {
                    FrmDangNhap frm = new FrmDangNhap();
                    frm.ShowDialog();
                }));
                thread.Start();
                Thread.Sleep(10);
                this.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = true;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

    }
}
