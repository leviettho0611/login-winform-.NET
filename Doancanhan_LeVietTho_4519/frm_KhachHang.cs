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
    public partial class frm_KhachHang : Form
    {
        public frm_KhachHang()
        {
            InitializeComponent();
        }
        LopDungChung lopchung = new LopDungChung();
        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            string sql = "Insert into KhachHang values ('" + txt_MaKH.Text + "',N'" + txt_HoTenKH.Text + "',N'" + txt_DiaChiKH.Text + "',convert(datetime,'" + date_NgaySinhKH.Text + "',103),N'" + cb_GioiTinh.SelectedValue + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
                MessageBox.Show("Thêm nhân viên thành công");
            else MessageBox.Show("Thêm nhân viên thất bại");
            LoadKH();
        }
        public void LoadKH()
        {

            string sqlKH = "Select * from KhachHang";
            dt_KhachHang.DataSource = lopchung.LoadDL(sqlKH);
        }
        public void LoadCBGIOITINH()
        {
            string sql = "Select * from GioiTinh";
            cb_GioiTinh.DataSource = lopchung.LoadDL(sql);
            cb_GioiTinh.ValueMember = "GioiTinh";
            cb_GioiTinh.DisplayMember = "GioiTinh";
        }

        private void btn_SuaKH_Click(object sender, EventArgs e)
        {
            string sql = "Update KhachHang set HoTenKH = N'" + txt_HoTenKH.Text + "', DiaChiKH = N'" + txt_DiaChiKH.Text + "',NgaySinhKH = '" + date_NgaySinhKH.Text + "',GioiTinh = N'" + cb_GioiTinh.SelectedValue + "'where MaKH = '" + txt_MaKH.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
                MessageBox.Show("Cập nhật nhân viên thành công");
            else MessageBox.Show("Cập nhật nhân viên thất bại");
            LoadKH();
        }

        private void btn_XoaKH_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                string sql = "Delete KhachHang where MaKH = '" + txt_MaKH.Text + "'";
                int kq = lopchung.ThemXoaSua(sql);
                if (kq >= 1)
                    MessageBox.Show("Xoá khách hàng thành công");
                else MessageBox.Show("Xoá khách hàng thất bại");
                LoadKH();
            }
        }

        private void btn_DongKH_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_KhachHang_Load(object sender, EventArgs e)
        {
            LoadCBGIOITINH();
            LoadKH();
        }

        private void frm_KhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đóng ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dt_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaKH.Text = dt_KhachHang.CurrentRow.Cells[0].Value.ToString();
            txt_HoTenKH.Text = dt_KhachHang.CurrentRow.Cells["HoTenKH"].Value.ToString();
            date_NgaySinhKH.Text = dt_KhachHang.CurrentRow.Cells["NgaySinhKH"].Value.ToString();
            txt_DiaChiKH.Text = dt_KhachHang.CurrentRow.Cells["DiaChiKH"].Value.ToString();
        }
    }
}
