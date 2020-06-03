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

namespace GUI
{
    public partial class frmDangKI : Form
    {
        public frmDangKI()
        {
            InitializeComponent();
        }

        private void frmDangKI_Load(object sender, EventArgs e)
        {
            comboBox2.DataSource = busDangKi.KhoaDK();
            comboBox2.DisplayMember = "MaSV";
            comboBox1.DataSource = busDangKi.XXX();
            comboBox1.DisplayMember = "MaLopHP";
            string ten = comboBox2.Text;
            dataGridView1.DataSource = busDangKi.getDK(ten);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form nk = new frmXemDiem();
            nk.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ten = comboBox2.Text;
            dataGridView1.DataSource = busDangKi.getDK(ten);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            comboBox1.Text = row.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mal = comboBox1.Text;
                string ten = comboBox2.Text;
                
                DTO.tblDangki hp = new DTO.tblDangki(mal, ten);
                busDangKi.InsertDK(hp);
                MessageBox.Show("đăng kí thành công");
                dataGridView1.DataSource = busDangKi.getDK(ten);

            }
            catch
            {
                MessageBox.Show("môn học đã được đăng kí");

            }
        }
    }
}
