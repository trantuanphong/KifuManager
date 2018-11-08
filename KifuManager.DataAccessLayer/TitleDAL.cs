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
    public class TitleDAL : IDal
    {
        public int Delete(object obj)
        {
            throw new NotImplementedException();
        }

        public int Insert(object obj)
        {
            Title title = (Title)obj;
            string sql = "INSERT INTO Title VALUES(@titleName,@point)";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[1] = new SqlParameter("@titleName", title.TitleName);
            parameters[1] = new SqlParameter("@point", title.Point);
            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }

        public DataTable SelectAll()
        {
            string sql = "SELECT * FROM Title";
            return SqlHelper.ExecuteDataTable(sql);
        }

        public int Update(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
