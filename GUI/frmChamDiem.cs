using BUS;
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


namespace QLDiem1
{
    public partial class frmGiangVien : Form
    {

        public frmGiangVien()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            dgvGiangVien.DataSource = busGiangVien.getGiangVien();
            cboTenKhoa.DataSource = busGiangVien.Khoa();
            cboTenKhoa.DisplayMember = "MaKhoa";
            cboTenKhoa.ValueMember = "TenKhoa";
            cboKhoa.DataSource = busGiangVien.Khoa();
            cboKhoa.DisplayMember = "TenKhoa";
            cboKhoa.ValueMember = "MaKhoa";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
                try
                {
                    string magv= txtMaGV.Text;
                    string ten = txtTenGV.Text;
                    string sdt = txtSDT.Text;
                    string hocvi = txtHocVi.Text;
                    string mak = cboTenKhoa.Text;
                DTO.tblGiangVien hp = new DTO.tblGiangVien(magv, ten, sdt, hocvi, mak);
                busGiangVien.InsertGiangVien(hp);
                MessageBox.Show("them  " + ten + "  thanh cong");
                dgvGiangVien.DataSource = busGiangVien.getGiangVien();
                }
                catch 
                {
                MessageBox.Show("co loi xay ra");
                }
        
        }

        private void cboTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboKhoa.DataSource = busGiangVien.Khoa();
        }

        private void dgvGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row =dgvGiangVien.Rows[e.RowIndex];
                txtMaGV.Text = row.Cells[0].Value.ToString();
                txtTenGV.Text = row.Cells[1].Value.ToString();
                txtSDT.Text = row.Cells[2].Value.ToString();
                txtHocVi.Text = row.Cells[3].Value.ToString();
                cboTenKhoa.Text = row.Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string magv = txtMaGV.Text;
                string ten = txtTenGV.Text;
                string sdt = txtSDT.Text;
                string hocvi = txtHocVi.Text;
                string mak = cboTenKhoa.Text;
                DTO.tblGiangVien hp = new DTO.tblGiangVien(magv, ten, sdt, hocvi, mak);
                busGiangVien.UpdateGiangVien(hp);
                MessageBox.Show("sua  " + ten + "  thanh cong");
                dgvGiangVien.DataSource = busGiangVien.getGiangVien();
            }
            catch 
            {
                MessageBox.Show("co loi xay ra");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string magv = txtMaGV.Text;                          
                busGiangVien.DeleteGiangVien(magv);
                MessageBox.Show("Xoa thanh cong");
                dgvGiangVien.DataSource = busGiangVien.getGiangVien();
            }
            catch 
            {
                MessageBox.Show("co loi xay ra");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string ten = txtTimKiem.Text;
            dgvGiangVien.DataSource = busGiangVien.SreachGiangVien(ten);
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }
    }
}
