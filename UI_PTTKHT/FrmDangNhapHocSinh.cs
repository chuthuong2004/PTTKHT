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
    public partial class FrmDangNhapHocSinh : Form
    {
        public FrmDangNhapHocSinh()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtID.Text !=string.Empty && txtTen.Text !=string.Empty && (radNam.Checked || radNu.Checked))
            {
                FrmHocSinh frmHocSinh = new FrmHocSinh();
                frmHocSinh.Show();
                this.Hide();
            }
        }

        private void FrmDangNhapHocSinh_Load(object sender, EventArgs e)
        {
            radNam.Checked = true;
        }
    }
}
