using KifuManager.DataAccessLayer;
using KifuManager.Entity;
using System;
using System.Collections.Generic;
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
            return dal.CheckLogin(username, password);
        }
        public static int Update(UserAcc UserAcc)
        {
            return dal.Update(UserAcc);
        }
        public static int UpdateUser(string username, string email, string password)
        {
            return dal.UpdateUser(username, email, password);
        }
        public static UserAcc GetUserByName(string username)
        {
            return dal.GetUserByName(username);
        }
    }
}
