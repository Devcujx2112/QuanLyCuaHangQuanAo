using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSHOPQUANAO
{
    class Class_CTHoaDon
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VV7F55B\\SQLEXPRESS;Initial Catalog=SHOPQUANAO;Integrated Security=True");
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PKGEMFS\\HIEUNE;Initial Catalog=SHOPQUANAO;Integrated Security=True");

        public void Them(string sohd, string masanpham, string sanpham, string dongia, string soluong, string tongtien)
        {
            conn.Open();
            string str_them = "INSERT INTO CTHoaDon VALUES ('" + sohd + "', '" + masanpham + "', N'" + sanpham + "', " + dongia + ", " + soluong + ", " + tongtien + ")";
            SqlCommand cmd = new SqlCommand(str_them, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Sua(string sohd, string masanpham, string sanpham, string dongia, string soluong, string tongtien)
        {
            conn.Open();
            string str_sua = "UPDATE CTHoaDon SET sanpham = N'" + sanpham + "', dongia = " + dongia + ", soluong = " + soluong + ", tongtien = " + tongtien + "  WHERE sohd = '" + sohd + "' and masanpham='" + masanpham + "'";
            SqlCommand cmd = new SqlCommand(str_sua, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Xoa(string sohd,string masanpham)
        {
            conn.Open();
            string str_xoa = "DELETE FROM CTHoaDon WHERE sohd = '" + sohd + "' and masanpham='" + masanpham + "'";
            SqlCommand cmd = new SqlCommand(str_xoa, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
