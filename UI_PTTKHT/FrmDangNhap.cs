using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
            if (txtID.Text!=string.Empty && txtTen.Text !=string.Empty && (radNam.Checked||radNu.Checked))
            {
                ShowFrmGiaoVien(txtID.Text, txtTen.Text);
                Hide();
            }
        }
        private void ShowFrmGiaoVien(string id, string name)
        {
            string gender = "";
            if (radNam.Checked)
                gender = "Nam";
            else
                gender = "Nữ";
            FrmGiaoVien f = new FrmGiaoVien(id,name,gender);
            f.ShowDialog();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            radNam.Checked = true;
        }
    }
}
