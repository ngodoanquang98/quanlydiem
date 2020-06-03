using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using System.Data.SqlClient;
using GUI;
using BUS;

namespace QLDiem1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //this.Hide();
            // Form1 frmmain = new Form1();
            //frmmain.ShowDialog();
            //this.Close();
            //SqlConnection Conn = new SqlConnection(@"Data Source=QUANG\SQLEXPRESS;Initial Catalog=QLDiem_SV;Integrated Security=True");
            //string sql = "select * from GiangVien where maGV = ' " + txtAcc.Text + " ' and MaKhoa = ' " + txtPass.Text+ "'";
            //Conn.Open();
            //SqlCommand cmd = new SqlCommand(sql, Conn);
            //SqlDataReader re = cmd.ExecuteReader();
            //if(re.Read()==true)
            //{
            //    this.Hide();
            //    Form nk = new nhaky();
            //    nk.ShowDialog();
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("dang nhap khong thanh cong!");
            //    txtAcc.Text = "";
            //    txtPass.Text = "";
            //    txtAcc.Focus();
            //}

        }

        private void txtAcc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mal = txtAcc.Text;
            string pas = txtPass.Text;
            SqlConnection Conn = new SqlConnection(@"Data Source=QUANG\SQLEXPRESS;Initial Catalog=QLDiem_SV;Integrated Security=True");
            string sql = "select * from GiangVien where maGV = '" + mal + "' and MaKhoa = '" + pas + "'";
            Conn.Open();
            SqlCommand cmd = new SqlCommand(sql, Conn);
            SqlDataReader re = cmd.ExecuteReader();
            if (re.Read() == true)
            {
                tblNhatKy nky = new tblNhatKy(mal);
                busNhatKy.themnk(nky);
                this.Hide();
                Form nk = new Main();
                nk.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("dang nhap khong thanh cong!");       
                txtPass.Text = "";
                txtAcc.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form nk = new frmXemDiem();
            nk.Show();
            this.Close();
        }
    }
}
