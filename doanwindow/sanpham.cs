using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace doanwindow
{
    public partial class frmsanpham : Form
    {
        public frmsanpham()
        {
            InitializeComponent();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pícanpham_Click(object sender, EventArgs e)
        {

        }

        private void loadSANPHAM()
        {
            SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=doan;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select MASP,TENSP,MA_NSX,MAUSAC,NGAYNHAP,SIZE,SLTON,DONGIA  from SANPHAM";
            cmd.Connection = con;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dtb = new DataTable();
            adapter.Fill(dtb);
            dgvsanpham.DataSource = dtb;
            con.Close();
        }
            private void frmsanpham_Load(object sender, EventArgs e)
        {
            loadSANPHAM();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=doan;Integrated Security=True");
            //mo ket noi
            con.Open();
            //string image =pictureBox1.Image.ToString();
            string tensp = txttensp.Text;
            string masp = txtmasp.Text;
            string ngaynhap = dtpngaynhap.Value.ToString("dd-MM-yy");
            string mansx = txtmansx.Text;
            string mau = txtmau.Text;
            string size = txtsize.Text;
            string slton = txtslton.Text;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = string.Format("INSERT INTO SANPHAM (MASP,TENSP,MA_NSX,MAUSAC,NGAYNHAP,SIZE,SLTON,DONGIA) VALUES ('{0}', '{1}','{2}','{3}',{4},'{5}', {6})", masp, tensp, mansx,mau,ngaynhap,size,slton);
            cmd.Connection = con;
            if (cmd.ExecuteNonQuery() == 1)
            {
                loadSANPHAM();
            }
            else
            {
                MessageBox.Show("thong bao that bai ", "loi ");
            }



            //dong 
            con.Close();
        }
    }
}
