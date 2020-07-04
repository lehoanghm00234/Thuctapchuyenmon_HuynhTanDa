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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        private void label4_Click(object sender, EventArgs e)
        {

        }
        string b;
        private void FormNhanVien_Load(object sender, EventArgs e)
        {

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt.nhanviens.ToList();
            cbChucVu.DataSource = dt.chucvus.ToList();
            cbChucVu.DisplayMember = "tenchucvu";
            cbChucVu.ValueMember = "machucvu";
           
        }

        private void btThemNV_Click(object sender, EventArgs e)
        {
            dt.themNhanVien1(txtManhanvien.Text, txtTennhanvien.Text, txtGioitinh.Text, txtNgaysinh.Text, txtSodienthoai.Text, txtDiachi.Text, txtLuong.Text,cbChucVu.SelectedValue.ToString(), txtTongLuong.Text);
            FormNhanVien_Load(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            txtManhanvien.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTennhanvien.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtGioitinh.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtNgaysinh.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtSodienthoai.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtDiachi.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
           // txtChucvu.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txtLuong.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();



        }

        private void btSuaNV_Click(object sender, EventArgs e)
        {
            dt.suaNhanVien(txtManhanvien.Text, txtTennhanvien.Text, txtGioitinh.Text, txtNgaysinh.Text, txtSodienthoai.Text, txtDiachi.Text, cbChucVu.SelectedValue.ToString(), txtLuong.Text);
            dataGridView1.DataSource = new DataClasses1DataContext().nhanviens.ToList();
        }

        private void btXoaNV_Click(object sender, EventArgs e)
        {
            dt.xoaNhanVien(txtManhanvien.Text);
            FormNhanVien_Load(sender, e);
        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            chucvu chucvu = dt.chucvus.FirstOrDefault(s => s.machucvu == cbChucVu.SelectedValue.ToString());
            if (chucvu != null)
            {
                label5.Text = chucvu.hesoluong.ToString();
            }
            label5_TextChanged(sender, e);

        }

        private void label5_TextChanged(object sender, EventArgs e)
        {
            if(txtLuong.Text.Trim()!="")
            {
                int a = Convert.ToInt32(label5.Text.ToString());
                int b = Convert.ToInt32(txtLuong.Text.ToString());
                txtTongLuong.Text = (a*b).ToString();

            }
          
        }
    }
}
