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
    public class BUSNSX
    {
        DAONSX nsx = new DAONSX();
        public  DataTable LoadNSX(string con)
        {
            return nsx.GetData(con);
        }
        public void AddNSX(DTONSX NSX)
        {
            nsx.AddData(NSX);
        }
        public void EditNSX(DTONSX NSX)
        {
            nsx.EditData(NSX);
        }
        public void DelNSX(DTONSX NSX)
        {
            nsx.DeleteData(NSX);
        }
        public DataTable GetData(string NSX)
        {
            return nsx.GetData(NSX);
        }
        public DataTable GetMANSX()
        {
            return nsx.GetMANSX();
        }
        public DataTable SearchNSX(string NSX)
        {
            return nsx.SearchNCC(NSX);
        }
    }
}
