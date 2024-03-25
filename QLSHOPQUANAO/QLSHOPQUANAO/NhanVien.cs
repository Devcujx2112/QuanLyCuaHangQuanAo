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
    public partial class NhanVien : UserControl
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        Class_NhanVien sql = new Class_NhanVien();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VV7F55B\\SQLEXPRESS;Initial Catalog=SHOPQUANAO;Integrated Security=True");
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PKGEMFS\\HIEUNE;Initial Catalog=SHOPQUANAO;Integrated Security=True");
        SqlDataAdapter adap = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public void LoadDuLieu()
        {
            dt.Clear();
            SqlCommand cm = new SqlCommand("SELECT manhanvien, tennhanvien, gioitinh, ngaysinh, diachi, sdt, tendangnhap, matkhau, chucvu FROM NhanVien", conn);
            adap.SelectCommand = cm;
            adap.Fill(dt);
            dgvDSNhanVien.DataSource = dt;
        }

        public void LayDuLieuLenTextBox()
        {
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "diachi");

            txtMaNhanVien.DataBindings.Clear();
            txtMaNhanVien.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "manhanvien");

            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "matkhau");

            txtNgaySinh.DataBindings.Clear();
            txtNgaySinh.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "ngaysinh");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "sdt");

            txtTenDangNhap.DataBindings.Clear();
            txtTenDangNhap.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "tendangnhap");

            txtTenNhanVien.DataBindings.Clear();
            txtTenNhanVien.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "tennhanvien");

            cbbChucVu.DataBindings.Clear();
            cbbChucVu.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "chucvu");

            cbbGioiTinh.DataBindings.Clear();
            cbbGioiTinh.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "gioitinh");
        }

        public void DisableTextBox()
        {
            txtDiaChi.Enabled = false;
            txtMaNhanVien.Enabled = false;
            txtMatKhau.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtSDT.Enabled = false;
            txtTenDangNhap.Enabled = false;
            txtTenNhanVien.Enabled = false;
        }

        public void DisableComboBox()
        {
            cbbChucVu.Enabled = false;
            cbbGioiTinh.Enabled = false;
        }

        public void EnableTextBox()
        {
            txtDiaChi.Enabled = true;
            txtMaNhanVien.Enabled = true;
            txtMatKhau.Enabled = true;
            txtNgaySinh.Enabled = true;
            txtSDT.Enabled = true;
            txtTenDangNhap.Enabled = true;
            txtTenNhanVien.Enabled = true;
        }

        public void EnableComboBox()
        {
            cbbChucVu.Enabled = true;
            cbbGioiTinh.Enabled = true;
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
            txtDiaChi.Text = "";
            txtMaNhanVien.Text = "";
            txtMatKhau.Text = "";
            txtNgaySinh.Text = "";
            txtSDT.Text = "";
            txtTenDangNhap.Text = "";
            txtTenNhanVien.Text = "";
            cbbChucVu.Text = "Chủ quán";
            cbbGioiTinh.Text = "Nam";
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text.Equals("THÊM"))
            {
                EnableComboBox();
                EnableTextBox();
                XoaTrang();
                btnThem.Text = "LƯU";

                EnableHuyButton();
                DisableSuaButton();
                DisableXoaButton();

            }
            else if (btnThem.Text.Equals("LƯU"))
            {
                try
                {
                    // lấy dữ liệu từ textBox
                    string manv = txtMaNhanVien.Text;
                    string tennv = txtTenNhanVien.Text;
                    string gioitinh = cbbGioiTinh.Text;
                    string ngaysinh = txtNgaySinh.Value.ToString("MM/dd/yyyy");
                    string diachi = txtDiaChi.Text;
                    string sdt = txtSDT.Text;
                    string tendn = txtTenDangNhap.Text;
                    string matkhau = txtMatKhau.Text;
                    string chucvu = cbbChucVu.Text;

                    if (manv == "")
                    {
                        MessageBox.Show("Vui lòng điền 'mã nhân viên'");
                        return;
                    }
                    if (tennv == "")
                    {
                        MessageBox.Show("Vui lòng điền 'tên nhân viên'");
                        return;
                    }
                    if (ngaysinh == "")
                    {
                        MessageBox.Show("Vui lòng điền 'năm sinh nhân viên'");
                        return;
                    }
                    if (diachi == "")
                    {
                        MessageBox.Show("Vui lòng điền 'địa chi của nhân viên'");
                        return;
                    }
                    if (sdt == "")
                    {
                        MessageBox.Show("Vui lòng điền 'sđt của nhân viên'");
                        return;
                    }
                    if (tendn == "")
                    {
                        MessageBox.Show("Vui lòng điền 'tên đăng nhập của nhân viên'");
                        return;
                    }
                    if (matkhau == "")
                    {
                        MessageBox.Show("Vui lòng điền 'mật khẩu của nhân viên'");
                        return;
                    }
                    if (matkhau == "")
                    {
                        MessageBox.Show("Vui lòng điền 'mật khẩu của nhân viên'");
                        return;
                    }
                    if (sql.ktKhoaChinh(manv) == false)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại !!");
                        return;
                    }
                    sql.Them(manv , tennv , gioitinh , ngaysinh , diachi , sdt, tendn , matkhau , chucvu);
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
                    MessageBox.Show("Thất Bại!");
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text.Equals("SỬA"))
            {
                EnableComboBox();
                EnableTextBox();

                DisableThemButton();
                DisableXoaButton();

                btnSua.Text = "LƯU";

                EnableHuyButton();
            }
            else
            {
                // lấy dữ liệu từ textBox
                string manv = txtMaNhanVien.Text;
                string tennv = txtTenNhanVien.Text;
                string gioitinh = cbbGioiTinh.Text;
                string ngaysinh = txtNgaySinh.Value.ToString("MM/dd/yyyy");
                string diachi = txtDiaChi.Text;
                string sdt = txtSDT.Text;
                string tendn = txtTenDangNhap.Text;
                string matkhau = txtMatKhau.Text;
                string chucvu = cbbChucVu.Text;

                if (manv == "")
                {
                    MessageBox.Show("Vui lòng điền 'mã nhân viên'");
                    return;
                }
                if (tennv == "")
                {
                    MessageBox.Show("Vui lòng điền 'tên nhân viên'");
                    return;
                }
                if (ngaysinh == "")
                {
                    MessageBox.Show("Vui lòng điền 'năm sinh nhân viên'");
                    return;
                }
                if (diachi == "")
                {
                    MessageBox.Show("Vui lòng điền 'địa chi của nhân viên'");
                    return;
                }
                if (sdt == "")
                {
                    MessageBox.Show("Vui lòng điền 'sđt của nhân viên'");
                    return;
                }
                if (tendn == "")
                {
                    MessageBox.Show("Vui lòng điền 'tên đăng nhập của nhân viên'");
                    return;
                }
                if (matkhau == "")
                {
                    MessageBox.Show("Vui lòng điền 'mật khẩu của nhân viên'");
                    return;
                }
                if (sql.ktKhoaChinh(manv) == true)
                {
                    MessageBox.Show("Mã nhân viên không tồn tại !!");
                    return;
                }
                sql.Sua(manv, tennv, gioitinh, ngaysinh, diachi, sdt, tendn, matkhau, chucvu);
                LoadDuLieu();

                DisableTextBox();
                DisableComboBox();
                btnSua.Text = "SỬA";
                DisableHuyButton();
                EnableThemButton();
                EnableXoaButton();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            { 
            string manv = txtMaNhanVien.Text;
                sql.Xoa(manv);
                LoadDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất Bại!!");
                MessageBox.Show(ex.ToString());
            }
        }

        private void NhanVien_Load_1(object sender, EventArgs e)
        {
            conn.Open();
            LoadDuLieu();
            conn.Close();
            DisableTextBox();
            DisableComboBox();
            LayDuLieuLenTextBox();
            DisableHuyButton();
        }

    }
}
