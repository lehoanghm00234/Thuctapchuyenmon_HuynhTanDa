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
    public partial class Form1ChucVu : Form
    {
        public Form1ChucVu()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        private void btThem_Click(object sender, EventArgs e)
        {
            dt.themChucvu(txtMachucvu.Text, txtTenChucVu.Text, txtHesoluong.Text);
            Form1ChucVu_Load(sender, e);
        }

        private void Form1ChucVu_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt.chucvus.ToList();
            
            

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            dt.suaChucvu(txtMachucvu.Text, txtTenChucVu.Text, txtHesoluong.Text);
            dataGridView1.DataSource = new DataClasses1DataContext().chucvus.ToList();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txtMachucvu.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenChucVu.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtHesoluong.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            dt.xoaChucvu(txtMachucvu.Text);
            Form1ChucVu_Load(sender, e);
        }
    }
}
