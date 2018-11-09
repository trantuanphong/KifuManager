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
        public String GameName { get; set; }
        public String Event { get; set; }
        public String WhitePlayer { get; set; }
        public String BlackPlayer { get; set; }
        public String WhiteLevel { get; set; }
        public String BlackLevel { get; set; }
        public DateTime Date { get; set; }
        public String Result { get; set; }
        public String Uploader { get; set; }

        public Kifu(int kifuID, string gameName, string @event, DateTime date)
        {
            KifuID = kifuID;
            GameName = gameName;
            Event = @event;
            Date = date;
        }

        public Kifu(string rule, int size, float komi, string gameName, string @event, string whitePlayer, string blackPlayer, string whiteLevel, string blackLevel, string result, string uploader)
        {
            Rule = rule;
            Size = size;
            Komi = komi;
            GameName = gameName;
            Event = @event;
            WhitePlayer = whitePlayer;
            BlackPlayer = blackPlayer;
            WhiteLevel = whiteLevel;
            BlackLevel = blackLevel;
            Result = result;
            Uploader = uploader;
        }

        public Kifu(string rule, int size, float komi, string gameName, string @event, string whitePlayer, string blackPlayer, string whiteLevel, string blackLevel, DateTime date, string result, string uploader)
        {
            Rule = rule;
            Size = size;
            Komi = komi;
            GameName = gameName;
            Event = @event;
            WhitePlayer = whitePlayer;
            BlackPlayer = blackPlayer;
            WhiteLevel = whiteLevel;
            BlackLevel = blackLevel;
            Date = date;
            Result = result;
            Uploader = uploader;
        }

        public Kifu(int kifuID, string rule, int size, float komi, string gameName, string @event, string whitePlayer, string blackPlayer, string whiteLevel, string blackLevel, DateTime date, string result, string uploader)
        {
            KifuID = kifuID;
            Rule = rule;
            Size = size;
            Komi = komi;
            GameName = gameName;
            Event = @event;
            WhitePlayer = whitePlayer;
            BlackPlayer = blackPlayer;
            WhiteLevel = whiteLevel;
            BlackLevel = blackLevel;
            Date = date;
            Result = result;
            Uploader = uploader;
        }
    }
}
