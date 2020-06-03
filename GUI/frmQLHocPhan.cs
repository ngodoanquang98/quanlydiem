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
using DTO;
using GUI;

namespace QLDiem1
{
    public partial class frmQLHocPhan : Form
    {
        public frmQLHocPhan()
        {
            InitializeComponent();
        }

        private void dgvHocPhan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmQLHocPhan_Load(object sender, EventArgs e)
        {
            dgvHocPhan.DataSource = busHocPhan.getHocPhan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string mahp = textBox1.Text;
                string tenhp = textBox2.Text;
                int sotc = int.Parse(textBox3.Text);
                tblHocPhan hp = new tblHocPhan(mahp, tenhp, sotc);
                busHocPhan.InsertHocPhan(hp);
                MessageBox.Show("ban da them " + tenhp + " thanh cong");
                dgvHocPhan.DataSource = busHocPhan.getHocPhan();
            }
            catch
            {
                MessageBox.Show("ban kiem tra lai ma hoc phan");
            }
        }

        private void dgvHocPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvHocPhan.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string mahp = textBox1.Text;
                string tenhp = textBox2.Text;
                int sotc = int.Parse(textBox3.Text);
                tblHocPhan hp = new tblHocPhan(mahp, tenhp, sotc);
                busHocPhan.UpdateHocPhan(hp);
                MessageBox.Show("ban da sua" + tenhp + " thanh cong");
                dgvHocPhan.DataSource = busHocPhan.getHocPhan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string mahp = textBox1.Text;
                string tenhp = textBox2.Text;
                int sotc = int.Parse(textBox3.Text);
                tblHocPhan hp = new tblHocPhan(mahp, tenhp, sotc);
                busHocPhan.DeleteHocPhan(mahp);
                MessageBox.Show("ban da xoa " + tenhp + " thanh cong");
                dgvHocPhan.DataSource = busHocPhan.getHocPhan();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form nk = new Main();
            nk.Show();

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

            string mahp = txtTimKiem.Text;       
            dgvHocPhan.DataSource = busHocPhan.SreachHocPhan(mahp);

        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }
    }
    
}
