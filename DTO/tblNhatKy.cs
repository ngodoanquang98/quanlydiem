using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblNhatKy
    {
        private String MaGV;
        private String Hoten;
        private DateTime Ngay;


        public tblNhatKy(string maGV)
        {
            MaGV = maGV;
            Ngay = DateTime.Now;
        }

        public string MaGV1 { get => MaGV; set => MaGV = value; }
        public DateTime Ngay1 { get => Ngay; set => Ngay = value; }
        public string Hoten1 { get => Hoten; set => Hoten = value; }
    }
}
