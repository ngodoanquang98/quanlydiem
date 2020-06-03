using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using QLDiem1;

namespace GUI
{
    public partial class frmXemDiem : Form
    {
        public frmXemDiem()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string t = comboBox2.Text;
            string ten = comboBox1.Text;
            dataGridView1.DataSource = busXemDiem.getDM(ten);
            label5.DataBindings.Clear();
            label5.DataBindings.Add("Text", busXemDiem.getD(ten, t), "diemTBC", true);
            label7.DataBindings.Clear();
            label7.DataBindings.Add("Text", busXemDiem.getD(ten, t), "xeploai", true);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmXemDiem_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = busXemDiem.VVV();
            comboBox2.DisplayMember = "MaHK";
            comboBox1.DataSource = busDangKi.KhoaDK();
            comboBox1.DisplayMember = "MaSV";           
           // string c = comboBox1.Text;
            dataGridView1.DataSource = busXemDiem.getDY();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form nk = new frmLogin();
            nk.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form nk = new frmDangKI();
            nk.Show();
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    //string ten = comboBox1.Text;
        //    //dataGridView1.DataSource = busXemDiem.getDM(ten);
        //}
    }
}
