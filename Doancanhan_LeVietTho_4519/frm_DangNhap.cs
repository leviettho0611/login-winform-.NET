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
    public partial class frm_DangNhap : Form
    {
        private int count = 0;
        LopDungChung lopchung = new LopDungChung();
        public frm_DangNhap()
        {
            InitializeComponent();

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string sql = "Select COUNT (*) from ThongTinTaiKhoan where TaiKhoan = '" + txt_TaiKhoan.Text + "' and MatKhau = '" + txt_MatKhau.Text + "'";
            int kq = (int)lopchung.Scalar(sql);
            if (kq >= 1)
            {

                frm_Main main = new frm_Main();
                main.Show();
                MessageBox.Show("Đăng nhập thành công");

            }
            else
            {
                //Dang nhap sai
                count++;
                MessageBox.Show("Đăng nhập sai! Vui lòng nhập lại.", "Thông báo");
                if (count >= 3)
                {
                    // Đăng nhập sai quá 3 lần, thoát ứng dụng
                    MessageBox.Show("Bạn đã đăng nhập sai quá 3 lần! Cảm ơn bạn đã sử dụng ứng dụng.", "Thông báo");
                    Application.Exit();
                }
                else
                {
                    // Xóa nội dung textbox
                    txt_TaiKhoan.Text = "";
                    txt_MatKhau.Text = "";
                }
            }
        }

        private void chk_HienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_HienMatKhau.Checked)
            {
                txt_MatKhau.PasswordChar = (char)0;
            }
            else txt_MatKhau.PasswordChar = '*'; if (chk_HienMatKhau.Checked)
            {
                txt_MatKhau.PasswordChar = (char)0;
            }
            else txt_MatKhau.PasswordChar = '*';
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
            
        }

        private void frm_DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đóng ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            frm_DangKy dangky = new frm_DangKy();
            dangky.Show();
            //MessageBox.Show("Đăng nhập thành công");
        }
    }
}
