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
    public class HeSoLuong_BLL
    {
        HeSoLuong_DAL dal = new HeSoLuong_DAL();

        public DataTable SelectAll()
        {
            return dal.SelectAll();
        }

        public DataTable SelectWhereId(string MaCV, string MaC)
        {
            return dal.SelectWhereId(MaCV, MaC);
        }

        public int Insert(string MaCV, string MaC, double HeSoLuong)
        {
            return dal.Insert(MaCV, MaC, HeSoLuong);
        }

        public int Update(string MaCV, string MaC, double HeSoLuong)
        {
            return dal.Update(MaCV, MaC, HeSoLuong);
        }

        public int Delete(string MaCV, string MaC)
        {
            return dal.Delete(MaCV, MaC);
        }
    }
}
