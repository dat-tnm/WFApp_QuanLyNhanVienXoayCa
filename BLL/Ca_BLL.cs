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
    public class Ca_BLL
    {
        Ca_DAL dal = new Ca_DAL();

        public DataTable SelectAll()
        {
            return dal.SelectAll();
        }

        public List<Ca> SelectAll2()
        {
            var dt =  dal.SelectAll();
            List<Ca> list = new List<Ca>();
            Ca model;

            foreach (DataRow row in dt.Rows)
            {
                model = new Ca(row.ItemArray);
                list.Add(model);
            }

            return list;
        }

        public Ca SelectWhereId(string MaC)
        {
            DataTable dt = dal.SelectWhereId(MaC);
            return new Ca(dt.Rows[0].ItemArray);
        }

        public int Insert(string Ten, DateTime GioBatDau, DateTime GioKetThuc)
        {
            return dal.Insert(Ten, GioBatDau, GioKetThuc);
        }

        public int Update(string MaC, string Ten, DateTime GioBatDau, DateTime GioKetThuc)
        {
            return dal.Update(MaC, Ten, GioBatDau, GioKetThuc);
        }

        public int Delete(string MaC)
        {
            return dal.Delete(MaC);
        }
    }
}
