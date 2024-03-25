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
    public partial class KhachHang : UserControl
    {
        public KhachHang()
        {
            InitializeComponent();
        }
        Class_KhachHang sql = new Class_KhachHang();
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VV7F55B\\SQLEXPRESS;Initial Catalog=SHOPQUANAO;Integrated Security=True");
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PKGEMFS\\HIEUNE;Initial Catalog=SHOPQUANAO;Integrated Security=True");
        SqlDataAdapter adap = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public void LoadDuLieu()
        {
            dt.Clear();
            SqlCommand cm = new SqlCommand("SELECT makh,tenkhach,gioitinh,diachi,sdt FROM KhachHang", conn);
            adap.SelectCommand = cm;
            adap.Fill(dt);
            dgvDSKhachHang.DataSource = dt;
        }

        public void LayDuLieuLenTextBox()
        {
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDSKhachHang.DataSource, "diachi");

            txtMaKhach.DataBindings.Clear();
            txtMaKhach.DataBindings.Add("Text", dgvDSKhachHang.DataSource, "makh");

            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dgvDSKhachHang.DataSource, "sdt");

            txtTenKhach.DataBindings.Clear();
            txtTenKhach.DataBindings.Add("Text", dgvDSKhachHang.DataSource, "tenkhach");

            cbbGioiTinh.DataBindings.Clear();
            cbbGioiTinh.DataBindings.Add("Text", dgvDSKhachHang.DataSource, "gioitinh");
        }

        public void DisableTextBox()
        {
            txtDiaChi.Enabled = false;
            txtMaKhach.Enabled = false;
            txtSDT.Enabled = false;
            txtTenKhach.Enabled = false;
        }

        public void DisableComboBox()
        {
            cbbGioiTinh.Enabled = false;
        }

        public void EnableTextBox()
        {
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
            txtTenKhach.Enabled = true;
        }

        public void EnableComboBox()
        {
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
            txtMaKhach.Text = "";
            txtSDT.Text = "";
            txtTenKhach.Text = "";
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
                    string tenkh = txtTenKhach.Text;
                    string gioitinh = cbbGioiTinh.Text;
                    string diachi = txtDiaChi.Text;
                    string sdt = txtSDT.Text;

                    if (tenkh == "")
                    {
                        MessageBox.Show("Vui lòng điền 'tên khách hàng'");
                        return;
                    }
                    if (diachi == "")
                    {
                        MessageBox.Show("Vui lòng điền 'địa chi của khách hàng'");
                        return;
                    }
                    if (sdt == "")
                    {
                        MessageBox.Show("Vui lòng điền 'sđt của khách hàng'");
                        return;
                    }
                    sql.Them(tenkh, diachi, gioitinh, sdt);
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
                string makh = txtMaKhach.Text;
                string tenkh = txtTenKhach.Text;
                string gioitinh = cbbGioiTinh.Text;
                string diachi = txtDiaChi.Text;
                string sdt = txtSDT.Text;

                if (makh == "")
                {
                    MessageBox.Show("Vui lòng điền 'mã khách hàng'");
                    return;
                }
                if (tenkh == "")
                {
                    MessageBox.Show("Vui lòng điền 'tên khách hàng'");
                    return;
                }
                if (diachi == "")
                {
                    MessageBox.Show("Vui lòng điền 'địa chi của khách hàng'");
                    return;
                }
                if (sdt == "")
                {
                    MessageBox.Show("Vui lòng điền 'sđt của khách hàng'");
                    return;
                }

                sql.Sua(tenkh, diachi, gioitinh, sdt,makh);
                LoadDuLieu();

                DisableTextBox();
                DisableComboBox();
                btnSua.Text = "SỬA";
                DisableHuyButton();
                EnableThemButton();
                EnableXoaButton();
            }
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            conn.Open();
            LoadDuLieu();
            conn.Close();
            DisableTextBox();
            DisableComboBox();
            LayDuLieuLenTextBox();
            DisableHuyButton();
            txtMaKhach.Enabled = false;
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (sql.ktKhoaNgoai(txtMaKhach.Text) == false)
                {
                    MessageBox.Show("khách hàng đang đặt hàng, vui lòng thanh toán rồi xóa!!");
                    return;
                }
                sql.Xoa(txtMaKhach.Text);
                LoadDuLieu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất Bại!!");
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dt.Clear();
            SqlCommand cm = new SqlCommand("SELECT makh,tenkhach,gioitinh,diachi,sdt FROM KhachHang where tenkhach like N'%" + txt_tenkh.Text+ "%'", conn);
            adap.SelectCommand = cm;
            adap.Fill(dt);
            dgvDSKhachHang.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
        }




    }
}
