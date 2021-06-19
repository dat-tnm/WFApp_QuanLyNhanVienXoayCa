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
    public class ChamCong_BLL
    {
        ChamCong_DAL cc_dal = new ChamCong_DAL();

        public DataTable SelectAll()
        {
            return cc_dal.SelectAll();
        }

        public DataTable SelectByMonthYear(DateTime MonthYear)
        {
            return cc_dal.SelectByMonthYear(MonthYear);
        }

        public DataTable SelectMaPCNull(DateTime MonthYear)
        {
            return cc_dal.SelectMaPCNull(MonthYear);
        }

        public int SelectLastId(string MaNV, DateTime Ngay)
        {
            DataTable dt = cc_dal.SelectLastId(MaNV, Ngay);

            if (dt.Rows.Count == 1)
            {
                return (int)dt.Rows[0][0];
            }

            return -1;
        }

        public DataTable SelectDiffTimeTable(DateTime MonthYear)
        {
            return cc_dal.SelectDiffTimeTable(MonthYear);
        }

        public int Insert(string MaNV, TimeSpan GioVao, DateTime Ngay)
        {
            return cc_dal.Insert(MaNV, GioVao, Ngay);
        }

        public int Insert(string MaNV, TimeSpan GioVao, TimeSpan GioRa, DateTime Ngay)
        {
            return cc_dal.Insert(MaNV, GioVao, GioRa, Ngay);
        }

        public int Update(int MaCC, DateTime GioRa)
        {
            return cc_dal.Update(MaCC, GioRa);
        }

        public int Update(int MaCC, string MaNV, TimeSpan GioVao, TimeSpan GioRa, DateTime Ngay)
        { 
            return cc_dal.Update(MaCC, MaNV, GioVao, GioRa, Ngay);
        }

        public int UpdateMaPC(int MaCC, string MaPC) 
        {
            return cc_dal.UpdateMaPC(MaCC, MaPC);
        }

        public int ReUpdateMaPC(int MaCC, string MaNV, TimeSpan GioVao, DateTime Ngay)
        {
            return cc_dal.ReUpdateMaPC(MaCC, MaNV, GioVao, Ngay);
        }


        public int UpdateSoGioLam(int MaCC, double SoGioLam)
        {
            return cc_dal.UpdateSoGioLam(MaCC, SoGioLam);
        }

        public int Delete(int Month)
        {
            return cc_dal.Delete(Month);
        }

        public int DeleteById(int MaCC)
        {
            return cc_dal.DeleteById(MaCC);
        }
    }
}
