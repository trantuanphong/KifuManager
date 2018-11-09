using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KifuManager.DataAccessLayer
{
    public class KifuRatingDAL : IDal
    {
        public int Delete(object obj)
        {
            int kifuID = (int)obj;
            string sql = "DELETE FROM KifuRating WHERE KifuID=@kifuID";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@kifuID", kifuID);
            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }

        public int Insert(object obj)
        {
            throw new NotImplementedException();
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
