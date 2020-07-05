using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKhachSanVui
{
    public partial class Tinhtrang : Form
    {
        public Tinhtrang()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tinhtrang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt.tinhtrangs.ToList();
        }

        private void btThemtinhtrang_Click(object sender, EventArgs e)
        {
            dt.themtinhtrang(txtMatinhtrang.Text, txtTentinhtrang.Text);
            Tinhtrang_Load(sender, e);
        }

        private void btSuatinhtrang_Click(object sender, EventArgs e)
        {
            dt.suatinhtrang(txtMatinhtrang.Text, txtTentinhtrang.Text);
            dataGridView1.DataSource = new DataClasses1DataContext().tinhtrangs.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txtMatinhtrang.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTentinhtrang.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        }

        private void btXoatinhtrang_Click(object sender, EventArgs e)
        {
            dt.xoatinhtrang(txtMatinhtrang.Text);
            Tinhtrang_Load(sender, e);
        }
    }
}
