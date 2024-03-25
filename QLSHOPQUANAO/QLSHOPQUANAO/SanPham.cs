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
using System.IO;

namespace QLSHOPQUANAO
{
    public partial class SanPham : UserControl
    {
        public SanPham()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VV7F55B\\SQLEXPRESS;Initial Catalog=SHOPQUANAO;Integrated Security=True");
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PKGEMFS\\HIEUNE;Initial Catalog=SHOPQUANAO;Integrated Security=True");
        SqlDataAdapter adap = new SqlDataAdapter();
        DataTable dt = new DataTable();

        private string chucvu;
        public string ChucVu
        {
            get { return chucvu; }
            set { chucvu = value; }
        }
        public void LoadDuLieu()
        {
            try { 
            dt.Clear();
            SqlCommand cm = new SqlCommand("SELECT * FROM SanPham", conn);
            adap.SelectCommand = cm;
            adap.Fill(dt);
            dgvDSSanPham.DataSource = dt;
                }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        public void LayDuLieuLenTextBox()
        {
            txtGiaSanPham.DataBindings.Clear();
            txtGiaSanPham.DataBindings.Add("Text", dgvDSSanPham.DataSource, "giasanpham");

            txtMaSanPham.DataBindings.Clear();
            txtMaSanPham.DataBindings.Add("Text", dgvDSSanPham.DataSource, "masanpham");

            txtTenSanPham.DataBindings.Clear();
            txtTenSanPham.DataBindings.Add("Text", dgvDSSanPham.DataSource, "tensanpham");

            txtMoTaSanPham.DataBindings.Clear();
            txtMoTaSanPham.DataBindings.Add("Text", dgvDSSanPham.DataSource, "motasanpham");

            txtSize.DataBindings.Clear();
            txtSize.DataBindings.Add("Text", dgvDSSanPham.DataSource, "size");

            txtNgaySanXuat.DataBindings.Clear();
            txtNgaySanXuat.DataBindings.Add("Text", dgvDSSanPham.DataSource, "ngaysanxuat");

            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dgvDSSanPham.DataSource, "soluong");

            txtAnhSP.DataBindings.Clear();
            txtAnhSP.DataBindings.Add("Text", dgvDSSanPham.DataSource, "anhsp");

            pictureBox1.DataBindings.Clear();
            pictureBox1.DataBindings.Add("Image", dgvDSSanPham.DataSource, "anhsp",true);

            // hiển thị hình ảnh sản phẩm lên PictureBox
            
        }
        public void dieuchinhrow()
        {
            dgvDSSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void XoaTrang()
        {
            txtSoLuong.Text = "";
            txtTenSanPham.Text = "";
            txtSize.Text = "";
            txtNgaySanXuat.Text = "";
            txtMoTaSanPham.Text = "";
            txtMaSanPham.Text = "";
            txtGiaSanPham.Text = "";
            txtAnhSP.Text = "";
            pictureBox1.Image = null;
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

        public void EnableTextBox()
        {
            txtGiaSanPham.Enabled = true;
            txtMaSanPham.Enabled = true;
            txtMoTaSanPham.Enabled = true;
            txtNgaySanXuat.Enabled = true;
            txtSize.Enabled = true;
            txtSoLuong.Enabled = true;
            txtTenSanPham.Enabled = true;
        }
        public void DisableTextBox()
        {
            txtGiaSanPham.Enabled = false;
            txtMaSanPham.Enabled = false;
            txtMoTaSanPham.Enabled = false;
            txtNgaySanXuat.Enabled = false;
            txtSize.Enabled = false;
            txtSoLuong.Enabled = false;
            txtTenSanPham.Enabled = false;
            txtAnhSP.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
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

            LoadDuLieu();
            LayDuLieuLenTextBox();
        }
        public bool ktKhoaChinh(string a)
        {
            try
            {
                conn.Open();
                string sql = "select count(*) from sanpham where masanpham= '" + a + "'";
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
            string masp = txtMaSanPham.Text;
            string tensp = txtTenSanPham.Text;
            string giasp = txtGiaSanPham.Text;
            string motasp = txtMoTaSanPham.Text;
            string size = txtSize.Text;
            string ngaysx = txtNgaySanXuat.Value.ToString("MM/dd/yyyy");
            string soluong = txtSoLuong.Text;
            string anhsp = txtAnhSP.Text;

                if (btnThem.Text.Equals("THÊM"))
                {
                    EnableTextBox();
                    XoaTrang();
                    
                    btnThem.Text = "LƯU";

                    EnableHuyButton();
                    DisableSuaButton();
                    DisableXoaButton();

                }
                else
                {
                    try
                    {
                        if (masp == "")
                        {
                            MessageBox.Show("Vui lòng điền 'mã sản phẩm'");
                            return;
                        }
                        if (tensp == "")
                        {
                            MessageBox.Show("Vui lòng điền 'tên sản phẩm'");
                            return;
                        }
                        if (giasp == "")
                        {
                            MessageBox.Show("Vui lòng điền 'giá sản phẩm'");
                            return;
                        }
                        if (motasp == "")
                        {
                            MessageBox.Show("Vui lòng điền 'mô tả sản phẩm'");
                            return;
                        }
                        if (size == "")
                        {
                            MessageBox.Show("Vui lòng điền 'size sản phẩm'");
                            return;
                        }
                        if (ngaysx == "")
                        {
                            MessageBox.Show("Vui lòng điền 'ngày sản xuất sản phẩm'");
                            return;
                        }
                        if (soluong == "")
                        {
                            MessageBox.Show("Vui lòng điền 'số lượng sản phẩm'");
                            return;
                        }
                        if (anhsp == "")
                        {
                            MessageBox.Show("Vui lòng chọn tệp ảnh");
                            return;
                        }
                        if (ktKhoaChinh(masp) == false)
                        {
                            MessageBox.Show("Mã sản phẩm đã tồn tại !!");
                            return;
                        }
                        conn.Open();
                        string str_them = "INSERT INTO SanPham VALUES ('" + masp + "', N'" + tensp + "', " + giasp + ", N'" + motasp + "','" + size + "','" + ngaysx + "', " + soluong + ", " + "@ANHSP" + ")";
                        SqlCommand cmd = new SqlCommand(str_them, conn);
                        cmd.Parameters.AddWithValue("@ANHSP",convertImageToBytes());
                        cmd.ExecuteNonQuery();
                        LoadDuLieu();
                        MessageBox.Show("Thành Công =))");
                        DisableTextBox();
                        btnThem.Text = "THÊM";

                        DisableHuyButton();
                        EnableSuaButton();
                        EnableXoaButton();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thất Bại!!");
                        MessageBox.Show(ex.Message);
                        conn.Close();
                    }
                }
        }
        private byte[] convertImageToBytes()
        {
            FileStream fs;
            fs = new FileStream(txtAnhSP.Text, FileMode.Open, FileAccess.Read);

            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (btnSua.Text.Equals("SỬA"))
            {
                EnableTextBox();

                DisableThemButton();
                DisableXoaButton();

                btnSua.Text = "LƯU";

                EnableHuyButton();
            }
            else if (btnSua.Text.Equals("LƯU"))
            {
                // lấy dữ liệu từ textBox
                string masp = txtMaSanPham.Text;
                string tensp = txtTenSanPham.Text;
                string giasp = txtGiaSanPham.Text;
                string motasp = txtMoTaSanPham.Text;
                string size = txtSize.Text;
                string ngaysx = txtNgaySanXuat.Value.ToString("MM/dd/yyyy");
                string soluong = txtSoLuong.Text;

                if (masp == "")
                {
                    MessageBox.Show("Vui lòng điền 'mã sản phẩm'");
                    return;
                }
                else if (tensp == "")
                {
                    MessageBox.Show("Vui lòng điền 'tên sản phẩm'");
                    return;
                }
                else if (giasp == "")
                {
                    MessageBox.Show("Vui lòng điền 'giá sản phẩm'");
                    return;
                }
                else if (motasp == "")
                {
                    MessageBox.Show("Vui lòng điền 'mô tả sản phẩm'");
                    return;
                }
                else if (size == "")
                {
                    MessageBox.Show("Vui lòng điền 'size sản phẩm'");
                    return;
                }
                else if (ngaysx == "")
                {
                    MessageBox.Show("Vui lòng điền 'ngày sản xuất sản phẩm'");
                    return;
                }
                else if (soluong == "")
                {
                    MessageBox.Show("Vui lòng điền 'số lượng sản phẩm'");
                    return;
                }
                else
                {
                    try
                    {
                        if (ktKhoaChinh(masp) == true)
                        {
                            MessageBox.Show("Mã sản phẩm không tồn tại !!");
                            return;
                        }
                        conn.Open();
                        string str_sua = "UPDATE SanPham SET tensanpham = N'" + tensp + "', giasanpham = '" + giasp + "', motasanpham =  N'" + motasp + "', size = '" + size + "', ngaysanxuat = '" + ngaysx + "', soluong = " + soluong + ",anhsp=@ANHSP WHERE masanpham = '" + masp + "' ";
                        SqlCommand cmd = new SqlCommand(str_sua, conn);
                        cmd.Parameters.AddWithValue("@ANHSP", convertImageToBytes());
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
                        MessageBox.Show("Thất Bại!!");
                        MessageBox.Show(ex.ToString());
                        conn.Close();
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try { 
            conn.Open();
            string masp = txtMaSanPham.Text;
            string str_xoa = "DELETE FROM SanPham WHERE masanpham = '" + masp + "' ";
            SqlCommand cmd = new SqlCommand(str_xoa, conn);
            cmd.ExecuteNonQuery();
            LoadDuLieu();
            conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thất Bại!!");
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                dt.Clear();
                SqlCommand cm = new SqlCommand("SELECT * FROM SanPham where tensanpham like N'%"+txt_tensp.Text+"%'", conn);
                adap.SelectCommand = cm;
                adap.Fill(dt);
                dgvDSSanPham.DataSource = dt;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void SanPham_Load_1(object sender, EventArgs e)
        {
            conn.Open();
            LoadDuLieu();
            conn.Close();
            LayDuLieuLenTextBox();
            DisableTextBox();
            DisableHuyButton();
            dieuchinhrow();
            
            if (DangNhap.ktchucVu.Equals("NHÂN VIÊN"))
            {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTim.Enabled = false;
            }
            
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            // "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*"
            openFileDialog1.Filter = openFileDialog1.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                txtAnhSP.Text = openFileDialog1.FileName;
            }
        }

        private void dgvDSSanPham_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //if(dgvDSSanPham.Rows[e.RowIndex].Cells[e.ColumnIndex].Value==DBNull.Value)
            //{
            //    e.Cancel = true;
            //}
        }

        private void dgvDSSanPham_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //xử lí lỗi ngoại lệ khi insert dữ liệu trước khi load form
            //foreach (DataGridViewCell cell in dgvDSSanPham.Rows[e.RowIndex].Cells)
            //{
            //    if (cell.GetType() == typeof(DataGridViewImageCell))
            //    {
            //        cell.Value = DBNull.Value;
            //    }
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDuLieu();
        }



    }
}
