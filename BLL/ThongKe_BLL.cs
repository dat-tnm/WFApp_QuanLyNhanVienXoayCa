using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongKe_BLL
    {
        ThongKe_DAL tk_dal;

        public ThongKe_BLL()
        {
            tk_dal = new ThongKe_DAL();
        }


        public DataTable TK_DiTre(DateTime MonthYear)
        {
            return tk_dal.TK_DiTre(MonthYear);
        }

        public DataTable TK_TongChiTra(DateTime MonthYear)
        {
            return tk_dal.TK_TongChiTra(MonthYear);
        }


    }
}
