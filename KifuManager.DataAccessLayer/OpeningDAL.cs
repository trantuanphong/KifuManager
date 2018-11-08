using KifuManager.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KifuManager.DataAccessLayer
{
    public class OpeningDAL : IDal
    {
        public int Delete(object obj)
        {
            throw new NotImplementedException();
        }

        public int Insert(object obj)
        {
            Opening open = (Opening)obj;
            string sql = "INSERT INTO Opening VALUES(@name,@description)";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@name", open.OpenName);
            parameters[1] = new SqlParameter("@description", open.Description);
            return SqlHelper.ExecuteNonQuery(sql,parameters);
        }

        public DataTable SelectAll()
        {
            string sql = "SELECT * FROM Opening";
            return SqlHelper.ExecuteDataTable(sql);
        }

        public int Update(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
