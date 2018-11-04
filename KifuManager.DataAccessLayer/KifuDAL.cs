using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KifuManager.Entity;

namespace KifuManager.DataAccessLayer
{
    public class KifuDAL : IDal
    {
        public int Delete(object obj)
        {
            Kifu kifu = (Kifu)obj;
            throw new NotImplementedException();
        }

        public int Insert(object obj)
        {
            Kifu kifu = (Kifu)obj;
            SqlParameter[] parameters = new SqlParameter[12];
            parameters[0] = new SqlParameter("@rule", kifu.Rule);
            parameters[1] = new SqlParameter("@size", kifu.Size);
            parameters[2] = new SqlParameter("@komi", kifu.Komi);
            parameters[3] = new SqlParameter("@gameName", kifu.GameName);
            parameters[4] = new SqlParameter("@event", kifu.Event);
            parameters[5] = new SqlParameter("@whitePlayer", kifu.WhitePlayer);
            parameters[6] = new SqlParameter("@blackPlayer", kifu.BlackPlayer);
            parameters[7] = new SqlParameter("@blackLevel", kifu.BlackLevel);
            parameters[8] = new SqlParameter("@whiteLevel", kifu.WhiteLevel);
            parameters[9] = new SqlParameter("@date", kifu.Date);
            parameters[10] = new SqlParameter("@result", kifu.Result);
            parameters[11] = new SqlParameter("@uploader", kifu.Uploader);

            string query = "INSERT INTO Kifu VALUES(@rule, @size, @komi, @gameName, @event, @whitePlayer, @blackPlayer"
                + ", @whiteLevel, @blackLevel, @date, @result, @uploader)";

            return SqlHelper.ExecuteNonQuery(query, parameters);
        }

        public DataTable SelectAll()
        {
            throw new NotImplementedException();
        }

        public DataTable SelectMyKifu(string uploader)
        {
            string sql = "SELECT k.GameName, k.Event, k.WhitePlayer, k.WhiteLevel, k.BlackPlayer, k.BlackLevel, k.Result, k.Date " +
                " FROM Kifu k WHERE Uploader = @uploader";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@uploader", uploader);
            return SqlHelper.ExecuteDataTable(sql, parameters);
        }

        public DataTable SelectKifuByID(int id)
        {
            string sql = "SELECT k.[Rule], k.Size, k.Komi, k.GameName, k.Event, k.WhitePlayer, k.WhiteLevel, k.BlackPlayer, k.BlackLevel, k.Result, k.Date " +
    " FROM Kifu k WHERE KifuID = @id";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", id);
            return SqlHelper.ExecuteDataTable(sql, parameters);
        }

        public int Update(object obj)
        {
            Kifu kifu = (Kifu)obj;
            throw new NotImplementedException();
        }
    }
}
