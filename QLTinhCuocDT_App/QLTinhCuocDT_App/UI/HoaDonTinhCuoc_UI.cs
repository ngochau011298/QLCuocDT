using QLTinhCuocDT_App.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace QLTinhCuocDT_App.UI
{
    public partial class HoaDonTinhCuoc_UI : Form
    {
        public HoaDonTinhCuoc_UI()
        {
            InitializeComponent();
        }

        QLTinhCuocDT_DbContext db = new QLTinhCuocDT_DbContext();

        public void Clear()
        {
            tbxMaHDTC.Clear();
            tbxIDSIM.Clear();
            tbxPhiThueBao.Clear();
            tbxTongTien.Clear();
            tbxNgayLapHD.Clear();
            ckbThanhToan.Checked = false;

            tbxsearch.Clear();
            hoaDonTinhCuocBindingSource.DataSource = (from hdtc in db.HoaDonTinhCuoc where hdtc.Flag == true select hdtc).ToList();

            dvHoaDonTinhCuoc.DataSource = hoaDonTinhCuocBindingSource;

            int row = 0;

            foreach (HoaDonTinhCuoc hdtc in hoaDonTinhCuocBindingSource)
            {
                dvHoaDonTinhCuoc.Rows[row].Cells["TenKH"].Value = hdtc.ThongTinSIM.KhachHang.TenKH;

                row++;
            }

            dvHoaDonTinhCuoc.ClearSelection();
        }

        private void HoaDonTinhCuoc_UI_FormClosing(object sender, FormClosingEventArgs e)
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

        private void HoaDonTinhCuoc_UI_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 f = new Form1();
            f.Show();
        }

        private void dvHoaDonTinhCuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                DataGridViewRow row = dvHoaDonTinhCuoc.Rows[e.RowIndex];
                tbxMaHDTC.Text = row.Cells["MaHDTC"].Value.ToString();
                tbxIDSIM.Text = row.Cells["IDSIM"].Value.ToString();
                tbxPhiThueBao.Text = row.Cells["PhiThueBao"].Value.ToString();
                tbxTongTien.Text = row.Cells["TongTien"].Value.ToString();
                tbxNgayLapHD.Text = Convert.ToDateTime(row.Cells["NgayLapHD"].Value).ToShortDateString();

                if(row.Cells["ThanhToan"].Value.Equals(true))
                {
                    ckbThanhToan.Checked = true;
                }
                else
                {
                    ckbThanhToan.Checked = false;
                }
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            HoaDonTinhCuoc hdtc = db.HoaDonTinhCuoc.Find(tbxMaHDTC.Text);

            DialogResult rs = MessageBox.Show("Bạn có muốn xóa " + hdtc.MaHDTC + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                hdtc.Flag = false;

                db.Entry(hdtc).State = EntityState.Modified;
                db.SaveChanges();

                Clear();
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (tbxMaHDTC.Text.Equals(""))
            {
                MessageBox.Show("Hãy chọn hóa đơn để cập nhật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HoaDonTinhCuoc hdtc = db.HoaDonTinhCuoc.Find(tbxMaHDTC.Text);

                if (ckbThanhToan.Checked == true)
                {
                    hdtc.ThanhToan = true;
                }
                else
                {
                    hdtc.ThanhToan = false;
                }

                db.Entry(hdtc).State = EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show("Hóa đơn " + hdtc.MaHDTC + " đã được thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear();
            }
        }

        private void Add_formclosed(object sender, FormClosedEventArgs e)
        {
            Clear();
        }

        private void them_Click(object sender, EventArgs e)
        {
            NewHoaDonTinhCuoc_UI newhdtc = new NewHoaDonTinhCuoc_UI();

            newhdtc.FormClosed += new FormClosedEventHandler(Add_formclosed);

            newhdtc.Show();
        }

        private void retype_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void email_Click(object sender, EventArgs e)
        {
            if (tbxIDSIM.Text.Equals(""))
            {
                MessageBox.Show("Hãy chọn hóa đơn để gửi Email", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                HoaDonTinhCuoc hdtc = db.HoaDonTinhCuoc.Find(tbxMaHDTC.Text);

                if(hdtc.ThanhToan == true)
                {
                    MessageBox.Show("Hóa đơn " + tbxMaHDTC.Text + " đã được thanh toán", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string ToEmail = (from a in db.KhachHang
                                      from b in db.ThongTinSIM
                                      where a.MaKH == b.MaKH && b.IDSIM == tbxIDSIM.Text && a.Flag == true
                                      select a.Email).FirstOrDefault().ToString();

                    if (ToEmail.Equals(""))
                    {
                        MessageBox.Show("Chủ sỡ hữu " + tbxIDSIM.Text + " không cung cấp địa chỉ Email", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Gmail model = new Gmail();

                        MailMessage mm = new MailMessage();
                        mm.From = new MailAddress(ConfigurationManager.AppSettings["FromEmailAddress"].ToString());

                        mm.To.Add(new MailAddress(ToEmail));

                        mm.Subject = "Hóa đơn tiền điện thoại tháng " + Convert.ToDateTime(tbxNgayLapHD.Text).Month;
                        mm.Body = "Chi tiết hóa đơn của " + tbxIDSIM.Text + ":\nPhí thuê bao: " + tbxPhiThueBao.Text + "\nTổng tiền: " + tbxTongTien.Text +
                                    "\nVui lòng đến đại lý để thanh toán!";
                        mm.IsBodyHtml = false;

                        SmtpClient smtp = new SmtpClient();
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;
                        smtp.EnableSsl = true;

                        NetworkCredential nc = new NetworkCredential(ConfigurationManager.AppSettings["FromEmailAddress"].ToString(), ConfigurationManager.AppSettings["FromEmailPassword"].ToString());
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = nc;
                        smtp.Send(mm);

                        MessageBox.Show("Đã gửi Email hóa đơn tháng " + Convert.ToDateTime(tbxNgayLapHD.Text).Month + " đến cho " + tbxIDSIM.Text + "\nĐịa chỉ Email: " + ToEmail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        private void tim_Click(object sender, EventArgs e)
        {
            var ctsd = from ct in db.HoaDonTinhCuoc where ct.Flag == true select ct;

            if (!string.IsNullOrEmpty(tbxsearch.Text))
            {
                ctsd = ctsd.Where(s => s.IDSIM.Contains(tbxsearch.Text)
                || s.ThongTinSIM.KhachHang.TenKH.Contains(tbxsearch.Text));
            }

            dvHoaDonTinhCuoc.DataSource = ctsd.OrderBy(i => i.MaHDTC).ToList();

            int row = 0;

            foreach (HoaDonTinhCuoc hdtc in ctsd)
            {
                dvHoaDonTinhCuoc.Rows[row].Cells["TenKH"].Value = hdtc.ThongTinSIM.KhachHang.TenKH;

                row++;
            }

            dvHoaDonTinhCuoc.ClearSelection();
        }
    }
}
