using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BUS
{
    public class busLopHocPhan
    {
        public static DataTable getLopHocPhan()
        {
            return dalLopHocPhan.getData();
        }
        public static void InsertLopHocPhan(DTO.tblLopHocPhan LHP)
        {
            dalLopHocPhan.InsertLHP(LHP);
        }
        public static void UpdateLopHocPhan(DTO.tblLopHocPhan LHP)
        {
            dalLopHocPhan.UpdateLHP(LHP);
        }
        public static void DeleteLopHocPhan(string LHP)
        {
            dalLopHocPhan.DeleteLHP(LHP);
        }
        public static DataTable SreachLopHocPhan(string maLHP)
        {
            return dalLopHocPhan.SreachLHP(maLHP);
        }
        public static DataTable LopHocPhan()
        {
            return dalLopHocPhan.LopHP();
        }
        public static DataTable soluong()
        {
            return dalLopHocPhan.SL();
        }
    }
}
