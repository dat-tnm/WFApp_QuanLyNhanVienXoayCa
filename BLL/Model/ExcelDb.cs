using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
    public class ExcelDb
    {
        public string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR=YES'";

        public string OLEDB12 = "Microsoft.ACE.OLEDB.12.0";

        public string dataConStr = @"Data Source=DESKTOP-4H2CDN2;Initial Catalog=SPDRGoldTrust;Persist Security Info=True;User Id=sa;Password=1093218446";


        public ExcelDb()
        {
                
        }

        SqlConnection GetConnection;
        private void KetnoiCSDL()
        {
            GetConnection = new SqlConnection(dataConStr);
            GetConnection.Open();
        }
        private void NgatKetNoi()
        {
            GetConnection.Close();
            GetConnection.Dispose();
        }

        public DataTable ExecQuery(string query) 
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(query, GetConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            NgatKetNoi();

            return dt;
        }

        public void ExecNonQuery(string query)
        {
            KetnoiCSDL();
            SqlCommand cmd = new SqlCommand(query, GetConnection);
            cmd.ExecuteNonQuery();
            NgatKetNoi();
        }

        public void SaveTableFromExcel(string filepath, string tablename)
        {
            string excel_version;
            switch (Path.GetExtension(filepath))
            {
                case ".xls":
                    excel_version = "Excel 8.0";
                    break;
                case ".xlsx":
                    excel_version = "Excel 12.0 Xml";
                    break;
                case ".xlsm":
                    excel_version = "Excel 12.0 Macro";
                    break;
                case ".xlsb":
                    excel_version = "Excel 12.0";
                    break;
                default:
                    return;
            }
            filepath = filepath.Replace("\\\\", "\\");

            this.ExecNonQuery($"IF (EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES" +
                $" WHERE TABLE_NAME = '{ tablename}')) DROP TABLE {tablename};" +
                $"SELECT * INTO {tablename} FROM OPENROWSET('{this.OLEDB12}'," +
                $"'{excel_version};Database={filepath}'," +
                $"'SELECT * FROM [{tablename}$]')");
        }
    }
}
