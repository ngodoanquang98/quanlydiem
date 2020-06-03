using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblLop
    {
        private String MaLop;
        private String TenLop;
        private int SiSo;
        private String MaKhoa;
        private String NienKhoa;

        public tblLop(string maLop, string tenLop, int siSo, string maKhoa, string nienKhoa)
        {
            MaLop = maLop;
            TenLop = tenLop;
            SiSo = siSo;
            MaKhoa = maKhoa;
            NienKhoa = nienKhoa;
        }

        public string MaLop1 { get => MaLop; set => MaLop = value; }
        public string TenLop1 { get => TenLop; set => TenLop = value; }
        public int SiSo1 { get => SiSo; set => SiSo = value; }
        public string MaKhoa1 { get => MaKhoa; set => MaKhoa = value; }
        public string NienKhoa1 { get => NienKhoa; set => NienKhoa = value; }
    }
}
