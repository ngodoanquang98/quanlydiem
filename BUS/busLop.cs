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
    public class busLop
    {
        public static DataTable getLop()
        {
            return dalLop.getData();
        }
        public static void InsertLop(tblLop gv)
        {
            dalLop.InsertL(gv);
        }
        public static void UpdateLop(tblLop gv)
        {
            dalLop.UpdateL(gv);
        }
        public static void DeleteLop(string gv)
        {
            dalLop.DeleteL(gv);
        }
        public static DataTable SreachLop(string magv)
        {
            return dalLop.SreachL(magv);
        }
        public static DataTable Khoa()
        {
            return dalLop.Khoa();
        }
    }
}
