using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Random_File.Entity;

namespace Random_File.DAL
{
    class Log_DAL
    {
        QLTinhCuocDT_DbContext db = null;

        public Log_DAL()
        {
            db = new QLTinhCuocDT_DbContext();
        }

        public List<string> GetIDSIM()
        {
            var IDSIM = from sim in db.ThongTinSIM where sim.Flag == true select sim.IDSIM;
            return IDSIM.ToList();
        }

        public string AutoID()
        {
            int total = db.ChiTietSuDung.Count();
            int index = 0;

            if(total == 0)
            {
                index = 1;
            }
            else
            {
                index = total + 1;
            }


            if(index < 10)
            {
                return "CT00" + index;
            }
            else if (index < 100)
            {
                return "CT0" + index;
            }
            else
            {
                return "CT" + index;
            }
        }
    }
}
