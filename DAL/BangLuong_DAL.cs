using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BangLuong_DAL : DAL
    {
        public BangLuong_DAL()
        {
            db = new DbCommand();
        }

        public DataTable SelectByMonthYear(DateTime MonthYear)
        {
            parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MonthYear", MonthYear);
            return db.ExecQueryProcedure("BangLuong_SelectByMonthYear", parameters);
        }

        public int Insert(string MaNV, int Thang, int Nam, double TongGioLam, double Luong)
        {
            parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@MaNV", MaNV);
            parameters[1] = new SqlParameter("@Thang", Thang);
            parameters[2] = new SqlParameter("@Nam", Nam);
            parameters[3] = new SqlParameter("@TongGioLam", TongGioLam);
            parameters[4] = new SqlParameter("@Luong", Luong);

            return db.ExecNonQueryProcedure("BangLuong_Insert", parameters);
        }

        public int CalculateByMonthYear(DateTime MonthYear)
        {
            parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@Month", MonthYear.Month);
            parameters[1] = new SqlParameter("@Year", MonthYear.Year);

            return db.ExecNonQueryProcedure("BangLuong_CalculateByMonthYear", parameters);
        }

        public int Update(int MaBL, double Thuong, string GhiChu)
        {
            parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@MaBL", MaBL);
            parameters[1] = new SqlParameter("@Thuong", Thuong);
            parameters[2] = new SqlParameter("@GhiChu", GhiChu);

            return db.ExecNonQueryProcedure("BangLuong_Update", parameters);
        }

        public int UpdateLuong(int MaBL, double TongGioLam, double Luong)
        {
            parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@MaBL", MaBL);
            parameters[1] = new SqlParameter("@TongGioLam", TongGioLam);
            parameters[2] = new SqlParameter("@Luong", Luong);

            return db.ExecNonQueryProcedure("BangLuong_UpdateLuong", parameters);
        }

        public int Delete(int MaBL)
        {
            parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaBL", MaBL);

            return db.ExecNonQueryProcedure("BangLuong_Delete", parameters);
        }

        public int DeleteByMonthYear(DateTime MonthYear)
        {
            parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@Month", MonthYear.Month);
            parameters[1] = new SqlParameter("@Year", MonthYear.Year);

            return db.ExecNonQueryProcedure("BangLuong_DeleteByMonthYear", parameters);
        }
    }
}
