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
            DTONSX NSX = new DTONSX();
            NSX.MANSX = txtmansx.Text;
            NSX.TEN = txttennsx.Text;
            NSX.EMAIL = txtemailnsx.Text;
            NSX.SDT = txtsdtnsx.Text;
            NSX.DCHI = txtdiachinsx.Text;
            if (BusNSX.KTNSX(NSX.MANSX))
            {
                Load_data();
                XoaTextBox();
                BusNSX.KTNSX(NSX.MANSX);
                MessageBox.Show("Thêm Thành Công");
            }
            else
            {
                MessageBox.Show("Thêm Thất Bại");
            }
        }
    }
}
