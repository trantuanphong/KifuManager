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
    public class KifuOpenDAL : IDal
    {
        public int Delete(object obj)
        {
            throw new NotImplementedException();
        }

        public int Insert(object obj)
        {
            KifuOpen kifuOpen = (KifuOpen)obj;
            string sql = "INSERT INTO KifuOpen VALUES((SELECT MAX(KifuID) FROM Kifu),@openID,@player)";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@openID", kifuOpen.OpenID);
            parameters[1] = new SqlParameter("@player", kifuOpen.Player);
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
