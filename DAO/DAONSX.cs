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
            //param[5] = new SqlParameter("@HINHANH", tk.HINHANH);
            return DataProvider.ExecuteNonQuery(query, param) == 1;
        }
        public static bool SuaNSX(DTONSX tk)
        {
            string query = "UPDATE NSX SET (MANSX = @MANSX ,TEN =@TEN, EMAIL=@EMAIL, SDT=@SDT, DCHI=@DCHI )";
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@MANSX", tk.MANSX);
            param[1] = new SqlParameter("@TEN", tk.TEN);
            param[2] = new SqlParameter("@EMAIL", tk.EMAIL);
            param[3] = new SqlParameter("@SDT", tk.SDT);
            param[4] = new SqlParameter("@DCHI", tk.DCHI);
            //param[5] = new SqlParameter("@HINHANH", tk.HINHANH);
            return DataProvider.ExecuteNonQuery(query, param) == 1;
        }
        public static bool XoaNSX(string MANSX)
        {
            string query = "DELETE form NSX WHERE MANSX = @MANSX";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MANSX", MANSX);
            return DataProvider.ExecuteNonQuery(query, param) == 1;
        }public static bool SearchNSX(DTONSX tk)
        {
            string query = "SELECT * form NSX WHERE MANSX = @MANSX";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MANSX", tk.MANSX);
            return DataProvider.ExecuteNonQuery(query, param) == 1;
        }
        public static bool KTNSX(DTONSX tk)
        {
            string query = "select count(*) from NSX where MANSX = @MANSX";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MANSX", tk.MANSX);
            return DataProvider.ExecuteNonQuery(query, param) == 1;
        }
        public static DataTable LayMANSX(string MANSX)
        {
            string query = "SELECT * FROM NSX where MANSX = @MANSX";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@MANSX", MANSX);
            return DataProvider.ExecuteSelectQuery(query, param);
        }
    }
}
