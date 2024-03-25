using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSHOPQUANAO
{
    class Class_KhachHang
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VV7F55B\\SQLEXPRESS;Initial Catalog=SHOPQUANAO;Integrated Security=True");
        //   SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PKGEMFS\\HIEUNE;Initial Catalog=SHOPQUANAO;Integrated Security=True");

        public bool ktKhoaNgoai(string a)
        {
            try
            {
                string sql = "select count(*) from hoadon where makh= '" + a + "'";
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

        public void Them(string tenkh , string diachi , string gioitinh, string sdt)
        {
            conn.Open();
            string str_them = "INSERT INTO Khachhang VALUES (N'" + tenkh + "', N'" + diachi + "', N'" + gioitinh + "', N'" + sdt + "')";
            SqlCommand cmd = new SqlCommand(str_them, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Sua(string tenkh, string diachi, string gioitinh, string sdt,string makh)
        {
            conn.Open();
            string str_sua = "UPDATE khachhang SET tenkhach = N'" + tenkh + "', gioitinh = N'" + gioitinh + "', diachi = N'" + diachi + "', sdt = N'" + sdt + "' WHERE makh= '" + makh + "' ";
            SqlCommand cmd = new SqlCommand(str_sua, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Xoa(string makh)
        {
            conn.Open();
            string str_xoa = "DELETE FROM khachhang WHERE makh = " + makh;
            SqlCommand cmd = new SqlCommand(str_xoa, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
