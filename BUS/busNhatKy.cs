using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class busNhatKy
    {
        public static DataTable GetNhatKy()
        {
            return dalNhatKy.getData();
        }
        public static void themnk(tblNhatKy nk)
        {
            dalNhatKy.InsertNK(nk);
        }

    }
}
