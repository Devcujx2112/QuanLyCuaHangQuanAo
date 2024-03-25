using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSHOPQUANAO
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        public static string ktchucVu = "";
        public static string ktTen = "";
        public static string ktmanv = "";
        private void btnExit_Click(object sender, EventArgs e)
        {
            Main m = new Main();
            m.Show();
            m.CTHoaDonUC.BringToFront();
            ////if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            ////{
            ////    Application.Exit();
            ////}
         
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // lấy dữ liệu từ textbox
            string tendn = txtTenDN.Text;
            string matkhau = txtMatKhau.Text;
            //kết nối csdl
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VV7F55B\\SQLEXPRESS;Initial Catalog=SHOPQUANAO;Integrated Security=True");
            //string str = "Data Source=DESKTOP-PKGEMFS\\HIEUNE;Initial Catalog=SHOPQUANAO;Integrated Security=True";
            //SqlConnection conn = new SqlConnection(str);
            conn.Open();
            //truy vấn dữ liệu
            SqlCommand cmd = new SqlCommand("select matkhau, tennhanvien, chucvu,manhanvien from NhanVien where tendangnhap = '" + tendn + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            //so sánh password
            if (reader.HasRows)//nếu không có hàng nó sẽ không đọc
            {
                reader.Read();
                if (reader.GetString(0) == matkhau)
                {
                    string tennv = reader.GetString(1);
                    string chucvu = reader.GetString(2);
                    string manv = reader.GetString(3);
                    MessageBox.Show("Đăng Nhập thành công!" + "\t\n" + "Xin chào " + "'" + chucvu + "'" + " " + tennv + "!");
                    // kiem tra chức vụ 
                    ktchucVu = chucvu;
                    // kiem tra tên
                    ktTen = tennv;
                    ktmanv = manv;
                    // gọi Main lên và truyền tham số tennv và chucvu qua frmMain
                    Main f = new Main(tennv, chucvu); 
                    this.Hide();
                    f.ShowDialog();
                    
                    this.Show();
                }
                else
                { 
                    MessageBox.Show("Mật khẩu sai!");
                    txtMatKhau.Text = null;
                    txtMatKhau.Focus();
                }
            }
            else
            {
                MessageBox.Show("Người dùng không hợp lệ!");
                txtMatKhau.Text = null;
                txtTenDN.Text = null;
                txtTenDN.Focus();
            }
            reader.Close();
        }
        private void txtTenDN_Click(object sender, EventArgs e)
        {
            txtTenDN.Text = null;
        }
        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.Text = null;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTenDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
