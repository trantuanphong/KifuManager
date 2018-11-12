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
        public static DataTable GetAllUser()
        {
            return dal.SelectAll();
        }
        public static UserAcc GetUser(string username)
        {
            return dal.GetUserByName(username);
        }
        public static int ResetPassword(string username)
        {
            string password = "123456";
            return dal.UpdatePassword(username, password);
        }
        public static int ChangeStatus(string username)
        {
            return dal.ChangeStatus(username);
        }
        public static int SetTitle(string username, int titleID)
        {
            return dal.UpdateTitle(username, titleID);
        }
        public static int RemoveTitle(string username)
        {
            return dal.RemoveTitle(username);
        }
        public static int ChangePassword(string username, string newPassword)
        {
            return dal.UpdatePassword(username, newPassword);
        }
        public static int ChangeEmail(string username, string email)
        {
            return dal.UpdateEmail(username, email);
        }
    }
}