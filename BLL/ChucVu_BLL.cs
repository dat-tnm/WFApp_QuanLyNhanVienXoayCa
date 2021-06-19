using BLL.Model;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChucVu_BLL
    {
        ChucVu_DAL dal = new ChucVu_DAL();

        public DataTable SelectAll()
        {
            return dal.SelectAll();
        }

        public ChucVu SelectWhereId(string MaCV)
        {
            DataTable dt = dal.SelectWhereId(MaCV);

            if (dt.Rows.Count == 0)
            {
                return new ChucVu();
            }

            return new ChucVu((string)dt.Rows[0][0], (string)dt.Rows[0][1]);
        }

        public int Insert(string Ten)
        {
            return dal.Insert(Ten);
        }

        public int Update(string MaCV, string Ten)
        {
            return dal.Update(MaCV, Ten);
        }

        public int Delete(string MaCV)
        {
            return dal.Delete(MaCV);
        }
    }
}
