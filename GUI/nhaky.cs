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
    public partial class nhaky : Form
    {
        public nhaky()
        {
            InitializeComponent();
        }

        private void nhaky_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = busNhatKy.GetNhatKy();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form nk = new Main();
            nk.Show();
        }
    }
}
