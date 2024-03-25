using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSHOPQUANAO
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            TrangChuUC.BringToFront();
            lblTieuDe.Text = "TRANG CHỦ";
            btn_TrangChu.BackColor = Color.Tomato;
            
        }
        private string tennv_nhan;
        private string chucvu_nhan;

        public Main(string tennv, string chucvu)
            : this()
        {
            tennv_nhan = tennv;
            chucvu_nhan = chucvu;
            textBox2.Text = tennv_nhan;
            textBox1.Text = chucvu_nhan;

            if (chucvu.Equals("QUẢN LÝ") || chucvu.Equals("NHÂN VIÊN"))
            {
                btn_NhanVien.Enabled = false;
            }
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            TrangChuUC.BringToFront();
            lblTieuDe.Text = "TRANG CHỦ";
            btn_TrangChu.BackColor = Color.Tomato;
            btn_SanPham.BackColor = Color.White;
            btn_NhanVien.BackColor = Color.White;
            btn_CTHoaDon.BackColor = Color.White;
            btn_KhachHang.BackColor = Color.White;
            btn_HoaDon.BackColor = Color.White;
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            SanPhamUC.BringToFront();
            lblTieuDe.Text = "SẢN PHẨM";
            btn_SanPham.BackColor = Color.Tomato;
            btn_NhanVien.BackColor = Color.White;
            btn_TrangChu.BackColor = Color.White;
            btn_CTHoaDon.BackColor = Color.White;
            btn_KhachHang.BackColor = Color.White;
            btn_HoaDon.BackColor = Color.White;
        }

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Form f = new DangNhap();
                f.Show();
            }
            
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            KhachHangUC.BringToFront();
            lblTieuDe.Text = "KHÁCH HÀNG";
            btn_KhachHang.BackColor = Color.Tomato;
            btn_TrangChu.BackColor = Color.White;
            btn_SanPham.BackColor = Color.White;
            btn_CTHoaDon.BackColor = Color.White;
            btn_NhanVien.BackColor = Color.White;
            btn_HoaDon.BackColor = Color.White;
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            NhanVienUC.BringToFront();
            lblTieuDe.Text = "NHÂN VIÊN";
            btn_NhanVien.BackColor = Color.Tomato;
            btn_TrangChu.BackColor = Color.White;
            btn_SanPham.BackColor = Color.White;
            btn_CTHoaDon.BackColor = Color.White;
            btn_KhachHang.BackColor = Color.White;
            btn_HoaDon.BackColor = Color.White;
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            CTHoaDonUC.BringToFront();
            lblTieuDe.Text = "CHI TIẾT HÓA ĐƠN";
            btn_CTHoaDon.BackColor = Color.Tomato;
            btn_SanPham.BackColor = Color.White;
            btn_NhanVien.BackColor = Color.White;
            btn_TrangChu.BackColor = Color.White;
            btn_KhachHang.BackColor = Color.White;
            btn_HoaDon.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HoaDonUC.BringToFront();
            lblTieuDe.Text = "HÓA ĐƠN";
            btn_HoaDon.BackColor = Color.Tomato;
            btn_SanPham.BackColor = Color.White;
            btn_NhanVien.BackColor = Color.White;
            btn_TrangChu.BackColor = Color.White;
            btn_KhachHang.BackColor = Color.White;
            btn_CTHoaDon.BackColor = Color.White;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            CTHoaDonUC.BringToFront();
        }

        private void HoaDonUC_Load(object sender, EventArgs e)
        {

        }
    }
}
