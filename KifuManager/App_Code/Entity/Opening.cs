using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KifuManager.App_Code.Entity
{
    public class Opening
    {
        public int OpenID { get; set; }
        public String OpenName { get; set; }
        public String Description { get; set; }
        public String Image { get; set; }

        public Opening(int openID, string openName, string description, string image)
        {
            OpenID = openID;
            OpenName = openName;
            Description = description;
            Image = image;
        }
    }
}