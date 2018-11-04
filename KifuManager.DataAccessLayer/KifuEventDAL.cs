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
    public class KifuEventDAL : IDal
    {
        public int Delete(object obj)
        {
            KifuEvent kifuEvent = (KifuEvent)obj;
            throw new NotImplementedException();
        }

        public int Insert(object obj)
        {
            KifuEvent kifuEvent = (KifuEvent)obj;
            SqlParameter[] parameters = new SqlParameter[2];
            string query = "INSERT INTO KifuEvent VALUES((SELECT MAX(KifuID) FROM Kifu),@position,@comment)";
            parameters[0] = new SqlParameter("@position", kifuEvent.Position);
            parameters[1] = new SqlParameter("@comment", kifuEvent.Comment);
            return SqlHelper.ExecuteNonQuery(query, parameters);
        }

        public DataTable SelectByID(int id)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            string query = "SELECT * FROM KifuEvent WHERE KifuID = @id";
            parameters[0] = new SqlParameter("@id", id);
            return SqlHelper.ExecuteDataTable(query, parameters);
        }

        public DataTable SelectAll()
        {
            throw new NotImplementedException();
        }

        public int Update(object obj)
        {
            KifuEvent kifuEvent = (KifuEvent)obj;
            throw new NotImplementedException();
        }
    }
}
