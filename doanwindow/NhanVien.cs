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

            //OpenFileDialog photo = new OpenFileDialog();
            //photo.ShowDialog();
            //picavatar.Image = Image.FromFile(photo.FileName);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dgvnhanvien.Rows[0].Clone();
            //DataGridCell cell = new  DataGridViewImageCell();
            row.Cells[0].Value = picavatar.Image;
            row.Cells[1].Value = txtusername.Text;
            row.Cells[2].Value = txtfullname.Text;
            row.Cells[3].Value = dtpbirthday.Value.ToString();
            row.Cells[4].Value = txtemail.Text;
            row.Cells[5].Value = txtphonenumber.Text;
            row.Cells[6].Value = txtpassword.Text;
            row.Cells[7].Value = txtid.Text;
            row.Cells[8].Value = dtpdaytowork.Value.ToString();
            row.Cells[9].Value = (radmale.Checked ? 1 : 0);
            dgvnhanvien.Rows.Add(row);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            OpenFileDialog photo = new OpenFileDialog();
            photo.ShowDialog();
            picavatar.Image = Image.FromFile(photo.FileName);
        }

        private void picavatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog photo = new OpenFileDialog();
            photo.ShowDialog();
            picavatar.Image = Image.FromFile(photo.FileName);
           
            
        }
    }
}
