namespace QLKhachSanVui
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnHethong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnDoimatkhau = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnKhachhang1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnInhoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDatphong1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThuephong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQuanly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNguoidung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTrogiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnThongtin = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblUser = new System.Windows.Forms.Label();
            this.lbllogo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnHethong,
            this.mnKhachhang1,
            this.mnDatphong1,
            this.mnQuanly,
            this.mnBaocao,
            this.mnTrogiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnHethong
            // 
            this.mnHethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnDangnhap,
            this.mnDangxuat,
            this.toolStripSeparator1,
            this.mnDoimatkhau,
            this.toolStripSeparator2,
            this.mnThoat});
            this.mnHethong.Name = "mnHethong";
            this.mnHethong.Size = new System.Drawing.Size(102, 28);
            this.mnHethong.Text = "Hệ thống";
            // 
            // mnDangnhap
            // 
            this.mnDangnhap.Image = ((System.Drawing.Image)(resources.GetObject("mnDangnhap.Image")));
            this.mnDangnhap.Name = "mnDangnhap";
            this.mnDangnhap.Size = new System.Drawing.Size(224, 28);
            this.mnDangnhap.Text = "Đăng nhập";
            this.mnDangnhap.Click += new System.EventHandler(this.mnDangnhap_Click);
            // 
            // mnDangxuat
            // 
            this.mnDangxuat.Image = ((System.Drawing.Image)(resources.GetObject("mnDangxuat.Image")));
            this.mnDangxuat.Name = "mnDangxuat";
            this.mnDangxuat.Size = new System.Drawing.Size(224, 28);
            this.mnDangxuat.Text = "Đăng xuất";
            this.mnDangxuat.Click += new System.EventHandler(this.mnDangxuat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // mnDoimatkhau
            // 
            this.mnDoimatkhau.Name = "mnDoimatkhau";
            this.mnDoimatkhau.Size = new System.Drawing.Size(224, 28);
            this.mnDoimatkhau.Text = "Đổi mật khẩu";
            this.mnDoimatkhau.Click += new System.EventHandler(this.mnDoimatkhau_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // mnThoat
            // 
            this.mnThoat.Name = "mnThoat";
            this.mnThoat.Size = new System.Drawing.Size(224, 28);
            this.mnThoat.Text = "Thoát";
            this.mnThoat.Click += new System.EventHandler(this.mnThoat_Click);
            // 
            // mnKhachhang1
            // 
            this.mnKhachhang1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnKhachhang,
            this.mnInhoadon});
            this.mnKhachhang1.Name = "mnKhachhang1";
            this.mnKhachhang1.Size = new System.Drawing.Size(126, 28);
            this.mnKhachhang1.Text = "Khách hàng";
            // 
            // mnKhachhang
            // 
            this.mnKhachhang.Name = "mnKhachhang";
            this.mnKhachhang.Size = new System.Drawing.Size(224, 28);
            this.mnKhachhang.Text = "Khách hàng";
            this.mnKhachhang.Click += new System.EventHandler(this.mnKhachhang_Click);
            // 
            // mnInhoadon
            // 
            this.mnInhoadon.Name = "mnInhoadon";
            this.mnInhoadon.Size = new System.Drawing.Size(224, 28);
            this.mnInhoadon.Text = "In hóa đơn";
            this.mnInhoadon.Click += new System.EventHandler(this.mnInhoadon_Click);
            // 
            // mnDatphong1
            // 
            this.mnDatphong1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnThuephong});
            this.mnDatphong1.Name = "mnDatphong1";
            this.mnDatphong1.Size = new System.Drawing.Size(111, 28);
            this.mnDatphong1.Text = "Đặt phòng";
            // 
            // mnThuephong
            // 
            this.mnThuephong.Name = "mnThuephong";
            this.mnThuephong.Size = new System.Drawing.Size(224, 28);
            this.mnThuephong.Text = "Thuê phòng";
            this.mnThuephong.Click += new System.EventHandler(this.mnThuephong_Click);
            // 
            // mnQuanly
            // 
            this.mnQuanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnPhong,
            this.mnNhanvien,
            this.mnNguoidung});
            this.mnQuanly.Name = "mnQuanly";
            this.mnQuanly.Size = new System.Drawing.Size(89, 28);
            this.mnQuanly.Text = "Quản lý";
            // 
            // mnPhong
            // 
            this.mnPhong.Name = "mnPhong";
            this.mnPhong.Size = new System.Drawing.Size(224, 28);
            this.mnPhong.Text = "Phòng";
            this.mnPhong.Click += new System.EventHandler(this.mnPhong_Click);
            // 
            // mnNhanvien
            // 
            this.mnNhanvien.Name = "mnNhanvien";
            this.mnNhanvien.Size = new System.Drawing.Size(224, 28);
            this.mnNhanvien.Text = "Nhân viên";
            this.mnNhanvien.Click += new System.EventHandler(this.mnNhanvien_Click);
            // 
            // mnNguoidung
            // 
            this.mnNguoidung.Name = "mnNguoidung";
            this.mnNguoidung.Size = new System.Drawing.Size(224, 28);
            this.mnNguoidung.Text = "Người dùng";
            this.mnNguoidung.Click += new System.EventHandler(this.mnNguoidung_Click);
            // 
            // mnBaocao
            // 
            this.mnBaocao.Name = "mnBaocao";
            this.mnBaocao.Size = new System.Drawing.Size(93, 28);
            this.mnBaocao.Text = "Báo cáo";
            this.mnBaocao.Click += new System.EventHandler(this.mnBaocao_Click);
            // 
            // mnTrogiup
            // 
            this.mnTrogiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnThongtin});
            this.mnTrogiup.Name = "mnTrogiup";
            this.mnTrogiup.Size = new System.Drawing.Size(95, 28);
            this.mnTrogiup.Text = "Trợ giúp";
            // 
            // mnThongtin
            // 
            this.mnThongtin.Name = "mnThongtin";
            this.mnThongtin.Size = new System.Drawing.Size(174, 28);
            this.mnThongtin.Text = "Thông tin";
            this.mnThongtin.Click += new System.EventHandler(this.mnThongtin_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "home.png");
            this.imageList1.Images.SetKeyName(1, "home1.png");
            this.imageList1.Images.SetKeyName(2, "home2.png");
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblUser.Location = new System.Drawing.Point(16, 43);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(69, 20);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Hi user!";
            // 
            // lbllogo
            // 
            this.lbllogo.AutoSize = true;
            this.lbllogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbllogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbllogo.Location = new System.Drawing.Point(268, 43);
            this.lbllogo.Name = "lbllogo";
            this.lbllogo.Size = new System.Drawing.Size(329, 42);
            this.lbllogo.TabIndex = 7;
            this.lbllogo.Text = "Quản lý khách sạn";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.lbllogo);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý khách sạn";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnHethong;
        private System.Windows.Forms.ToolStripMenuItem mnDangnhap;
        private System.Windows.Forms.ToolStripMenuItem mnDangxuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnDoimatkhau;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnThoat;
        private System.Windows.Forms.ToolStripMenuItem mnKhachhang1;
        private System.Windows.Forms.ToolStripMenuItem mnKhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnInhoadon;
        private System.Windows.Forms.ToolStripMenuItem mnDatphong1;
        private System.Windows.Forms.ToolStripMenuItem mnThuephong;
        private System.Windows.Forms.ToolStripMenuItem mnQuanly;
        private System.Windows.Forms.ToolStripMenuItem mnPhong;
        private System.Windows.Forms.ToolStripMenuItem mnNhanvien;
        private System.Windows.Forms.ToolStripMenuItem mnNguoidung;
        private System.Windows.Forms.ToolStripMenuItem mnBaocao;
        private System.Windows.Forms.ToolStripMenuItem mnTrogiup;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lbllogo;
        private System.Windows.Forms.ToolStripMenuItem mnThongtin;
        private System.Windows.Forms.ImageList imageList1;

    }
}

