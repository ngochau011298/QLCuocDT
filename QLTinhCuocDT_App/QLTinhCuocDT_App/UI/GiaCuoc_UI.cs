using QLTinhCuocDT_App.DAL;
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
    public partial class GiaCuoc_UI : Form
    {
        public GiaCuoc_UI()
        {
            InitializeComponent();
        }

        GiaCuoc_DAL dal = new GiaCuoc_DAL();

        QLTinhCuocDT_DbContext db = new QLTinhCuocDT_DbContext();

        public void Clear()
        {
            tbxMaGiaCuoc.Clear();

            numGiaTien.Show();
            numGiaTien.Value = numGiaTien.Minimum;

            dtpTGBD.Value = DateTime.Now;
            dtpTGKT.Value = DateTime.Now;

            tbxsearch.Clear();
            dvGiaCuoc.DataSource = (from gc in db.GiaCuoc where gc.Flag == true select gc).ToList();
            dvGiaCuoc.ClearSelection();
        }

        private void GiaCuoc_UI_FormClosing(object sender, FormClosingEventArgs e)
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

        private void GiaCuoc_UI_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 f = new Form1();
            f.Show();
        }

        private void retype_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dvGiaCuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                DataGridViewRow row = dvGiaCuoc.Rows[e.RowIndex];
                tbxMaGiaCuoc.Text = row.Cells["MaGiaCuoc"].Value.ToString();
                dtpTGBD.Text = row.Cells["TGBD"].Value.ToString();
                dtpTGKT.Text = row.Cells["TGKT"].Value.ToString();
                numGiaTien.Value = Convert.ToDecimal(row.Cells["Gia"].Value);
            }
        }

        private void them_Click(object sender, EventArgs e)
        {
            int flag = 1;

            if (dtpTGKT.Value.TimeOfDay <= dtpTGBD.Value.TimeOfDay)
            {
                MessageBox.Show("Thời gian kết thúc phải lớn hơn thời gian bắt đầu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 0;
            }

            if (flag != 0)
            {
                var gc = new GiaCuoc();
                gc.MaGiaCuoc = dal.AutoID();

                gc.TGBD = TimeSpan.Parse(dtpTGBD.Value.TimeOfDay.ToString("hh\\:mm\\:ss"));
                gc.TGKT = TimeSpan.Parse(dtpTGKT.Value.TimeOfDay.ToString("hh\\:mm\\:ss"));
                
                gc.Gia = Convert.ToDecimal(numGiaTien.Value);
                gc.Flag = true;

                db.GiaCuoc.Add(gc);
                db.SaveChanges();

                MessageBox.Show("Thêm giá cước " + gc.MaGiaCuoc + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear();
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            int flag = 1;

            if (dtpTGKT.Value.TimeOfDay <= dtpTGBD.Value.TimeOfDay)
            {
                MessageBox.Show("Thời gian kết thúc phải lớn hơn thời gian bắt đầu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 0;
            }

            if (dal.TestNull(tbxMaGiaCuoc.Text) == true)
            {
                MessageBox.Show("Hãy chọn giá cước cần cập nhật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                flag = 0;
            }

            if (flag != 0)
            {
                GiaCuoc gc = db.GiaCuoc.Find(tbxMaGiaCuoc.Text);

                gc.TGBD = TimeSpan.Parse(dtpTGBD.Value.TimeOfDay.ToString("hh\\:mm\\:ss"));
                gc.TGKT = TimeSpan.Parse(dtpTGKT.Value.TimeOfDay.ToString("hh\\:mm\\:ss"));

                gc.Gia = Convert.ToDecimal(numGiaTien.Value);
                gc.Flag = true;

                db.Entry(gc).State = EntityState.Modified;
                db.SaveChanges();

                MessageBox.Show("Sửa thông tin của " + gc.MaGiaCuoc + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear();
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            GiaCuoc gc = db.GiaCuoc.Find(tbxMaGiaCuoc.Text);

            DialogResult rs = MessageBox.Show("Bạn có muốn xóa " + gc.MaGiaCuoc + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                gc.Flag = false;

                db.Entry(gc).State = EntityState.Modified;
                db.SaveChanges();

                Clear();
            }
        }

        private void tim_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxsearch.Text))
            {
                var giacuoc = db.GiaCuoc.SqlQuery("select * from GiaCuoc where Flag = 1 and Gia <= " + tbxsearch.Text + "");

                dvGiaCuoc.DataSource = giacuoc.OrderBy(i => i.MaGiaCuoc).ToList();

                dvGiaCuoc.ClearSelection();
            }
            else
            {
                dvGiaCuoc.DataSource = (from gc in db.GiaCuoc where gc.Flag == true select gc).ToList();

                dvGiaCuoc.ClearSelection();
            }
        }
    }
}
