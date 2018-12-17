using QLTinhCuocDT_App.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTinhCuocDT_App.DAL
{
    class HoaDonTinhCuoc_DAL
    {
        QLTinhCuocDT_DbContext db = null;

        public HoaDonTinhCuoc_DAL()
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

        public bool TestNumber(string data)
        {
            double number;
            bool isNum = double.TryParse(data.ToString(), out number);
            return isNum;
        }

        public bool CheckCharNumber(char data)
        {
            double number;
            bool isNum = double.TryParse(data.ToString(), out number);
            return isNum;
        }

        public string AutoID()
        {
            int total = db.HoaDonTinhCuoc.Count();
            int index = 0;

            if (total == 0)
            {
                index = 1;
            }
            else
            {
                index = total + 1;
            }

            string word = "HD";

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

        public double CalculateBill(string id, DateTime now, DateTime last, decimal fee)
        {
            last = now.AddMonths(-1);

            var chitietsudung = (from ctsd in db.ChiTietSuDung
                                 where ctsd.IDSIM == id
                                 && ctsd.TGBD >= last && ctsd.TGKT <= now
                                 && ctsd.Flag == true
                                 select ctsd);

            decimal sum = Convert.ToDecimal(chitietsudung.AsEnumerable().Sum(o => o.PhiCuocGoi));

            decimal tongtien = sum + fee;

            return Convert.ToDouble(tongtien);
        }
    }
}
