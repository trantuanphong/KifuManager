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

        public int DeleteByKifuID(int kifuID)
        {
            string sql = "DELETE FROM FavouriteKifu WHERE KifuID=@kifuID";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@kifuID", kifuID);
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

        public DataTable SelectFavouriteKifu(string username)
        {
            string sql = "SELECT k.KifuID, k.GameName, k.[Event], k.WhitePlayer, k.WhiteLevel, k.BlackPlayer, k.BlackLevel, k.Result, k.[Date] " +
                " FROM FavouriteKifu f LEFT JOIN Kifu k ON f.KifuID = k.KifuID WHERE f.Username = @username";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@username", username);
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

        public DataTable SelectTopFavour()
        {
            string sql = "SELECT TOP(5) k.KifuID, k.WhitePlayer, k.BlackPlayer, k.WhiteLevel, k.BlackLevel, k.Result " +
                " FROM (SELECT KifuID, COUNT(Username) AS Favour FROM FavouriteKifu GROUP BY KifuID) f " +
                " LEFT JOIN Kifu k ON f.KifuID = k.KifuID ORDER BY Favour DESC";
            return SqlHelper.ExecuteDataTable(sql);
        }
    }
}
