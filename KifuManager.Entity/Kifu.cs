using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KifuManager.Entity
{
    public class Kifu
    {
        public int KifuID { get; set; }
        public String Rule { get; set; }
        public int Size { get; set; }
        public float Komi { get; set; }
        public float Time { get; set; }
        public String GameName { get; set; }
        public String Event { get; set; }
        public int ByomiTurn { get; set; }
        public int ByomiTime { get; set; }
        public String WhitePlayer { get; set; }
        public String BlackPlayer { get; set; }
        public String WhiteLevel { get; set; }
        public String BlackLevel { get; set; }
        public DateTime Date { get; set; }
        public String Result { get; set; }
        public String Uploader { get; set; }
    }
}
