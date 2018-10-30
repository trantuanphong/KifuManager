using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KifuManager.App_Code.Entity
{
    public class OpenSequence
    {
        public int OpenID { get; set; }
        public int Move { get; set; }
        public String Position { get; set; }

        public OpenSequence(int openID, int move, string position)
        {
            OpenID = openID;
            Move = move;
            Position = position;
        }
    }
}