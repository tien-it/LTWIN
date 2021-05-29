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
    public class BusNSX
    {
        public static DataTable LayDSTaiKhoan()
        {
            return DAONSX.LayDSTaiKhoan();
        }

        public static bool ThemNSX(DTONSX tk)
        {
                return DAONSX.ThemNSX(tk);
        }
        public static bool KTNSX(string tk)
        {
            return DAONSX.KTNSX(tk);
        }
    }
}
