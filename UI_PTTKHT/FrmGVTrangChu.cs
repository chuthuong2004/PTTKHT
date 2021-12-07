using System;
using System.Threading;
using System.Windows.Forms;

namespace UI_PTTKHT
{
    public partial class FrmGVTrangChu : Form
    {
        public FrmGVTrangChu()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 6;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 7;

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 6;

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 6;
        }
        private void lblDangXuat_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(DangXuat));
            thread.Start();
            this.Close();
        }
        private void DangXuat()
        {
            FrmDangNhap f = new FrmDangNhap();
            f.ShowDialog();
        }

        private void FrmGVTrangChu_Load(object sender, EventArgs e)
        {

        }
    }
}
