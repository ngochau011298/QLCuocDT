using QLTinhCuocDT_App.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTinhCuocDT_App.DAL
{
    class ChiTietSuDung_DAL
    {
        QLTinhCuocDT_DbContext db = null;

        public ChiTietSuDung_DAL()
        {
            db = new QLTinhCuocDT_DbContext();
        }

        public bool TestNull(string data)
        {
            if (data == null || data.Trim() == "")
            {
                return true;
            }

            return false;
        }

        public bool CheckCharNumber(char data)
        {
            double number;
            bool isNum = double.TryParse(data.ToString(), out number);
            return isNum;
        }

        public string AutoID()
        {
            int total = db.ChiTietSuDung.Count();
            int index = 0;

            if (total == 0)
            {
                index = 1;
            }
            else
            {
                index = total + 1;
            }

            string word = "CT";

            if (index < 10)
            {
                return word + "00" + index;
            }
            else if (index < 100)
            {
                return word + "0" + index;
            }
            else
            {
                return word + index;
            }
        }

        public List<string> GetIDSIM()
        {
            var IDSIM = from sim in db.ThongTinSIM where sim.Flag == true select sim.IDSIM;
            return IDSIM.ToList();
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
    }
}
