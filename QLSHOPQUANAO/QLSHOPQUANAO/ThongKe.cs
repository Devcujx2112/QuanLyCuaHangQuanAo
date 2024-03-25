using System;
using System.Collections;
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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VV7F55B\\SQLEXPRESS;Initial Catalog=SHOPQUANAO;Integrated Security=True");
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PKGEMFS;Initial Catalog=SHOPQUANAO;Integrated Security=True");
        private void ThongKe_Load(object sender, EventArgs e)
        {
            combo.Items.Add("ALL");
            combo.SelectedIndex = 0;
            List<string> ds = load_com();
            foreach (var item in ds)
            {
                combo.Items.Add(item);
            }
        }
        public DataTable laybang(string connstr)
        {
            DataTable bang = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(connstr, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                ////SqlDataAdapter da = new SqlDataAdapter(connstr, conn);
                DataSet ds = new DataSet();
                da.Fill(bang);
            }
            catch { bang = null; }
            finally { conn.Close(); }
            return bang;
        }
        public List<string> load_com()
        {
            List<string> ds = new List<string>();
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Sohd from hoadon", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                ds.Add(rd[0].ToString());
            }
            rd.Close();
            conn.Close();
            return ds;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (combo.Text.Equals("ALL"))
            {
                ThongKeHD rp = new ThongKeHD();
                crystalReportViewer1.ReportSource = rp;
            }
            else
            {
                ThongKeHD rp = new ThongKeHD();
                rp.SetDataSource(laybang("select distinct c.sohd, c.masanpham,h.manhanvien,h.ngaylap,h.makh,c.dongia,c.soluong,c.tongtien from hoadon h join CTHoadon c on h.sohd=c.sohd where c.sohd='" + combo.Text.Trim() + "'"));
                crystalReportViewer1.ReportSource = rp;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_nam.Text.Trim() =="")
            {
                MessageBox.Show("Nhập Số Năm!!");
                return;
            }
            DataTable dt = new DataTable();
            dt = laybang("select distinct c.masanpham,c.sanpham,c.soluong,c.tongtien from hoadon h join CTHoadon c on h.sohd=c.sohd where MONTH(ngaylap)='"+txt_thang.Text.Trim()+"' and YEAR(ngaylap)='"+txt_nam.Text.Trim()+"'");
            DoanhThu rp = new DoanhThu();
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }

    }
}
