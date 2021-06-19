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
    public class PhanCong_BLL
    {
        PhanCong_DAL pc_dal = new PhanCong_DAL();

        public List<PhanCong> SelectAll()
        {
            DataTable dt = pc_dal.SelectAll();

            List<PhanCong> list = new List<PhanCong>();
            PhanCong model;
            foreach (DataRow row in dt.Rows)
            {
                model = new PhanCong(row.ItemArray);
                list.Add(model);
            }

            return list;
        }

        public List<PhanCong> SelectWhereLike(string pattern, DateTime Ngay)
        {
            DataTable dt = pc_dal.SelectWhereLike(pattern, Ngay);

            var listPC = new List<PhanCong>();

            foreach (DataRow row in dt.Rows)
            {
                listPC.Add(new PhanCong(row.ItemArray));
            }

            return listPC;
        }

        public PhanCong SelectWhereId(int MaPC)
        {
            DataTable dt = pc_dal.SelectWhereId(MaPC);

            if (dt.Rows.Count > 0)
            {
                return new PhanCong(dt.Rows[0].ItemArray);
            }

            return null;
        }

        public List<PhanCong> SelectIdsWhere(DateTime startWeek, DateTime endWeek)
        {
            DataTable dt = pc_dal.SelectIdsWhere(startWeek, endWeek);

            List<PhanCong> list = new List<PhanCong>();
            PhanCong model;
            foreach (DataRow row in dt.Rows)
            {
                model = new PhanCong();
                model.MaNV = (string)row[0];
                model.MaCV = (string)row[1];
                model.MaC = (string)row[2];
                list.Add(model);
            }

            return list;
        }

        public int Insert(PhanCong phanCong) 
        {
            return pc_dal.Insert(phanCong.MaNV, phanCong.MaCV, phanCong.MaC, phanCong.Ngay);
        }

        public int Update(PhanCong phanCong)
        {
            return pc_dal.Update(phanCong.MaNV, phanCong.MaCV, phanCong.MaC, phanCong.Ngay);
        }







        public int Insert(string MaNV, string MaCV, string MaC, DateTime Ngay) 
        {
            return pc_dal.Insert(MaNV, MaCV, MaC, Ngay);
        }

        public int Update(string MaNV, string MaCV, string MaC, DateTime Ngay)
        {
            return pc_dal.Update(MaNV, MaCV, MaC, Ngay);
        }

        public int Delete(string MaPC)
        {
            return pc_dal.Delete(MaPC);
        }

        public int DeleteRange(string MaNV, string MaC, DateTime StartWeek, DateTime EndWeek)
        {
            return pc_dal.DeleteRange(MaNV, MaC, StartWeek, EndWeek);
        }
    }
}
