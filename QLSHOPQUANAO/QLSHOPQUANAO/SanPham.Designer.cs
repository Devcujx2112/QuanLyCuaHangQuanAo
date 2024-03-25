namespace QLSHOPQUANAO
{
    partial class SanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvDSSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNgaySanXuat = new System.Windows.Forms.DateTimePicker();
            this.btnChon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnhSP = new System.Windows.Forms.TextBox();
            this.lblNgaySanXuat = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblMaSanPham = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.txtGiaSanPham = new System.Windows.Forms.TextBox();
            this.lblGiaSanPham = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtMoTaSanPham = new System.Windows.Forms.TextBox();
            this.lblMoTaSanPham = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSanPham)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_tensp);
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.dgvDSSanPham);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(0, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1153, 361);
            this.groupBox2.TabIndex = 79;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1047, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 126;
            this.button1.Text = "Reset";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(339, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 103;
            // 
            // txt_tensp
            // 
            this.txt_tensp.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tensp.Location = new System.Drawing.Point(579, 17);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.Size = new System.Drawing.Size(313, 34);
            this.txt_tensp.TabIndex = 78;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.SpringGreen;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Image = ((System.Drawing.Image)(resources.GetObject("btnTim.Image")));
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTim.Location = new System.Drawing.Point(911, 14);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(110, 33);
            this.btnTim.TabIndex = 77;
            this.btnTim.Text = "Tìm";
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dgvDSSanPham
            // 
            this.dgvDSSanPham.AllowDrop = true;
            this.dgvDSSanPham.AllowUserToOrderColumns = true;
            this.dgvDSSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDSSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSSanPham.Location = new System.Drawing.Point(3, 34);
            this.dgvDSSanPham.Name = "dgvDSSanPham";
            this.dgvDSSanPham.RowHeadersWidth = 51;
            this.dgvDSSanPham.RowTemplate.Height = 30;
            this.dgvDSSanPham.Size = new System.Drawing.Size(1147, 324);
            this.dgvDSSanPham.TabIndex = 76;
            this.dgvDSSanPham.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDSSanPham_DataError);
            this.dgvDSSanPham.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDSSanPham_RowsAdded);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNgaySanXuat);
            this.groupBox1.Controls.Add(this.btnChon);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAnhSP);
            this.groupBox1.Controls.Add(this.lblNgaySanXuat);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtMaSanPham);
            this.groupBox1.Controls.Add(this.lblSoLuong);
            this.groupBox1.Controls.Add(this.lblMaSanPham);
            this.groupBox1.Controls.Add(this.txtTenSanPham);
            this.groupBox1.Controls.Add(this.lblTenSanPham);
            this.groupBox1.Controls.Add(this.txtGiaSanPham);
            this.groupBox1.Controls.Add(this.lblGiaSanPham);
            this.groupBox1.Controls.Add(this.txtSize);
            this.groupBox1.Controls.Add(this.lblSize);
            this.groupBox1.Controls.Add(this.txtMoTaSanPham);
            this.groupBox1.Controls.Add(this.lblMoTaSanPham);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1153, 259);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // txtNgaySanXuat
            // 
            this.txtNgaySanXuat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNgaySanXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgaySanXuat.Location = new System.Drawing.Point(705, 72);
            this.txtNgaySanXuat.Name = "txtNgaySanXuat";
            this.txtNgaySanXuat.Size = new System.Drawing.Size(233, 34);
            this.txtNgaySanXuat.TabIndex = 78;
            // 
            // btnChon
            // 
            this.btnChon.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChon.Location = new System.Drawing.Point(987, 213);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(116, 28);
            this.btnChon.TabIndex = 102;
            this.btnChon.Text = "chọn tệp...";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(974, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 179);
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(517, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 100;
            this.label1.Text = "ẢNH SẢN PHẨM";
            // 
            // txtAnhSP
            // 
            this.txtAnhSP.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtAnhSP.Location = new System.Drawing.Point(705, 157);
            this.txtAnhSP.Multiline = true;
            this.txtAnhSP.Name = "txtAnhSP";
            this.txtAnhSP.Size = new System.Drawing.Size(233, 29);
            this.txtAnhSP.TabIndex = 99;
            // 
            // lblNgaySanXuat
            // 
            this.lblNgaySanXuat.AutoSize = true;
            this.lblNgaySanXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgaySanXuat.Location = new System.Drawing.Point(515, 81);
            this.lblNgaySanXuat.Name = "lblNgaySanXuat";
            this.lblNgaySanXuat.Size = new System.Drawing.Size(172, 22);
            this.lblNgaySanXuat.TabIndex = 98;
            this.lblNgaySanXuat.Text = "NGÀY SẢN XUẤT:";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(416, 213);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(113, 40);
            this.btnHuy.TabIndex = 96;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Tomato;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(828, 213);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(110, 40);
            this.btnXoa.TabIndex = 95;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(694, 213);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(110, 40);
            this.btnSua.TabIndex = 94;
            this.btnSua.Text = "SỬA";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Turquoise;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(551, 213);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 40);
            this.btnThem.TabIndex = 93;
            this.btnThem.Text = "THÊM";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtSoLuong.Location = new System.Drawing.Point(705, 116);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(233, 29);
            this.txtSoLuong.TabIndex = 7;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaSanPham.Location = new System.Drawing.Point(226, 43);
            this.txtMaSanPham.Multiline = true;
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(257, 29);
            this.txtMaSanPham.TabIndex = 0;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoLuong.Location = new System.Drawing.Point(516, 123);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(115, 22);
            this.lblSoLuong.TabIndex = 91;
            this.lblSoLuong.Text = "SỐ LƯỢNG:";
            // 
            // lblMaSanPham
            // 
            this.lblMaSanPham.AutoSize = true;
            this.lblMaSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaSanPham.Location = new System.Drawing.Point(30, 50);
            this.lblMaSanPham.Name = "lblMaSanPham";
            this.lblMaSanPham.Size = new System.Drawing.Size(152, 22);
            this.lblMaSanPham.TabIndex = 77;
            this.lblMaSanPham.Text = "MÃ SẢN PHẨM:";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtTenSanPham.Location = new System.Drawing.Point(226, 85);
            this.txtTenSanPham.Multiline = true;
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(257, 29);
            this.txtTenSanPham.TabIndex = 1;
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenSanPham.Location = new System.Drawing.Point(27, 88);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(159, 22);
            this.lblTenSanPham.TabIndex = 79;
            this.lblTenSanPham.Text = "TÊN SẢN PHẨM:";
            // 
            // txtGiaSanPham
            // 
            this.txtGiaSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtGiaSanPham.Location = new System.Drawing.Point(226, 123);
            this.txtGiaSanPham.Multiline = true;
            this.txtGiaSanPham.Name = "txtGiaSanPham";
            this.txtGiaSanPham.Size = new System.Drawing.Size(257, 29);
            this.txtGiaSanPham.TabIndex = 2;
            // 
            // lblGiaSanPham
            // 
            this.lblGiaSanPham.AutoSize = true;
            this.lblGiaSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGiaSanPham.Location = new System.Drawing.Point(27, 123);
            this.lblGiaSanPham.Name = "lblGiaSanPham";
            this.lblGiaSanPham.Size = new System.Drawing.Size(155, 22);
            this.lblGiaSanPham.TabIndex = 81;
            this.lblGiaSanPham.Text = "GIÁ SẢN PHẨM:";
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtSize.Location = new System.Drawing.Point(705, 37);
            this.txtSize.Multiline = true;
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(233, 29);
            this.txtSize.TabIndex = 4;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSize.Location = new System.Drawing.Point(515, 45);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(56, 22);
            this.lblSize.TabIndex = 85;
            this.lblSize.Text = "SIZE:";
            // 
            // txtMoTaSanPham
            // 
            this.txtMoTaSanPham.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtMoTaSanPham.Location = new System.Drawing.Point(31, 189);
            this.txtMoTaSanPham.Multiline = true;
            this.txtMoTaSanPham.Name = "txtMoTaSanPham";
            this.txtMoTaSanPham.Size = new System.Drawing.Size(362, 64);
            this.txtMoTaSanPham.TabIndex = 3;
            // 
            // lblMoTaSanPham
            // 
            this.lblMoTaSanPham.AutoSize = true;
            this.lblMoTaSanPham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMoTaSanPham.Location = new System.Drawing.Point(27, 164);
            this.lblMoTaSanPham.Name = "lblMoTaSanPham";
            this.lblMoTaSanPham.Size = new System.Drawing.Size(183, 22);
            this.lblMoTaSanPham.TabIndex = 83;
            this.lblMoTaSanPham.Text = "MÔ TẢ SẢN PHẨM:";
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SanPham";
            this.Size = new System.Drawing.Size(1153, 626);
            this.Load += new System.EventHandler(this.SanPham_Load_1);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSanPham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNgaySanXuat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtMaSanPham;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblMaSanPham;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.TextBox txtGiaSanPham;
        private System.Windows.Forms.Label lblGiaSanPham;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtMoTaSanPham;
        private System.Windows.Forms.Label lblMoTaSanPham;
        private System.Windows.Forms.TextBox txtAnhSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.DateTimePicker txtNgaySanXuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvDSSanPham;
    }
}
