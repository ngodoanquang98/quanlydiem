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
using System.Data.SqlClient;
using System.Globalization;
using GUI;

namespace QLDiem1
{
    public partial class frmSinhVien : Form
    {       
        public frmSinhVien()
        {
            InitializeComponent();
        }     

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = busSinhVien.getSinhVien();
            cboMaLop.DataSource = busSinhVien.LopSinhVien();
            cboMaLop.DisplayMember = "maLop";
            cboMaLop.ValueMember = "maLop";
        }



        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvSinhVien.Rows[e.RowIndex];
            txtMaSV.Text = row.Cells[0].Value.ToString();
            txtTenSV.Text = row.Cells[1].Value.ToString();
            dtpNgaySinh.Text = row.Cells[2].Value.ToString();
            comboBox1.Text = row.Cells[3].Value.ToString();
            txtQueQuan.Text = row.Cells[4].Value.ToString();
            txtDiaChiHT.Text = row.Cells[5].Value.ToString();
            cboMaLop.Text = row.Cells[6].Value.ToString();
            txtSoTCDaDat.Text = row.Cells[7].Value.ToString();
            txtDiemTichLuy.Text = row.Cells[8].Value.ToString();
            txtSoTCDaDKy.Text = row.Cells[9].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
       
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string masv = txtMaSV.Text;
                string ten = txtTenSV.Text;
                DateTime ns = DateTime.Parse(dtpNgaySinh.Text,CultureInfo.InvariantCulture);
                string gt = comboBox1.Text;
                string qq = txtQueQuan.Text;
                string dc = txtDiaChiHT.Text;
                string mal = cboMaLop.Text;
                int dd = int.Parse(txtSoTCDaDat.Text,CultureInfo.InvariantCulture);
                float diem = float.Parse(txtDiemTichLuy.Text, CultureInfo.InvariantCulture);
                int dk = int.Parse(txtSoTCDaDKy.Text, CultureInfo.InvariantCulture);
                tblSinhVien hp = new tblSinhVien(masv,ten,ns,gt,qq,dc,mal,dd,diem,dk);
                busSinhVien.InsertSinhVien(hp);
                MessageBox.Show("them  " + ten + "  thanh cong");
                dgvSinhVien.DataSource = busSinhVien.getSinhVien();
        }
            catch 
            {
                MessageBox.Show("co loi xay ra");
            }

}

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string masv = txtMaSV.Text;
            busSinhVien.DeleteSinhVien(masv);
            MessageBox.Show("xoa thanh cong");
            dgvSinhVien.DataSource = busSinhVien.getSinhVien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form nk = new Main();
            nk.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
     
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = textBox1.Text;
                dgvSinhVien.DataSource = busSinhVien.SreachLop(ten);
            }
            catch
            {
                MessageBox.Show("he thong dang nang cap");
            }
        }

        private void cboKhoa_SelectedValueChanged(object sender, EventArgs e)
        {

         
                

            
        }

        private void cboLop_SelectedValueChanged(object sender, EventArgs e)
        {
      
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string ten = txtTimKiem.Text;
            dgvSinhVien.DataSource = busSinhVien.SreachSinhVien(ten);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
