using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblKetQuaLHP
    {
        private String MaLopHP;
        private String MaSV;
        private float DiemCC;
        private float DiemTX;
        private float DiemThi;
        private float DiemHe10;
        private float DiemHeBon;
        private String DiemChu;

        public tblKetQuaLHP()
        {
            MaLopHP = "";
            MaSV = "";
            DiemCC = 0;
            DiemTX = 0;
            DiemThi = 0;
        }
        public tblKetQuaLHP(string maLopHP, string maSV, float diemCC, float diemTX, float diemThi)
        {
            MaLopHP = maLopHP;
            MaSV = maSV;
            DiemCC = diemCC;
            DiemTX = diemTX;
            DiemThi = diemThi;          
        }

        public string MaLopHP1 { get => MaLopHP; set => MaLopHP = value; }
        public string MaSV1 { get => MaSV; set => MaSV = value; }
        public float DiemCC1 { get => DiemCC; set => DiemCC = value; }
        public float DiemTX1 { get => DiemTX; set => DiemTX = value; }
        public float DiemThi1 { get => DiemThi; set => DiemThi = value; }
        public float DiemHe101 { get => DiemHe10; set => DiemHe10 = value; }
        public float DiemHeBon1 { get => DiemHeBon; set => DiemHeBon = value; }
        public string DiemChu1 { get => DiemChu; set => DiemChu = value; }
    }
}
