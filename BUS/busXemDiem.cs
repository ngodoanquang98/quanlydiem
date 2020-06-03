using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BUS
{
    public class busXemDiem
    {
        public static DataTable getDY()
        {
            return dalXemDiem.getDuLieu();
        }
        public static DataTable getD(string magv,string a)
        {
            return dalXemDiem.getData2(magv,a);
        }
        public static DataTable getDM(string magv)
        {
            return dalXemDiem.getData(magv);
        }
        public static DataTable VVV()
        {
            return dalXemDiem.LHP1();
        }
        public static DataTable getDX(string magv)
        {
            return dalXemDiem.getData3(magv);
        }
    }
}
