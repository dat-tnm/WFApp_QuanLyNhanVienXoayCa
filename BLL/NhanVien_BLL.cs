using BLL.Model;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVien_BLL
    {
        NhanVien_DAL nv_dal = new NhanVien_DAL();

        public DataTable SelectAll()
        {
            return nv_dal.SelectAll();
        }

        public List<NhanVien> SelectAll2()
        {
            DataTable dt = nv_dal.SelectAll();

            List<NhanVien> list = new List<NhanVien>();
            NhanVien model;
            foreach (DataRow row in dt.Rows)
            {
                model = new NhanVien(row.ItemArray);
                list.Add(model);
            }

            return list;
        }

        public NhanVien SelectWhereId(string MaNV)
        {
            var dt = nv_dal.SelectWhereId(MaNV);

            if (dt.Rows.Count == 1)
            {
                return new NhanVien(dt.Rows[0].ItemArray);
            }

            return new NhanVien();
        }

        public DataTable SelectWhereLike(string pattern)
        {
            return nv_dal.SelectWhereLike(pattern);
        }

        public int Insert(string MaCV, string Ten, DateTime NgaySinh, string GioiTinh, string NoiSinh, string SDT, string Email, DateTime NgayVaoLam)
        {
            return nv_dal.Insert(MaCV, Ten, NgaySinh, GioiTinh, NoiSinh, SDT, Email, NgayVaoLam);
        }

        public int Update(string MaNV, string MaCV, string Ten, DateTime NgaySinh, string GioiTinh, string NoiSinh, string SDT, string Email, DateTime NgayVaoLam)
        {
            return nv_dal.Update(MaNV, MaCV, Ten, NgaySinh, GioiTinh, NoiSinh, SDT, Email, NgayVaoLam);
        }

        public int Delete(string MaNV)
        {
            return nv_dal.Delete(MaNV);
        }
    }
}
