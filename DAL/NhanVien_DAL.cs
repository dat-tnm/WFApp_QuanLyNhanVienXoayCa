using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVien_DAL : DAL
    {
        public NhanVien_DAL()
        {
            db = new DbCommand();
        }

        public DataTable SelectAll()
        {
            return db.ExecQueryProcedure("NhanVien_SelectAll");
        }

        public DataTable SelectWhereId(string MaNV)
        {
            parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaNV", MaNV);
            return db.ExecQueryProcedure("NhanVien_SelectWhereId", parameters);
        }

        public DataTable SelectWhereLike(string pattern)
        {
            parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@pattern", pattern);
            return db.ExecQueryProcedure("NhanVien_SelectWhereLike", parameters);
        }

        public int Insert(string MaCV, string Ten, DateTime NgaySinh, string GioiTinh, string NoiSinh, string SDT, string Email, DateTime NgayVaoLam)
        {
            parameters = new SqlParameter[8];
            parameters[0] = new SqlParameter("@MaCV", MaCV);
            parameters[1] = new SqlParameter("@Ten", Ten);
            parameters[2] = new SqlParameter("@NgaySinh", NgaySinh);
            parameters[3] = new SqlParameter("@GioiTinh", GioiTinh);
            parameters[4] = new SqlParameter("@NoiSinh", NoiSinh);
            parameters[5] = new SqlParameter("@SDT", SDT);
            parameters[6] = new SqlParameter("@Email", Email);
            parameters[7] = new SqlParameter("@NgayVaoLam", NgayVaoLam);

            return db.ExecNonQueryProcedure("NhanVien_Insert", parameters);
        }

        public int Update(string MaNV, string MaCV, string Ten, DateTime NgaySinh, string GioiTinh, string NoiSinh, string SDT, string Email, DateTime NgayVaoLam)
        {
            parameters = new SqlParameter[9];
            parameters[0] = new SqlParameter("@MaNV", MaNV);
            parameters[1] = new SqlParameter("@MaCV", MaCV);
            parameters[2] = new SqlParameter("@Ten", Ten);
            parameters[3] = new SqlParameter("@NgaySinh", NgaySinh);
            parameters[4] = new SqlParameter("@GioiTinh", GioiTinh);
            parameters[5] = new SqlParameter("@NoiSinh", NoiSinh);
            parameters[6] = new SqlParameter("@SDT", SDT);
            parameters[7] = new SqlParameter("@Email", Email);
            parameters[8] = new SqlParameter("@NgayVaoLam", NgayVaoLam);

            return db.ExecNonQueryProcedure("NhanVien_Update", parameters);
        }

        public int Delete(string MaNV)
        {
            parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaNV", MaNV);

            return db.ExecNonQueryProcedure("NhanVien_Delete", parameters);
        }
    }
}
