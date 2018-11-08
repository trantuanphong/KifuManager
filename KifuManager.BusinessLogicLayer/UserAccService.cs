using KifuManager.DataAccessLayer;
using KifuManager.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KifuManager.BusinessLogicLayer
{
    public class UserAccService
    {
        private static UserAccDAL dal = new UserAccDAL();

        public static int CheckLogin(string username, string password)
        {
            UserAcc user = dal.GetUserByName(username);
            if (user == null || !user.Password.Equals(password)) return 0;
            return 1;
        }
        public static Boolean IsExist(string username)
        {
            UserAcc user = dal.GetUserByName(username);
            if (user == null || !user.Password.Equals(username)) return false;
            return true;
        }
        public static int Update(UserAcc UserAcc)
        {
            return dal.Update(UserAcc);
        }
        public static int UpdateUser(string username, string email, string password)
        {
            return dal.UpdateUser(username, email, password);
        }
        public static int Register(UserAcc user)
        {
            if (IsExist(user.Username)) return 0;
            return dal.Insert(user);
        }
        public static int IncreasePoint(string username)
        {
            return dal.IncreasePoint(username);
        }
        public static DataTable GetUser()
        {
            return dal.SelectAll();
        }
    }
}
