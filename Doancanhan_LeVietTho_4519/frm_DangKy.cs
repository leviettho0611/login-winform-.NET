using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doancanhan_LeVietTho_4519
{
    public partial class frm_DangKy : Form
    {
        public frm_DangKy()
        {
            InitializeComponent();
        }
        LopDungChung lopchung = new LopDungChung();
        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            string sql = "Insert into ThongTinTaiKhoan values ('" + txt_TaiKhoanDK.Text + "',N'" + txt_MatKhauDK.Text + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) { 
                MessageBox.Show("Đăng ký thành công");
                frm_DangNhap dangnhap = new frm_DangNhap();
                dangnhap.Show();
                this.Close();
            }
            else MessageBox.Show("Đăng ký thất bại");

            //LoadNV();
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void chk_HienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_HienMatKhau.Checked)
            {
                txt_MatKhauDK.PasswordChar = (char)0;
            }
            else txt_MatKhauDK.PasswordChar = '*'; if (chk_HienMatKhau.Checked)
            {
                txt_MatKhauDK.PasswordChar = (char)0;
            }
            else txt_MatKhauDK.PasswordChar = '*';
        }
    }
}
