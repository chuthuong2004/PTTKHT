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
    public partial class FrmGiaoVien : Form
    {
        private string Id;
        private string fullName;
        private string gender;
        public FrmGiaoVien(string id, string name, string gender)
        {
            InitializeComponent();
            this.Id = id;
            this.fullName = name;
            this.gender = gender;
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

        private void FrmGiaoVien_Load(object sender, EventArgs e)
        {
            lblID.Text = Id;
            lblTen.Text = fullName;
            lblGender.Text = gender;
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
