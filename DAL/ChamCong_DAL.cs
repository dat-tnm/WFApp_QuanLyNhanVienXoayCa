using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChamCong_DAL : DAL
    {
        public ChamCong_DAL()
        {
            db = new DbCommand();
        }

        public DataTable SelectAll()
        {
            return db.ExecQueryProcedure("ChamCong_SelectAll");
        }


        public DataTable SelectByMonthYear(DateTime MonthYear)
        {
            parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MonthYear", MonthYear);
            return db.ExecQueryProcedure("ChamCong_SelectByMonthYear", parameters);
        }

        public DataTable SelectMaPCNull(DateTime MonthYear)
        {
            parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MonthYear", MonthYear);
            return db.ExecQueryProcedure("ChamCong_SelectMaPCNull", parameters);
        }

        public DataTable SelectLastId(string MaNV, DateTime Ngay)
        {
            parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@MaNV", MaNV);
            parameters[1] = new SqlParameter("@Ngay", Ngay);
            return db.ExecQueryProcedure("ChamCong_SelectLastId", parameters);
        }

        public DataTable SelectDiffTimeTable(DateTime MonthYear)
        {
            parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MonthYear", MonthYear);
            return db.ExecQueryProcedure("ChamCong_SelectDiffTable", parameters);
        }

        public int Insert(string MaNV, TimeSpan GioVao, DateTime Ngay)
        {
            parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@MaNV", MaNV);
            parameters[1] = new SqlParameter("@GioVao", GioVao);
            parameters[2] = new SqlParameter("@Ngay", Ngay);

            return db.ExecNonQueryProcedure("ChamCong_Insert", parameters);
        }

        public int Insert(string MaNV, TimeSpan GioVao, TimeSpan GioRa, DateTime Ngay)
        {
            parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@MaNV", MaNV);
            parameters[1] = new SqlParameter("@GioVao", GioVao);
            parameters[2] = new SqlParameter("@GioRa", GioRa);
            parameters[3] = new SqlParameter("@Ngay", Ngay);

            return db.ExecNonQueryProcedure("ChamCong_Insert", parameters);
        }

        public int Update(int MaCC, DateTime GioRa)
        {
            parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@MaCC", MaCC);
            parameters[1] = new SqlParameter("@GioRa", GioRa);

            return db.ExecNonQueryProcedure("ChamCong_Update", parameters);
        }

        public int Update(int MaCC, string MaNV, TimeSpan GioVao, TimeSpan GioRa, DateTime Ngay)
        {
            parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@MaCC", MaCC);
            parameters[1] = new SqlParameter("@MaNV", MaNV);
            parameters[2] = new SqlParameter("@GioVao", GioVao);
            parameters[3] = new SqlParameter("@GioRa", GioRa);
            parameters[4] = new SqlParameter("@Ngay", Ngay);

            return db.ExecNonQueryProcedure("ChamCong_Update", parameters);
        }

        public int UpdateMaPC(int MaCC, string MaPC)
        {
            parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@MaCC", MaCC);
            parameters[1] = new SqlParameter("@MaPC", MaPC);

            return db.ExecNonQueryProcedure("ChamCong_UpdateMaPC", parameters);
        }

        public int ReUpdateMaPC(int MaCC, string MaNV, TimeSpan GioVao, DateTime Ngay)
        {
            parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@MaCC", MaCC);
            parameters[1] = new SqlParameter("@MaNV", MaNV);
            parameters[2] = new SqlParameter("@GioVao", GioVao);
            parameters[3] = new SqlParameter("@Ngay", Ngay);

            return db.ExecNonQueryProcedure("ChamCong_ReUpdateMaPC", parameters);
        }

        public int UpdateSoGioLam(int MaCC, double SoGioLam)
        {
            parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@MaCC", MaCC);
            parameters[1] = new SqlParameter("@SoGioLam", SoGioLam);

            return db.ExecNonQueryProcedure("ChamCong_UpdateSoGioLam", parameters);
        }

        public int Delete(int Month)
        {
            parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@Month", Month);

            return db.ExecNonQueryProcedure("ChamCong_Delete", parameters);
        }

        public int DeleteById(int MaCC)
        {
            parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@MaCC", MaCC);

            return db.ExecNonQueryProcedure("ChamCong_Delete", parameters);
        }
    }
}
