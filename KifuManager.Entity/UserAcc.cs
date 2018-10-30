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
    }
}
