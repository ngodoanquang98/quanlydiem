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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busChamDiem.getDiem();           
            comboBox1.DataSource = busGiangVien.Khoa();
            comboBox1.DisplayMember = "TenKhoa";
            comboBox1.ValueMember = "MaKhoa";
            comboBox2.DataSource = busChamDiem.Khoa1();
            comboBox2.DisplayMember = "malophp";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox5.Text = row.Cells[3].Value.ToString();
            textBox4.Text = row.Cells[4].Value.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
            {
                string mal = textBox1.Text;
                string ten = textBox2.Text;
                float sdt = float.Parse(textBox3.Text);
                float khoa = float.Parse(textBox5.Text);
                float mak = float.Parse(textBox4.Text);
                DTO.tblKetQuaLHP hp = new DTO.tblKetQuaLHP(mal, ten, sdt, khoa, mak);
                busChamDiem.UpdateLop(hp);
                MessageBox.Show("đã sửa điểm của " + ten);
                dataGridView1.DataSource = busChamDiem.getDiem();              
            }
            catch
            {              
                    string mal = textBox1.Text;
                    string ten = textBox2.Text;
                    float sdt = float.Parse(textBox3.Text);
                    float khoa = float.Parse(textBox5.Text);
                    float mak = float.Parse(textBox4.Text);
                //try
                //{
                    DTO.tblKetQuaLHP hp = new DTO.tblKetQuaLHP(mal, ten, sdt, khoa, mak);
                    busChamDiem.InsertDiem(hp);
                    MessageBox.Show("đã thêm điểm của " + ten);
                    dataGridView1.DataSource = busChamDiem.getDiem();
                //}
                //catch
                //{
                //    MessageBox.Show(ten+"đã hoàn thành học phàn này");
                //}

            }                                      
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("khong the xoa diem");
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ten = comboBox2.Text;
            dataGridView1.DataSource = busChamDiem.SreachLop(ten);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form nk = new Main();
            nk.Show();
        }
    }
}
