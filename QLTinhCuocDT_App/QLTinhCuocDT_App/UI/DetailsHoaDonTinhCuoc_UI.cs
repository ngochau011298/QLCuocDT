using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTinhCuocDT_App.Entity;

namespace QLTinhCuocDT_App.UI
{
    public partial class DetailsHoaDonTinhCuoc_UI : Form
    {
        public DetailsHoaDonTinhCuoc_UI(HoaDonTinhCuoc hdtc)
        {
            InitializeComponent();

            tbxMaHDTC.Text = hdtc.MaHDTC;
            tbxMaHDTC.TabStop = false;

            tbxIDSIM.Text = hdtc.IDSIM;
            tbxIDSIM.TabStop = false;

            tbxNgayLapHD.Text = Convert.ToDateTime(hdtc.NgayLapHD).ToString("dd/MM/yyyy");
            tbxNgayLapHD.TabStop = false;

            tbxPhiThueBao.Text = hdtc.PhiThueBao.ToString();
            tbxPhiThueBao.TabStop = false;

            tbxTongTien.Text = hdtc.TongTien.ToString();
            tbxTongTien.TabStop = false;

            tbxHanChot.Text = Convert.ToDateTime(hdtc.NgayLapHD).AddDays(30).ToString("dd/MM/yyyy");
            tbxHanChot.TabStop = false;

            DateTime now = DateTime.Now;
            if(now > Convert.ToDateTime(tbxHanChot.Text))
            {
                ckbIsOver.Checked = true;
                labelIsOver.ForeColor = Color.Red;
            }
            else
            {
                ckbIsOver.Checked = false;
            }
        }

        QLTinhCuocDT_DbContext db = new QLTinhCuocDT_DbContext();

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void email_Click(object sender, EventArgs e)
        {
            if (ckbIsOver.Checked == false)
            {
                MessageBox.Show("Hóa đơn chưa vượt quá hạn chót thanh toán", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    mm.Subject = "Đình chỉ cung cấp dịch vụ cho " + tbxIDSIM.Text;
                    mm.Body = "Vì chủ sỡ hữu của " + tbxIDSIM.Text + " không thanh toán hóa đơn tháng " + Convert.ToDateTime(tbxHanChot.Text).Month +
                                " ( Tổng tiền: " + tbxTongTien.Text + " ) đúng hạn, chúng tôi sẽ ngừng cung cấp dịch vụ cho " + tbxIDSIM.Text +
                                ".\nĐể tiếp tục sử dụng dịch vụ, vui lòng đến đại lý để thanh toán hóa đơn trong thời gian sớm nhất có thể!";
                    mm.IsBodyHtml = false;

                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;

                    NetworkCredential nc = new NetworkCredential(ConfigurationManager.AppSettings["FromEmailAddress"].ToString(), ConfigurationManager.AppSettings["FromEmailPassword"].ToString());
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = nc;
                    smtp.Send(mm);

                    MessageBox.Show("Đã gửi Email đình chỉ cung cấp dịch vụ đến cho " + tbxIDSIM.Text + "\nĐịa chỉ Email: " + ToEmail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
    }
}
