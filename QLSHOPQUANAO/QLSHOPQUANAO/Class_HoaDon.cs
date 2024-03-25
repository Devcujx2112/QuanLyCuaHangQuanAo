using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSHOPQUANAO
{
    class Class_HoaDon
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VV7F55B\\SQLEXPRESS;Initial Catalog=SHOPQUANAO;Integrated Security=True");
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PKGEMFS\\HIEUNE;Initial Catalog=SHOPQUANAO;Integrated Security=True");

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
        public void Them(string sohd, string manv, string nhanvien, string ngaylap, string makhach)
        {
            conn.Open();
            string str_them = "INSERT INTO HoaDon VALUES ('" + sohd + "', '" + manv + "', N'" + nhanvien + "', '" + ngaylap + "', " + makhach + ")";
            SqlCommand cmd = new SqlCommand(str_them, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Sua(string sohd, string manv, string nhanvien, string ngaylap, string makhach)
        {
            conn.Open();
            string str_sua = "UPDATE HoaDon SET ngaylap = '" + ngaylap + "', nhanvienlap = N'" + nhanvien + "', makh = " + makhach + ", manhanvien = N'" + manv + "' WHERE sohd = '" + sohd + "'";
            SqlCommand cmd = new SqlCommand(str_sua, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Xoa(string sohd)
        {
            conn.Open();
            string str_xoa = "DELETE FROM HoaDon WHERE sohd = '" + sohd + "' ";
            SqlCommand cmd = new SqlCommand(str_xoa, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
