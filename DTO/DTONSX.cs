using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DTO
{
    public class DTONSX
    {
        //0
        public string MANSX { get; set; }
        //1
        public string TEN { get; set; }
        //2
        public string EMAIL { get; set; }
        //2
        public string SDT { get; set; }
        //3
        //4
        public string DCHI { get; set; }
        //5
        //6
        //7
        //8
        public DTONSX(string MANSX, string TEN, string EMAIL, string SDT, string DCHI )
        {
            this.MANSX = MANSX;
            this.TEN = TEN;
            this.EMAIL = EMAIL;
            this.SDT = SDT;
            this.DCHI = DCHI;
        }
        public DTONSX(DataRow dr)
        {
            MANSX = Convert.ToString(dr["MANSX"]);

        }
    }
}
