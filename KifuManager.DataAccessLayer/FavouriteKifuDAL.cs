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
    public class FavouriteKifuDAL : IDal
    {
        public int Delete(object obj)
        {
            FavouriteKifu favouriteKifu = (FavouriteKifu)obj;
            string sql = "DELETE FROM FavouriteKifu WHERE KifuID=@kifuID AND Username=@username";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@kifuID", favouriteKifu.KifuID);
            parameters[1] = new SqlParameter("@username", favouriteKifu.Username);
            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }

        public int Insert(object obj)
        {
            FavouriteKifu favouriteKifu = (FavouriteKifu)obj;
            string sql = "INSERT INTO FavouriteKifu VALUES(@kifuID,@username)";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@kifuID", favouriteKifu.KifuID);
            parameters[1] = new SqlParameter("@username", favouriteKifu.Username);
            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }

        public DataTable Select(FavouriteKifu favouriteKifu)
        {
            string sql = "SELECT * FROM FavouriteKifu WHERE KifuID=@kifuID AND Username=@username";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@kifuID", favouriteKifu.KifuID);
            parameters[1] = new SqlParameter("@username", favouriteKifu.Username);
            return SqlHelper.ExecuteDataTable(sql, parameters);
        }

        public DataTable SelectMyFavour(FavouriteKifu favouriteKifu)
        {
            string sql = "SELECT * FROM FavouriteKifu WHERE Username=@username";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@username", favouriteKifu.Username);
            return SqlHelper.ExecuteDataTable(sql, parameters);
        }

        public DataTable SelectAll()
        {
            string sql = "SELECT * FROM FavouriteKifu";
            return SqlHelper.ExecuteDataTable(sql);
        }

        public int Update(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
