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
    public partial class FormKhachHang : Form
    {
        public FormMain frmMain;

        DataClasses1DataContext dt = new DataClasses1DataContext();
        //private DataSet dataset;
        public FormKhachHang()
        {
            InitializeComponent();
        }
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            gvKhachhang.AutoGenerateColumns = false;
            gvKhachhang.DataSource = dt.khachhangs.ToList();
        }
      
        private void btnThem_Click(object sender, EventArgs e)
        {
            dt.themkh(txtMkh.Text, txtTenkh.Text, txtGioiTinh.Text, dateTimePicker1.Text, txtCmnd.Text, txtSodt.Text, txtDiachi.Text, txtGhichu.Text);
            FormKhachHang_Load(sender, e);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            dt.update_kh(txtMkh.Text, txtTenkh.Text, txtGioiTinh.Text, dateTimePicker1.Text, txtCmnd.Text, txtSodt.Text, txtDiachi.Text, txtGhichu.Text);
            gvKhachhang.DataSource = new DataClasses1DataContext().khachhangs.ToList();

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            dt.deletekh(txtMkh.Text);
            FormKhachHang_Load(sender, e);

        }
        private void gvKhachhang_Click(object sender, EventArgs e)
        {
           
        }

        private void txtTimkiem_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void gvKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = gvKhachhang.CurrentRow.Index;
            txtMkh.Text = gvKhachhang.Rows[i].Cells[0].Value.ToString();
            txtTenkh.Text = gvKhachhang.Rows[i].Cells[1].Value.ToString();
            txtGioiTinh.Text = gvKhachhang.Rows[i].Cells[2].Value.ToString();
            dateTimePicker1.Text = gvKhachhang.Rows[i].Cells[3].Value.ToString();
            txtCmnd.Text = gvKhachhang.Rows[i].Cells[4].Value.ToString();
            txtDiachi.Text = gvKhachhang.Rows[i].Cells[5].Value.ToString();
            txtSodt.Text = gvKhachhang.Rows[i].Cells[6].Value.ToString();
            txtGhichu.Text = gvKhachhang.Rows[i].Cells[7].Value.ToString();
        }
    }
}
