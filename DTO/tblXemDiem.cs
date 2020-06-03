using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblXemDiem
    {
        private String MaSV;
        private String MaHK;
        private String DiemTBc;
        private String XepLoai;

        public tblXemDiem(string diemTBc, string xepLoai)
        {
            DiemTBc = diemTBc;
            XepLoai = xepLoai;
        }

        public string MaSV1 { get => MaSV; set => MaSV = value; }
        public string MaHK1 { get => MaHK; set => MaHK = value; }
        public string DiemTBc1 { get => DiemTBc; set => DiemTBc = value; }
        public string XepLoai1 { get => XepLoai; set => XepLoai = value; }

       
    }
}
