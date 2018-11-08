using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KifuManager.Entity
{
    public class KifuOpen
    {
        public int KifuID { get; set; }
        public int OpenID { get; set; }
        public String Player { get; set; }

        public KifuOpen(int openID, string player)
        {
            OpenID = openID;
            Player = player;
        }

        public KifuOpen(int kifuID, int openID, string player)
        {
            KifuID = kifuID;
            OpenID = openID;
            Player = player;
        }
    }
}
