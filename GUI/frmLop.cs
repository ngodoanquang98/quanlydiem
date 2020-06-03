using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busLop.getLop();
            comboBox2.DataSource = busLop.Khoa();
            comboBox2.DisplayMember = "MaKhoa";
            comboBox2.ValueMember = "TenKhoa";
            comboBox1.DataSource = busGiangVien.Khoa();
            comboBox1.DisplayMember = "TenKhoa";
            comboBox1.ValueMember = "MaKhoa";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
                comboBox2.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void Luu(object sender, EventArgs e)
        {
            try
            {
                string mal = textBox1.Text;
                string ten = textBox2.Text;
                int sdt = int.Parse(textBox3.Text);
                string khoa = comboBox2.Text;
                string mak = textBox4.Text;
                DTO.tblLop hp = new DTO.tblLop(mal, ten, sdt, khoa, mak);
                busLop.InsertLop(hp);
                MessageBox.Show("them " + ten + "  thanh cong");
                dataGridView1.DataSource = busLop.getLop();
                
            }
            catch 
            {
                string mal = textBox1.Text;
                string ten = textBox2.Text;
                int sdt = int.Parse(textBox3.Text);
                string khoa = comboBox2.Text;
                string mak = textBox4.Text;
                DTO.tblLop hp = new DTO.tblLop(mal, ten, sdt, khoa, mak);
                busLop.UpdateLop(hp);
                MessageBox.Show("sua  " + ten + "  thanh cong");
                dataGridView1.DataSource = busLop.getLop();
            }                                      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string magv = textBox1.Text;
            busLop.DeleteLop(magv);
            MessageBox.Show("Xoa thanh cong");
            dataGridView1.DataSource = busLop.getLop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form nk = new Main();
            nk.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string ten =textBox5.Text;
            dataGridView1.DataSource = busLop.SreachLop(ten);
        }
    }
}
