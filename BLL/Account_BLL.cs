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
    public class Account_BLL
    {
        Account_DAL acc_dal = new Account_DAL();

        public DataTable SelectAll()
        {
            return acc_dal.SelectAll();
        }

        public DataTable SelectWhere(string UserName)
        {
            return acc_dal.SelectWhereId(UserName);
        }


        public int Insert(string UserName, string Role, string DisplayName, string Password)
        {
            return acc_dal.Insert(UserName, Role, DisplayName, Password);
        }

        public int Update(string UserName, string DisplayName)
        {
            return acc_dal.Update(UserName, DisplayName);
        }

        public int UpdatePassword(string UserName, string Password)
        {
            return acc_dal.UpdatePassword(UserName, Password);
        }

        public int Delete(string UserName)
        {
            return acc_dal.Delete(UserName);
        }
    }
}
