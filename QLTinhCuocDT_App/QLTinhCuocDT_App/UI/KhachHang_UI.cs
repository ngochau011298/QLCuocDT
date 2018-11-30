using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTinhCuocDT_App.DAL;
using QLTinhCuocDT_App.Entity;

namespace QLTinhCuocDT_App.UI
{
    public partial class KhachHang_UI : Form
    {
        public KhachHang_UI()
        {
            InitializeComponent();
        }

        KhachHang_DAL dal = new KhachHang_DAL();

        QLTinhCuocDT_DbContext db = new QLTinhCuocDT_DbContext();

        public void Clear()
        {
            tbxMaKH.Clear();
            tbxTenKH.Clear();
            tbxCMND.Clear();
            tbxEmail.Clear();
            tbxNgheNghiep.Clear();
            tbxChucVu.Clear();
            tbxDiaChi.Clear();

            tbxsearch.Clear();
            dvKhachHang.DataSource = (from kh in db.KhachHang where kh.Flag == true select kh).ToList();
            dvKhachHang.ClearSelection();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void KhachHang_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                DataGridViewRow row = dvKhachHang.Rows[e.RowIndex];
                tbxMaKH.Text = row.Cells["MaKH"].Value.ToString();
                tbxTenKH.Text = row.Cells["TenKH"].Value.ToString();
                tbxCMND.Text = row.Cells["CMND"].Value.ToString();
                tbxEmail.Text = row.Cells["Email"].Value.ToString();
                tbxNgheNghiep.Text = row.Cells["NgheNghiep"].Value.ToString();
                tbxChucVu.Text = row.Cells["ChucVu"].Value.ToString();
                tbxDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            }
        }

        private void retype_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Add_formclosed(object sender, FormClosedEventArgs e)
        {
            Clear();
        }

        private void them_Click(object sender, EventArgs e)
        {
            NewKhachHang_UI newkh = new NewKhachHang_UI();

            newkh.FormClosed += new FormClosedEventHandler(Add_formclosed);

            newkh.Show();
        }

        private void sua_Click(object sender, EventArgs e)
        {
            int flag = 1;
            try
            {
                string error = "Vui lòng nhập vào: ";
                if (dal.TestNull(tbxTenKH.Text) == true)
                {
                    error += "Tên khách hàng";
                    flag = 0;
                }
                if (dal.TestNull(tbxCMND.Text) == true)
                {
                    if (flag == 0)
                    {
                        error += ", CMND";
                        flag = 0;
                    }
                    else
                    {
                        error += "CMND";
                        flag = 0;
                    }
                }
                if (dal.TestNull(tbxNgheNghiep.Text) == true)
                {
                    if (flag == 0)
                    {
                        error += ", Nghề nghiệp";
                        flag = 0;
                    }
                    else
                    {
                        error += "Nghề nghiệp";
                        flag = 0;
                    }
                }
                if (dal.TestNull(tbxChucVu.Text) == true)
                {
                    if (flag == 0)
                    {
                        error += ", Chức vụ";
                        flag = 0;
                    }
                    else
                    {
                        error += "Chức vụ";
                        flag = 0;
                    }
                }
                if (dal.TestNull(tbxDiaChi.Text) == true)
                {
                    if (flag == 0)
                    {
                        error += ", Địa chỉ";
                        flag = 0;
                    }
                    else
                    {
                        error += "Địa chỉ";
                        flag = 0;
                    }
                }

                if (flag == 0)
                    MessageBox.Show("Thiếu thông tin!\n" + error + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (!tbxCMND.Text.Equals(""))
                    {
                        if (dal.TestNumber(tbxCMND.Text) == false)
                        {
                            MessageBox.Show("Số chứng minh chỉ cho phép nhập vào số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            flag = 0;
                        }
                    }
                    if (flag != 0)
                    {
                        KhachHang kh = db.KhachHang.Find(tbxMaKH.Text);

                        kh.TenKH = tbxTenKH.Text;
                        kh.CMND = tbxCMND.Text;
                        kh.Email = tbxEmail.Text;
                        kh.NgheNghiep = tbxNgheNghiep.Text;
                        kh.ChucVu = tbxChucVu.Text;
                        kh.DiaChi = tbxDiaChi.Text;
                        kh.Flag = true;

                        db.Entry(kh).State = EntityState.Modified;
                        db.SaveChanges();

                        MessageBox.Show("Sửa thông tin của " + kh.TenKH + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        Clear();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            KhachHang kh = db.KhachHang.Find(tbxMaKH.Text);

            DialogResult rs = MessageBox.Show("Bạn có muốn xóa " + kh.TenKH + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                kh.Flag = false;

                db.Entry(kh).State = EntityState.Modified;
                db.SaveChanges();

                Clear();
            }
        }

        private void tim_Click(object sender, EventArgs e)
        {
            var khachhang = from kh in db.KhachHang where kh.Flag == true select kh;

            if (!string.IsNullOrEmpty(tbxsearch.Text))
            {
                khachhang = khachhang.Where(s => s.TenKH.Contains(tbxsearch.Text)
                || s.Email.Contains(tbxsearch.Text)
                || s.NgheNghiep.Contains(tbxsearch.Text)
                || s.ChucVu.Contains(tbxsearch.Text)
                || s.DiaChi.Contains(tbxsearch.Text));
            }

            dvKhachHang.DataSource = khachhang.OrderBy(i => i.MaKH).ToList();

            dvKhachHang.ClearSelection();
        }
    }
}
