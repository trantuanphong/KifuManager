using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KifuManager.Entity
{
    public class Opening
    {
        public int OpenID { get; set; }
        public String OpenName { get; set; }
        public String Description { get; set; }

        public Opening(string openName, string description)
        {
            OpenName = openName;
            Description = description;
        }
        public Opening(int openID, string openName, string description)
        {
            OpenID = openID;
            OpenName = openName;
            Description = description;
        }
    }
}
