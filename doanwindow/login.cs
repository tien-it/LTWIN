using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS; 

namespace doanwindow
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        //private void hienthimpi(Form f)
        //{
        //   f.MdiParent = this;
        //    f.ShowIcon = false;
        //    f.ControlBox = false;
        //    f.FormBorderStyle = FormBorderStyle.None;
        //    f.Show();
        //    f.WindowState = FormWindowState.Maximized;
        //    f.Dock = DockStyle.Fill;
        //}
        private void btnlogin_Click(object sender, EventArgs e)
        {
            //this.Close();
            //FrmMain f = new FrmMain();
            //hienthimpi(f);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textpass_TextChanged_1(object sender, EventArgs e)
        {

        }
        // Dang nhap vao chuong trinh #1
        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            string usernametxt = txtusername.Text;
            string passtxt = txtpass.Text; 
            if(TaiKhoanBUS.Dangnhap(usernametxt, passtxt))
            {
                //DialogResult dg = new DialogResult() ;
                //MessageBox.Show.DialogResult
                MessageBox.Show("Dang Nhap Thanh Cong"); 

            }
            else
            {
                MessageBox.Show("Dang Nhap That Bai");
            }
        }

        private void txtusername_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pcban.BringToFront();
            txtpass.UseSystemPasswordChar = true;
        }

        private void pcban_Click(object sender, EventArgs e)
        {
            pcbhien.BringToFront();
            txtpass.UseSystemPasswordChar = false;
        }

        private void txtusername_Enter(object sender, EventArgs e)
        {
            string usernametxt = txtusername.Text;
            string passtxt = txtpass.Text;
            if (TaiKhoanBUS.Dangnhap(usernametxt, passtxt))
            {
                //DialogResult dg = new DialogResult() ;
                //MessageBox.Show.DialogResult
                MessageBox.Show("Dang Nhap Thanh Cong");

            }
            else
            {
                MessageBox.Show("Dang Nhap That Bai");
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            string usernametxt = txtusername.Text;
            string passtxt = txtpass.Text;
            if (TaiKhoanBUS.Dangnhap(usernametxt, passtxt))
            {
                //DialogResult dg = new DialogResult() ;
                //MessageBox.Show.DialogResult
                MessageBox.Show("Dang Nhap Thanh Cong");

            }
            else
            {
                MessageBox.Show("Dang Nhap That Bai");
            }
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
}
