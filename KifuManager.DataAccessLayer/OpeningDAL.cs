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
            int openID = (int)obj;
            string sql = "DELETE FROM Opening WHERE OpenID=@openID";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@openID", openID);
            return SqlHelper.ExecuteNonQuery(sql, parameters);
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
            string sql = "SELECT o.OpenID, o.OpenName, o.Description FROM Opening o";
            return SqlHelper.ExecuteDataTable(sql);
        }

        public int Update(object obj)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectPopularOpening()
        {
            string sql = "SELECT TOP(5) o.OpenID, o.OpenName, o.Description, m.Amount FROM " +
                " (SELECT OpenID, COUNT(KifuID) AS Amount FROM KifuOpen " +
                " GROUP BY OpenID) m LEFT JOIN Opening o ON m.OpenID = o.OpenID";
            return SqlHelper.ExecuteDataTable(sql);
        }
    }
}
