using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HeSoLuong_DAL : DAL
    {
        public HeSoLuong_DAL()
        {
            db = new DbCommand();
        }

        public DataTable SelectAll()
        {
            return db.ExecQueryProcedure("HeSoLuong_SelectAll");
        }

        public DataTable SelectWhereId(string MaCV, string MaC)
        {
            parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@MaCV", MaCV);
            parameters[1] = new SqlParameter("@MaC", MaC);
            return db.ExecQueryProcedure("HeSoLuong_SelectWhereId", parameters);
        }

        public int Insert(string MaCV, string MaC, double HeSoLuong)
        {
            parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@MaC", MaC);
            parameters[1] = new SqlParameter("@MaCV", MaCV);
            parameters[2] = new SqlParameter("@HeSoLuong", HeSoLuong);
            return db.ExecNonQueryProcedure("HeSoLuong_Insert", parameters);
        }

        public int Update(string MaCV, string MaC, double HeSoLuong)
        {
            parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@MaC", MaC);
            parameters[1] = new SqlParameter("@MaCV", MaCV);
            parameters[2] = new SqlParameter("@HeSoLuong", HeSoLuong);
            return db.ExecNonQueryProcedure("HeSoLuong_Update", parameters);
        }

        public int Delete(string MaCV, string MaC)
        {
            parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@MaC", MaC);
            parameters[1] = new SqlParameter("@MaCV", MaCV);

            return db.ExecNonQueryProcedure("HeSoLuong_Delete", parameters);
        }
    }
}
