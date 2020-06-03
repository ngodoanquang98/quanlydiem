using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblHocPhan
    {
        private String MaHP;
        private String TenHP;
        private int SoTC;

        public tblHocPhan(string maHP, string tenHP, int soTC)
        {
            MaHP1 = maHP;
            TenHP1 = tenHP;
            SoTC1 = soTC;
        }

        public string MaHP1 { get => MaHP; set => MaHP = value; }
        public string TenHP1 { get => TenHP; set => TenHP = value; }
        public int SoTC1 { get => SoTC; set => SoTC = value; }
    }
}
