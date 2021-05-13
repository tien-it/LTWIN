﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class TaiKhoanDAO
    {
        public static List<TaiKhoanDTO> layDSTaiKhoan()
        {

            string query = "SELECT * FROM Accounts";
            SqlParameter[] param = new SqlParameter[0];
            DataTable dtb = DataProvider.ExecuteSelectQuery(query, param);
            List<TaiKhoanDTO> LsTK = new List<TaiKhoanDTO>();

            foreach (DataRow item in dtb.Rows)
            {
                LsTK.Add(new TaiKhoanDTO(item));
            }   
            return LsTK;


        }
        public static DataTable LayDSTaiKhoan()
        {
            string query = "SELECT * FROM Accounts";
            SqlParameter[] param = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, param);
        }

        public static bool ThemTaiKhoan(TaiKhoanDTO tk)
        {
            string query = "INSERT INTO Accounts (Fullname ,Username, Password, Email, Birthday,SDT , Gender, Avatar, Status) VALUES ( @Fullname ,@Username, @Password, @Email, @Birthday,@SDT, @Gender, @Avatar, @Status)";
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@Fullname", tk.Fullname);
            param[1] = new SqlParameter("@Username", tk.Username);
            param[2] = new SqlParameter("@Password", tk.Password);
            param[3] = new SqlParameter("@Email", tk.Email);
            param[4] = new SqlParameter("@Birthday", tk.Brithday);
            param[5] = new SqlParameter("@SDT", tk.SDT);
            param[6] = new SqlParameter("@Gender", tk.Gender);
            param[7] = new SqlParameter("@Avatar", tk.avatar);
            param[8] = new SqlParameter("@Status", tk.Status);
            return DataProvider.ExecuteNonQuery(query, param) == 1;
        }
        public static bool KTTaiKhoanTonTai(string username )
        {
            string query = "select count(*) from NhanVien where UserName = @username";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@username", username);


            return Convert.ToUInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) == 1;
        }

        public static string LayMatKhau(string username)
        {
            string query = "select Pass from nhanvien where username =@username";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Username", username);

            return Convert.ToString(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]);
        }
    }
    public class NSXDAO
    {
        public static List<NSXDTO> LayDSNSX()
        {
            string query = "SELECT * FROM NSX";
            SqlParameter[] param = new SqlParameter[0];
            DataTable dtb = DataProvider.ExecuteSelectQuery(query, param);
            List<NSXDTO> LsNSX = new List<NSXDTO>();

            foreach (DataRow item in dtb.Rows)
            {
                LsNSX.Add(new NSXDTO(item));
            }
            return LsNSX;
        }
        public static DataTable LayDSNSX()
        {
            string query = "SELECT * FROM NSX";
            SqlParameter[] param = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, param);
        }
        public static bool ThemNSX(NSXDTO nsx)
        {
            string query = "INSERT INTO NSX (MANSX,TEN,EMAIL,SDT,DCHI) VALUES (@MANSX,@TEN,@EMAIL,@SDT,@DCHI)";
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@MANSX", nsx);
            param[1] = new SqlParameter("@TEN", nsx.TenNSX);
            param[2] = new SqlParameter("@EMAIL", nsx.Email);
            param[3] = new SqlParameter("@SDT", nsx.SDT);
            param[4] = new SqlParameter("@DCHI", nsx.DChi);
            return DataProvider.ExecuteNonQuery(query, param) == 1;
        }
        public static bool KTNSXTonTai(string MANSX)
        {
            string query = "SELECT * FROM NSX";
            SqlParameter[] param = new SqlParameter[0];
            param[0] = new SqlParameter("@MANSX", MANSX);

            return DataProvider.ExecuteNonQuery(query, param) == 1;
        }

        public static bool KTNSXTonTai(int p)
        {
            throw new NotImplementedException();
        }
    }
}