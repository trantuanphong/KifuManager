using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KifuManager.App_Code.Entity
{
    public class Account
    {
        public int AccountID { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public int Type { get; set; }

        public Account(int accountID, string userName, string password, string email, int type)
        {
            AccountID = accountID;
            UserName = userName;
            Password = password;
            Email = email;
            Type = type;
        }
    }
}