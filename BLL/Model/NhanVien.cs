using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string MaCV { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string NoiSinh { get; set; }
        public DateTime NgayVaoLam { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }

        public NhanVien() 
        {
            MaNV = string.Empty;
            MaCV = string.Empty;
            Ten = string.Empty;
            NgaySinh = DateTime.Now;
            GioiTinh = string.Empty;
            NoiSinh = string.Empty;
            NgayVaoLam = DateTime.Now;
            SDT = string.Empty;
            Email = string.Empty;
        }

        public NhanVien(string maNV, string chucVu, string ten, DateTime ngaySinh, string gioiTinh, string noiSinh, DateTime ngayVaoLam, string sDT, string email)
        {
            MaNV = maNV;
            MaCV = chucVu;
            Ten = ten;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            NoiSinh = noiSinh;
            NgayVaoLam = ngayVaoLam;
            SDT = sDT;
            Email = email;
        }

        public NhanVien(object[] items)
        {
            MaNV = items[0].ToString();
            MaCV = items[1].ToString();
            Ten = items[2].ToString();
            NgaySinh = (DateTime)items[3];
            GioiTinh = items[4].ToString();
            NoiSinh = items[5].ToString();
            SDT = items[6].ToString();
            Email = items[7].ToString();
            NgayVaoLam = (DateTime)items[8];
        }
    }
}
