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
using QLTinhCuocDT_App.Entity;
using QLTinhCuocDT_App.UI;

namespace QLTinhCuocDT_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        QLTinhCuocDT_DbContext db = new QLTinhCuocDT_DbContext();

        HoaDonTinhCuoc hdtc = new HoaDonTinhCuoc();

        ThongTinSIM sim = new ThongTinSIM();

        ThongTinSIM sim_cat = new ThongTinSIM();

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            KhachHang_UI kh_form = new KhachHang_UI();
            kh_form.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnCTSD_Click(object sender, EventArgs e)
        {
            ChiTietSuDung_UI ctsd_form = new ChiTietSuDung_UI();
            ctsd_form.Show();
            this.Hide();
        }

        private void btnHDTC_Click(object sender, EventArgs e)
        {
            HoaDonTinhCuoc_UI hdtc_form = new HoaDonTinhCuoc_UI();
            hdtc_form.Show();
            this.Hide();
        }

        private void details_Click(object sender, EventArgs e)
        {
            if(dvHoaDonChuaThanhToan.SelectedCells.Count == 0)
            {
                MessageBox.Show("Hãy chọn hóa đơn để xem chi tiết", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DetailsHoaDonTinhCuoc_UI detail_form = new DetailsHoaDonTinhCuoc_UI(hdtc);
                detail_form.Show();
            }
        }

        private void retype_Click(object sender, EventArgs e)
        {
            var hd_notcheck = (from hdtc in db.HoaDonTinhCuoc
                               where hdtc.ThanhToan == false && hdtc.Flag == true
                               select hdtc).OrderBy(i => i.NgayLapHD);

            dvHoaDonChuaThanhToan.DataSource = hd_notcheck.ToList();

            int row = 0;

            foreach (HoaDonTinhCuoc hdtc in hd_notcheck)
            {
                dvHoaDonChuaThanhToan.Rows[row].Cells["TenKH"].Value = hdtc.ThongTinSIM.KhachHang.TenKH;

                dvHoaDonChuaThanhToan.Rows[row].Cells["HanChotThanhToan"].Value = Convert.ToDateTime(hdtc.NgayLapHD).AddDays(30).ToShortDateString();

                row++;
            }

            dvHoaDonChuaThanhToan.ClearSelection();
        }

        private void btnGiaCuoc_Click(object sender, EventArgs e)
        {
            GiaCuoc_UI giacuoc_form = new GiaCuoc_UI();
            giacuoc_form.Show();
            this.Hide();
        }

        private void btnThongTinSIM_Click(object sender, EventArgs e)
        {
            ThongTinSim_UI sim_form = new ThongTinSim_UI();
            sim_form.Show();
            this.Hide();
        }

        private void btnHDDK_Click(object sender, EventArgs e)
        {
            HoaDonDangKy_UI hddk_form = new HoaDonDangKy_UI();
            hddk_form.Show();
            this.Hide();
        }

        private void tabPage_CTSD_Enter(object sender, EventArgs e)
        {
            cbxIDSIM.DataSource = (from sim in db.ThongTinSIM where sim.Flag == true select sim.IDSIM).ToList();

            cbxIDSIM.SelectedItem = null;
        }

        private void cbxIDSIM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxIDSIM.SelectedItem == null)
            {
                tbxTenKH.Clear();
            }
            else
            {
                string name = (from sim in db.ThongTinSIM
                               from kh in db.KhachHang
                               where sim.MaKH == kh.MaKH && sim.IDSIM == cbxIDSIM.SelectedItem
                               select kh.TenKH).FirstOrDefault().ToString();

                tbxTenKH.Text = name;
            }

            dvChiTietSD.DataSource = (from ctsd in db.ChiTietSuDung
                                      where ctsd.Flag == true && ctsd.IDSIM == cbxIDSIM.SelectedItem
                                      select ctsd).ToList();

            dvChiTietSD.ClearSelection();

            dvHoaDonTinhCuoc.DataSource = (from hdtc in db.HoaDonTinhCuoc
                                           where hdtc.Flag == true && hdtc.IDSIM == cbxIDSIM.SelectedItem
                                           select hdtc).ToList();

            dvHoaDonTinhCuoc.ClearSelection();
        }

        private void dvHoaDonChuaThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                DataGridViewRow row = dvHoaDonChuaThanhToan.Rows[e.RowIndex];

                hdtc = db.HoaDonTinhCuoc.Find(row.Cells["MaHDTC"].Value.ToString());

                sim_cat = db.ThongTinSIM.Find(row.Cells["IDSIM"].Value.ToString());
            }
        }

        private void load_Click(object sender, EventArgs e)
        {
            var sim_cut = (from sim in db.ThongTinSIM
                               where sim.Flag == false
                               select sim).OrderBy(i => i.NgayDangKy);

            dvCutSIM.DataSource = sim_cut.ToList();

            int row = 0;

            foreach (ThongTinSIM sim in sim_cut)
            {
                dvCutSIM.Rows[row].Cells["TenKHCUT"].Value = sim.KhachHang.TenKH;

                row++;
            }

            dvCutSIM.ClearSelection();

            dvHoaDonCut.DataSource = null;
        }

        private void dvCutSIM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                DataGridViewRow row = dvCutSIM.Rows[e.RowIndex];

                sim = db.ThongTinSIM.Find(row.Cells["IDSIMCUT"].Value.ToString());
            }

            var hd_cut = (from hdtc in db.HoaDonTinhCuoc
                          where hdtc.ThanhToan == false && hdtc.IDSIM == sim.IDSIM && hdtc.Flag == true
                          select hdtc).OrderBy(i => i.NgayLapHD).ToList();

            dvHoaDonCut.DataSource = hd_cut;

            int row_hdcut = 0;

            foreach (HoaDonTinhCuoc hdtc in hd_cut)
            {
                dvHoaDonCut.Rows[row_hdcut].Cells["HanChot"].Value = Convert.ToDateTime(hdtc.NgayLapHD).AddDays(30).ToShortDateString();

                row_hdcut++;
            }

            dvHoaDonCut.ClearSelection();
        }

        private void restore_Click(object sender, EventArgs e)
        {
            if(dvCutSIM.SelectedCells.Count == 0)
            {
                MessageBox.Show("Hãy chọn SIM để phục hồi dịch vụ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var hd_check = (from hdtc in db.HoaDonTinhCuoc
                                where hdtc.ThanhToan == false && hdtc.IDSIM == sim.IDSIM && hdtc.Flag == true
                                select hdtc).OrderBy(i => i.NgayLapHD).ToList();

                int flag = 1;

                foreach(HoaDonTinhCuoc hd in hd_check)
                {
                    if(hd.ThanhToan == false)
                    {
                        flag = 0;
                    }
                }

                if(flag != 1)
                {
                    MessageBox.Show(sim.IDSIM + " vẫn còn hóa đơn chưa thanh toán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sim.Flag = true;

                    db.Entry(sim).State = EntityState.Modified;
                    db.SaveChanges();

                    MessageBox.Show(sim.IDSIM + " đã được phục hồi dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    load_Click(sender, e);
                }
            }
        }

        private void cut_Click(object sender, EventArgs e)
        {
            if (dvHoaDonChuaThanhToan.SelectedCells.Count == 0)
            {
                MessageBox.Show("Hãy chọn hóa đơn để cắt dịch vụ của SIM tương úng với hóa đơn", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn có muốn cắt dịch vụ của " + sim_cat.IDSIM + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rs == DialogResult.Yes)
                {
                    sim_cat.Flag = false;

                    db.Entry(sim_cat).State = EntityState.Modified;
                    db.SaveChanges();

                    MessageBox.Show(sim_cat.IDSIM + " đã bị cắt dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
    }
}
