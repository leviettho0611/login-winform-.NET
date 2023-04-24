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
    public partial class frm_Sach : Form
    {
        public frm_Sach()
        {
            InitializeComponent();
        }


        LopDungChung lopchung = new LopDungChung();
        private void btn_ThemS_Click(object sender, EventArgs e)
        {
            string sql = "Insert into Sach values ('" + txt_MaSach.Text + "',N'" + txt_TenSach.Text + "',N'" + txt_TacGia.Text + "',convert(datetime,'" + date_NgayXuatBan.Text + "',103),N'" + txt_TheLoai.Text + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
                MessageBox.Show("Thêm sách thành công");
            else MessageBox.Show("Thêm sách thất bại");
            LoadS();
        }
        private void btn_SuaS_Click(object sender, EventArgs e)
        {
            string sql = "Update Sach set TenSach = N'" + txt_TenSach.Text + "', TacGia = N'" + txt_TacGia.Text + "',NgayXuatBan = '" + date_NgayXuatBan.Text + "',TheLoai = N'" + txt_TheLoai.Text + "'where MaSach = '" + txt_MaSach.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
                MessageBox.Show("Cập nhật sách thành công");
            else MessageBox.Show("Cập nhật sách thất bại");
            LoadS();
        }
        public void LoadS()
        {

            string sqlNV = "Select * from Sach";
            dt_Sach.DataSource = lopchung.LoadDL(sqlNV);
        }
        
        private void frm_Sach_Load(object sender, EventArgs e)
        {
            LoadS();
        }

        private void btn_XoaS_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                string sql = "Delete Sach where MaSach = '" + txt_MaSach.Text + "'";
                int kq = lopchung.ThemXoaSua(sql);
                if (kq >= 1)
                    MessageBox.Show("Xoá sách thành công");
                else MessageBox.Show("Xoá sách thất bại");
                LoadS();
            }
        }

        private void btn_DongS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dt_Sach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaSach.Text = dt_Sach.CurrentRow.Cells[0].Value.ToString();
            txt_TenSach.Text = dt_Sach.CurrentRow.Cells["TenSach"].Value.ToString();
            date_NgayXuatBan.Text = dt_Sach.CurrentRow.Cells["NgayXuatBan"].Value.ToString();
            txt_TacGia.Text = dt_Sach.CurrentRow.Cells["TacGia"].Value.ToString();
            txt_TheLoai.Text = dt_Sach.CurrentRow.Cells["TheLoai"].Value.ToString();
        }

        private void frm_Sach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đóng ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
