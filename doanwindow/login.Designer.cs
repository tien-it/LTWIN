namespace doanwindow
{
    partial class frmlogin
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
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbhien = new System.Windows.Forms.PictureBox();
            this.pcban = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbhien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcban)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnlogin.AutoSize = true;
            this.btnlogin.BackColor = System.Drawing.SystemColors.Info;
            this.btnlogin.Location = new System.Drawing.Point(536, 480);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(197, 53);
            this.btnlogin.TabIndex = 11;
            this.btnlogin.Text = "&Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click_1);
            // 
            // txtpass
            // 
            this.txtpass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtpass.BackColor = System.Drawing.SystemColors.Info;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(517, 430);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(276, 44);
            this.txtpass.TabIndex = 8;
            this.txtpass.TextChanged += new System.EventHandler(this.textpass_TextChanged_1);
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            // 
            // txtusername
            // 
            this.txtusername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtusername.BackColor = System.Drawing.SystemColors.Info;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(517, 380);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(276, 44);
            this.txtusername.TabIndex = 9;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged_1);
            this.txtusername.Enter += new System.EventHandler(this.txtusername_Enter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::doanwindow.Properties.Resources.rb;
            this.pictureBox3.Location = new System.Drawing.Point(467, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(326, 252);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::doanwindow.Properties.Resources.aaa;
            this.pictureBox2.Location = new System.Drawing.Point(467, 430);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::doanwindow.Properties.Resources.bbb;
            this.pictureBox1.Location = new System.Drawing.Point(467, 380);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pcbhien
            // 
            this.pcbhien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pcbhien.BackColor = System.Drawing.Color.White;
            this.pcbhien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbhien.Image = global::doanwindow.Properties.Resources.OIP__2_;
            this.pcbhien.Location = new System.Drawing.Point(750, 430);
            this.pcbhien.Name = "pcbhien";
            this.pcbhien.Size = new System.Drawing.Size(43, 44);
            this.pcbhien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbhien.TabIndex = 13;
            this.pcbhien.TabStop = false;
            this.pcbhien.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pcban
            // 
            this.pcban.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pcban.BackColor = System.Drawing.Color.White;
            this.pcban.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcban.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcban.Image = global::doanwindow.Properties.Resources.ui_icon_pack_15_128;
            this.pcban.Location = new System.Drawing.Point(750, 430);
            this.pcban.Name = "pcban";
            this.pcban.Size = new System.Drawing.Size(43, 44);
            this.pcban.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcban.TabIndex = 13;
            this.pcban.TabStop = false;
            this.pcban.Click += new System.EventHandler(this.pcban_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(529, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 42);
            this.label1.TabIndex = 17;
            this.label1.Text = "Đăng Nhập";
            // 
            // frmlogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pcbhien);
            this.Controls.Add(this.pcban);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtusername);
            this.Name = "frmlogin";
            this.Text = "login";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbhien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.PictureBox pcban;
        private System.Windows.Forms.PictureBox pcbhien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
    }
}