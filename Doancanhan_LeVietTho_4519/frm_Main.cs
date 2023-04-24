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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_NhanVien"] == null)
            {
                frm_NhanVien kh = new frm_NhanVien();
                kh.MdiParent = this;
                kh.Show();
            }
            else Application.OpenForms["frm_NhanVien"].Activate();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Sach"] == null)
            {
                frm_Sach s = new frm_Sach();
                s.MdiParent = this;
                s.Show();
            }
            else Application.OpenForms["frm_Sach"].Activate();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đóng ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_TimKiemNhanVien"] == null)
            {
                frm_TimKiemNhanVien TKNV = new frm_TimKiemNhanVien();
                TKNV.MdiParent = this;
                TKNV.Show();
            }
            else Application.OpenForms["frm_TimKiemNhanVien"].Activate();
        }

        private void tìmKiếmSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_TimKiemSach"] == null)
            {
                frm_TimKiemSach TKS = new frm_TimKiemSach();
                TKS.MdiParent = this;
                TKS.Show();
            }
            else Application.OpenForms["frm_TimKiemSach"].Activate();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_KhachHang"] == null)
            {
                frm_KhachHang KH = new frm_KhachHang();
                KH.MdiParent = this;
                KH.Show();
            }
            else Application.OpenForms["frm_KhachHang"].Activate();
        }
    }
}
