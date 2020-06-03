using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblHocKy
    {
        private String MaHK;
        private DateTime TimeBatDau;
        private DateTime TimeKetThuc;

        public tblHocKy(string maHK, DateTime timeBatDau, DateTime timeKetThuc)
        {
            MaHK = maHK;
            TimeBatDau = timeBatDau;
            TimeKetThuc = timeKetThuc;
        }

        public string MaHK1 { get => MaHK; set => MaHK = value; }
        public DateTime TimeBatDau1 { get => TimeBatDau; set => TimeBatDau = value; }
        public DateTime TimeKetThuc1 { get => TimeKetThuc; set => TimeKetThuc = value; }
    }
}
