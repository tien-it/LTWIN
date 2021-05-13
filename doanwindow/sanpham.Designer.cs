namespace doanwindow
{
    partial class frmsanpham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsanpham));
            this.dgvsanpham = new System.Windows.Forms.DataGridView();
            this.colAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SIZE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLTON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coldongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picsanpham = new System.Windows.Forms.PictureBox();
            this.dtpngaynhap = new System.Windows.Forms.DateTimePicker();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtsize = new System.Windows.Forms.TextBox();
            this.txtmau = new System.Windows.Forms.TextBox();
            this.txtmasp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtmansx = new System.Windows.Forms.TextBox();
            this.txtslton = new System.Windows.Forms.TextBox();
            this.btnseach = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvsanpham
            // 
            this.dgvsanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAnh,
            this.MASP,
            this.TENSP,
            this.NGAYNHAP,
            this.MANSX,
            this.MAU,
            this.SIZE,
            this.SLTON,
            this.Coldongia});
            this.dgvsanpham.Location = new System.Drawing.Point(3, 496);
            this.dgvsanpham.Name = "dgvsanpham";
            this.dgvsanpham.Size = new System.Drawing.Size(1263, 307);
            this.dgvsanpham.TabIndex = 6;
            // 
            // colAnh
            // 
            this.colAnh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colAnh.HeaderText = "Avatar";
            this.colAnh.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colAnh.Name = "colAnh";
            this.colAnh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAnh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colAnh.Width = 122;
            // 
            // MASP
            // 
            this.MASP.HeaderText = "Mã Sản Phẩm";
            this.MASP.Name = "MASP";
            // 
            // TENSP
            // 
            this.TENSP.HeaderText = "Tên Sản Phẩm";
            this.TENSP.Name = "TENSP";
            // 
            // NGAYNHAP
            // 
            this.NGAYNHAP.HeaderText = "Ngày Nhập";
            this.NGAYNHAP.Name = "NGAYNHAP";
            // 
            // MANSX
            // 
            this.MANSX.HeaderText = "Mã Nhà Sản Xuất";
            this.MANSX.Name = "MANSX";
            // 
            // MAU
            // 
            this.MAU.HeaderText = "Màu Sắc";
            this.MAU.Name = "MAU";
            // 
            // SIZE
            // 
            this.SIZE.HeaderText = "SIZE";
            this.SIZE.Name = "SIZE";
            // 
            // SLTON
            // 
            this.SLTON.DataPropertyName = "ID";
            this.SLTON.HeaderText = "SỐ LƯỢNG TỒN";
            this.SLTON.Name = "SLTON";
            // 
            // Coldongia
            // 
            this.Coldongia.HeaderText = "Đơn Gía";
            this.Coldongia.Name = "Coldongia";
            // 
            // picsanpham
            // 
            this.picsanpham.BackColor = System.Drawing.Color.DarkCyan;
            this.picsanpham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picsanpham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picsanpham.Location = new System.Drawing.Point(340, 58);
            this.picsanpham.Name = "picsanpham";
            this.picsanpham.Size = new System.Drawing.Size(418, 191);
            this.picsanpham.TabIndex = 7;
            this.picsanpham.TabStop = false;
            this.picsanpham.Click += new System.EventHandler(this.pícanpham_Click);
            // 
            // dtpngaynhap
            // 
            this.dtpngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaynhap.Location = new System.Drawing.Point(558, 318);
            this.dtpngaynhap.Name = "dtpngaynhap";
            this.dtpngaynhap.Size = new System.Drawing.Size(200, 20);
            this.dtpngaynhap.TabIndex = 22;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(779, 318);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(200, 20);
            this.txtdongia.TabIndex = 16;
            this.txtdongia.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // txtsize
            // 
            this.txtsize.Location = new System.Drawing.Point(558, 275);
            this.txtsize.Name = "txtsize";
            this.txtsize.Size = new System.Drawing.Size(200, 20);
            this.txtsize.TabIndex = 17;
            // 
            // txtmau
            // 
            this.txtmau.Location = new System.Drawing.Point(122, 318);
            this.txtmau.Name = "txtmau";
            this.txtmau.Size = new System.Drawing.Size(200, 20);
            this.txtmau.TabIndex = 18;
            // 
            // txtmasp
            // 
            this.txtmasp.Location = new System.Drawing.Point(340, 275);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.Size = new System.Drawing.Size(200, 20);
            this.txtmasp.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(168, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã Nhà Sản Xuất:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(846, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Màu Sắc:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(853, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Đơn Gía";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(619, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ngày Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(391, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã sản phẩm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(416, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "SL Tồn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(637, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "SIZE :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(122, 275);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(200, 20);
            this.txttensp.TabIndex = 20;
            // 
            // txtmansx
            // 
            this.txtmansx.Location = new System.Drawing.Point(340, 318);
            this.txtmansx.Name = "txtmansx";
            this.txtmansx.Size = new System.Drawing.Size(200, 20);
            this.txtmansx.TabIndex = 19;
            // 
            // txtslton
            // 
            this.txtslton.Location = new System.Drawing.Point(779, 275);
            this.txtslton.Name = "txtslton";
            this.txtslton.Size = new System.Drawing.Size(200, 20);
            this.txtslton.TabIndex = 16;
            this.txtslton.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // btnseach
            // 
            this.btnseach.Location = new System.Drawing.Point(704, 459);
            this.btnseach.Name = "btnseach";
            this.btnseach.Size = new System.Drawing.Size(110, 31);
            this.btnseach.TabIndex = 24;
            this.btnseach.Text = "Search";
            this.btnseach.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(470, 450);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Search";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(308, 470);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(375, 20);
            this.txtsearch.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 433);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1373, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(441, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 46);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sản Phẩm";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(273, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 70);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(436, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 70);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(757, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 70);
            this.button3.TabIndex = 27;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(613, 360);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 70);
            this.button4.TabIndex = 27;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmsanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnseach);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpngaynhap);
            this.Controls.Add(this.txtslton);
            this.Controls.Add(this.txtdongia);
            this.Controls.Add(this.txtsize);
            this.Controls.Add(this.txtmau);
            this.Controls.Add(this.txtmansx);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.txtmasp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picsanpham);
            this.Controls.Add(this.dgvsanpham);
            this.Name = "frmsanpham";
            this.Text = "sanpham";
            this.Load += new System.EventHandler(this.frmsanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvsanpham;
        private System.Windows.Forms.PictureBox picsanpham;
        private System.Windows.Forms.DateTimePicker dtpngaynhap;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtsize;
        private System.Windows.Forms.TextBox txtmau;
        private System.Windows.Forms.TextBox txtmasp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtmansx;
        private System.Windows.Forms.TextBox txtslton;
        private System.Windows.Forms.Button btnseach;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewImageColumn colAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn SIZE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLTON;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coldongia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}