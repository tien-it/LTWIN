using HoaDon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1;

namespace doanwindow
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void hienthimpi(Form f)
        {
            foreach (Form frm in this.MdiChildren)
            { frm.Hide(); }

            f.MdiParent = this;
            f.ShowIcon = false;
            f.ControlBox = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
            f.WindowState = FormWindowState.Maximized;
            f.Dock = DockStyle.Fill;
        }
        private bool kiemtratontai(string fromName)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == fromName)
                {
                    hienthimpi(f);
                    return true;
                }
            }
            return false;
        }
        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!kiemtratontai("frmNhanVien"))
            {
                frmNhanVien f = new frmNhanVien();
                hienthimpi(f);
            }
            
                         
            
        }

        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!kiemtratontai("frmsanpham"))
            {
                frmsanpham f = new frmsanpham();
                hienthimpi(f);
            }
        }

        private void hoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!kiemtratontai("FrmHoaDon"))
            {
                FrmHoaDon f = new FrmHoaDon();
                hienthimpi(f);
            }
        }

        private void nhaSanXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!kiemtratontai("nhasanxuat"))
            {
                nhasanxuat f = new nhasanxuat();
                hienthimpi(f);
            }
        }

        private void chiTietHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!kiemtratontai(" FrmCTHD"))
            {
                FrmCTHD f = new FrmCTHD();
                hienthimpi(f);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           
                frmlogin f = new frmlogin();
                hienthimpi(f);
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!kiemtratontai("frmlogin"))
            {
                frmlogin f = new frmlogin();
                hienthimpi(f);
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!kiemtratontai("KH"))
            {
                KH f = new KH();
                hienthimpi(f);
            }
        }
    }
}
