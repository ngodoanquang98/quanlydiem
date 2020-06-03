using QLDiem1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form nk = new Form1();
            nk.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form nk = new nhaky();
            nk.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form nk = new frmXemDiem();
            nk.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form nk = new frmSinhVien();
            nk.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form nk = new frmQLHocPhan();
            nk.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form nk = new frmQLLHP();
            nk.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form nk = new frmLop();
            nk.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form nk = new frmGiangVien();
            nk.Show();
        }
    }
}
