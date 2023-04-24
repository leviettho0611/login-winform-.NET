namespace Doancanhan_LeVietTho_4519
{
    partial class frm_TimKiemNhanVien
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
            this.txt_TimKiemNhanVien = new System.Windows.Forms.TextBox();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.dt_TimNV = new System.Windows.Forms.DataGridView();
            this.btn_TimKiemNV = new System.Windows.Forms.Button();
            this.btn_Dong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_TimNV)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TimKiemNhanVien
            // 
            this.txt_TimKiemNhanVien.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_TimKiemNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TimKiemNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiemNhanVien.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_TimKiemNhanVien.Location = new System.Drawing.Point(325, 45);
            this.txt_TimKiemNhanVien.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_TimKiemNhanVien.Multiline = true;
            this.txt_TimKiemNhanVien.Name = "txt_TimKiemNhanVien";
            this.txt_TimKiemNhanVien.Size = new System.Drawing.Size(238, 32);
            this.txt_TimKiemNhanVien.TabIndex = 25;
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MaNV.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaNV.ForeColor = System.Drawing.Color.Black;
            this.lbl_MaNV.Location = new System.Drawing.Point(178, 45);
            this.lbl_MaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(95, 33);
            this.lbl_MaNV.TabIndex = 24;
            this.lbl_MaNV.Text = "Mã NV";
            // 
            // dt_TimNV
            // 
            this.dt_TimNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_TimNV.Location = new System.Drawing.Point(83, 211);
            this.dt_TimNV.Name = "dt_TimNV";
            this.dt_TimNV.RowHeadersWidth = 51;
            this.dt_TimNV.RowTemplate.Height = 24;
            this.dt_TimNV.Size = new System.Drawing.Size(659, 216);
            this.dt_TimNV.TabIndex = 26;
            // 
            // btn_TimKiemNV
            // 
            this.btn_TimKiemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiemNV.ForeColor = System.Drawing.Color.Red;
            this.btn_TimKiemNV.Location = new System.Drawing.Point(137, 136);
            this.btn_TimKiemNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_TimKiemNV.Name = "btn_TimKiemNV";
            this.btn_TimKiemNV.Size = new System.Drawing.Size(296, 56);
            this.btn_TimKiemNV.TabIndex = 29;
            this.btn_TimKiemNV.Text = "Tìm Kiếm Nhân Viên";
            this.btn_TimKiemNV.UseVisualStyleBackColor = true;
            this.btn_TimKiemNV.Click += new System.EventHandler(this.btn_TimKiemNV_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Dong.Location = new System.Drawing.Point(523, 136);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(168, 56);
            this.btn_Dong.TabIndex = 30;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // frm_TimKiemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_TimKiemNV);
            this.Controls.Add(this.dt_TimNV);
            this.Controls.Add(this.txt_TimKiemNhanVien);
            this.Controls.Add(this.lbl_MaNV);
            this.Name = "frm_TimKiemNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_TimKiemNhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_TimKiemNhanVien_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dt_TimNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TimKiemNhanVien;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.DataGridView dt_TimNV;
        private System.Windows.Forms.Button btn_TimKiemNV;
        private System.Windows.Forms.Button btn_Dong;
    }
}