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
    public class busChamDiem
    {
        public static DataTable getDiem()
        {
            return dalChamDiem.getData();
        }
        public static void InsertDiem(tblKetQuaLHP gv)
        {
            dalChamDiem.InsertL(gv);
        }
        public static void UpdateLop(tblKetQuaLHP gv)
        {
            dalChamDiem.UpdateL(gv);
        }
        public static void DeleteLop(string gv)
        {
            dalChamDiem.DeleteL(gv);
        }
        public static DataTable SreachLop(string magv)
        {
            return dalChamDiem.SreachL(magv);
        }
        public static DataTable Khoa()
        {
            return dalChamDiem.Khoa();
        }
        public static DataTable Khoa1()
        {
            return dalChamDiem.Khoa1();
        }
    }
}
