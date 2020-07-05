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
using System.Collections;

namespace QLKhachSanVui
{

    public partial class FormDatPhong : Form
    {
        

        public FormDatPhong()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        private void FormDatPhong_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt.phieuthuephongs.ToList();
            cbkh.DataSource = dt.khachhangs.ToList();
            cbkh.DisplayMember = "tenkh";
            cbkh.ValueMember = "makh";

            cbmp.DataSource = dt.phongs.ToList();
            cbmp.DisplayMember = "maphong";
            cbmp.ValueMember = "maphong";

        }
        private void LoadComboKH()
        {
        }
        private void LoadDataKh()
        {
           
        }
        private void TimPhongTrong()
        {
            
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
        }

        private void cbkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void LoadCTKH()
        {
            
        }

        private void btnDatphong_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSonguoi_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTiencoc_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
           
        }

        private void ChonPhong()
        {
           
        }

        private void gvTimPhong_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt.themDatPhong(txtmapd.Text, cbmp.SelectedValue.ToString(), cbkh.SelectedValue.ToString(), dateTimePicker1.CustomFormat, txtSonguoi.Text);
            FormDatPhong_Load(sender, e);
        }
        //kích lên trên ô thêm.
    }
}
