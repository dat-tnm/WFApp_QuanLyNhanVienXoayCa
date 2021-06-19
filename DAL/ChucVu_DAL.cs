using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChucVu_DAL : DAL
    {
        public ChucVu_DAL()
        {
            db = new DbCommand();
        }

        public DataTable SelectAll()
        {
            return db.ExecQueryProcedure("ChucVu_SelectAll");
        }

        public DataTable SelectWhereId(string MaCV)
        {
            parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaCV", MaCV);
            return db.ExecQueryProcedure("ChucVu_SelectWhereId", parameters);
        }

        public int Insert(string Ten)
        {
            parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Ten", Ten);

            return db.ExecNonQueryProcedure("ChucVu_Insert", parameters);
        }

        public int Update(string MaCV, string Ten)
        {
            parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@MaCV", MaCV);
            parameters[1] = new SqlParameter("@Ten", Ten);

            return db.ExecNonQueryProcedure("ChucVu_Update", parameters);
        }

        public int Delete(string MaCV)
        {
            parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaCV", MaCV);

            return db.ExecNonQueryProcedure("ChucVu_Delete", parameters);
        }
    }
}
