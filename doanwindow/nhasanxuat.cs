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
        BUSNSX bnsx = new BUSNSX();
        DTONSX dnsx = new DTONSX();
        DataTable dt = new DataTable();
        bool addnew;
        private void nhasanxuat_Load(object sender, EventArgs e)
        {
            loaddata();
            CloseNSX();
        }
        void CloseNSX()
        {
            txtmansx.Enabled = false;
            txttennsx.Enabled = false;
            txtsdtnsx.Enabled = false;
            txtdiachinsx.Enabled = false;
            txtemailnsx.Enabled = false;
            txtmansx.BackColor = Color.DarkGray;
            txttennsx.BackColor = Color.DarkGray;
            txtsdtnsx.BackColor = Color.DarkGray;
            txtdiachinsx.BackColor = Color.DarkGray;
            txtemailnsx.BackColor = Color.DarkGray;
            btnadd.Enabled = true;
            btnupdate.Enabled = false;
            btndel.Enabled = false;
            btncancel.Enabled = false;
            btnSave.Enabled = false;
        }
        void OpenNSX()
        {
            txttennsx.Enabled = true;
            txtsdtnsx.Enabled = true;
            txtdiachinsx.Enabled = true;
            txtemailnsx.Enabled = true;
            txttennsx.BackColor = Color.White;
            txtsdtnsx.BackColor = Color.White;
            txtdiachinsx.BackColor = Color.White;
            txtemailnsx.BackColor = Color.White;
            btnadd.Enabled = false;
            btnupdate.Enabled = false;
            btndel.Enabled = false;
            btncancel.Enabled = false;
            btnseach.Enabled = false;
        }
        private void txtma_TextChanged(object sender, EventArgs e)
        {

        }
        public void XoaTextBox()
        {
            txttennsx.Text = "";
            txtemailnsx.Text = "";
            txtmansx.Text = "";
            txtsdtnsx.Text = "";
            txtdiachinsx.Text = "";
        }
        void AutoNSX()
        {
            dt = bnsx.GetMANSX();
            if (dt == null || dt.Rows.Count == 0)
            {
                txtmansx.Text = "NSX0001";
            }
            else
            {
                int tam1 = int.Parse(dt.Rows[0][0].ToString());
                if (tam1 < 10)
                {
                    tam1 = tam1 + 1;
                    txtmansx.Text = "NSX000" + Convert.ToString(tam1);
                }
                else
                    if (tam1 < 100)
                {
                    tam1 = tam1 + 1;
                    txtmansx.Text = "NSX00" + Convert.ToString(tam1);
                }
                else
                        if (tam1 < 1000)
                {
                    tam1 = tam1 + 1;
                    txtmansx.Text = "NSX0" + Convert.ToString(tam1);
                }
            }
        }
        void loaddata()
        {
            dgvnhasanxuat.DataSource = bnsx.GetData("");
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            OpenNSX();
            XoaTextBox();
            addnew = true;
            btnSave.Enabled = true;
            btncancel.Enabled = true;
            AutoNSX();
            this.txttennsx.Focus();
        }

        private void dgvnhasanxuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtmansx.Text == "")
            {
                MessageBox.Show("Lỗi mã nhà cung cấp !");
                return;
            }
            if (txttennsx.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại tên nhà cung cấp !");
                return;
            }
            if (txtsdtnsx.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại số điện thoại của nhà cung cấp !");
                return;
            }
            if (txtdiachinsx.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại địa chỉ của nhà cung cấp !");
                return;
            }
            if (txtemailnsx.Text == "")
            {
                MessageBox.Show("Xin mời nhập lại email của nhà cung cấp !");
                return;
            }
            if (addnew == true)
            {
                try
                {
                    if (txtsdtnsx.Text.Length < 10)
                    {
                        MessageBox.Show("Số điện thoại không đúng !");
                        return;
                    }
                    else
                    {
                        if (txtsdtnsx.Text.Length == 10 || txtsdtnsx.Text.Length == 11)
                        {
                            dnsx.MANSX = txtmansx.Text;
                            dnsx.TEN = txttennsx.Text;
                            dnsx.SDT = txtsdtnsx.Text;
                            dnsx.DCHI = txtdiachinsx.Text;
                            dnsx.EMAIL = txtemailnsx.Text;
                            bnsx.AddNSX(dnsx);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể thêm mới được !");
                    return;
                }
            }
            else
            {
                try
                {
                    if (txtsdtnsx.Text.Length < 10)
                    {
                        MessageBox.Show("Số điện thoại không đúng !");
                        return;
                    }
                    else
                    {
                        if (txtsdtnsx.Text.Length == 10 || txtsdtnsx.Text.Length == 11)
                        {
                            dnsx.MANSX = txtmansx.Text;
                            dnsx.TEN = txttennsx.Text;
                            dnsx.SDT = txtsdtnsx.Text;
                            dnsx.DCHI = txtdiachinsx.Text;
                            dnsx.EMAIL = txtemailnsx.Text;
                            bnsx.AddNSX(dnsx);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể sửa được !");
                    return;
                }

            }
            CloseNSX();
            loaddata();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtmansx.Text == "" || txttennsx.Text == "")
                {
                    MessageBox.Show("Vui lòng nhấp chọn bên dưới !", "Thông báo !");
                    return;
                }
                OpenNSX();
                addnew = false;
                btnSave.Enabled = true;
                btncancel.Enabled = true;
                this.txttennsx.Focus();
                loaddata();
            }
            catch { }
        }
    }
}
