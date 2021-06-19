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

    public class BangLuong_BLL
    {
        BangLuong_DAL bl_dal = new BangLuong_DAL();

        public DataTable SelectByMonthYear(DateTime MonthYear)
        {
            return bl_dal.SelectByMonthYear(MonthYear);
        }

        public int Insert(string MaNV, int Thang, int Nam, double TongGioLam, double Luong)
        {
            return bl_dal.Insert(MaNV, Thang, Nam, TongGioLam, Luong);
        }

        public int CalculateByMonthYear(DateTime MonthYear)
        {
            return bl_dal.CalculateByMonthYear(MonthYear);
        }

        public int Update(int MaBL, double Thuong, string GhiChu)
        {
            return bl_dal.Update(MaBL, Thuong, GhiChu);
        }

        public int UpdateLuong(int MaBL, double TongGioLam, double Luong)
        {
            return bl_dal.UpdateLuong(MaBL, TongGioLam, Luong);
        }

        public int Delete(int MaBL)
        {
            return bl_dal.Delete(MaBL);
        }

        public int DeleteByMonthYear(DateTime MonthYear)
        {
            return bl_dal.DeleteByMonthYear(MonthYear);
        }
    }
}
