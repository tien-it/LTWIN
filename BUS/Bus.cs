using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;
namespace BUS
{
    public class TaiKhoanBUS
    {
        public static DataTable LayDSTaiKhoan()
        {
            return TaiKhoanDAO.LayDSTaiKhoan();
        }

        public static bool ThemTaiKhoan(TaiKhoanDTO tk)
        {
            if (!TaiKhoanDAO.KTTaiKhoanTonTai(tk.Username))
            {
                return TaiKhoanDAO.ThemTaiKhoan(tk);
            }
            return false;
        }
        public static bool Dangnhap(string username , string password)
        {
            if (TaiKhoanDAO.KTTaiKhoanTonTai(username))
            {
               if(Convert.ToString( TaiKhoanDAO.LayMatKhau(username)) == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }else
            {
                return false;
            }

            

        }

    }
}
