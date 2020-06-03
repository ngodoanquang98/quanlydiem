using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblLopHocPhan
    {
        private String MaLopHP;
        private String PhongHoc;
        private String TongSoSV;
        private int TietBatDau;
        private int TietKetThuc;
        private String Thu;
        private String MaHP;
        private String MaGV;
        private String MaHK;

        public tblLopHocPhan(string maLopHP, string phongHoc, string tongSoSV, int tietBatDau, int tietKetThuc, string thu, string maHP, string maGV, string maHK)
        {
            MaLopHP = maLopHP;
            PhongHoc = phongHoc;
            TongSoSV = tongSoSV;
            TietBatDau = tietBatDau;
            TietKetThuc = tietKetThuc;
            Thu = thu;
            MaHP = maHP;
            MaGV = maGV;
            MaHK = maHK;
        }

        public string PhongHoc1 { get => PhongHoc; set => PhongHoc = value; }
        public string TongSoSV1 { get => TongSoSV; set => TongSoSV = value; }
        public int TietBatDau1 { get => TietBatDau; set => TietBatDau = value; }
        public int TietKetThuc1 { get => TietKetThuc; set => TietKetThuc = value; }
        public string Thu1 { get => Thu; set => Thu = value; }
        public string MaHP1 { get => MaHP; set => MaHP = value; }
        public string MaGV1 { get => MaGV; set => MaGV = value; }
        public string MaHK1 { get => MaHK; set => MaHK = value; }
        public string MaLopHP1 { get => MaLopHP; set => MaLopHP = value; }
    }
}
