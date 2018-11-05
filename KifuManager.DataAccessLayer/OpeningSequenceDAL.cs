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
            throw new NotImplementedException();
        }

        public int Insert(object obj)
        {
            string position = (string)obj;
            string sql = "INSERT INTO OpenSequence VALUES((SELECT MAX(OpenID) FROM Opening),@position)";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[1] = new SqlParameter("@position", position);
            return SqlHelper.ExecuteNonQuery(sql, parameters);
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
