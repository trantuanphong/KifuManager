using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KifuManager.Entity
{
    public class UserAcc
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public int Point { get; set; }
        public int TitleID { get; set; }
        public Boolean Status { get; set; }
        public int Type { get; set; }

        public UserAcc() { }

        public UserAcc(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }

        public UserAcc(string username, string password, string email, int point, int titleID, bool status, int type)
        {
            Username = username;
            Password = password;
            Email = email;
            Point = point;
            TitleID = titleID;
            Status = status;
            Type = type;
        }
    }
}
