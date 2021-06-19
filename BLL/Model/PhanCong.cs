using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public class PhanCong
    {
        public string MaPC { get; set; }
        public string MaNV { get; set; }
        public string MaCV { get; set; }
        public string MaC { get; set; }
        public DateTime Ngay { get; set; }


        public string TenNV { get; set; }
        public string TenCV { get; set; }
        public string TenC { get; set; }

        public PhanCong() {}


        public PhanCong(object[] items)
        {
            MaPC = items[0].ToString();
            MaNV = items[1].ToString();
            MaCV = items[2].ToString();
            MaC = items[3].ToString();
            Ngay = (DateTime)items[4];

            if(items.Length == 8)
            {
                TenNV = items[5].ToString();
                TenCV = items[6].ToString();
                TenC = items[7].ToString();
            }
        }

    }
}
