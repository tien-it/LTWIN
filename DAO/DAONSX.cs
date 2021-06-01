using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class DAONSX
    {
        DataProvider cn = new DataProvider();
        public DataTable GetData(string Condition)
        {
            return cn.GetDataTable("Select * from NSX" + Condition);
        }

        public void AddData(DTONSX ex)
        {
            cn.ExecuteReader(@"INSERT INTO NSX(MANSX, TEN, EMAIL, SDT , DCHI) VALUES(N'" + ex.MANSX + "',N'" + ex.TEN + "',N'" + ex.EMAIL + "',N'" + ex.SDT + "',N'" +  ex.DCHI+ "')");
        }
        public void EditData(DTONSX ex)
        {
            cn.ExecuteReader(@"UPDATE NSX SET TEN =N'" + ex.TEN + "', EMAIL =N'" + ex.EMAIL + "', SDT =N'" + ex.SDT + "', DCHI =N'" + ex.DCHI + "' Where MANSX=N'" + ex.MANSX + "'");
        }
        public void DeleteData(DTONSX ex)
        {
            cn.ExecuteReader(@"DELETE FROM NSX WHERE MANSX=N'" + ex.MANSX + "'");
        }
        public DataTable GetMANSX()
        {
            return cn.GetDataTable("SELECT TOP (1) RIGHT(MANSX,4) AS MANSX FROM NSX ORDER BY MANSX DESC ");
        }
        public DataTable SearchNCC(string Condition)
        {
            return cn.GetDataTable("SELECT MANSX, TEN, EMAIL, SDT, DCHI FROM NSX Where MANSX =N" + Condition);
        }
    }
}
