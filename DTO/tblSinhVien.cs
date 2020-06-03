using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblSinhVien
    {
        private String MaSV;
        private String HoTen;
        private DateTime NgaySinh;
        private String GioiTinh;
        private String QueQuan;
        private String DiaChiHT;
        private String MaLop;
        private int SoTinChiDaDat;
        private float DiemTichLuy;
        private int SoTinChiDaDKi;

        public tblSinhVien(string maSV, string hoTen, DateTime ngaySinh, string gioiTinh, string queQuan, string diaChiHT, string maLop, int soTinChiDaDat, float diemTichLuy, int soTinChiDaDKi)
        {
            MaSV = maSV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            QueQuan = queQuan;
            DiaChiHT = diaChiHT;
            MaLop = maLop;
            SoTinChiDaDat = soTinChiDaDat;
            DiemTichLuy = diemTichLuy;
            SoTinChiDaDKi = soTinChiDaDKi;
        }

        public string MaSV1 { get => MaSV; set => MaSV = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string QueQuan1 { get => QueQuan; set => QueQuan = value; }
        public string DiaChiHT1 { get => DiaChiHT; set => DiaChiHT = value; }
        public string MaLop1 { get => MaLop; set => MaLop = value; }
        public int SoTinChiDaDat1 { get => SoTinChiDaDat; set => SoTinChiDaDat = value; }
        public float DiemTichLuy1 { get => DiemTichLuy; set => DiemTichLuy = value; }
        public int SoTinChiDaDKi1 { get => SoTinChiDaDKi; set => SoTinChiDaDKi = value; }
    }
}
