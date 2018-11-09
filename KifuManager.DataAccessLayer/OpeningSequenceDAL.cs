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
    public class OpeningSequenceDAL : IDal
    {
        public int Delete(object obj)
        {
            int openID = (int)obj;
            string sql = "DELETE FROM OpenSequence WHERE OpenID=@openID";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@openID", openID);
            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }

        public int Insert(object obj)
        {
            string position = (string)obj;
            string sql = "INSERT INTO OpenSequence VALUES((SELECT MAX(OpenID) FROM Opening),@position)";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@position", position);
            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }

        public DataTable SelectByID(int id)
        {
            string sql = "SELECT * FROM OpenSequence WHERE OpenID=@id";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", id);
            return SqlHelper.ExecuteDataTable(sql, parameters);
        }

        public DataTable SelectAll()
        {
            throw new NotImplementedException();
        }

        public int Update(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
