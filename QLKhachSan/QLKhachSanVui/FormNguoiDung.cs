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
    public partial class FormNguoiDung : Form
    {
        public FormMain frmMain;
        public FormNguoiDung()
        {
            InitializeComponent();
        }

        private void FormNguoiDung_Load(object sender, EventArgs e)
        {
            LoadDataUser();
        }
        private void LoadDataUser()
        {
            
        }
    }
}
