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
    public class UserAccDAL : IDal
    {
        public int Delete(object obj)
        {
            UserAcc userAcc = (UserAcc) obj;
            throw new NotImplementedException();
        }

        public int Insert(object obj)
        {
            UserAcc userAcc = (UserAcc)obj;
            throw new NotImplementedException();
        }

        public DataTable SelectAll()
        {
            throw new NotImplementedException();
        }

        public int Update(object obj)
        {
            UserAcc userAcc = (UserAcc)obj;
            throw new NotImplementedException();
        }

        public int IncreasePoint(string username)
        {
            SqlParameter[] parameters = new SqlParameter[1];
            string query = "UPDATE UserAcc SET APoint = (SELECT APoint FROM UserAcc WHERE Username = @username) "
                + " + 1 WHERE Username = @username";
            parameters[0] = new SqlParameter("@username", username);
            return SqlHelper.ExecuteNonQuery(query, parameters);
        }
    }
}
