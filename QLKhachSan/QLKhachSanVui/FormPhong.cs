using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLKhachSanVui
{
    public partial class FormPhong : Form
    {
        public FormMain frmMain;

        DataClasses1DataContext dt = new DataClasses1DataContext();
        public FormPhong()
        {
            InitializeComponent();
        }

        private void FormPhong_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt.phongs.ToList();
            cbLoaiPhong.DataSource = dt.loaiphongs.ToList();
            cbLoaiPhong.DisplayMember = "maloai";
            cbLoaiPhong.ValueMember = "maloai";


            cbMatinhtrang.DataSource = dt.tinhtrangs.ToList();
            cbMatinhtrang.DisplayMember = "matinhtrang";
            cbMatinhtrang.ValueMember = "matinhtrang";

            
        }

        private void LoadDataPhong()
        {
            
        }
        private void LoadComboLoai()
        {
            
            //cbLoaiPhong.ValueMember = "maloai";

        }
        private void ReadDataPhong()
        {
            
        }
        private void LoadDataLoaiPhong()
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
           // panel1.Enabled = true;
        }
        int i = 0;
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            panel1.Visible = false;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dt.themPhong(txtMaphong.Text, cbMatinhtrang.SelectedValue.ToString(), cbLoaiPhong.SelectedValue.ToString());
            FormPhong_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
