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
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
        }
        LopDungChung lopchung = new LopDungChung();
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into NhanVien values ('" + txt_MaNV.Text + "',N'" + txt_HoTen.Text + "',N'" + txt_DiaChi.Text + "',convert(datetime,'" + date_NgaySinh.Text + "',103),N'" + txt_ChucVu.Text + "',N'" + cb_GioiTinh.SelectedValue + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
                MessageBox.Show("Thêm nhân viên thành công");
            else MessageBox.Show("Thêm nhân viên thất bại");
            LoadNV();
        }
        public void LoadNV()
        {

            string sqlNV = "Select * from NhanVien";
            dt_NhanVien.DataSource = lopchung.LoadDL(sqlNV);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update NhanVien set HoTen = N'" + txt_HoTen.Text + "', DiaChi = N'" + txt_DiaChi.Text + "',NgaySinh = '" + date_NgaySinh.Text + "',ChucVu = N'" + txt_ChucVu.Text + "',GioiTinh = N'" + cb_GioiTinh.SelectedValue + "'where MaNV = '" + txt_MaNV.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
                MessageBox.Show("Cập nhật nhân viên thành công");
            else MessageBox.Show("Cập nhật nhân viên thất bại");
            LoadNV();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                string sql = "Delete NhanVien where MaNV = '" + txt_MaNV.Text + "'";
                int kq = lopchung.ThemXoaSua(sql);
                if (kq >= 1)
                    MessageBox.Show("Xoá nhân viên thành công");
                else MessageBox.Show("Xoá nhân viên thất bại");
                LoadNV();
            }
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
           
                this.Close();
            
        }

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            LoadCBGIOITINH();
            LoadNV();
        }

        private void dt_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text = dt_NhanVien.CurrentRow.Cells[0].Value.ToString();
            txt_HoTen.Text = dt_NhanVien.CurrentRow.Cells["HoTen"].Value.ToString();
            date_NgaySinh.Text = dt_NhanVien.CurrentRow.Cells["NgaySinh"].Value.ToString();
            txt_ChucVu.Text = dt_NhanVien.CurrentRow.Cells["ChucVu"].Value.ToString();
            txt_DiaChi.Text = dt_NhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
        }

        private void frm_NhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đóng ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public void LoadCBGIOITINH()
        {
            string sql = "Select * from GioiTinh";
            cb_GioiTinh.DataSource = lopchung.LoadDL(sql);
            cb_GioiTinh.ValueMember = "GioiTinh";
            cb_GioiTinh.DisplayMember = "GioiTinh";
        }

        
    }
}
