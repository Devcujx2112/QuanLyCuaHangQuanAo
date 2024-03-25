namespace QLSHOPQUANAO
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_HoaDon = new System.Windows.Forms.Button();
            this.btn_KhachHang = new System.Windows.Forms.Button();
            this.btn_DangXuat = new System.Windows.Forms.Button();
            this.btn_CTHoaDon = new System.Windows.Forms.Button();
            this.btn_SanPham = new System.Windows.Forms.Button();
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.btn_TrangChu = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.HoaDonUC = new QLSHOPQUANAO.HoaDon();
            this.CTHoaDonUC = new QLSHOPQUANAO.CTHoaDon();
            this.KhachHangUC = new QLSHOPQUANAO.KhachHang();
            this.NhanVienUC = new QLSHOPQUANAO.NhanVien();
            this.SanPhamUC = new QLSHOPQUANAO.SanPham();
            this.TrangChuUC = new QLSHOPQUANAO.TrangChu();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.btn_HoaDon);
            this.panel5.Controls.Add(this.btn_KhachHang);
            this.panel5.Controls.Add(this.btn_DangXuat);
            this.panel5.Controls.Add(this.btn_CTHoaDon);
            this.panel5.Controls.Add(this.btn_SanPham);
            this.panel5.Controls.Add(this.btn_NhanVien);
            this.panel5.Controls.Add(this.btn_TrangChu);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(228, 727);
            this.panel5.TabIndex = 9;
            // 
            // btn_HoaDon
            // 
            this.btn_HoaDon.FlatAppearance.BorderSize = 0;
            this.btn_HoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HoaDon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_HoaDon.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_HoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btn_HoaDon.Image")));
            this.btn_HoaDon.Location = new System.Drawing.Point(0, 534);
            this.btn_HoaDon.Name = "btn_HoaDon";
            this.btn_HoaDon.Size = new System.Drawing.Size(231, 59);
            this.btn_HoaDon.TabIndex = 18;
            this.btn_HoaDon.Text = " HÓA ĐƠN";
            this.btn_HoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_HoaDon.UseVisualStyleBackColor = true;
            this.btn_HoaDon.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_KhachHang
            // 
            this.btn_KhachHang.FlatAppearance.BorderSize = 0;
            this.btn_KhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_KhachHang.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_KhachHang.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_KhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btn_KhachHang.Image")));
            this.btn_KhachHang.Location = new System.Drawing.Point(-5, 417);
            this.btn_KhachHang.Name = "btn_KhachHang";
            this.btn_KhachHang.Size = new System.Drawing.Size(236, 61);
            this.btn_KhachHang.TabIndex = 17;
            this.btn_KhachHang.Text = "KHÁCH HÀNG";
            this.btn_KhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_KhachHang.UseVisualStyleBackColor = true;
            this.btn_KhachHang.Click += new System.EventHandler(this.btn_KhachHang_Click);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.FlatAppearance.BorderSize = 0;
            this.btn_DangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DangXuat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DangXuat.ForeColor = System.Drawing.Color.Red;
            this.btn_DangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.Image")));
            this.btn_DangXuat.Location = new System.Drawing.Point(-3, 660);
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.Size = new System.Drawing.Size(231, 67);
            this.btn_DangXuat.TabIndex = 13;
            this.btn_DangXuat.Text = " ĐĂNG XUẤT";
            this.btn_DangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_DangXuat.UseVisualStyleBackColor = true;
            this.btn_DangXuat.Click += new System.EventHandler(this.btn_DangXuat_Click);
            // 
            // btn_CTHoaDon
            // 
            this.btn_CTHoaDon.FlatAppearance.BorderSize = 0;
            this.btn_CTHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CTHoaDon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_CTHoaDon.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_CTHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btn_CTHoaDon.Image")));
            this.btn_CTHoaDon.Location = new System.Drawing.Point(-5, 589);
            this.btn_CTHoaDon.Name = "btn_CTHoaDon";
            this.btn_CTHoaDon.Size = new System.Drawing.Size(234, 74);
            this.btn_CTHoaDon.TabIndex = 12;
            this.btn_CTHoaDon.Text = "   CHI TIẾT      HÓA ĐƠN";
            this.btn_CTHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CTHoaDon.UseVisualStyleBackColor = true;
            this.btn_CTHoaDon.Click += new System.EventHandler(this.btn_HoaDon_Click);
            // 
            // btn_SanPham
            // 
            this.btn_SanPham.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_SanPham.FlatAppearance.BorderSize = 0;
            this.btn_SanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_SanPham.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_SanPham.Image = ((System.Drawing.Image)(resources.GetObject("btn_SanPham.Image")));
            this.btn_SanPham.Location = new System.Drawing.Point(0, 356);
            this.btn_SanPham.Name = "btn_SanPham";
            this.btn_SanPham.Size = new System.Drawing.Size(231, 67);
            this.btn_SanPham.TabIndex = 11;
            this.btn_SanPham.Text = " SẢN PHẨM";
            this.btn_SanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SanPham.UseVisualStyleBackColor = false;
            this.btn_SanPham.Click += new System.EventHandler(this.btn_SanPham_Click);
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.FlatAppearance.BorderSize = 0;
            this.btn_NhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhanVien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_NhanVien.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_NhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhanVien.Image")));
            this.btn_NhanVien.Location = new System.Drawing.Point(-3, 474);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Size = new System.Drawing.Size(234, 64);
            this.btn_NhanVien.TabIndex = 10;
            this.btn_NhanVien.Text = " NHÂN VIÊN";
            this.btn_NhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_NhanVien.UseVisualStyleBackColor = true;
            this.btn_NhanVien.Click += new System.EventHandler(this.btn_NhanVien_Click);
            // 
            // btn_TrangChu
            // 
            this.btn_TrangChu.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_TrangChu.FlatAppearance.BorderSize = 0;
            this.btn_TrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TrangChu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TrangChu.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_TrangChu.Image = ((System.Drawing.Image)(resources.GetObject("btn_TrangChu.Image")));
            this.btn_TrangChu.Location = new System.Drawing.Point(-1, 295);
            this.btn_TrangChu.Name = "btn_TrangChu";
            this.btn_TrangChu.Size = new System.Drawing.Size(232, 67);
            this.btn_TrangChu.TabIndex = 9;
            this.btn_TrangChu.Text = " TRANG CHỦ";
            this.btn_TrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_TrangChu.UseVisualStyleBackColor = false;
            this.btn_TrangChu.Click += new System.EventHandler(this.btn_TrangChu_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBox1);
            this.panel6.Controls.Add(this.textBox2);
            this.panel6.Location = new System.Drawing.Point(0, 221);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(231, 50);
            this.panel6.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox1.Location = new System.Drawing.Point(0, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(231, 50);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-5, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 169);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(228, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1160, 50);
            this.panel7.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(243, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 41);
            this.label2.TabIndex = 9;
            this.label2.Text = "SHOP QUẦN ÁO ";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.Red;
            this.lblTieuDe.Location = new System.Drawing.Point(234, 50);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(239, 47);
            this.lblTieuDe.TabIndex = 12;
            this.lblTieuDe.Text = "TRANG CHỦ";
            // 
            // HoaDonUC
            // 
            this.HoaDonUC.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.HoaDonUC.BackColor = System.Drawing.Color.Transparent;
            this.HoaDonUC.Location = new System.Drawing.Point(228, 96);
            this.HoaDonUC.Name = "HoaDonUC";
            this.HoaDonUC.Size = new System.Drawing.Size(1153, 631);
            this.HoaDonUC.TabIndex = 29;
            this.HoaDonUC.Load += new System.EventHandler(this.HoaDonUC_Load);
            // 
            // CTHoaDonUC
            // 
            this.CTHoaDonUC.Location = new System.Drawing.Point(231, 101);
            this.CTHoaDonUC.Name = "CTHoaDonUC";
            this.CTHoaDonUC.Size = new System.Drawing.Size(1153, 626);
            this.CTHoaDonUC.TabIndex = 28;
            // 
            // KhachHangUC
            // 
            this.KhachHangUC.Location = new System.Drawing.Point(231, 101);
            this.KhachHangUC.Name = "KhachHangUC";
            this.KhachHangUC.Size = new System.Drawing.Size(1153, 626);
            this.KhachHangUC.TabIndex = 26;
            // 
            // NhanVienUC
            // 
            this.NhanVienUC.Location = new System.Drawing.Point(231, 101);
            this.NhanVienUC.Name = "NhanVienUC";
            this.NhanVienUC.Size = new System.Drawing.Size(1153, 626);
            this.NhanVienUC.TabIndex = 25;
            // 
            // SanPhamUC
            // 
            this.SanPhamUC.ChucVu = null;
            this.SanPhamUC.Location = new System.Drawing.Point(231, 101);
            this.SanPhamUC.Name = "SanPhamUC";
            this.SanPhamUC.Size = new System.Drawing.Size(1153, 626);
            this.SanPhamUC.TabIndex = 24;
            // 
            // TrangChuUC
            // 
            this.TrangChuUC.BackColor = System.Drawing.Color.White;
            this.TrangChuUC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TrangChuUC.Location = new System.Drawing.Point(231, 100);
            this.TrangChuUC.Name = "TrangChuUC";
            this.TrangChuUC.Size = new System.Drawing.Size(1153, 629);
            this.TrangChuUC.TabIndex = 23;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1388, 727);
            this.Controls.Add(this.HoaDonUC);
            this.Controls.Add(this.CTHoaDonUC);
            this.Controls.Add(this.KhachHangUC);
            this.Controls.Add(this.NhanVienUC);
            this.Controls.Add(this.SanPhamUC);
            this.Controls.Add(this.TrangChuUC);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_KhachHang;
        private System.Windows.Forms.Button btn_DangXuat;
        private System.Windows.Forms.Button btn_CTHoaDon;
        private System.Windows.Forms.Button btn_SanPham;
        private System.Windows.Forms.Button btn_NhanVien;
        private System.Windows.Forms.Button btn_TrangChu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTieuDe;
        private TrangChu TrangChuUC;
        private SanPham SanPhamUC;
        private NhanVien NhanVienUC;
        private KhachHang KhachHangUC;
        public CTHoaDon CTHoaDonUC;
        private System.Windows.Forms.Button btn_HoaDon;
        private HoaDon HoaDonUC;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}