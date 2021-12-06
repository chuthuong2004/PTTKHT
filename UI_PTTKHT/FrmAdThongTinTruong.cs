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
    public partial class FrmAdThongTinTruong : Form
    {
        public FrmAdThongTinTruong()
        {
            InitializeComponent();
        }
        private void ShowForm(Form frm)
        {
            Thread thread = new Thread(new ThreadStart(()=>
            {
                frm.ShowDialog();
            }));
            thread.Start();
            Thread.Sleep(100);
            this.Close();
        }
        private void lblTrangChu_Click(object sender, EventArgs e)
        {
            FrmAdTrangChu frm = new FrmAdTrangChu();
            ShowForm(frm);
        }

        private void lblThongBaoChung_Click(object sender, EventArgs e)
        {
            FrmAdThongBaoChung frm = new FrmAdThongBaoChung();
            ShowForm(frm);
        }

        private void lblThongTinTruong_Click(object sender, EventArgs e)
        {

        }

        private void lblQuanLyTruongHoc_Click(object sender, EventArgs e)
        {
            //FrmAdThongBaoChung frm = new FrmAdThongBaoChung();
            //ShowForm(frm);
        }

        private void lblLopHoc_Click(object sender, EventArgs e)
        {
            //FrmAdThongBaoChung frm = new FrmAdThongBaoChung();
            //ShowForm(frm);
        }

        private void lblPhongHoc_Click(object sender, EventArgs e)
        {
            FrmAdDanhSachPhongHoc frm = new FrmAdDanhSachPhongHoc();
            ShowForm(frm);
        }
        private void lblGiaoVien_Click(object sender, EventArgs e)
        {
            FrmAdGiaoVien frm = new FrmAdGiaoVien();
            ShowForm(frm);
        }

        private void lblHocSinh_Click(object sender, EventArgs e)
        {
            //FrmAdGiaoVien frm = new FrmAdGiaoVien();
            //ShowForm(frm);
        }

        private void lblToBoMon_Click(object sender, EventArgs e)
        {
            FrmAdDanhSachToBoMon frm = new FrmAdDanhSachToBoMon();
            ShowForm(frm);
        }

        private void lblThongBao_Click(object sender, EventArgs e)
        {
            FrmAdThongBao frm = new FrmAdThongBao();
            ShowForm(frm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdSuaThongTinTruongHoc frm = new FrmAdSuaThongTinTruongHoc();
            ShowForm(frm);
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

        private void panel1_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = true;
        }

    }
}
