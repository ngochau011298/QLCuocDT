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
using Random_File.DAL;
using Random_File.Entity;

namespace Random_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Log_DAL dal = new Log_DAL();

        QLTinhCuocDT_DbContext db = new QLTinhCuocDT_DbContext();

        /*public static string GenerateString(int length, Random gen)
        {
            string characters = "0123456789";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[gen.Next(characters.Length)]);
            }
            return result.ToString();
        }*/

        public DateTime GetStartTime(Random gen)
        {
            DateTime now = DateTime.Now;
            DateTime start = new DateTime(now.Year, 1, 1);
            return start.AddMonths(gen.Next(0, 12)).AddDays(gen.Next(0, 30)).AddHours(gen.Next(0, 24)).AddMinutes(gen.Next(0, 60)).AddSeconds(gen.Next(0, 60));
        }

        public int CalculateMinutes(DateTime start, DateTime end)
        {
            TimeSpan span = end.Subtract(start);
            return Convert.ToInt32(span.TotalMinutes);
        }

        public void CalculateFeeMinutes(DateTime start, DateTime end, ref int fee1minutes, ref int fee2minutes)
        {
            DateTime fee1Start = new DateTime(start.Year, start.Month, start.Day, 7, 0, 0);
            DateTime fee1End = new DateTime(start.Year, start.Month, start.Day, 23, 0, 0);

            DateTime fee2End = fee1Start.AddDays(1);

            if (start > fee1Start)
            {
                if (start > fee1End)
                {
                    if (end <= fee2End)
                    {
                        fee2minutes = CalculateMinutes(start, end);
                    }
                    else if (end > fee2End)
                    {
                        fee2minutes = Convert.ToInt32(fee2End.Subtract(start).TotalMinutes);
                        fee1Start = fee1Start.AddDays(1);
                        fee1minutes = Convert.ToInt32(fee1Start.Subtract(end).TotalMinutes) * (-1);
                    }
                }
                else
                {
                    if (end <= fee1End)
                    {
                        fee1minutes = CalculateMinutes(start, end);
                    }
                    else if (end > fee1End)
                    {
                        fee1minutes = Convert.ToInt32(fee1End.Subtract(start).TotalMinutes);
                        fee2minutes = Convert.ToInt32(fee1End.Subtract(end).TotalMinutes) * (-1);
                    }
                }
            }

            else if (start < fee1Start)
            {
                if (end <= fee1Start)
                {
                    fee2minutes = CalculateMinutes(start, end);
                }
                else if (end > fee1Start)
                {
                    fee2minutes = Convert.ToInt32(fee1Start.Subtract(start).TotalMinutes);
                    fee1minutes = Convert.ToInt32(fee1Start.Subtract(end).TotalMinutes) * (-1);
                }
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            dvLog.Rows.Clear();

            int maxrows = 100;

            Random gen = new Random();

            List<string> IDs = dal.GetIDSIM();
            

            DateTime start;
            DateTime end;
            

            for (int i = 0; i < maxrows; i++)
            {
                dvLog.Rows.Add();

                dvLog.Rows[i].Cells["IDSIM"].Value = IDs[gen.Next(IDs.Count)];


                start = GetStartTime(gen);
                end = start.AddHours(gen.Next(0, 2)).AddMinutes(gen.Next(0, 60)).AddSeconds(gen.Next(0, 60));

                int fee1minutes = 0;
                int fee2minutes = 0;

                CalculateFeeMinutes(start, end, ref fee1minutes, ref fee2minutes);


                dvLog.Rows[i].Cells["TGBD"].Value = start.ToString("dd-MM-yyyy   HH:mm:ss");
                dvLog.Rows[i].Cells["TGKT"].Value = end.ToString("dd-MM-yyyy   HH:mm:ss");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Title = "Xuất file Log";
            save.FileName = "Log " + DateTime.Now.ToString("dd-MM-yyyy") + ".txt";
            save.Filter = "Text File | *.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.OpenFile());

                for (int i = 0; i < dvLog.Rows.Count; i++)
                {
                    for (int j = 0; j < dvLog.Columns.Count; j++)
                    {
                        writer.Write("\t" + dvLog.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }

                    writer.WriteLine("");
                    writer.WriteLine("");
                }

                writer.Dispose();
                writer.Close();

                MessageBox.Show("Xuất thành công!\nĐường dẫn:  " + save.FileName, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                // Do nothing
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Title = "Chọn file Log để xem";
            open.Filter = "TXT files|*.txt";
            open.InitialDirectory = @"../../../";

            if (open.ShowDialog() == DialogResult.OK)
            {
                dvLog.Rows.Clear();

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

                        dvLog.Rows.Add(columns);
                    }
                }
            }
            else
            {
                // Do nothing
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            List<ChiTietSuDung> ctsd = (from chitiet in db.ChiTietSuDung select chitiet).ToList();
            db.ChiTietSuDung.RemoveRange(ctsd);
            db.SaveChanges();

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

                        chitiet.SoPhutSD = CalculateMinutes(Convert.ToDateTime(chitiet.TGBD), Convert.ToDateTime(chitiet.TGKT));

                        int fee1minutes = 0;
                        int fee2minutes = 0;

                        CalculateFeeMinutes(Convert.ToDateTime(chitiet.TGBD), Convert.ToDateTime(chitiet.TGKT), ref fee1minutes, ref fee2minutes);

                        decimal price1 = Convert.ToDecimal((from gia in db.GiaCuoc where gia.MaGiaCuoc == "GC01" select gia.Gia).FirstOrDefault());
                        decimal price2 = Convert.ToDecimal((from gia in db.GiaCuoc where gia.MaGiaCuoc == "GC02" select gia.Gia).FirstOrDefault());

                        decimal fee1 = fee1minutes * price1;
                        decimal fee2 = fee2minutes * price2;

                        chitiet.PhiCuocGoi = fee1 + fee2;

                        chitiet.Flag = true;

                        db.ChiTietSuDung.Add(chitiet);
                        db.SaveChanges();
                    }
                }

                MessageBox.Show("Lưu dữ liệu thành công!\nFile log:  " + open.FileName, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                // Do nothing
            }
        }
    }
}
