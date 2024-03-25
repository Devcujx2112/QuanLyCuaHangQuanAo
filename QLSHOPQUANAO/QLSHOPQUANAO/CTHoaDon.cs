using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLSHOPQUANAO
{
    public partial class CTHoaDon : UserControl
    {
        public CTHoaDon()
        {
            InitializeComponent();
        }
        Class_CTHoaDon sql = new Class_CTHoaDon();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VV7F55B\\SQLEXPRESS;Initial Catalog=SHOPQUANAO;Integrated Security=True");
       //s SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PKGEMFS\\HIEUNE;Initial Catalog=SHOPQUANAO;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public void LoadDuLieu()
        {
            dt.Clear();
            SqlCommand cm = new SqlCommand("select masanpham,sanpham,dongia,soluong,tongtien from CTHoaDon where sohd='" + txtSoHD.Text+ "'", conn);
            da.SelectCommand = cm;
            da.Fill(dt);
            dgvHoaDon.DataSource = dt;
        }

        //load combobox
        private void LayDuLieuSanPham()
        {
            string query = "SELECT * FROM SanPham";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);

            DataTable tb = new DataTable();
            adap.Fill(tb);

            cbbTenSanPham.DataSource = tb;
            cbbTenSanPham.DisplayMember = "motasanpham";

            txtDonGia.DataSource = tb;
            txtDonGia.DisplayMember = "giasanpham";

            txtMaSP.DataSource = tb;
            txtMaSP.DisplayMember = "masanpham";

        }
        //load combobox
        private void LayDuLieuHoaDon()
        {
            string query = "SELECT * FROM hoadon";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);

            DataTable tb = new DataTable();
            adap.Fill(tb);

            txtSoHD.DataSource = tb;
            txtSoHD.DisplayMember = "sohd";

        }
        public void LayDuLieuLenTextBox()
        {
            //txtSoHD.DataBindings.Clear();
           // txtSoHD.DataBindings.Add("Text", dgvHoaDon.DataSource, "sohd");

            txtMaSP.DataBindings.Clear();
            txtMaSP.DataBindings.Add("Text", dgvHoaDon.DataSource, "masanpham");

            cbbTenSanPham.DataBindings.Clear();
            cbbTenSanPham.DataBindings.Add("Text", dgvHoaDon.DataSource, "sanpham");

            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dgvHoaDon.DataSource, "soluong");

            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dgvHoaDon.DataSource, "dongia");

        }

        public void DisableTextBox()
        {
            txtDonGia.Enabled = false;
            txtSoLuong.Enabled = false;
            //txtSoHD.Enabled = false;
            txtNgayLapHD.Enabled = false;
            cbbTenSanPham.Enabled = false;
            txtMaSP.Enabled = false;
            txtMaNV.Enabled = false;
            cbbNhanVienLap.Enabled = false;
            txtNgayLapHD.Enabled = false;
            txtMaKH.Enabled = false;
        }

        public void DisableComboBox()
        {
            cbbTenSanPham.Enabled = false;
        }

        public void EnableTextBox()
        {
            txtSoLuong.Enabled = true;
            txtNgayLapHD.Enabled = true;
            cbbTenSanPham.Enabled = true;
            txtDonGia.Enabled = false;
        }


        public void EnableTextBox2()
        {
            txtSoLuong.Enabled = true;
        }

        public void EnableComboBox()
        {
            cbbTenSanPham.Enabled = true;
        }

        public void EnableHuyButton()
        {
            btnHuy.Enabled = true;
            btnHuy.BackColor = Color.DeepSkyBlue;
        }
        public void DisableHuyButton()
        {
            btnHuy.Enabled = false;
            btnHuy.BackColor = Color.White;
        }

        public void DisableThemButton()
        {
            btnThem.Enabled = false;
            btnThem.BackColor = Color.White;
        }
        public void EnableThemButton()
        {
            btnThem.Enabled = true;
            btnThem.BackColor = Color.Turquoise;
        }

        public void EnableSuaButton()
        {
            btnSua.Enabled = true;
            btnSua.BackColor = Color.RoyalBlue;
        }
        public void DisableSuaButton()
        {
            btnSua.Enabled = false;
            btnSua.BackColor = Color.White;
        }

        public void DisableXoaButton()
        {
            btnXoa.Enabled = false;
            btnXoa.BackColor = Color.White;
        }
        public void EnableXoaButton()
        {
            btnXoa.Enabled = true;
            btnXoa.BackColor = Color.Tomato;
        }

        public void XoaTrang()
        {
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text.Equals("THÊM"))
            {
                LayDuLieuSanPham();
                LayDuLieuLenTextBox();
                EnableComboBox();
                EnableTextBox2();
                XoaTrang();
                btnThem.Text = "LƯU";

                cbbNhanVienLap.Text =DangNhap.ktTen;
                EnableHuyButton();
                DisableSuaButton();
                DisableXoaButton();
                cbbTenSanPham.Text = "";
            }
            else if (btnThem.Text.Equals("LƯU"))
            {
                try
                {
                    string sohd = txtSoHD.Text;
                    string masanpham = txtMaSP.Text;
                    string sanpham = cbbTenSanPham.Text;
                    float dongia = float.Parse(txtDonGia.Text);
                    float soluong = float.Parse(txtSoLuong.Text);
                    float tongtien = dongia * soluong;

                    if (masanpham == "")
                    {
                        MessageBox.Show("Vui lòng điền 'mã sản phẩm");
                        return;
                    }
                    if (txtDonGia.Text == "")
                    {
                        MessageBox.Show("Vui lòng chọn 'sản phẩm'");
                        return;
                    }
                    if (soluong.Equals(""))
                    {
                        MessageBox.Show("Vui lòng điền 'số lượng'");
                        return;
                    }

                    sql.Them(sohd,  masanpham,  sanpham,  dongia.ToString(),  soluong.ToString(),  tongtien.ToString());
                    LoadDuLieu();

                    DisableTextBox();
                    DisableComboBox();
                    btnThem.Text = "THÊM";
                    DisableHuyButton();
                    EnableSuaButton();
                    EnableXoaButton();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
            LayDuLieuLenTextBox();

            if (btnThem.Text.Equals("LƯU"))
            {
                btnThem.Text = "THÊM";
                EnableSuaButton();
                EnableXoaButton();
            }
            if (btnSua.Text.Equals("LƯU"))
            {
                btnSua.Text = "SỬA";
                EnableXoaButton();
                EnableThemButton();
            }

            DisableHuyButton();
            DisableTextBox();
            DisableComboBox();
        }
        
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text.Equals("SỬA"))
            {
                LayDuLieuLenTextBox();

                EnableComboBox();
                EnableTextBox();
                DisableThemButton();
                DisableXoaButton();
                btnSua.Text = "LƯU";
                EnableHuyButton();
            }
            else
            {
                string sohd = txtSoHD.Text;
                string masanpham = txtMaSP.Text;
                string sanpham = cbbTenSanPham.Text;
                float dongia = float.Parse(txtDonGia.Text);
                float soluong = float.Parse(txtSoLuong.Text);
                float tongtien = dongia * soluong;

                if (masanpham == "")
                {
                    MessageBox.Show("Vui lòng chọn 'sản phẩm'");
                    return;
                }
                if (txtDonGia.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn 'sản phẩm'");
                    return;
                }
                if (soluong.Equals(""))
                {
                    MessageBox.Show("Vui lòng điền 'số lượng'");
                    return;
                }

                try
                {
                    sql.Sua(sohd, masanpham, sanpham, dongia.ToString(), soluong.ToString(), tongtien.ToString());
                    LoadDuLieu();

                    DisableTextBox();
                    DisableComboBox();
                    btnSua.Text = "SỬA";
                    DisableHuyButton();
                    EnableThemButton();
                    EnableXoaButton();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!!");
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
            string sohd = txtSoHD.Text;
            string masanpham = txtMaSP.Text;
            sql.Xoa(sohd,masanpham);
            LoadDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất Bại!!");
                MessageBox.Show(ex.ToString());
                conn.Close();
            }
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            
            conn.Open();
            DisableTextBox();
            DisableComboBox();
            
            DisableHuyButton();
            LayDuLieuSanPham();
            LayDuLieuHoaDon();
            LoadDuLieu();
            LayDuLieuLenTextBox();
            LayDuLieumanv();
            LayDuLieumakh();
            LayDuLieunhanvienlap();
            LayDuLieungaylap();

            
            cbbNhanVienLap.Enabled = false;
            conn.Close();
        }
        private void LayDuLieumanv()
        {
            string sql = @"select manhanvien from hoadon where sohd = '" + txtSoHD.Text.Trim() + "'";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable dtbl = new DataTable();
            dap.Fill(dtbl);
            if (dt.Rows.Count > 0)
            {
                txtMaNV.Text = dtbl.Rows[0]["manhanvien"].ToString().Trim();
            }
            else
            {
                //MessageBox.Show("Không tìm thấy thông tin", "Thông báo !");
                return;
            }
        }
        private void LayDuLieumakh()
        {
            string sql = @"select makh from hoadon where sohd = '" + txtSoHD.Text.Trim() + "'";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable dtbl = new DataTable();
            dap.Fill(dtbl);
            if (dt.Rows.Count > 0)
            {
                txtMaKH.Text = dtbl.Rows[0]["makh"].ToString().Trim();
            }
            else
            {
                //MessageBox.Show("Không tìm thấy thông tin", "Thông báo !");
                return;
            }
        }
        private void LayDuLieunhanvienlap()
        {
            string sql = @"select nhanvienlap from hoadon where sohd = '" + txtSoHD.Text.Trim() + "'";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable dtbl = new DataTable();
            dap.Fill(dtbl);
            if (dt.Rows.Count > 0)
            {
                cbbNhanVienLap.Text = dtbl.Rows[0]["nhanvienlap"].ToString().Trim();
            }
            else
            {
               // MessageBox.Show("Không tìm thấy thông tin", "Thông báo !");
                return;
            }
        }
        private void LayDuLieungaylap()
        {
            string sql = @"select ngaylap from hoadon where sohd = '" + txtSoHD.Text.Trim() + "'";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable dtbl = new DataTable();
            dap.Fill(dtbl);
            if (dt.Rows.Count > 0)
            {
                txtNgayLapHD.Text = dtbl.Rows[0]["ngaylap"].ToString().Trim();
            }
            else
            {
              // MessageBox.Show("Không tìm thấy thông tin", "Thông báo !");
                return;
            }
        }
        private void dgvHoaDon_Click(object sender, EventArgs e)
        {
            LayDuLieumanv();
            LayDuLieumakh();
            LayDuLieunhanvienlap();
            LayDuLieungaylap();
        }

        private void txtSoHD_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
            LayDuLieumanv();
            LayDuLieumakh();
            LayDuLieunhanvienlap();
            LayDuLieungaylap();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt.Clear();
            SqlCommand cm = new SqlCommand("select masanpham,sanpham,dongia,soluong,tongtien from CTHoaDon where sohd='" + txtSoHD.Text + "'", conn);
            da.SelectCommand = cm;
            da.Fill(dt);
            dgvHoaDon.DataSource = dt;
            LayDuLieumanv();
            LayDuLieumakh();
            LayDuLieunhanvienlap();
            LayDuLieungaylap();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ThongKe().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LayDuLieuHoaDon();
        }

    }
}
