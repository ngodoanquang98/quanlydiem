using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class busHocPhan
    {
        public static DataTable getHocPhan()
        {
            return dalHocPhan.getData();
        }
        public static void InsertHocPhan(tblHocPhan hp)
        {
            dalHocPhan.InsertHP(hp);
        }
        public static void UpdateHocPhan(tblHocPhan hp)
        {
            dalHocPhan.UpdateHP(hp);
        }
        public static void DeleteHocPhan(string mahp)
        {
            dalHocPhan.DeleteHP(mahp);
        }
        public static DataTable SreachHocPhan(string mahp)
        {
            return dalHocPhan.SreachHP(mahp);
        }
    }
}
