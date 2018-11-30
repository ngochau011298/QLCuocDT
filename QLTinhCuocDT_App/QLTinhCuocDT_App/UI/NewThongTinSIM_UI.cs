using QLTinhCuocDT_App.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTinhCuocDT_App.DAL;
using System.Data.SqlClient;

namespace QLTinhCuocDT_App.UI
{
    public partial class NewThongTinSIM_UI : Form
    {
        public NewThongTinSIM_UI()
        {
            InitializeComponent();
        }

        ThongTinSim_DAL dal = new ThongTinSim_DAL();

        QLTinhCuocDT_DbContext db = new QLTinhCuocDT_DbContext();

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void NewThongTinSIM_UI_Load(object sender, EventArgs e)
        {
            dvKhachHang.DataSource = (from kh in db.KhachHang where kh.Flag == true select kh).ToList();

            dtpNgayDangKy.Value = DateTime.Now;
            dtpNgayHetHan.Value = dtpNgayDangKy.Value.AddMonths(2);
        }

        private void dvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                DataGridViewRow row = dvKhachHang.Rows[e.RowIndex];
                tbxTenKH.Text = row.Cells["TenKH"].Value.ToString();
            }
        }

        private void dtpNgayDangKy_ValueChanged(object sender, EventArgs e)
        {
            dtpNgayHetHan.Value = dtpNgayDangKy.Value.AddMonths(3);
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
                if (dal.TestNull(tbxIDSIM.Text) == true)
                {
                    if (flag == 0)
                    {
                        error += ", Thông tin SIM / Số điện thoại";
                        flag = 0;
                    }
                    else
                    {
                        error += "Thông tin SIM / Số điện thoại";
                        flag = 0;
                    }
                }

                if (flag == 0)
                    MessageBox.Show("Thiếu thông tin!\n" + error + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (!tbxIDSIM.Text.Equals(""))
                    {
                        if (dal.TestNumber(tbxIDSIM.Text) == false)
                        {
                            MessageBox.Show("Số điện thoại chỉ cho phép nhập vào số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            flag = 0;
                        }
                        else
                        {
                            bool sim_exist = db.ThongTinSIM.Count(x => x.IDSIM == tbxIDSIM.Text) > 0;

                            if (sim_exist == true)
                            {
                                MessageBox.Show("Số điện thoại " + tbxIDSIM.Text + " đã có chủ sở hữu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                flag = 0;
                            }
                            else
                            {
                                var sim = new ThongTinSIM();

                                sim.IDSIM = tbxIDSIM.Text;
                                sim.MaKH = (from kh in db.KhachHang
                                            where kh.TenKH.Equals(tbxTenKH.Text)
                                            select kh.MaKH).FirstOrDefault().ToString();

                                sim.NgayDangKy = dtpNgayDangKy.Value;
                                sim.NgayHetHan = dtpNgayHetHan.Value;
                                sim.Flag = true;

                                db.ThongTinSIM.Add(sim);


                                var hddk = new HoaDonDangKy();

                                hddk.MaHDDK = dal.AutoID_HDDK();
                                hddk.IDSIM = tbxIDSIM.Text;

                                hddk.ChiPhiDangKy = 50000;
                                hddk.Flag = true;

                                db.HoaDonDangKy.Add(hddk);


                                db.SaveChanges();

                                MessageBox.Show("Thêm SĐT " + sim.IDSIM + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                                MessageBox.Show("Đã thêm hóa đơn đăng kí mới ứng với SĐT " + sim.IDSIM, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                                this.Close();
                            }
                        }
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
