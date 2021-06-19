using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKe_DAL : DAL
    {
        public ThongKe_DAL()
        {
            db = new DbCommand();
        }


        public DataTable TK_DiTre(DateTime MonthYear)
        {
            parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@Month", MonthYear.Month);
            parameters[1] = new SqlParameter("@Year", MonthYear.Year);
            return db.ExecQueryProcedure("ThongKe_DiTre", parameters);
        }

        public DataTable TK_TongChiTra(DateTime MonthYear)
        {
            parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Year", MonthYear.Year);
            return db.ExecQueryProcedure("ThongKe_TongChiTra", parameters);
        }


    }
}
