using QLTinhCuocDT_App.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTinhCuocDT_App.DAL
{
    class GiaCuoc_DAL
    {
        QLTinhCuocDT_DbContext db = null;

        public GiaCuoc_DAL()
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
            int total = db.GiaCuoc.Count();
            int index = 0;

            if (total == 0)
            {
                index = 1;
            }
            else
            {
                index = total + 1;
            }

            string word = "GC";

            if (index < 10)
            {
                return word + "0" + index;
            }
            else
            {
                return word + index;
            }
        }
    }
}
