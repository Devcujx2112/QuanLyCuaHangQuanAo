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
    public partial class HoaDon : UserControl
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VV7F55B\\SQLEXPRESS;Initial Catalog=SHOPQUANAO;Integrated Security=True");
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PKGEMFS\\HIEUNE;Initial Catalog=SHOPQUANAO;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public void LoadDuLieu()
        {
            dt.Clear();
            SqlCommand cm = new SqlCommand("select * from HoaDon", conn);
            da.SelectCommand = cm;
            da.Fill(dt);
            dgvHoaDon.DataSource = dt;
        }

        public void LayDuLieuLenTextBox()
        {
            txtSoHD.DataBindings.Clear();
            txtSoHD.DataBindings.Add("Text", dgvHoaDon.DataSource, "sohd");

            txtMaNV.DataBindings.Clear();
            txtMaNV.DataBindings.Add("Text", dgvHoaDon.DataSource, "manhanvien");

            cbbNhanVienLap.DataBindings.Clear();
            cbbNhanVienLap.DataBindings.Add("Text", dgvHoaDon.DataSource, "nhanvienlap");

            txtNgayLapHD.DataBindings.Clear();
            txtNgayLapHD.DataBindings.Add("Text", dgvHoaDon.DataSource, "ngaylap");

            txtMaKH.DataBindings.Clear();
            txtMaKH.DataBindings.Add("Text", dgvHoaDon.DataSource, "makh");
        }

        public void DisableTextBox()
        {
            txtSoHD.Enabled = false;
            txtMaNV.Enabled = false;
            cbbNhanVienLap.Enabled = false;
            txtNgayLapHD.Enabled = false;
            txtMaKH.Enabled = false;
        }

        public void EnableTextBox()
        {
            txtSoHD.Enabled = true;
            //txtMaNV.Enabled = true;
            //cbbNhanVienLap.Enabled = true;
            txtNgayLapHD.Enabled = true;
            txtMaKH.Enabled = true;
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
            txtSoHD.Text = "";
            txtMaNV.Text = "";
            txtNgayLapHD.Text = "";
            txtMaKH.Text = "";
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
        }
        public bool ktKhoaChinh(string a)
        {
            try
            {
                string sql = "select count(*) from hoadon where sohd= '" + a + "'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int sl = (int)cmd.ExecuteScalar();
                conn.Close();
                if (sl >= 1)
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ktKhoaNgoaiNhanVien(string a)
        {
            try
            {
                string sql = "select count(*) from nhanvien where manhanvien= '" + a + "'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int sl = (int)cmd.ExecuteScalar();
                conn.Close();
                if (sl >= 1)
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ktKhoaNgoaiKhachHang(string a)
        {
            try
            {
                string sql = "select count(*) from khachhang where makh= '" + a + "'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int sl = (int)cmd.ExecuteScalar();
                conn.Close();
                if (sl >= 1)
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text.Equals("THÊM"))
            {
                LayDuLieuLenTextBox();
                EnableTextBox();
                XoaTrang();
                btnThem.Text = "LƯU";
                txtMaNV.Text = DangNhap.ktmanv;
                cbbNhanVienLap.Text = DangNhap.ktTen;
                EnableHuyButton();
                DisableSuaButton();
                DisableXoaButton();
            }
            else if (btnThem.Text.Equals("LƯU"))
            {
                try
                {
                    string sohd = txtSoHD.Text;
                    string ngaylap = txtNgayLapHD.Value.ToString("MM/dd/yyyy");
                    string manv = txtMaNV.Text;
                    string nhanvien = cbbNhanVienLap.Text;
                    string makhach = txtMaKH.Text;

                    if (sohd == "")
                    {
                        MessageBox.Show("Vui lòng điền 'số hóa đơn'");
                        return;
                    }
                    if (ngaylap == "")
                    {
                        MessageBox.Show("Vui lòng điền 'ngày lập hóa đơn'");
                        return;
                    }
                    if (nhanvien == "")
                    {
                        MessageBox.Show("Vui lòng điền 'nhân viên lập hóa đơn'");
                        return;
                    }
                    if (manv == "")
                    {
                        MessageBox.Show("Vui lòng điền 'mã nhân viên'");
                        return;
                    }
                    if (makhach == "")
                    {
                        MessageBox.Show("Vui lòng điền 'mã khách hàng'");
                        return;
                    }
                    if (ktKhoaChinh(sohd)==false)
                    {
                        MessageBox.Show("Số hóa đơn đã tồn tại!!");
                        return;
                    }
                    if (ktKhoaNgoaiNhanVien(manv) == true)
                    {
                        MessageBox.Show("Nhân viên không tồn tại!!");
                        return;
                    }
                    if (ktKhoaNgoaiKhachHang(makhach) == true)
                    {
                        MessageBox.Show("Khách hàng không tồn tại!!");
                        return;
                    }
                    conn.Open();
                    string str_them = "INSERT INTO HoaDon VALUES ('" + sohd + "', '" + manv + "', N'" + nhanvien + "', '" + ngaylap + "', " + makhach + ")";
                    SqlCommand cmd = new SqlCommand(str_them, conn);
                    cmd.ExecuteNonQuery();
                    LoadDuLieu();
                    
                    DisableTextBox();
                    btnThem.Text = "THÊM";
                    DisableHuyButton();
                    EnableSuaButton();
                    EnableXoaButton();
                    conn.Close();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text.Equals("SỬA"))
            {
                LayDuLieuLenTextBox();

                EnableTextBox();
                DisableThemButton();
                DisableXoaButton();
                btnSua.Text = "LƯU";
                EnableHuyButton();
            }
            else
            {
                string sohd = txtSoHD.Text;
                string ngaylap = txtNgayLapHD.Value.ToString("MM/dd/yyyy");
                string manv = txtMaNV.Text;
                string nhanvien = cbbNhanVienLap.Text;
                string makhach = txtMaKH.Text;

                if (sohd == "")
                {
                    MessageBox.Show("Vui lòng điền 'số hóa đơn'");
                    return;
                }
                if (ngaylap == "")
                {
                    MessageBox.Show("Vui lòng điền 'ngày lập hóa đơn'");
                    return;
                }
                if (nhanvien == "")
                {
                    MessageBox.Show("Vui lòng điền 'nhân viên lập hóa đơn'");
                    return;
                }
                if (manv == "")
                {
                    MessageBox.Show("Vui lòng điền 'mã nhân viên'");
                    return;
                }
                if (makhach == "")
                {
                    MessageBox.Show("Vui lòng điền 'mã khách hàng'");
                    return;
                }
                try
                {
                    if (ktKhoaChinh(sohd) == true)
                    {
                        MessageBox.Show("Số hóa đơn không tồn tại !!");
                        return;
                    }
                    conn.Open();
                    string str_sua = "UPDATE HoaDon SET ngaylap = '" + ngaylap + "', nhanvienlap = N'" + nhanvien + "', makh = " + makhach + ", manhanvien = N'" + manv + "' WHERE sohd = '" + sohd + "'";
                    SqlCommand cmd = new SqlCommand(str_sua, conn);
                    cmd.ExecuteNonQuery();
                    LoadDuLieu();

                    DisableTextBox();
                    btnSua.Text = "SỬA";
                    DisableHuyButton();
                    EnableThemButton();
                    EnableXoaButton();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi!!");
                    MessageBox.Show(ex.ToString());
                    conn.Close();
                }
            }
        }
        public bool ktKhoaNgoaiCTHD(string a)
        {
            try
            {
                string sql = "select count(*) from CThoadon where sohd= '" + a + "'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int sl = (int)cmd.ExecuteScalar();
                conn.Close();
                if (sl >= 1)
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sohd = txtSoHD.Text;
                if (ktKhoaNgoaiCTHD(sohd) == false)
                {
                    MessageBox.Show("Số hóa đơn đã tồn tại trong Chi Tiết Hóa Đơn!!");
                    return;
                }
                conn.Open();
                string str_xoa = "DELETE FROM HoaDon WHERE sohd = '" + sohd + "' ";
                SqlCommand cmd = new SqlCommand(str_xoa, conn);
                cmd.ExecuteNonQuery();
                LoadDuLieu();
                conn.Close();
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
            LoadDuLieu();
            LayDuLieuLenTextBox();
            DisableTextBox();
        }
    }
}
