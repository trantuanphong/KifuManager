using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KifuManager.App_Code.Entity
{
    public class KifuEvent
    {
        public int KifuID { get; set; }
        public int Move { get; set; }
        public String Position { get; set; }
        public float TimeLast { get; set; }
        public int OverTimeTurn { get; set; }
        public String Comment { get; set; }
    }
}