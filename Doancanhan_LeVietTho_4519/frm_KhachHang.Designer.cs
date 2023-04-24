namespace Doancanhan_LeVietTho_4519
{
    partial class frm_KhachHang
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
            this.cb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.btn_DongKH = new System.Windows.Forms.Button();
            this.dt_KhachHang = new System.Windows.Forms.DataGridView();
            this.btn_XoaKH = new System.Windows.Forms.Button();
            this.btn_SuaKH = new System.Windows.Forms.Button();
            this.btn_ThemKH = new System.Windows.Forms.Button();
            this.date_NgaySinhKH = new System.Windows.Forms.DateTimePicker();
            this.txt_DiaChiKH = new System.Windows.Forms.TextBox();
            this.txt_HoTenKH = new System.Windows.Forms.TextBox();
            this.txt_MaKH = new System.Windows.Forms.TextBox();
            this.lbl_KhachHang = new System.Windows.Forms.Label();
            this.lbl_GioiTinhKH = new System.Windows.Forms.Label();
            this.lbl_DiaChiKHKH = new System.Windows.Forms.Label();
            this.lbl_DiaChiKH = new System.Windows.Forms.Label();
            this.lbl_HoTenKH = new System.Windows.Forms.Label();
            this.lbl_MaKH = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dt_KhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_GioiTinh
            // 
            this.cb_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_GioiTinh.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.cb_GioiTinh.FormattingEnabled = true;
            this.cb_GioiTinh.Location = new System.Drawing.Point(187, 286);
            this.cb_GioiTinh.Name = "cb_GioiTinh";
            this.cb_GioiTinh.Size = new System.Drawing.Size(238, 28);
            this.cb_GioiTinh.TabIndex = 49;
            // 
            // btn_DongKH
            // 
            this.btn_DongKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DongKH.ForeColor = System.Drawing.Color.Red;
            this.btn_DongKH.Location = new System.Drawing.Point(911, 512);
            this.btn_DongKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_DongKH.Name = "btn_DongKH";
            this.btn_DongKH.Size = new System.Drawing.Size(142, 54);
            this.btn_DongKH.TabIndex = 47;
            this.btn_DongKH.Text = "Đóng";
            this.btn_DongKH.UseVisualStyleBackColor = true;
            this.btn_DongKH.Click += new System.EventHandler(this.btn_DongKH_Click);
            // 
            // dt_KhachHang
            // 
            this.dt_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_KhachHang.Location = new System.Drawing.Point(454, 172);
            this.dt_KhachHang.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dt_KhachHang.Name = "dt_KhachHang";
            this.dt_KhachHang.RowHeadersWidth = 51;
            this.dt_KhachHang.RowTemplate.Height = 24;
            this.dt_KhachHang.Size = new System.Drawing.Size(599, 320);
            this.dt_KhachHang.TabIndex = 46;
            this.dt_KhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_KhachHang_CellClick);
            // 
            // btn_XoaKH
            // 
            this.btn_XoaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaKH.ForeColor = System.Drawing.Color.Red;
            this.btn_XoaKH.Location = new System.Drawing.Point(911, 92);
            this.btn_XoaKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_XoaKH.Name = "btn_XoaKH";
            this.btn_XoaKH.Size = new System.Drawing.Size(142, 56);
            this.btn_XoaKH.TabIndex = 45;
            this.btn_XoaKH.Text = "Xóa\r\n";
            this.btn_XoaKH.UseVisualStyleBackColor = true;
            this.btn_XoaKH.Click += new System.EventHandler(this.btn_XoaKH_Click);
            // 
            // btn_SuaKH
            // 
            this.btn_SuaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaKH.ForeColor = System.Drawing.Color.Red;
            this.btn_SuaKH.Location = new System.Drawing.Point(685, 92);
            this.btn_SuaKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_SuaKH.Name = "btn_SuaKH";
            this.btn_SuaKH.Size = new System.Drawing.Size(145, 57);
            this.btn_SuaKH.TabIndex = 44;
            this.btn_SuaKH.Text = "Sửa";
            this.btn_SuaKH.UseVisualStyleBackColor = true;
            this.btn_SuaKH.Click += new System.EventHandler(this.btn_SuaKH_Click);
            // 
            // btn_ThemKH
            // 
            this.btn_ThemKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemKH.ForeColor = System.Drawing.Color.Red;
            this.btn_ThemKH.Location = new System.Drawing.Point(454, 92);
            this.btn_ThemKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_ThemKH.Name = "btn_ThemKH";
            this.btn_ThemKH.Size = new System.Drawing.Size(145, 56);
            this.btn_ThemKH.TabIndex = 43;
            this.btn_ThemKH.Text = "Thêm";
            this.btn_ThemKH.UseVisualStyleBackColor = true;
            this.btn_ThemKH.Click += new System.EventHandler(this.btn_ThemKH_Click);
            // 
            // date_NgaySinhKH
            // 
            this.date_NgaySinhKH.CustomFormat = "dd/MM/yyyy";
            this.date_NgaySinhKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_NgaySinhKH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_NgaySinhKH.Location = new System.Drawing.Point(187, 399);
            this.date_NgaySinhKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.date_NgaySinhKH.Name = "date_NgaySinhKH";
            this.date_NgaySinhKH.Size = new System.Drawing.Size(238, 30);
            this.date_NgaySinhKH.TabIndex = 42;
            // 
            // txt_DiaChiKH
            // 
            this.txt_DiaChiKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DiaChiKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChiKH.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_DiaChiKH.Location = new System.Drawing.Point(187, 344);
            this.txt_DiaChiKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_DiaChiKH.Multiline = true;
            this.txt_DiaChiKH.Name = "txt_DiaChiKH";
            this.txt_DiaChiKH.Size = new System.Drawing.Size(238, 32);
            this.txt_DiaChiKH.TabIndex = 40;
            // 
            // txt_HoTenKH
            // 
            this.txt_HoTenKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_HoTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTenKH.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_HoTenKH.Location = new System.Drawing.Point(187, 228);
            this.txt_HoTenKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_HoTenKH.Multiline = true;
            this.txt_HoTenKH.Name = "txt_HoTenKH";
            this.txt_HoTenKH.Size = new System.Drawing.Size(238, 32);
            this.txt_HoTenKH.TabIndex = 39;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_MaKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaKH.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_MaKH.Location = new System.Drawing.Point(187, 172);
            this.txt_MaKH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_MaKH.Multiline = true;
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Size = new System.Drawing.Size(238, 32);
            this.txt_MaKH.TabIndex = 38;
            // 
            // lbl_KhachHang
            // 
            this.lbl_KhachHang.AutoSize = true;
            this.lbl_KhachHang.BackColor = System.Drawing.Color.Transparent;
            this.lbl_KhachHang.Font = new System.Drawing.Font("Lucida Fax", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KhachHang.ForeColor = System.Drawing.Color.Blue;
            this.lbl_KhachHang.Location = new System.Drawing.Point(426, 23);
            this.lbl_KhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KhachHang.Name = "lbl_KhachHang";
            this.lbl_KhachHang.Size = new System.Drawing.Size(296, 49);
            this.lbl_KhachHang.TabIndex = 37;
            this.lbl_KhachHang.Text = "Khách Hàng";
            // 
            // lbl_GioiTinhKH
            // 
            this.lbl_GioiTinhKH.AutoSize = true;
            this.lbl_GioiTinhKH.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GioiTinhKH.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioiTinhKH.ForeColor = System.Drawing.Color.Black;
            this.lbl_GioiTinhKH.Location = new System.Drawing.Point(21, 285);
            this.lbl_GioiTinhKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_GioiTinhKH.Name = "lbl_GioiTinhKH";
            this.lbl_GioiTinhKH.Size = new System.Drawing.Size(125, 33);
            this.lbl_GioiTinhKH.TabIndex = 55;
            this.lbl_GioiTinhKH.Text = "Giới Tính";
            // 
            // lbl_DiaChiKHKH
            // 
            this.lbl_DiaChiKHKH.AutoSize = true;
            this.lbl_DiaChiKHKH.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DiaChiKHKH.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChiKHKH.ForeColor = System.Drawing.Color.Black;
            this.lbl_DiaChiKHKH.Location = new System.Drawing.Point(24, 399);
            this.lbl_DiaChiKHKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DiaChiKHKH.Name = "lbl_DiaChiKHKH";
            this.lbl_DiaChiKHKH.Size = new System.Drawing.Size(131, 33);
            this.lbl_DiaChiKHKH.TabIndex = 53;
            this.lbl_DiaChiKHKH.Text = "Ngày Sinh";
            // 
            // lbl_DiaChiKH
            // 
            this.lbl_DiaChiKH.AutoSize = true;
            this.lbl_DiaChiKH.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DiaChiKH.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaChiKH.ForeColor = System.Drawing.Color.Black;
            this.lbl_DiaChiKH.Location = new System.Drawing.Point(24, 343);
            this.lbl_DiaChiKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DiaChiKH.Name = "lbl_DiaChiKH";
            this.lbl_DiaChiKH.Size = new System.Drawing.Size(105, 33);
            this.lbl_DiaChiKH.TabIndex = 52;
            this.lbl_DiaChiKH.Text = "Địa Chỉ";
            // 
            // lbl_HoTenKH
            // 
            this.lbl_HoTenKH.AutoSize = true;
            this.lbl_HoTenKH.BackColor = System.Drawing.Color.Transparent;
            this.lbl_HoTenKH.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTenKH.ForeColor = System.Drawing.Color.Black;
            this.lbl_HoTenKH.Location = new System.Drawing.Point(21, 227);
            this.lbl_HoTenKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HoTenKH.Name = "lbl_HoTenKH";
            this.lbl_HoTenKH.Size = new System.Drawing.Size(98, 33);
            this.lbl_HoTenKH.TabIndex = 51;
            this.lbl_HoTenKH.Text = "Họ Tên";
            // 
            // lbl_MaKH
            // 
            this.lbl_MaKH.AutoSize = true;
            this.lbl_MaKH.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MaKH.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaKH.ForeColor = System.Drawing.Color.Black;
            this.lbl_MaKH.Location = new System.Drawing.Point(24, 171);
            this.lbl_MaKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaKH.Name = "lbl_MaKH";
            this.lbl_MaKH.Size = new System.Drawing.Size(97, 33);
            this.lbl_MaKH.TabIndex = 50;
            this.lbl_MaKH.Text = "Mã KH";
            // 
            // frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 575);
            this.Controls.Add(this.lbl_GioiTinhKH);
            this.Controls.Add(this.lbl_DiaChiKHKH);
            this.Controls.Add(this.lbl_DiaChiKH);
            this.Controls.Add(this.lbl_HoTenKH);
            this.Controls.Add(this.lbl_MaKH);
            this.Controls.Add(this.cb_GioiTinh);
            this.Controls.Add(this.btn_DongKH);
            this.Controls.Add(this.dt_KhachHang);
            this.Controls.Add(this.btn_XoaKH);
            this.Controls.Add(this.btn_SuaKH);
            this.Controls.Add(this.btn_ThemKH);
            this.Controls.Add(this.date_NgaySinhKH);
            this.Controls.Add(this.txt_DiaChiKH);
            this.Controls.Add(this.txt_HoTenKH);
            this.Controls.Add(this.txt_MaKH);
            this.Controls.Add(this.lbl_KhachHang);
            this.Name = "frm_KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_KhachHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_KhachHang_FormClosing);
            this.Load += new System.EventHandler(this.frm_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_KhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_GioiTinh;
        private System.Windows.Forms.Button btn_DongKH;
        private System.Windows.Forms.DataGridView dt_KhachHang;
        private System.Windows.Forms.Button btn_XoaKH;
        private System.Windows.Forms.Button btn_SuaKH;
        private System.Windows.Forms.Button btn_ThemKH;
        private System.Windows.Forms.DateTimePicker date_NgaySinhKH;
        private System.Windows.Forms.TextBox txt_DiaChiKH;
        private System.Windows.Forms.TextBox txt_HoTenKH;
        private System.Windows.Forms.TextBox txt_MaKH;
        private System.Windows.Forms.Label lbl_KhachHang;
        private System.Windows.Forms.Label lbl_GioiTinhKH;
        private System.Windows.Forms.Label lbl_DiaChiKHKH;
        private System.Windows.Forms.Label lbl_DiaChiKH;
        private System.Windows.Forms.Label lbl_HoTenKH;
        private System.Windows.Forms.Label lbl_MaKH;
    }
}