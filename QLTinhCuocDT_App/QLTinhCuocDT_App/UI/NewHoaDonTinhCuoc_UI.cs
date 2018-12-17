using QLTinhCuocDT_App.DAL;
using QLTinhCuocDT_App.Entity;
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

namespace QLTinhCuocDT_App.UI
{
    public partial class NewHoaDonTinhCuoc_UI : Form
    {
        public NewHoaDonTinhCuoc_UI()
        {
            InitializeComponent();
        }

        HoaDonTinhCuoc_DAL dal = new HoaDonTinhCuoc_DAL();

        QLTinhCuocDT_DbContext db = new QLTinhCuocDT_DbContext();

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void NewHoaDonTinhCuoc_UI_Load(object sender, EventArgs e)
        {
            thongTinSIMBindingSource.DataSource = db.ThongTinSIM.Where(x => x.Flag == true).ToList();

            dvThongTinSIM.DataSource = thongTinSIMBindingSource;

            int row = 0;

            foreach (ThongTinSIM sim in thongTinSIMBindingSource)
            {
                dvThongTinSIM.Rows[row].Cells["TenKH"].Value = sim.KhachHang.TenKH;

                row++;
            }

            dvThongTinSIM.ClearSelection();
        }

        private void dvThongTinSIM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                DataGridViewRow row = dvThongTinSIM.Rows[e.RowIndex];
                tbxIDSIM.Text = row.Cells["IDSIM"].Value.ToString();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            int flag = 1;
            try
            {
                string error = "Vui lòng nhập vào: ";
                if (dal.TestNull(tbxIDSIM.Text) == true)
                {
                    error += "Thông tin SIM / Số điện thoại";
                    flag = 0;
                }
                if (dal.TestNull(numPhiThueBao.Text) == true)
                {
                    if (flag == 0)
                    {
                        error += ", Phí thuê bao";
                        flag = 0;
                    }
                    else
                    {
                        error += "Phí thuê bao";
                        flag = 0;
                    }
                }
                
                if (flag == 0)
                    MessageBox.Show("Thiếu thông tin!\n" + error + ".", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (flag != 0)
                    {
                        var hdtc = new HoaDonTinhCuoc();

                        hdtc.MaHDTC = dal.AutoID();
                        hdtc.IDSIM = tbxIDSIM.Text;
                        hdtc.PhiThueBao = numPhiThueBao.Value;
                        hdtc.TongTien = Convert.ToDecimal(tbxTongTien.Text);
                        hdtc.NgayLapHD = dtpNgayLapHD.Value;
                        hdtc.ThanhToan = false;
                        hdtc.Flag = true;

                        db.HoaDonTinhCuoc.Add(hdtc);
                        db.SaveChanges();

                        MessageBox.Show("Thêm hóa đơn " + hdtc.MaHDTC + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        this.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxIDSIM_TextChanged(object sender, EventArgs e)
        {
            if (tbxIDSIM.Text.Equals(""))
            {
                tbxTongTien.Clear();
            }
            else
            {
                tbxTongTien.Text = dal.CalculateBill(tbxIDSIM.Text, dtpNgayLapHD.Value, dtpNgayLapHD.Value, numPhiThueBao.Value).ToString("#,##0");
            }
        }

        private void dtpNgayLapHD_ValueChanged(object sender, EventArgs e)
        {
            tbxTongTien.Text = dal.CalculateBill(tbxIDSIM.Text, dtpNgayLapHD.Value, dtpNgayLapHD.Value, numPhiThueBao.Value).ToString("#,##0");
        }

        private void numPhiThueBao_ValueChanged(object sender, EventArgs e)
        {
            if (numPhiThueBao.Text.Equals(""))
            {
                tbxTongTien.Clear();
            }
            else
            {
                tbxTongTien.Text = dal.CalculateBill(tbxIDSIM.Text, dtpNgayLapHD.Value, dtpNgayLapHD.Value, numPhiThueBao.Value).ToString("#,##0");
            }
        }
    }
}
