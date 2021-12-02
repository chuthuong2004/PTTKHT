using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (txtID.Text != string.Empty && txtTen.Text != string.Empty && (radNam.Checked || radNu.Checked))
            {
                ShowFrmGiaoVien(txtID.Text, txtTen.Text);
                this.Hide();
            }
        }
        private void ShowFrmGiaoVien(string id, string name)
        {
            string gender = "";
            if (radNam.Checked)
                gender = "Nam";
            else
                gender = "Nữ";
            FrmGiaoVien f = new FrmGiaoVien(id, name, gender);
            f.ShowDialog();
        }

        private void FrmDangNhapGiaoVien_Load(object sender, EventArgs e)
        {
            radNam.Checked = true;
        }
    }
}
