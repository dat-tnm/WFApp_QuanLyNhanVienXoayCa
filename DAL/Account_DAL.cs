using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Account_DAL : DAL
    {
        public Account_DAL()
        {
            db = new DbCommand();
        }

        public DataTable SelectAll()
        {
            return db.ExecQueryProcedure("Account_SelectAll");
        }

        public DataTable SelectWhereId(string UserName)
        {
            parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@UserName", UserName);
            return db.ExecQueryProcedure("Account_SelectWhere", parameters);
        }


        public int Insert(string UserName, string Role, string DisplayName, string Password)
        {
            parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@UserName", UserName);
            parameters[1] = new SqlParameter("@Role", Role);
            parameters[2] = new SqlParameter("@DisplayName", DisplayName);
            parameters[3] = new SqlParameter("@Password", Password);

            return db.ExecNonQueryProcedure("Account_Insert", parameters);
        }

        public int Update(string UserName, string DisplayName)
        {
            parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@UserName", UserName);
            parameters[1] = new SqlParameter("@DisplayName", DisplayName);

            return db.ExecNonQueryProcedure("Account_Update", parameters);
        }

        public int UpdatePassword(string UserName, string Password)
        {
            parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@UserName", UserName);
            parameters[1] = new SqlParameter("@Password", Password);

            return db.ExecNonQueryProcedure("Account_UpdatePassword", parameters);
        }

        public int Delete(string UserName)
        {
            parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@UserName", UserName);

            return db.ExecNonQueryProcedure("Account_Delete", parameters);
        }
    }
}
