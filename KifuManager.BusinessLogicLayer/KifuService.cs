using System;
using System.Collections.Generic;
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

            string rule = CommonService.GetContentInBracket(kifuContent, "RU");
            string size = CommonService.GetContentInBracket(kifuContent, "SZ");
            string komi = CommonService.GetContentInBracket(kifuContent, "KM");
            string gameName = CommonService.GetContentInBracket(kifuContent, "");
            string gameEvent = CommonService.GetContentInBracket(kifuContent, "");
            string whitePlayer = CommonService.GetContentInBracket(kifuContent, "PW");
            string blackPlayer = CommonService.GetContentInBracket(kifuContent, "PB");
            string blackLevel = CommonService.GetContentInBracket(kifuContent, "BR");
            string whiteLevel = CommonService.GetContentInBracket(kifuContent, "WR");
            string date = CommonService.GetContentInBracket(kifuContent, "DT");
            string result = CommonService.GetContentInBracket(kifuContent, "RE");

            //Kifu kifu = new Kifu(rule,Int32.Parse(size),float.Parse(komi),float.Parse(time),gameName,gameEvent,
                //0,0,whitePlayer, blackPlayer,whiteLevel,blackLevel,DateTime.Parse(date),result,"Phong");

            return 0;
        }
    }
}
