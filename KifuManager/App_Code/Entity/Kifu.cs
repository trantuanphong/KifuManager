using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KifuManager.App_Code.Entity
{
    public class Kifu
    {
        public int KifuID { get; set; }
        public String Rule { get; set; }
        public int Size { get; set; }
        public float Komi { get; set; }
        public float Time { get; set; }
        public int ByoYomiTurn { get; set; }
        public int ByoYomiTime { get; set; }
        public String WhitePlayer { get; set; }
        public String BlackPlayer { get; set; }
        public String WhiteRank { get; set; }
        public String BlackRank { get; set; }
        public DateTime Date { get; set; }
        public String Winner { get; set; }
        public float Result { get; set; }
        public int OpenID { get; set; }
        public int Owner { get; set; }

        public Kifu(int kifuID, string rule, int size, float komi, float time, int byoYomiTurn, int byoYomiTime, string whitePlayer, string blackPlayer, string whiteRank, string blackRank, DateTime date, string winner, float result, int openID, int owner)
        {
            KifuID = kifuID;
            Rule = rule;
            Size = size;
            Komi = komi;
            Time = time;
            ByoYomiTurn = byoYomiTurn;
            ByoYomiTime = byoYomiTime;
            WhitePlayer = whitePlayer;
            BlackPlayer = blackPlayer;
            WhiteRank = whiteRank;
            BlackRank = blackRank;
            Date = date;
            Winner = winner;
            Result = result;
            OpenID = openID;
            Owner = owner;
        }
    }
}