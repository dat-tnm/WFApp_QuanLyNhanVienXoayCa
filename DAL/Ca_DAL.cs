using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Ca_DAL : DAL
    {
        public Ca_DAL()
        {
            db = new DbCommand();
        }

        public DataTable SelectAll()
        {
            return db.ExecQueryProcedure("Ca_SelectAll");
        }

        public DataTable SelectWhereId(string MaC)
        {
            parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaC", MaC);
            return db.ExecQueryProcedure("Ca_SelectWhereId", parameters);
        }

        public int Insert(string Ten, DateTime GioBatDau, DateTime GioKetThuc)
        {
            parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@Ten", Ten);
            parameters[1] = new SqlParameter("@GioBatDau", GioBatDau);
            parameters[2] = new SqlParameter("@GioKetThuc", GioKetThuc);

            return db.ExecNonQueryProcedure("Ca_Insert", parameters);
        }

        public int Update(string MaC, string Ten, DateTime GioBatDau, DateTime GioKetThuc)
        {
            parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@MaC", MaC);
            parameters[1] = new SqlParameter("@Ten", Ten);
            parameters[2] = new SqlParameter("@GioBatDau", GioBatDau);
            parameters[3] = new SqlParameter("@GioKetThuc", GioKetThuc);

            return db.ExecNonQueryProcedure("Ca_Update", parameters);
        }

        public int Delete(string MaC)
        {
            parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaC", MaC);

            return db.ExecNonQueryProcedure("Ca_Delete", parameters);
        }
    }
}
