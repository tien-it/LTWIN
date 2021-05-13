namespace doanwindow
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhaSanXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTietHoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chucNangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoLỗiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.chucNangToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhanVienToolStripMenuItem,
            this.sanPhamToolStripMenuItem,
            this.hoaDonToolStripMenuItem,
            this.nhaSanXuatToolStripMenuItem,
            this.chiTietHoaDonToolStripMenuItem,
            this.kháchHàngToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // nhanVienToolStripMenuItem
            // 
            this.nhanVienToolStripMenuItem.Image = global::doanwindow.Properties.Resources._172571711_4131145390287068_6236671952919895316_n;
            this.nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            this.nhanVienToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nhanVienToolStripMenuItem.Text = "Nhân Viên";
            this.nhanVienToolStripMenuItem.Click += new System.EventHandler(this.nhanVienToolStripMenuItem_Click);
            // 
            // sanPhamToolStripMenuItem
            // 
            this.sanPhamToolStripMenuItem.Image = global::doanwindow.Properties.Resources._1739273;
            this.sanPhamToolStripMenuItem.Name = "sanPhamToolStripMenuItem";
            this.sanPhamToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sanPhamToolStripMenuItem.Text = "Sản Phẩm";
            this.sanPhamToolStripMenuItem.Click += new System.EventHandler(this.sanPhamToolStripMenuItem_Click);
            // 
            // hoaDonToolStripMenuItem
            // 
            this.hoaDonToolStripMenuItem.Image = global::doanwindow.Properties.Resources._172743795_158653796158534_3011931807412648768_n1;
            this.hoaDonToolStripMenuItem.Name = "hoaDonToolStripMenuItem";
            this.hoaDonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hoaDonToolStripMenuItem.Text = "Hóa Đơn";
            this.hoaDonToolStripMenuItem.Click += new System.EventHandler(this.hoaDonToolStripMenuItem_Click);
            // 
            // nhaSanXuatToolStripMenuItem
            // 
            this.nhaSanXuatToolStripMenuItem.Image = global::doanwindow.Properties.Resources._171559464_362374908482780_588209229218504634_n;
            this.nhaSanXuatToolStripMenuItem.Name = "nhaSanXuatToolStripMenuItem";
            this.nhaSanXuatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nhaSanXuatToolStripMenuItem.Text = "Nhà Sản Xuất";
            this.nhaSanXuatToolStripMenuItem.Click += new System.EventHandler(this.nhaSanXuatToolStripMenuItem_Click);
            // 
            // chiTietHoaDonToolStripMenuItem
            // 
            this.chiTietHoaDonToolStripMenuItem.Image = global::doanwindow.Properties.Resources._172743795_158653796158534_3011931807412648768_n;
            this.chiTietHoaDonToolStripMenuItem.Name = "chiTietHoaDonToolStripMenuItem";
            this.chiTietHoaDonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chiTietHoaDonToolStripMenuItem.Text = "Chi Tiết Hóa Đơn";
            this.chiTietHoaDonToolStripMenuItem.Click += new System.EventHandler(this.chiTietHoaDonToolStripMenuItem_Click);
            // 
            // chucNangToolStripMenuItem
            // 
            this.chucNangToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangXuatToolStripMenuItem,
            this.báoLỗiToolStripMenuItem});
            this.chucNangToolStripMenuItem.Name = "chucNangToolStripMenuItem";
            this.chucNangToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.chucNangToolStripMenuItem.Text = "Chức Năng";
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dangXuatToolStripMenuItem.Text = "Đăng Xuất";
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
            // 
            // báoLỗiToolStripMenuItem
            // 
            this.báoLỗiToolStripMenuItem.Name = "báoLỗiToolStripMenuItem";
            this.báoLỗiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.báoLỗiToolStripMenuItem.Text = "Báo Lỗi";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 711);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sanPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoaDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhaSanXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTietHoaDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chucNangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoLỗiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
    }
}