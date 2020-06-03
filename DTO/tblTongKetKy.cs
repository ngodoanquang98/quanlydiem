using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblTongKetKy
    {
        private String MaKy;
        private String MaSV;
        private float DiemTBC;
        private String XepLoai;

        public tblTongKetKy(string maKy, string maSV, float diemTBC, string xepLoai)
        {
            MaKy = maKy;
            MaSV = maSV;
            DiemTBC = diemTBC;
            XepLoai = xepLoai;
        }

        public string MaKy1 { get => MaKy; set => MaKy = value; }
        public string MaSV1 { get => MaSV; set => MaSV = value; }
        public float DiemTBC1 { get => DiemTBC; set => DiemTBC = value; }
        public string XepLoai1 { get => XepLoai; set => XepLoai = value; }
    }
}
