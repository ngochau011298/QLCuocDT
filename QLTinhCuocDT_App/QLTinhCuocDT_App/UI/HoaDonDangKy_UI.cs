using QLTinhCuocDT_App.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTinhCuocDT_App.UI
{
    public partial class HoaDonDangKy_UI : Form
    {
        public HoaDonDangKy_UI()
        {
            InitializeComponent();
        }

        QLTinhCuocDT_DbContext db = new QLTinhCuocDT_DbContext();

        public void Clear()
        {
            tbxMaHHDK.Clear();
            tbxIDSIM.Clear();
            tbxTenKH.Clear();
            tbxChiPhiDK.Clear();

            tbxsearch.Clear();

            hoaDonDangKyBindingSource.DataSource = db.HoaDonDangKy.Where(x => x.Flag == true).ToList();

            dvHoaDonDK.DataSource = hoaDonDangKyBindingSource;

            int row = 0;

            foreach (HoaDonDangKy hddk in hoaDonDangKyBindingSource)
            {
                dvHoaDonDK.Rows[row].Cells["TenKH"].Value = hddk.ThongTinSIM.KhachHang.TenKH;

                row++;
            }

            dvHoaDonDK.ClearSelection();
        }

        private void HoaDonDangKy_UI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult rs = MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 f = new Form1();
            f.Show();
        }

        private void HoaDonDangKy_UI_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void dvHoaDonDK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                DataGridViewRow row = dvHoaDonDK.Rows[e.RowIndex];
                tbxMaHHDK.Text = row.Cells["MaHDDK"].Value.ToString();
                tbxIDSIM.Text = row.Cells["IDSIM"].Value.ToString();
                tbxTenKH.Text = row.Cells["TenKH"].Value.ToString();
                tbxChiPhiDK.Text = Convert.ToDecimal(row.Cells["ChiPhiDangKy"].Value).ToString("#,##0");
            }
        }

        private void retype_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            HoaDonDangKy hddk = db.HoaDonDangKy.Find(tbxMaHHDK.Text);

            DialogResult rs = MessageBox.Show("Bạn có muốn xóa " + hddk.MaHDDK + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                hddk.Flag = false;

                db.Entry(hddk).State = EntityState.Modified;
                db.SaveChanges();

                Clear();
            }
        }

        private void tim_Click(object sender, EventArgs e)
        {
            var hoadondk = from hddk in db.HoaDonDangKy where hddk.Flag == true select hddk;

            if (!string.IsNullOrEmpty(tbxsearch.Text))
            {
                hoadondk = hoadondk.Where(s => s.IDSIM.Contains(tbxsearch.Text)
                || s.ThongTinSIM.KhachHang.TenKH.Contains(tbxsearch.Text));
            }

            dvHoaDonDK.DataSource = hoadondk.ToList();

            int row = 0;

            foreach (HoaDonDangKy hddk in hoadondk)
            {
                dvHoaDonDK.Rows[row].Cells["TenKH"].Value = hddk.ThongTinSIM.KhachHang.TenKH;

                row++;
            }

            dvHoaDonDK.ClearSelection();
        }
    }
}
