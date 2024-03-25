using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSHOPQUANAO
{
    class Class_NhanVien
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-VV7F55B\\SQLEXPRESS;Initial Catalog=SHOPQUANAO;Integrated Security=True");
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-PKGEMFS\\HIEUNE;Initial Catalog=SHOPQUANAO;Integrated Security=True");

        public bool ktKhoaChinh(string a)
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

        public void Them(string manv , string tennv , string gioitinh , string ngaysinh ,string diachi , string sdt, string tendn ,string matkhau  ,string chucvu )
        {
            conn.Open();
            //insert vào csdl
            string str_them = "INSERT INTO NhanVien VALUES ('" + manv + "', N'" + tennv + "', N'" + gioitinh + "', N'" + ngaysinh + "', N'" + diachi + "', N'" + sdt + "', '" + tendn + "', '" + matkhau + "', N'" + chucvu + "')";
            SqlCommand cmd = new SqlCommand(str_them, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Sua(string manv, string tennv, string gioitinh, string ngaysinh, string diachi, string sdt, string tendn, string matkhau, string chucvu)
        {
            conn.Open();
            string str_sua = "UPDATE NhanVien SET tennhanvien = N'" + tennv + "', gioitinh = N'" + gioitinh + "', ngaysinh =  '" + ngaysinh + "', diachi = N'" + diachi + "', sdt = N'" + sdt + "', tendangnhap = '" + tendn + "', matkhau = '" + matkhau + "', chucvu = N'" + chucvu + "'  WHERE manhanvien= '" + manv + "' ";
            SqlCommand cmd = new SqlCommand(str_sua, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Xoa(string manv)
        {
            conn.Open();
            string str_xoa = "DELETE FROM NhanVien WHERE manhanvien = '" + manv + "' ";
            SqlCommand cmd = new SqlCommand(str_xoa, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
