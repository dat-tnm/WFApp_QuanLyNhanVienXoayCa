using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhanCong_DAL : DAL
    {
        public PhanCong_DAL()
        {
            db = new DbCommand();
        }

        public DataTable SelectAll()
        {
            return db.ExecQueryProcedure("PhanCong_SelectAll");
        }

        public DataTable SelectWhereLike(string pattern, DateTime Ngay)
        {
            parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@pattern", pattern);
            parameters[1] = new SqlParameter("@Ngay", Ngay);
            return db.ExecQueryProcedure("PhanCong_SelectWhereLike", parameters);
        }

        public DataTable SelectWhereId(int MaPC)
        {
            parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaPC", MaPC);
            return db.ExecQueryProcedure("PhanCong_SelectWhereId", parameters);
        }

        public DataTable SelectIdsWhere(DateTime startWeek, DateTime endWeek)
        {
            parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@startWeek", startWeek);
            parameters[1] = new SqlParameter("@endWeek", endWeek);
            return db.ExecQueryProcedure("PhanCong_SelectIdsWhere", parameters);
        }

        public int Insert(string MaNV, string MaCV, string MaC, DateTime Ngay)
        {
            parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@MaNV", MaNV);
            parameters[1] = new SqlParameter("@MaCV", MaCV);
            parameters[2] = new SqlParameter("@MaC", MaC);
            parameters[3] = new SqlParameter("@Ngay", Ngay);

            return db.ExecNonQueryProcedure("PhanCong_Insert", parameters);
        }

        public int Update(string MaNV, string MaCV, string MaC, DateTime Ngay)
        {
            parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@MaNV", MaNV);
            parameters[1] = new SqlParameter("@MaCV", MaCV);
            parameters[2] = new SqlParameter("@MaC", MaC);
            parameters[3] = new SqlParameter("@Ngay", Ngay);

            return db.ExecNonQueryProcedure("PhanCong_Update", parameters);
        }

        public int Delete(string MaPC)
        {
            parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaPC", MaPC);

            return db.ExecNonQueryProcedure("PhanCong_Delete", parameters);
        }

        public int DeleteRange(string MaNV, string MaC, DateTime StartWeek, DateTime EndWeek)
        {
            parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@MaNV", MaNV);
            parameters[1] = new SqlParameter("@MaC", MaC);
            parameters[2] = new SqlParameter("@StartWeek", StartWeek);
            parameters[3] = new SqlParameter("@EndWeek", EndWeek);

            return db.ExecNonQueryProcedure("PhanCong_DeleteRange", parameters);
        }
    }
}
