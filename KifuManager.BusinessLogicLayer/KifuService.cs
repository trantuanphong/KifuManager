using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KifuManager.DataAccessLayer;
using KifuManager.Entity;

namespace KifuManager.BusinessLogicLayer
{
    public class KifuService
    {
        public static int Insert(string kifuContent)
        {
            //insert general information
            string rule = CommonService.GetContentInBracket(kifuContent, "RU");
            string size = CommonService.GetContentInBracket(kifuContent, "SZ");
            string komi = CommonService.GetContentInBracket(kifuContent, "KM");
            string gameName = CommonService.GetContentInBracket(kifuContent, "GN");
            string gameEvent = CommonService.GetContentInBracket(kifuContent, "EV");
            string whitePlayer = CommonService.GetContentInBracket(kifuContent, "PW");
            string blackPlayer = CommonService.GetContentInBracket(kifuContent, "PB");
            string blackLevel = CommonService.GetContentInBracket(kifuContent, "BR");
            string whiteLevel = CommonService.GetContentInBracket(kifuContent, "WR");
            string date = CommonService.GetContentInBracket(kifuContent, "DT");
            string result = CommonService.GetContentInBracket(kifuContent, "RE");

            Kifu kifu = new Kifu(rule,Int32.Parse(size),float.Parse(komi),gameName,gameEvent,
                whitePlayer, blackPlayer,whiteLevel,blackLevel,DateTime.Parse(date),result,"admin");

            new KifuDAL().Insert(kifu);

            //insert kifu event
            string[] kiEvent = kifuContent.Split(';');
            KifuEventDAL kifuEventDAL = new KifuEventDAL();
            for (int i = 2; i < kiEvent.Length; i++)
            {
                string position = CommonService.GetContentInBracket(kiEvent[i], "[BW]");
                string comment = (kiEvent[i].Split('C').Length > 2) ? kiEvent[i].Split('C')[1] : "" ;
                KifuEvent kifuEvent = new KifuEvent(position, comment);
                kifuEventDAL.Insert(kifuEvent);
            }

            return 0;
        }

        public static DataTable GetMyKifu(string uploader)
        {
            return new KifuDAL().SelectMyKifu(uploader);
        }
    }
}
