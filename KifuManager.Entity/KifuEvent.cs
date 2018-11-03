using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KifuManager.Entity
{
    public class KifuEvent
    {
        public int KifuID { get; set; }
        public int Move { get; set; }
        public String Position { get; set; }
        public String Comment { get; set; }

        public KifuEvent(string position, string comment)
        {
            Position = position;
            Comment = comment;
        }

        public KifuEvent(int kifuID, int move, string position, string comment)
        {
            KifuID = kifuID;
            Move = move;
            Position = position;
            Comment = comment;
        }
    }
}
