using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace doanwindow
{
    public class ConnecDB
    {
        public SqlConnection conDB()
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=CSDL2;Integrated Security=True");
            return con;
        }
    }
}
