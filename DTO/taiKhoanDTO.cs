using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DTO
{
    //Tai Khoan DTO
    public class taiKhoanDTO
    {
        public int ID { get; set; }
        //0
        public string Fullname { get; set; }
        //1
        public string Username { get; set; }
        //2
        public string Password { get; set; }
        //2
        public string Email { get; set; }
        //3
        public DateTime Brithday { get; set; }
        //4
        public string SDT { get; set; }
        //5
        public bool Gender { get; set; }
        //6
        public string avatar { get; set; }
        //7
        public bool Status { get; set; }
        //8
        public taiKhoanDTO(DataRow dr)
        {
            ID = Convert.ToInt32(dr["ID"]);
        }
        public taiKhoanDTO()
        {
        }

    }
}
