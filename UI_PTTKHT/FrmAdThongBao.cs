﻿using System;
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
    public partial class FrmAdThongBao : Form
    {
        public FrmAdThongBao()
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

        }
        private void lblUser_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = true;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void flowLayoutPanel2_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmAdThongBao_Load(object sender, EventArgs e)
        {
            lblLopHoc.Visible = false;
            lblPhongHoc.Visible = false;
            lblGiaoVien.Visible = false;
            lblHocSinh.Visible = false;
            lblToBoMon.Visible = false;
            lblThongBao.Visible = false;
        }

        private void lsbAdmin_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng tìm kiếm thông báo đang bảo trì !");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng thêm thông báo đang bảo trì !");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng sửa thông báo đang bảo trì !");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng sửa thông báo đang bảo trì !");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng sửa thông báo đang bảo trì !");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng sửa thông báo đang bảo trì !");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng sửa thông báo đang bảo trì !");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xóa thông báo đang bảo trì !");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xóa thông báo đang bảo trì !");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xóa thông báo đang bảo trì !");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xóa thông báo đang bảo trì !");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xóa thông báo đang bảo trì !");
        }
    }
}
