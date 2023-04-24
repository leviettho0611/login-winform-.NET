using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Doancanhan_LeVietTho_4519
{
    public partial class frm_TimKiemNhanVien : Form
    {
        public frm_TimKiemNhanVien()
        {
            InitializeComponent();
        }
        LopDungChung lopchung = new LopDungChung();
        public void LoadNV()
        {

            string sqlNV = "Select * from NhanVien";
            dt_TimNV.DataSource = lopchung.LoadDL(sqlNV);
        }
        private void btn_TimKiemNV_Click(object sender, EventArgs e)
        {
            string sql = "Select * from NhanVien where ( MaNV = N'" + txt_TimKiemNhanVien.Text + "')";

            if (txt_TimKiemNhanVien.Text == "")
            {
                LoadNV();
            }
            else dt_TimNV.DataSource = lopchung.LoadDL(sql);


        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_TimKiemNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đóng ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
