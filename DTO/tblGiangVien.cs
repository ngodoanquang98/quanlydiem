using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblGiangVien
        {
        private String MaGV;
        private String HoTen;
        private String SDT;
        private String HocVi;
        private String MaKhoa;

        public tblGiangVien(string maGV, string hoTen, string sDT, string hocVi, string maKhoa)
        {
            MaGV = maGV;
            HoTen = hoTen;
            SDT = sDT;
            HocVi = hocVi;
            MaKhoa = maKhoa;
        }

        public string MaGV1 { get => MaGV; set => MaGV = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string HocVi1 { get => HocVi; set => HocVi = value; }
        public string MaKhoa1 { get => MaKhoa; set => MaKhoa = value; }
    }
}
