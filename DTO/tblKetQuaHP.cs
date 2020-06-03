using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblKetQuaHP
    {
        private String MaHP;
        private String MaSV;
        private float DiemCC;
        private float DiemTX;
        private float DiemThi;
        private float DiemHe10;
        private float DiemHeBon;
        private String DiemChu;

        public tblKetQuaHP(string maHP, string maSV, float diemCC, float diemTX, float diemThi, float diemHe10, float diemHeBon, string diemChu)
        {
            MaHP = maHP;
            MaSV = maSV;
            DiemCC = diemCC;
            DiemTX = diemTX;
            DiemThi = diemThi;
            DiemHe10 = diemHe10;
            DiemHeBon = diemHeBon;
            DiemChu = diemChu;
        }

        public string MaHP1 { get => MaHP; set => MaHP = value; }
        public string MaSV1 { get => MaSV; set => MaSV = value; }
        public float DiemCC1 { get => DiemCC; set => DiemCC = value; }
        public float DiemTX1 { get => DiemTX; set => DiemTX = value; }
        public float DiemThi1 { get => DiemThi; set => DiemThi = value; }
        public float DiemHe101 { get => DiemHe10; set => DiemHe10 = value; }
        public float DiemHeBon1 { get => DiemHeBon; set => DiemHeBon = value; }
        public string DiemChu1 { get => DiemChu; set => DiemChu = value; }
    }
}
