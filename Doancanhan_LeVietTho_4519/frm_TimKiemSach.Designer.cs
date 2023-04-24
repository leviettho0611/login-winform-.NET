namespace Doancanhan_LeVietTho_4519
{
    partial class frm_TimKiemSach
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
            this.btn_TimKiemSach = new System.Windows.Forms.Button();
            this.dt_TimSach = new System.Windows.Forms.DataGridView();
            this.txt_TimKiemSach = new System.Windows.Forms.TextBox();
            this.lbl_MaSach = new System.Windows.Forms.Label();
            this.btn_Dong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_TimSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TimKiemSach
            // 
            this.btn_TimKiemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiemSach.ForeColor = System.Drawing.Color.Red;
            this.btn_TimKiemSach.Location = new System.Drawing.Point(162, 125);
            this.btn_TimKiemSach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_TimKiemSach.Name = "btn_TimKiemSach";
            this.btn_TimKiemSach.Size = new System.Drawing.Size(216, 56);
            this.btn_TimKiemSach.TabIndex = 33;
            this.btn_TimKiemSach.Text = "Tìm Kiếm Sách";
            this.btn_TimKiemSach.UseVisualStyleBackColor = true;
            this.btn_TimKiemSach.Click += new System.EventHandler(this.btn_TimKiemSach_Click);
            // 
            // dt_TimSach
            // 
            this.dt_TimSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_TimSach.Location = new System.Drawing.Point(71, 200);
            this.dt_TimSach.Name = "dt_TimSach";
            this.dt_TimSach.RowHeadersWidth = 51;
            this.dt_TimSach.RowTemplate.Height = 24;
            this.dt_TimSach.Size = new System.Drawing.Size(678, 216);
            this.dt_TimSach.TabIndex = 32;
            // 
            // txt_TimKiemSach
            // 
            this.txt_TimKiemSach.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_TimKiemSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TimKiemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiemSach.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txt_TimKiemSach.Location = new System.Drawing.Point(307, 35);
            this.txt_TimKiemSach.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_TimKiemSach.Multiline = true;
            this.txt_TimKiemSach.Name = "txt_TimKiemSach";
            this.txt_TimKiemSach.Size = new System.Drawing.Size(238, 32);
            this.txt_TimKiemSach.TabIndex = 31;
            // 
            // lbl_MaSach
            // 
            this.lbl_MaSach.AutoSize = true;
            this.lbl_MaSach.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MaSach.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaSach.ForeColor = System.Drawing.Color.Black;
            this.lbl_MaSach.Location = new System.Drawing.Point(166, 34);
            this.lbl_MaSach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaSach.Name = "lbl_MaSach";
            this.lbl_MaSach.Size = new System.Drawing.Size(113, 33);
            this.lbl_MaSach.TabIndex = 30;
            this.lbl_MaSach.Text = "Mã Sách";
            // 
            // btn_Dong
            // 
            this.btn_Dong.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Dong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_Dong.Location = new System.Drawing.Point(520, 125);
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(168, 56);
            this.btn_Dong.TabIndex = 34;
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.UseVisualStyleBackColor = true;
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // frm_TimKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Dong);
            this.Controls.Add(this.btn_TimKiemSach);
            this.Controls.Add(this.dt_TimSach);
            this.Controls.Add(this.txt_TimKiemSach);
            this.Controls.Add(this.lbl_MaSach);
            this.Name = "frm_TimKiemSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_TimKiemSach";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_TimKiemSach_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dt_TimSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TimKiemSach;
        private System.Windows.Forms.DataGridView dt_TimSach;
        private System.Windows.Forms.TextBox txt_TimKiemSach;
        private System.Windows.Forms.Label lbl_MaSach;
        private System.Windows.Forms.Button btn_Dong;
    }
}