﻿namespace PMTHITN
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.linkquenmk = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnexit = new PMTHITN.RJButton();
            this.btnlogin = new PMTHITN.RJButton();
            this.btnsv = new PMTHITN.RJButton();
            this.btngv = new PMTHITN.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 167);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PMTHITN.Properties.Resources.Logo_Đại_học_Mở_TPHCM;
            this.pictureBox1.Location = new System.Drawing.Point(3, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(136, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thi trắc nghiệm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(128, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(725, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRƯỜNG ĐẠI HỌC MỞ TPHCM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RosyBrown;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(116, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(259, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên đăng nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RosyBrown;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(117, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RosyBrown;
            this.label5.Location = new System.Drawing.Point(542, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 39);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bạn là:";
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtuser.Location = new System.Drawing.Point(76, 250);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(364, 35);
            this.txtuser.TabIndex = 7;
            // 
            // txtmk
            // 
            this.txtmk.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmk.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtmk.Location = new System.Drawing.Point(76, 349);
            this.txtmk.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(364, 35);
            this.txtmk.TabIndex = 7;
            this.txtmk.UseSystemPasswordChar = true;
            // 
            // linkquenmk
            // 
            this.linkquenmk.AutoSize = true;
            this.linkquenmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkquenmk.LinkColor = System.Drawing.Color.Maroon;
            this.linkquenmk.Location = new System.Drawing.Point(83, 395);
            this.linkquenmk.Name = "linkquenmk";
            this.linkquenmk.Size = new System.Drawing.Size(280, 29);
            this.linkquenmk.TabIndex = 13;
            this.linkquenmk.TabStop = true;
            this.linkquenmk.Text = "Forget your password?";
            this.linkquenmk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkquenmk_LinkClicked);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PMTHITN.Properties.Resources.login;
            this.pictureBox3.Location = new System.Drawing.Point(71, 209);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PMTHITN.Properties.Resources.iconfinder_key_4341299_120569;
            this.pictureBox2.Location = new System.Drawing.Point(76, 306);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.RosyBrown;
            this.btnexit.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.btnexit.BorderColor = System.Drawing.Color.LightCoral;
            this.btnexit.BorderRadius = 20;
            this.btnexit.BorderSize = 0;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(496, 456);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(205, 65);
            this.btnexit.TabIndex = 14;
            this.btnexit.Text = "Thoát";
            this.btnexit.TextColor = System.Drawing.Color.White;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.RosyBrown;
            this.btnlogin.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.btnlogin.BorderColor = System.Drawing.Color.LightCoral;
            this.btnlogin.BorderRadius = 20;
            this.btnlogin.BorderSize = 0;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(260, 456);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(205, 65);
            this.btnlogin.TabIndex = 10;
            this.btnlogin.Text = "Đăng nhập";
            this.btnlogin.TextColor = System.Drawing.Color.White;
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnsv
            // 
            this.btnsv.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsv.BorderColor = System.Drawing.Color.DarkSalmon;
            this.btnsv.BorderRadius = 20;
            this.btnsv.BorderSize = 2;
            this.btnsv.FlatAppearance.BorderSize = 0;
            this.btnsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsv.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnsv.Location = new System.Drawing.Point(548, 333);
            this.btnsv.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnsv.Name = "btnsv";
            this.btnsv.Size = new System.Drawing.Size(249, 71);
            this.btnsv.TabIndex = 9;
            this.btnsv.Text = "Sinh viên";
            this.btnsv.TextColor = System.Drawing.Color.RosyBrown;
            this.btnsv.UseVisualStyleBackColor = false;
            this.btnsv.Click += new System.EventHandler(this.btnsv_Click);
            this.btnsv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnsv_MouseClick);
            // 
            // btngv
            // 
            this.btngv.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btngv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btngv.BorderColor = System.Drawing.Color.DarkSalmon;
            this.btngv.BorderRadius = 20;
            this.btngv.BorderSize = 2;
            this.btngv.FlatAppearance.BorderSize = 0;
            this.btngv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngv.ForeColor = System.Drawing.Color.RosyBrown;
            this.btngv.Location = new System.Drawing.Point(548, 250);
            this.btngv.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btngv.Name = "btngv";
            this.btngv.Size = new System.Drawing.Size(249, 71);
            this.btngv.TabIndex = 8;
            this.btngv.Text = "Giảng viên";
            this.btngv.TextColor = System.Drawing.Color.RosyBrown;
            this.btngv.UseVisualStyleBackColor = false;
            this.btngv.Click += new System.EventHandler(this.btngv_Click);
            this.btngv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btngv_MouseClick);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(886, 533);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.linkquenmk);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btnsv);
            this.Controls.Add(this.btngv);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Hệ thống thi trắc nghiệm OU";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtmk;
        private RJButton btngv;
        private RJButton btnsv;
        private RJButton btnlogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel linkquenmk;
        private RJButton btnexit;
    }
}

