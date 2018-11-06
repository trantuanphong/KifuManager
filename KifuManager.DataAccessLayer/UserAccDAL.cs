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
            string sql = "INSERT INTO UserAcc (Username,Email) VALUES('@Username', '@Email'";
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@UserName", userAcc.Username);
            parameters[2] = new SqlParameter("@Email", userAcc.Email);
            return SqlHelper.ExecuteNonQuery(sql, parameters);
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

        public int CheckLogin(string username, string password)
        {
            UserAcc user = new UserAcc();
            using (SqlConnection conn = DBUtility.GetConnection())
            {
                string sql = "SELECT COUNT(1) FROM UserAcc WHERE Username='" + @username + "' AND Password='" + @password + "' ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                conn.Open();

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public UserAcc GetUserByName(string username)
        {
            string sql = "SELECT * FROM UserAcc WHERE Username='" + @username + "' ";

            return null;
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
    }
}
