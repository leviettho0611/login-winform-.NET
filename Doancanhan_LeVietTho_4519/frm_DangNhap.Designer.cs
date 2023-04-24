namespace Doancanhan_LeVietTho_4519
{
    partial class frm_DangNhap
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
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.chk_HienMatKhau = new System.Windows.Forms.CheckBox();
            this.btn_Dong = new System.Windows.Forms.Button();
            this.lbl_DangNhap = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.lbl_MatKhau = new System.Windows.Forms.Label();
            this.lbl_TaiKhoan = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_DangKy);
            this.panel1.Controls.Add(this.chk_HienMatKhau);
            this.panel1.Controls.Add(this.btn_Dong);
            this.panel1.Controls.Add(this.lbl_DangNhap);
            this.panel1.Controls.Add(this.txt_MatKhau);
            this.panel1.Controls.Add(this.txt_TaiKhoan);
            this.panel1.Controls.Add(this.btn_DangNhap);
            this.panel1.Controls.Add(this.lbl_MatKhau);
            this.panel1.Controls.Add(this.lbl_TaiKhoan);
            this.panel1.Location = new System.Drawing.Point(122, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 422);
            this.panel1.TabIndex = 0;
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangKy.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_DangKy.Location = new System.Drawing.Point(247, 303);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(168, 78);
            this.btn_DangKy.TabIndex = 9;
            this.btn_DangKy.Text = "Đăng Ký";
            this.btn_DangKy.UseVisualStyleBackColor = true;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // chk_HienMatKhau
            // 
            this.chk_HienMatKhau.AutoSize = true;
            this.chk_HienMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_HienMatKhau.Location = new System.Drawing.Point(357, 256);
            this.chk_HienMatKhau.Name = "chk_HienMatKhau";
            this.chk_HienMatKhau.Size = new System.Drawing.Size(164, 29);
            this.chk_HienMatKhau.TabIndex = 8;
            this.chk_HienMatKhau.Text = "Hiện Mật Khẩu";
            this.chk_HienMatKhau.UseVisualStyleBackColor = true;
            this.chk_HienMatKhau.CheckedChanged += new System.EventHandler(this.chk_HienMatKhau_CheckedChanged);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Dong.Location = new System.Drawing.Point(461, 303);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(168, 78);
            this.btn_Dong.TabIndex = 7;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // lbl_DangNhap
            // 
            this.lbl_DangNhap.AutoSize = true;
            this.lbl_DangNhap.Font = new System.Drawing.Font("Kristen ITC", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DangNhap.ForeColor = System.Drawing.Color.Red;
            this.lbl_DangNhap.Location = new System.Drawing.Point(219, 31);
            this.lbl_DangNhap.Name = "lbl_DangNhap";
            this.lbl_DangNhap.Size = new System.Drawing.Size(237, 51);
            this.lbl_DangNhap.TabIndex = 6;
            this.lbl_DangNhap.Text = "Đăng Nhập";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MatKhau.Location = new System.Drawing.Point(228, 198);
            this.txt_MatKhau.Multiline = true;
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.PasswordChar = '*';
            this.txt_MatKhau.Size = new System.Drawing.Size(327, 28);
            this.txt_MatKhau.TabIndex = 5;
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TaiKhoan.Location = new System.Drawing.Point(228, 127);
            this.txt_TaiKhoan.Multiline = true;
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(327, 28);
            this.txt_TaiKhoan.TabIndex = 4;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_DangNhap.Location = new System.Drawing.Point(32, 303);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(157, 78);
            this.btn_DangNhap.TabIndex = 2;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // lbl_MatKhau
            // 
            this.lbl_MatKhau.AutoSize = true;
            this.lbl_MatKhau.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MatKhau.ForeColor = System.Drawing.Color.Black;
            this.lbl_MatKhau.Location = new System.Drawing.Point(26, 191);
            this.lbl_MatKhau.Name = "lbl_MatKhau";
            this.lbl_MatKhau.Size = new System.Drawing.Size(163, 35);
            this.lbl_MatKhau.TabIndex = 1;
            this.lbl_MatKhau.Text = "Mật Khẩu";
            // 
            // lbl_TaiKhoan
            // 
            this.lbl_TaiKhoan.AutoSize = true;
            this.lbl_TaiKhoan.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TaiKhoan.ForeColor = System.Drawing.Color.Black;
            this.lbl_TaiKhoan.Location = new System.Drawing.Point(26, 120);
            this.lbl_TaiKhoan.Name = "lbl_TaiKhoan";
            this.lbl_TaiKhoan.Size = new System.Drawing.Size(172, 35);
            this.lbl_TaiKhoan.TabIndex = 0;
            this.lbl_TaiKhoan.Text = "Tài Khoản";
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Doancanhan_LeVietTho_4519.Properties.Resources.nhat_cay_1595747664059;
            this.ClientSize = new System.Drawing.Size(880, 548);
            this.Controls.Add(this.panel1);
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_DangNhap_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Label lbl_MatKhau;
        private System.Windows.Forms.Label lbl_TaiKhoan;
        private System.Windows.Forms.Label lbl_DangNhap;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.Button btn_Dong;
        private System.Windows.Forms.CheckBox chk_HienMatKhau;
        private System.Windows.Forms.Button btn_DangKy;
    }
}

