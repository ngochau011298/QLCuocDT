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
    public partial class ThongTinSim_UI : Form
    {
        public ThongTinSim_UI()
        {
            InitializeComponent();
        }

        QLTinhCuocDT_DbContext db = new QLTinhCuocDT_DbContext();

        public void Clear()
        {
            tbxIDSIM.Clear();
            tbxTenKH.Clear();
            tbxNgayDangKy.Clear();
            dtpNgayHetHan.Value = DateTime.Now;

            tbxsearch.Clear();

            thongTinSIMBindingSource.DataSource = db.ThongTinSIM.Where(x => x.Flag == true).OrderBy(i => i.NgayDangKy).ToList();

            dvThongTinSim.DataSource = thongTinSIMBindingSource;

            int row = 0;

            foreach (ThongTinSIM sim in thongTinSIMBindingSource)
            {
                dvThongTinSim.Rows[row].Cells["TenKH"].Value = sim.KhachHang.TenKH;

                row++;
            }

            dvThongTinSim.ClearSelection();
        }

        private void ThongTinSim_UI_FormClosing(object sender, FormClosingEventArgs e)
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

        private void ThongTinSim_UI_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void dvThongTinSim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                DataGridViewRow row = dvThongTinSim.Rows[e.RowIndex];
                tbxIDSIM.Text = row.Cells["IDSIM"].Value.ToString();
                tbxTenKH.Text = row.Cells["TenKH"].Value.ToString();
                tbxNgayDangKy.Text = Convert.ToDateTime(row.Cells["NgayDangKy"].Value).ToShortDateString();
                dtpNgayHetHan.Value = Convert.ToDateTime(row.Cells["NgayHetHan"].Value);
            }
        }

        private void retype_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            ThongTinSIM sim = db.ThongTinSIM.Find(tbxIDSIM.Text);

            sim.IDSIM = tbxIDSIM.Text;
            sim.MaKH = (from kh in db.KhachHang where kh.TenKH.Equals(tbxTenKH.Text) select kh.MaKH).FirstOrDefault().ToString();
            sim.NgayDangKy = Convert.ToDateTime(tbxNgayDangKy.Text);
            sim.NgayHetHan = dtpNgayHetHan.Value;
            sim.Flag = true;

            db.Entry(sim).State = EntityState.Modified;
            db.SaveChanges();

            MessageBox.Show("Sửa thông tin của " + sim.IDSIM + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            Clear();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            ThongTinSIM sim = db.ThongTinSIM.Find(tbxIDSIM.Text);

            DialogResult rs = MessageBox.Show("Bạn có muốn xóa " + sim.IDSIM + " ?\nĐiều này đồng nghĩa với việc " + sim.IDSIM + " sẽ bị cắt dịch vụ!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                sim.Flag = false;

                db.Entry(sim).State = EntityState.Modified;
                db.SaveChanges();

                Clear();
            }
        }

        private void tim_Click(object sender, EventArgs e)
        {
            var ttsim = from sim in db.ThongTinSIM where sim.Flag == true select sim;

            if (!string.IsNullOrEmpty(tbxsearch.Text))
            {
                ttsim = ttsim.Where(s => s.IDSIM.Contains(tbxsearch.Text)
                || s.KhachHang.TenKH.Contains(tbxsearch.Text));
            }

            dvThongTinSim.DataSource = ttsim.OrderBy(i => i.NgayDangKy).ToList();

            int row = 0;

            foreach (ThongTinSIM sim in ttsim)
            {
                dvThongTinSim.Rows[row].Cells["TenKH"].Value = sim.KhachHang.TenKH;

                row++;
            }

            dvThongTinSim.ClearSelection();
        }

        private void Add_formclosed(object sender, FormClosedEventArgs e)
        {
            Clear();
        }

        private void them_Click(object sender, EventArgs e)
        {
            NewThongTinSIM_UI newsim = new NewThongTinSIM_UI();

            newsim.FormClosed += new FormClosedEventHandler(Add_formclosed);

            newsim.Show();
        }
    }
}
