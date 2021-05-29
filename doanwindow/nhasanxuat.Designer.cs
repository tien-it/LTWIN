namespace doanwindow
{
    partial class nhasanxuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nhasanxuat));
            this.txtdiachinsx = new System.Windows.Forms.TextBox();
            this.txtsdtnsx = new System.Windows.Forms.TextBox();
            this.txttennsx = new System.Windows.Forms.TextBox();
            this.txtmansx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pícanpham = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvnhasanxuat = new System.Windows.Forms.DataGridView();
            this.colAnh = new System.Windows.Forms.DataGridViewImageColumn();
            this.Colmansx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coltennsx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colemailnsx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colsdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coldiachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtemailnsx = new System.Windows.Forms.TextBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnseach = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pícanpham)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhasanxuat)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdiachinsx
            // 
            this.txtdiachinsx.Location = new System.Drawing.Point(386, 297);
            this.txtdiachinsx.Name = "txtdiachinsx";
            this.txtdiachinsx.Size = new System.Drawing.Size(200, 20);
            this.txtdiachinsx.TabIndex = 29;
            // 
            // txtsdtnsx
            // 
            this.txtsdtnsx.Location = new System.Drawing.Point(386, 254);
            this.txtsdtnsx.Name = "txtsdtnsx";
            this.txtsdtnsx.Size = new System.Drawing.Size(200, 20);
            this.txtsdtnsx.TabIndex = 30;
            // 
            // txttennsx
            // 
            this.txttennsx.Location = new System.Drawing.Point(386, 125);
            this.txttennsx.Name = "txttennsx";
            this.txttennsx.Size = new System.Drawing.Size(200, 20);
            this.txttennsx.TabIndex = 31;
            // 
            // txtmansx
            // 
            this.txtmansx.Location = new System.Drawing.Point(386, 168);
            this.txtmansx.Name = "txtmansx";
            this.txtmansx.Size = new System.Drawing.Size(200, 20);
            this.txtmansx.TabIndex = 32;
            this.txtmansx.TextChanged += new System.EventHandler(this.txtma_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(383, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "SĐT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(383, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mã Nhà Sản Xuất:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tên Nhà Sản Xuất";
            // 
            // pícanpham
            // 
            this.pícanpham.BackColor = System.Drawing.Color.DarkCyan;
            this.pícanpham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pícanpham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pícanpham.Location = new System.Drawing.Point(29, 97);
            this.pícanpham.Name = "pícanpham";
            this.pícanpham.Size = new System.Drawing.Size(337, 229);
            this.pícanpham.TabIndex = 23;
            this.pícanpham.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(-4, 351);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1373, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncancel);
            this.groupBox1.Controls.Add(this.btndel);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(748, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 250);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function";
            // 
            // btncancel
            // 
            this.btncancel.AutoSize = true;
            this.btncancel.Location = new System.Drawing.Point(6, 193);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(200, 50);
            this.btncancel.TabIndex = 0;
            this.btncancel.Text = "&Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btndel
            // 
            this.btndel.AutoSize = true;
            this.btndel.Location = new System.Drawing.Point(6, 137);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(200, 50);
            this.btndel.TabIndex = 0;
            this.btndel.Text = "&Delete";
            this.btndel.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.AutoSize = true;
            this.btnupdate.Location = new System.Drawing.Point(6, 83);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(200, 50);
            this.btnupdate.TabIndex = 0;
            this.btnupdate.Text = "&Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.AutoSize = true;
            this.btnadd.Location = new System.Drawing.Point(6, 29);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(200, 50);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "&Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // dgvnhasanxuat
            // 
            this.dgvnhasanxuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvnhasanxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhasanxuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAnh,
            this.Colmansx,
            this.Coltennsx,
            this.Colemailnsx,
            this.Colsdt,
            this.Coldiachi});
            this.dgvnhasanxuat.Location = new System.Drawing.Point(3, 449);
            this.dgvnhasanxuat.Name = "dgvnhasanxuat";
            this.dgvnhasanxuat.Size = new System.Drawing.Size(1049, 232);
            this.dgvnhasanxuat.TabIndex = 36;
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
            // Colmansx
            // 
            this.Colmansx.HeaderText = "Mã Nhà Sản Xuất";
            this.Colmansx.Name = "Colmansx";
            // 
            // Coltennsx
            // 
            this.Coltennsx.HeaderText = "Tên Nhà Sản Xuất";
            this.Coltennsx.Name = "Coltennsx";
            // 
            // Colemailnsx
            // 
            this.Colemailnsx.HeaderText = "Email";
            this.Colemailnsx.Name = "Colemailnsx";
            // 
            // Colsdt
            // 
            this.Colsdt.HeaderText = "SDT";
            this.Colsdt.Name = "Colsdt";
            // 
            // Coldiachi
            // 
            this.Coldiachi.HeaderText = "Địa Chỉ";
            this.Coldiachi.Name = "Coldiachi";
            // 
            // txtemailnsx
            // 
            this.txtemailnsx.Location = new System.Drawing.Point(386, 211);
            this.txtemailnsx.Name = "txtemailnsx";
            this.txtemailnsx.Size = new System.Drawing.Size(200, 20);
            this.txtemailnsx.TabIndex = 32;
            this.txtemailnsx.TextChanged += new System.EventHandler(this.txtma_TextChanged);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(333, 395);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(375, 20);
            this.txtsearch.TabIndex = 39;
            // 
            // btnseach
            // 
            this.btnseach.Location = new System.Drawing.Point(714, 384);
            this.btnseach.Name = "btnseach";
            this.btnseach.Size = new System.Drawing.Size(110, 31);
            this.btnseach.TabIndex = 38;
            this.btnseach.Text = "Search";
            this.btnseach.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(330, 374);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(416, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 46);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nhà Sản Xuất";
            // 
            // nhasanxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnseach);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvnhasanxuat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtdiachinsx);
            this.Controls.Add(this.txtsdtnsx);
            this.Controls.Add(this.txttennsx);
            this.Controls.Add(this.txtemailnsx);
            this.Controls.Add(this.txtmansx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pícanpham);
            this.Name = "nhasanxuat";
            this.Text = "nhasanxuat";
            this.Load += new System.EventHandler(this.nhasanxuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pícanpham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhasanxuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtdiachinsx;
        private System.Windows.Forms.TextBox txtsdtnsx;
        private System.Windows.Forms.TextBox txttennsx;
        private System.Windows.Forms.TextBox txtmansx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pícanpham;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvnhasanxuat;
        private System.Windows.Forms.DataGridViewImageColumn colAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colmansx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coltennsx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colemailnsx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colsdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coldiachi;
        private System.Windows.Forms.TextBox txtemailnsx;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnseach;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
    }
}