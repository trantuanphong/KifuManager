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
            int openID = (int)obj;
            string sql = "DELETE FROM KifuOpen WHERE OpenID=@openID";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@openID", openID);
            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }

        public int Insert(object obj)
        {
            KifuOpen kifuOpen = (KifuOpen)obj;
            string sql = "INSERT INTO KifuOpen VALUES(@kifuID,@openID,@player)";
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@kifuID", kifuOpen.KifuID);
            parameters[1] = new SqlParameter("@openID", kifuOpen.OpenID);
            parameters[2] = new SqlParameter("@player", kifuOpen.Player);
            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }

        public DataTable SelectAll()
        {
            throw new NotImplementedException();
        }

        public int Update(object obj)
        {
            KifuOpen kifuOpen = (KifuOpen)obj;
            string sql = "UPDATE KifuOpen SET OpenID=@openID WHERE KifuID=@kifuID AND Player=@player";
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@kifuID", kifuOpen.KifuID);
            parameters[1] = new SqlParameter("@openID", kifuOpen.OpenID);
            parameters[2] = new SqlParameter("@player", kifuOpen.Player);
            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }

        public DataTable SelectByID(int kifuID)
        {
            string sql = "SELECT k.KifuID, o.OpenName, k.Player FROM KifuOpen k LEFT JOIN Opening o ON k.OpenID = o.OpenID WHERE KifuID =@kifuID";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@kifuID", kifuID);
            return SqlHelper.ExecuteDataTable(sql, parameters);
        }
    }
}
