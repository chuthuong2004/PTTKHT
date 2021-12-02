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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhapGV_Click(object sender, EventArgs e)
        {
            FrmDangNhapGiaoVien f = new FrmDangNhapGiaoVien();
            f.Show();
            this.Hide();
        }

        private void btnDangNhapHs_Click(object sender, EventArgs e)
        {
            FrmDangNhapHocSinh f = new FrmDangNhapHocSinh();
            f.Show();
            this.Hide();
        }
    }
}
