using QLTinhCuocDT_App.DAL;
using QLTinhCuocDT_App.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTinhCuocDT_App.UI
{
    public partial class NewKhachHang_UI : Form
    {
        public NewKhachHang_UI()
        {
            InitializeComponent();
        }

        KhachHang_DAL dal = new KhachHang_DAL();

        QLTinhCuocDT_DbContext db = new QLTinhCuocDT_DbContext();

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void save_Click(object sender, EventArgs e)
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
                        var kh = new KhachHang();
                        kh.MaKH = dal.AutoID();
                        kh.TenKH = tbxTenKH.Text;
                        kh.CMND = tbxCMND.Text;
                        kh.Email = tbxEmail.Text;
                        kh.NgheNghiep = tbxNgheNghiep.Text;
                        kh.ChucVu = tbxChucVu.Text;
                        kh.DiaChi = tbxDiaChi.Text;
                        kh.Flag = true;

                        db.KhachHang.Add(kh);
                        db.SaveChanges();

                        MessageBox.Show("Thêm khách hàng " + kh.TenKH + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        this.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
