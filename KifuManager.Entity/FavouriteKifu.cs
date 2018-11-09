using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KifuManager.Entity
{
    public class FavouriteKifu
    {
        public int KifuID { get; set; }
        public String Username { get; set; }

        public FavouriteKifu(int kifuID, string username)
        {
            KifuID = kifuID;
            Username = username;
        }
    }
}
