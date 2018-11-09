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
            KifuRating kifuRating = (KifuRating)obj;
            string sql = "INSERT INTO KifuRating VALUES(@kifuID,@username,@ratePoint,@comment)";
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@kifuID", kifuRating.KifuID);
            parameters[1] = new SqlParameter("@username", kifuRating.Username);
            parameters[2] = new SqlParameter("@ratePoint", kifuRating.RatePoint);
            parameters[3] = new SqlParameter("@comment", kifuRating.Comment);
            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }

        public DataTable SelectAll()
        {
            throw new NotImplementedException();
        }

        public int Update(object obj)
        {
            KifuRating kifuRating = (KifuRating)obj;
            string sql = "UPDATE KifuRating SET RatePoint=@ratePoint, Comment=@comment" +
                " WHERE KifuID=@kifuID AND Username=@username";
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@kifuID", kifuRating.KifuID);
            parameters[1] = new SqlParameter("@username", kifuRating.Username);
            parameters[2] = new SqlParameter("@ratePoint", kifuRating.RatePoint);
            parameters[3] = new SqlParameter("@comment", kifuRating.Comment);
            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }

        public DataTable Select(KifuRating kifuRating)
        {
            string sql = "SELECT * FROM KifuRating WHERE KifuID=@kifuID AND Username=@username";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@kifuID", kifuRating.KifuID);
            parameters[1] = new SqlParameter("@username", kifuRating.Username);
            return SqlHelper.ExecuteDataTable(sql, parameters);
        }

        public DataTable SelectByID(int kifuID)
        {
            string sql = "SELECT k.Username, t.TitleName, k.RatePoint, k.Comment " +
                "FROM KifuRating k LEFT JOIN UserAcc u ON k.Username = u.Username " +
                "LEFT JOIN Title t ON t.TitleID = u.TitleID WHERE KifuID = @kifuID";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@kifuID", kifuID);
            return SqlHelper.ExecuteDataTable(sql, parameters);
        }

        public DataTable GroupPointOfKifu(int kifuID)
        {
            string sql = "SELECT KifuID, SUM(RatePoint)/COUNT(RatePoint) AS Point " +
                " FROM KifuRating WHERE KifuID = @kifuID GROUP BY KifuID";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@kifuID", kifuID);
            return SqlHelper.ExecuteDataTable(sql, parameters);
        }
    }
}
