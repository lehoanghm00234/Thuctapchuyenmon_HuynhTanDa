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
    public partial class danhsachloaiphong : Form
    {
        public danhsachloaiphong()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        private void FormPhong_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt.loaiphongs.ToList();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            dt.themloaiphong(txtMaloai.Text, txtSonguoi.Text, txtgia.Text);
            FormPhong_Load(sender, e);

        }


        private void button4_Click(object sender, EventArgs e)
        {
            dt.suaLoaiPhong(txtMaloai.Text, txtSonguoi.Text, txtgia.Text);
            dataGridView1.DataSource = new DataClasses1DataContext().loaiphongs.ToList();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txtMaloai.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtSonguoi.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtgia.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.deleteLoaiPhong(txtMaloai.Text);
            FormPhong_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
