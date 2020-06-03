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
    public class busGiangVien
    {
        public static DataTable getGiangVien()
        {
            return dalGiangVien.getData();
        }
        public static void InsertGiangVien(DTO.tblGiangVien gv)
        {
            dalGiangVien.InsertGV(gv);
        }
        public static void UpdateGiangVien(DTO.tblGiangVien gv)
        {
            dalGiangVien.UpdateGV(gv);
        }
        public static void DeleteGiangVien(string gv)
        {
            dalGiangVien.DeleteGV(gv);
        }
        public static DataTable SreachGiangVien(string magv)
        {
            return dalGiangVien.SreachGV(magv);
        }
        public static DataTable Khoa()
        {
           return dalGiangVien.Khoa();
        }
    }
}
