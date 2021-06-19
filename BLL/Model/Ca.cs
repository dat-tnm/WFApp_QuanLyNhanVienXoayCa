using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public class Ca
    {
        public Ca()
        {

        }

        public Ca(string maCV, string ten, DateTime gioBatDau, DateTime gioKetThuc)
        {
            MaC = maCV;
            Ten = ten;
            GioBatDau = gioBatDau;
            GioKetThuc = gioKetThuc;
        }

        public Ca(object[] items) 
        {
            MaC = (string)items[0];
            Ten = (string)items[1];
            GioBatDau = DateTime.Parse(items[2].ToString());
            GioKetThuc = DateTime.Parse(items[3].ToString());
        }

        public string MaC { get; set; }
        public string Ten { get; set; }
        public DateTime GioBatDau { get; set; }
        public DateTime GioKetThuc { get; set; }
    }
}
