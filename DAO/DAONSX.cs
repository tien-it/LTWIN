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
    public class DAONSX
    {
        public static List<DTONSX> layDSTaiKhoan()
        {

            string query = "SELECT * FROM NSX";
            SqlParameter[] param = new SqlParameter[0];
            DataTable dtb = DataProvider.ExecuteSelectQuery(query, param);
            List<DTONSX> LsTK = new List<DTONSX>();

            foreach (DataRow item in dtb.Rows)
            {
                LsTK.Add(new DTONSX(item));
            }
            return LsTK;


        }
        public static DataTable LayDSTaiKhoan()
        {
            string query = "SELECT * FROM NSX";
            SqlParameter[] param = new SqlParameter[0];
            return DataProvider.ExecuteSelectQuery(query, param);
        }

        public static bool ThemNSX(DTONSX tk)
        {
            string query = "INSERT INTO NSX (MANSX ,TEN, EMAIL, SDT, DCHI ) VALUES ( @MANSX ,@TEN, @EMAIL, @SDT, @DCHI)";
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@MANSX", tk.MANSX);
            param[1] = new SqlParameter("@TEN", tk.TEN);
            param[2] = new SqlParameter("@EMAIL", tk.EMAIL);
            param[3] = new SqlParameter("@SDT", tk.SDT);
            param[4] = new SqlParameter("@DCHI", tk.DCHI);
            return DataProvider.ExecuteNonQuery(query, param) == 1;
        }
        public static bool KTNSX(string MANSX)
        {
            string query = "select count(*) from NSX where MANSX = @MANSX";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MANSX", MANSX);


            return Convert.ToUInt32(DataProvider.ExecuteSelectQuery(query, param).Rows[0][0]) == 1;
        }
    }
}
