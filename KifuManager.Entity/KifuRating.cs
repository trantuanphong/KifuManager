using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KifuManager.Entity
{
    public class KifuRating
    {
        public int KifuID { get; set; }
        public String Username { get; set; }
        public int RatePoint { get; set; }
        public String Comment { get; set; }

        public KifuRating(int kifuID, string username, int ratePoint, string comment)
        {
            KifuID = kifuID;
            Username = username;
            RatePoint = ratePoint;
            Comment = comment;
        }
    }
}
