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
        public static DataTable LayMANSX(string ma)
        {
            return DAONSX.LayMANSX(ma);
        }
        public static bool ThemNSX(DTONSX tk)
        {
            return DAONSX.ThemNSX(tk);
        }
        public static bool SuaNSX(DTONSX tk)
        {
            return DAONSX.SuaNSX(tk);
        }
        public static bool XoaNSX(string tk)
        {
            return DAONSX.XoaNSX(tk);
        }
        public static bool KTNSX(DTONSX tk)
        {
            return DAONSX.KTNSX(tk);
        }
    }
}
