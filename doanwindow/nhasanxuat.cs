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
using DTO;
namespace doanwindow
{
    public partial class nhasanxuat : Form
    {
        public nhasanxuat()
        {
            InitializeComponent();
        }
        public void Load_data()
        {
            DataTable dt = BusNSX.LayDSTaiKhoan();
            dgvnhasanxuat.DataSource = dt;
        }
        private void nhasanxuat_Load(object sender, EventArgs e)
        {

        }

        private void txtma_TextChanged(object sender, EventArgs e)
        {

        }
        public void XoaTextBox()
        {
            txttennsx.Text = "";
            txtmansx.Text = "";
            txtemailnsx.Text = "";
            txtsdtnsx.Text = "";
            txtdiachinsx.Text = "";
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            DTONSX NSX = new DTONSX(txtmansx.Text, txttennsx.Text, txtemailnsx.Text, txtsdtnsx.Text, txtdiachinsx.Text);
            if(BusNSX.ThemNSX(NSX))
            {
                Load_data();
                XoaTextBox();
                MessageBox.Show("Thêm Thành Công");
            }
            else
            {
                MessageBox.Show("Thêm Thành Thất Bại");
            }
        }
    }
}
