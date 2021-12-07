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

        private void lblThongBaoChung_Click(object sender, EventArgs e)
        {
            FrmAdThongBaoChung frm = new FrmAdThongBaoChung();
            ShowForm(frm);
        }


        private void lblThongTinTruong_Click(object sender, EventArgs e)
        {
            FrmAdThongTinTruong frm = new FrmAdThongTinTruong();
            ShowForm(frm);
        }

        private void lblQuanLyTruongHoc_Click(object sender, EventArgs e)
        {
            Thread.Sleep(10);
            if (lblLopHoc.Visible && lblPhongHoc.Visible && lblGiaoVien.Visible && lblHocSinh.Visible && lblToBoMon.Visible
                && lblThongBao.Visible)
            {
                lblLopHoc.Visible = false;
                lblPhongHoc.Visible = false;
                lblGiaoVien.Visible = false;
                lblHocSinh.Visible = false;
                lblToBoMon.Visible = false;
                lblThongBao.Visible = false;
            }
            else
            {
                lblLopHoc.Visible = true;
                lblPhongHoc.Visible = true;
                lblGiaoVien.Visible = true;
                lblHocSinh.Visible = true;
                lblToBoMon.Visible = true;
                lblThongBao.Visible = true;
            }

        }

        private void lblLopHoc_Click(object sender, EventArgs e)
        {
            FrmAdLopHoc frm = new FrmAdLopHoc();
            ShowForm(frm);
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
            FrmAdHocSinh frm = new FrmAdHocSinh();
            ShowForm(frm);
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

        private void lblQLDT_Click(object sender, EventArgs e)
        {
            Thread.Sleep(10);
            if (lblNamHoc.Visible && lblMonHoc.Visible && lblXepHang.Visible &&
                lblHanhKiem.Visible && lblTietHoc.Visible
                && lblLichNgay.Visible && lblLichTuan.Visible)
            {
                lblNamHoc.Visible = false;
                lblMonHoc.Visible = false;
                lblXepHang.Visible = false;
                lblHanhKiem.Visible = false;
                lblTietHoc.Visible = false;
                lblLichNgay.Visible = false;
                lblLichTuan.Visible = false;
            }
            else
            {
                lblNamHoc.Visible = true;
                lblMonHoc.Visible = true;
                lblXepHang.Visible = true;
                lblHanhKiem.Visible = true;
                lblTietHoc.Visible = true;
                lblLichNgay.Visible = true;
                lblLichTuan.Visible = true;
            }
        }

        private void lblNamHoc_Click(object sender, EventArgs e)
        {
            FrmAdNamHoc frm = new FrmAdNamHoc();
            ShowForm(frm);
        }

        private void lblMonHoc_Click(object sender, EventArgs e)
        {
            FrmAdMonHoc frm = new FrmAdMonHoc();
            ShowForm(frm);
        }

        private void lblXepHang_Click(object sender, EventArgs e)
        {

        }

        private void lblHanhKiem_Click(object sender, EventArgs e)
        {
            FrmAdHanhKiem frm = new FrmAdHanhKiem();
            ShowForm(frm);
        }

        private void lblTietHoc_Click(object sender, EventArgs e)
        {
            FrmAdTietHoc frm = new FrmAdTietHoc();
            ShowForm(frm);
        }

        private void lblLichNgay_Click(object sender, EventArgs e)
        {
            FrmAdLichHocTheoNgay frm = new FrmAdLichHocTheoNgay();
            ShowForm(frm);
        }

        private void lblLichTuan_Click(object sender, EventArgs e)
        {
            FrmAdLichHocTheoTuan frm = new FrmAdLichHocTheoTuan();
            ShowForm(frm);
        }

        private void lblQLHT_Click(object sender, EventArgs e)
        {
            if (lblTongKetDiem.Visible)
            {
                lblTongKetDiem.Visible = false;
            }
            else
            {
                lblTongKetDiem.Visible = true;
            }
        }

        private void lblTongKetDiem_Click(object sender, EventArgs e)
        {
            FrmAdTongKetDiem frm = new FrmAdTongKetDiem();
            ShowForm(frm);
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

        private void label9_Click(object sender, EventArgs e)
        {
            FrmAdDanhSachPhongHoc frm = new FrmAdDanhSachPhongHoc();
            ShowForm(frm);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FrmAdDanhSachPhongHoc frm = new FrmAdDanhSachPhongHoc();
            ShowForm(frm);
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            FrmAdDanhSachPhongHoc frm = new FrmAdDanhSachPhongHoc();
            ShowForm(frm);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            FrmAdGiaoVien frm = new FrmAdGiaoVien();
            ShowForm(frm);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FrmAdGiaoVien frm = new FrmAdGiaoVien();
            ShowForm(frm);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FrmAdGiaoVien frm = new FrmAdGiaoVien();
            ShowForm(frm);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FrmAdHocSinh frm = new FrmAdHocSinh();
            ShowForm(frm);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FrmAdHocSinh frm = new FrmAdHocSinh();
            ShowForm(frm);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            FrmAdHocSinh frm = new FrmAdHocSinh();
            ShowForm(frm);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            FrmAdLopHoc frm = new FrmAdLopHoc();
            ShowForm(frm);
        }

        private void label11_Click(object sender, EventArgs e)
        {
            FrmAdLopHoc frm = new FrmAdLopHoc();
            ShowForm(frm);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            FrmAdLopHoc frm = new FrmAdLopHoc();
            ShowForm(frm);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            FrmAdGiaoVien frm = new FrmAdGiaoVien();
            ShowForm(frm);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            FrmAdGiaoVien frm = new FrmAdGiaoVien();
            ShowForm(frm);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            FrmAdGiaoVien frm = new FrmAdGiaoVien();
            ShowForm(frm);
        }
    }
}
