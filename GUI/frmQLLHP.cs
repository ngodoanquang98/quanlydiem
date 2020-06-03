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
    public partial class frmQLLHP : Form
    {
        public frmQLLHP()
        {
            InitializeComponent();
        }

        private void cboLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvLHP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void frmQLLHP_Load(object sender, EventArgs e)
        {
            dgvLHP.DataSource = busLopHocPhan.getLopHocPhan();
            cboHocPhan.DataSource = busLopHocPhan.LopHocPhan();
            cboHocPhan.DisplayMember = "MaLopHP";        
            label14.DataBindings.Add("Text", busLopHocPhan.soluong(), "a",true);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form nk = new Main();
            nk.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = txtMaLHP.Text;
                string ph = txtPhongHoc.Text;
                string sv = txtTongSV.Text;
                int bd = int.Parse(cboTietBatDau.Text);
                int kt = int.Parse(cboTietKetThuc.Text);
                string th = cboThu.Text;
                string hp = cboTenHocPhan.Text;
                string gv = cboTenGV.Text;
                string hk = cboTenHK.Text;
                tblLopHocPhan lhp = new tblLopHocPhan(ma, ph, sv, bd, kt, th, hp, gv, hk);
                busLopHocPhan.InsertLopHocPhan(lhp);
                MessageBox.Show("them thanh cong");
                this.Hide();
                Form nk = new frmQLLHP();
                nk.Show();
                
            }
            catch
            {
                string ma = txtMaLHP.Text;
                string ph = txtPhongHoc.Text;
                string sv = txtTongSV.Text;
                int bd = int.Parse(cboTietBatDau.Text);
                int kt = int.Parse(cboTietKetThuc.Text);
                string th = cboThu.Text;
                string hp = cboTenHocPhan.Text;
                string gv = cboTenGV.Text;
                string hk = cboTenHK.Text;
                tblLopHocPhan lhp = new tblLopHocPhan(ma, ph, sv, bd, kt, th, hp, gv, hk);
                busLopHocPhan.UpdateLopHocPhan(lhp);
                MessageBox.Show("sua thanh cong");
                dgvLHP.DataSource = busLopHocPhan.getLopHocPhan();
                // dgvLHP.DataSource = busLopHocPhan.getLopHocPhan();
            }
        }

        private void dgvLHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvLHP.Rows[e.RowIndex];
            txtMaLHP.Text = row.Cells[0].Value.ToString();
            txtPhongHoc.Text = row.Cells[1].Value.ToString();
            txtTongSV.Text = row.Cells[2].Value.ToString();
            cboTietBatDau.Text = row.Cells[3].Value.ToString();
            cboTietKetThuc.Text = row.Cells[4].Value.ToString();
            cboThu.Text = row.Cells[5].Value.ToString();
            cboTenHocPhan.Text = row.Cells[6].Value.ToString();
            cboTenGV.Text = row.Cells[7].Value.ToString();
            cboTenHK.Text = row.Cells[8].Value.ToString();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string ten = txtTimKiem.Text;
            dgvLHP.DataSource = busLopHocPhan.SreachLopHocPhan(ten);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaLHP.Text;
            busLopHocPhan.DeleteLopHocPhan(ma);
            MessageBox.Show("xoa thanh cong");
            this.Hide();
            Form nk = new frmQLLHP();
            nk.Show();
            //  dgvLHP.DataSource = busLopHocPhan.getLopHocPhan();
            // label14.DataBindings.Add("Text", busLopHocPhan.soluong(), "a", true);

        }
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
        }
    }
}
