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
    public partial class frm_TimKiemSach : Form
    {
        public frm_TimKiemSach()
        {
            InitializeComponent();
        }
        LopDungChung lopchung = new LopDungChung();
        public void LoadSach()
        {

            string sqlSach = "Select * from Sach";
            dt_TimSach.DataSource = lopchung.LoadDL(sqlSach);
        }
        private void btn_TimKiemSach_Click(object sender, EventArgs e)
        {
            string sql = "Select * from Sach where ( MaSach = N'" + txt_TimKiemSach.Text + "')";

            if (txt_TimKiemSach.Text == "")
            {
                LoadSach();
            }
            else dt_TimSach.DataSource = lopchung.LoadDL(sql);
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_TimKiemSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đóng ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
