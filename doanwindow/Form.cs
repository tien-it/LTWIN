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
using System.Drawing.Imaging;
using DTO;
using BUS;

namespace doanwindow
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=doan;Integrated Security=True");
            ////mo ket noi
            //con.Open();
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "select *  from NhanVien";
            //cmd.Connection = con;
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //adapter.SelectCommand = cmd;
            //DataTable dtb = new DataTable();
            //adapter.Fill(dtb);
            //dgvnhanvien.DataSource = dtb;
            //con.Close();
                        
        }

        //thuc hien click vao nut add trong form nhan vien
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void picavatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog photo = new OpenFileDialog();
            photo.ShowDialog();
            picavatar.Image = Image.FromFile(photo.FileName);
            
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radmale_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
