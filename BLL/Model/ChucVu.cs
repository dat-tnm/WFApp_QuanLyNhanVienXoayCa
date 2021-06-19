using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public class ChucVu
    {
        public ChucVu(string maCV, string ten)
        {
            MaCV = maCV;
            Ten = ten;
        }

        public ChucVu()
        {
            MaCV = string.Empty;
            Ten = string.Empty;
        }

        public string MaCV { get; set; }
        public string Ten { get; set; }
    }
}
