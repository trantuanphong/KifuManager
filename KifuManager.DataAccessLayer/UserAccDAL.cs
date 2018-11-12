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
            UserAcc userAcc = (UserAcc)obj;
            throw new NotImplementedException();
        }

        public int Insert(object obj)
        {
            UserAcc userAcc = (UserAcc)obj;
            string sql = "INSERT INTO UserAcc VALUES(@username,@password,@email,0,null,1,0)";
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@username", userAcc.Username);
            parameters[1] = new SqlParameter("@password", userAcc.Password);
            parameters[2] = new SqlParameter("@Email", userAcc.Email);
            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }

        public DataTable SelectAll()
        {
            string sql = "SELECT * FROM UserAcc";
            return SqlHelper.ExecuteDataTable(sql);
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

        public UserAcc GetUserByName(string username)
        {
            string sql = "SELECT u.Password, u.Email, u.APoint, u.TitleID, u.Status, u.Type FROM UserAcc u WHERE Username=@username";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@username", username);
            DataTable dt = SqlHelper.ExecuteDataTable(sql, parameters);

            if (dt.Rows.Count != 1) return null;
            string password = dt.Rows[0][0].ToString();
            string email = dt.Rows[0][1].ToString();
            if (dt.Rows[0][2] == null) dt.Rows[0][2] = 0;
            int point = Int32.Parse(dt.Rows[0][2].ToString());
            if (dt.Rows[0][3].ToString().Equals("")) dt.Rows[0][3] = 0;
            int titleID = Int32.Parse(dt.Rows[0][3].ToString());
            Boolean status = Boolean.Parse(dt.Rows[0][4].ToString());
            int type = Int32.Parse(dt.Rows[0][5].ToString());
            return new UserAcc(username, password, email, point, titleID, status, type);
        }

        public int UpdateUser(string username, string email, string password)
        {
            using (SqlConnection connection = DBUtility.GetConnection())
            {
                string sql = "UPDATE UserAcc SET Email=@Email, Password=@Password WHERE Username=@Username";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.Add(new SqlParameter("@Email", email));
                cmd.Parameters.Add(new SqlParameter("@Password", password));
                cmd.Parameters.Add(new SqlParameter("@Username", username));
                connection.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public int RemoveAllTitle(int titleID)
        {
            string sql = "UPDATE UserAcc SET TitleID=NULL WHERE TitleID=@titleID";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@titleID", titleID);
            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }

        public int RemoveTitle(string username)
        {
            string sql = "UPDATE UserAcc SET TitleID=NULL WHERE Username=@username";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@username", username);
            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }

        public int UpdateTitle(string username, int titleID)
        {
            string sql = "UPDATE UserAcc SET TitleID=@titleID WHERE Username=@username";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@titleID", titleID);
            parameters[1] = new SqlParameter("@username", username);
            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }

        public int UpdatePassword(string username, string password)
        {
            string sql = "UPDATE UserAcc SET Password=@password WHERE Username=@username";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@password", password);
            parameters[1] = new SqlParameter("@username", username);
            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }

        public int ChangeStatus(string username)
        {
            string sql = "UPDATE UserAcc SET [Status] = [Status] ^ 1 WHERE Username=@username";
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@username", username);
            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }

        public int UpdateEmail(string username, string email)
        {
            string sql = "UPDATE UserAcc SET Email=@email WHERE Username=@username";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@email", email);
            parameters[1] = new SqlParameter("@username", username);
            return SqlHelper.ExecuteNonQuery(sql, parameters);
        }
    }
}
