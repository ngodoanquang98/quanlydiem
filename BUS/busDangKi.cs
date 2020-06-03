using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class busDangKi
    {
        public static DataTable getDK(string gv)
        {
            return balDangKi.getData(gv);
        }
        public static void InsertDK(tblDangki gv)
        {
            balDangKi.InsertL(gv);
        }
        public static DataTable KhoaDK()
        {
            return balDangKi.Khoa();
        }
        public static DataTable XXX()
        {
            return balDangKi.LHP();
        }
    }
}
