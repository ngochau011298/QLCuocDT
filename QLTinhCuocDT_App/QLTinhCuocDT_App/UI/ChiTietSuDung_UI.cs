using QLTinhCuocDT_App.DAL;
using QLTinhCuocDT_App.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTinhCuocDT_App.UI
{
    public partial class ChiTietSuDung_UI : Form
    {
        public ChiTietSuDung_UI()
        {
            InitializeComponent();
        }

        ChiTietSuDung_DAL dal = new ChiTietSuDung_DAL();

        QLTinhCuocDT_DbContext db = new QLTinhCuocDT_DbContext();

        public void Clear()
        {
            tbxMaCTSD.Clear();
            tbxIDSIM.Clear();
            tbxTGBD.Clear();
            tbxTGKT.Clear();
            tbxSoPhutSD.Clear();
            tbxPhiCuocGoi.Clear();

            tbxsearch.Clear();
            dvChiTietSD.DataSource = (from ctsd in db.ChiTietSuDung where ctsd.Flag == true select ctsd).ToList();
            dvChiTietSD.ClearSelection();
        }

        private void ChiTietSuDung_UI_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Title = "Chọn file Log để lưu vào CSDL";
            open.Filter = "TXT files|*.txt";
            open.InitialDirectory = @"../../../";

            if (open.ShowDialog() == DialogResult.OK)
            {
                string filename = open.FileName;

                string[] fileContent = File.ReadAllLines(filename);

                string[] columns = null;

                foreach (string dataLine in fileContent)
                {
                    if (dataLine.Equals(""))
                    {
                        continue;
                    }
                    else
                    {
                        columns = dataLine.Split('|');

                        for (int i = 0; i < columns.Length; i++)
                        {
                            columns[i] = columns[i].Replace("\t", "");
                        }

                        var chitiet = new ChiTietSuDung();
                        chitiet.MaChiTiet = dal.AutoID();
                        chitiet.IDSIM = columns[0].ToString();
                        chitiet.TGBD = Convert.ToDateTime(columns[1]);
                        chitiet.TGKT = Convert.ToDateTime(columns[2]);

                        chitiet.SoPhutSD = dal.CalculateMinutes(Convert.ToDateTime(chitiet.TGBD), Convert.ToDateTime(chitiet.TGKT));

                        int fee1minutes = 0;
                        int fee2minutes = 0;

                        dal.CalculateFeeMinutes(Convert.ToDateTime(chitiet.TGBD), Convert.ToDateTime(chitiet.TGKT), ref fee1minutes, ref fee2minutes);

                        decimal price1 = Convert.ToDecimal((from gia in db.GiaCuoc where gia.MaGiaCuoc == "GC01" select gia.Gia).FirstOrDefault());
                        decimal price2 = Convert.ToDecimal((from gia in db.GiaCuoc where gia.MaGiaCuoc == "GC02" select gia.Gia).FirstOrDefault());

                        decimal fee1 = fee1minutes * price1;
                        decimal fee2 = fee2minutes * price2;

                        chitiet.PhiCuocGoi = fee1 + fee2;

                        chitiet.Flag = true;

                        db.ChiTietSuDung.Add(chitiet);
                        db.SaveChanges();

                        Clear();
                    }
                }

                MessageBox.Show("Nhập dữ liệu thành công!\nFile log:  " + open.FileName, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                // Do nothing
            }
        }

        private void ChiTietSuDung_UI_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void retype_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dvChiTietSD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                DataGridViewRow row = dvChiTietSD.Rows[e.RowIndex];
                tbxMaCTSD.Text = row.Cells["MaChiTiet"].Value.ToString();
                tbxIDSIM.Text = row.Cells["IDSIM"].Value.ToString();
                tbxTGBD.Text = row.Cells["TGBD"].Value.ToString();
                tbxTGKT.Text = row.Cells["TGKT"].Value.ToString();
                tbxSoPhutSD.Text = row.Cells["SoPhutSD"].Value.ToString();
                tbxPhiCuocGoi.Text = row.Cells["PhiCuocGoi"].Value.ToString();
            }
        }

        private void tim_Click(object sender, EventArgs e)
        {
            var chitiet = from ctsd in db.ChiTietSuDung where ctsd.Flag == true select ctsd;

            if (!string.IsNullOrEmpty(tbxsearch.Text))
            {
                chitiet = chitiet.Where(s => s.IDSIM.Contains(tbxsearch.Text));
            }

            dvChiTietSD.DataSource = chitiet.OrderBy(i => i.MaChiTiet).ToList();

            dvChiTietSD.ClearSelection();
        }
    }
}
