using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblDangki
    {
        private String MaLopHP;
        private String MaSV;

        public tblDangki(string maSV)
        {
            MaSV = maSV;
        }

        public tblDangki(string maLopHP, string maSV)
        {
            MaLopHP = maLopHP;
            MaSV = maSV;
        }

        public string MaLopHP1 { get => MaLopHP; set => MaLopHP = value; }
        public string MaSV1 { get => MaSV; set => MaSV = value; }
    }
}
