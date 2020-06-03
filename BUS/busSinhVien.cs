using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;


namespace BUS
{
    public class busSinhVien
    {
        public static DataTable getSinhVien()
        {
            return dalSinhVien.getData();
        }
        public static void InsertSinhVien(DTO.tblSinhVien SV)
        {
            dalSinhVien.InsertSV(SV);
        }
        public static void UpdateSinhVien(DTO.tblSinhVien SV)
        {
            dalSinhVien.UpdateSV(SV);
        }
        public static void DeleteSinhVien(string SV)
        {
            dalSinhVien.DeleteSV(SV);
        }
        public static DataTable SreachSinhVien(string maSV)
        {
            return dalSinhVien.SreachSV(maSV);
        }
        public static DataTable LopSinhVien()
        {
            return dalSinhVien.Lop();
        }
        public static DataTable SreachLop(String ma)
        {
            return dalSinhVien.SreachL(ma);
        }
    }
}
