using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KifuManager.Entity
{
    public class Title
    {
        public int TitleID { get; set; }
        public String TitleName { get; set; }
        public int Point { get; set; }

        public Title(string titleName, int point)
        {
            TitleName = titleName;
            Point = point;
        }

        public Title(int titleID, string titleName, int point)
        {
            TitleID = titleID;
            TitleName = titleName;
            Point = point;
        }
    }
}
