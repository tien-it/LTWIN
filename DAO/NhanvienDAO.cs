using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
    //ID NVARCHAR(10) 
    //FullName NVARCHAR(50)
    //UserName NVARCHAR(15)
    //Pass NVARCHAR(20)
    //BirthDay DATE
    //Email NVARCHAR(40)
    //SDT NVARCHAR(10)
    //GT NVARCHAR(1)
    //Avatar Nvarchar(50)
    //TrangThai bit
    class NhanvienDAO
    {
        //lay danh sach nhan vien tu bang nhan vien
        public static DataTable LayDSNhanVien()
        {
            string query = "SELECT * FROM NHANVIEN";
            SqlParameter[] param = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, param);
        }
        //them nhan vien 
        public static bool ThemNhanVien(TaiKhoanDTO tk)
        {

            string query = "INSERT INTO NHANVIEN (id ,fullname, username, pass, birthday,email,sdt,gt,avatar,trangthai ) VALUES" +
                " ( @ID , @FullName, @UserName, @Pass ,@BirthDay,@Email ,@SDT ,@GT,@Avatar, @TrangThai )";
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@ID", tk.ID);
            param[1] = new SqlParameter("@FullName", tk.Fullname);
            param[2] = new SqlParameter("@UserName", tk.Username);
            param[3] = new SqlParameter("@Pass", tk.Password);
            param[4] = new SqlParameter("@BirthDay", tk.Brithday);
            param[5] = new SqlParameter("@Email", tk.Email);
            param[6] = new SqlParameter("@SDT", tk.SDT);
            param[7] = new SqlParameter("@GT", tk.Gender);
            param[8] = new SqlParameter("@Avatar", tk.avatar);
            param[9] = new SqlParameter("@TrangThai", tk.Status);
            return DataProvider.ExecuteNonQuery(query, param) == 1;
        }
        public static bool SuaNhanVien(TaiKhoanDTO tk)
        {

            string query = "update NHANVIEN  Set (ID= @ID, fullname = @FullName,  username= @UserName,pass= @Pass ,birthday = @BirthDay, email= @Email ,sdt = @SDT ,gt = @GT, avatar= @Avatar,trangthai= @TrangThai )";

            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@ID", tk.ID);
            param[1] = new SqlParameter("@FullName", tk.Fullname);
            param[2] = new SqlParameter("@UserName", tk.Username);
            param[3] = new SqlParameter("@Pass", tk.Password);
            param[4] = new SqlParameter("@BirthDay", tk.Brithday);
            param[5] = new SqlParameter("@Email", tk.Email);
            param[6] = new SqlParameter("@SDT", tk.SDT);
            param[7] = new SqlParameter("@GT", tk.Gender);
            param[8] = new SqlParameter("@Avatar", tk.avatar);
            param[9] = new SqlParameter("@TrangThai", tk.Status);
            return DataProvider.ExecuteNonQuery(query, param) == 1;
        }
    }
}
