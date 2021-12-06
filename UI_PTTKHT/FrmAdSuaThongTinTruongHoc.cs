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
    public partial class FrmAdSuaThongTinTruongHoc : Form
    {
        public FrmAdSuaThongTinTruongHoc()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(() =>
            {
                FrmAdThongTinTruong frm = new FrmAdThongTinTruong();
                frm.ShowDialog();
            }));
            thread.Start();
            Thread.Sleep(100);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
