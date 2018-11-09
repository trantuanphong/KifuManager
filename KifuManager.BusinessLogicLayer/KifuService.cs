using System;
using System.Collections;
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
        public static int NewKifu(string kifuContent, string username)
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
            if (date.Equals("")) date = DateTime.Now.ToShortDateString();
            string result = CommonService.GetContentInBracket(kifuContent, "RE");

            Kifu kifu = new Kifu(rule,Int32.Parse(size),float.Parse(komi),gameName,gameEvent,
                whitePlayer, blackPlayer,whiteLevel,blackLevel,DateTime.Parse(date),result,username);

            new KifuDAL().Insert(kifu);

            //insert kifu event
            string[] kiEvent = kifuContent.Split(';');
            ArrayList steps = new ArrayList();
            KifuEventDAL kifuEventDAL = new KifuEventDAL();
            for (int i = 2; i < kiEvent.Length; i++)
            {
                string position = CommonService.GetContentInBracket(kiEvent[i], "[BW]");
                
                //if not match B or W i-- and continue


                string comment = (kiEvent[i].Split('C').Length > 2) ? kiEvent[i].Split('C')[1] : "" ;
                KifuEvent kifuEvent = new KifuEvent(position, comment);
                kifuEventDAL.Insert(kifuEvent);
                steps.Add(position);
            }

            int blackOpening = 0, whiteOpening = 0;

            //define opening
            foreach(DataRow row in (new OpeningDAL().SelectAll()).Rows)
            {
                int id = Int32.Parse(row["OpenID"].ToString());
                ArrayList openStep = new ArrayList();
                foreach(DataRow row2 in (new OpeningSequenceDAL().SelectByID(id).Rows))
                {
                    openStep.Add(row2["Position"].ToString());
                }
                int count = 0;
                for (int i = 0; i <= 3; i++)
                {
                    openStep = CommonService.Rotate90(openStep);
                    count = CommonService.CountExistOpening(steps, openStep);
                }
                if (count == 1) blackOpening = id;
                else if (count == 2) whiteOpening = id;
                else if (count == 3) blackOpening = whiteOpening = id;
            }

            //insert into kifu open
            if (blackOpening != 0) new KifuOpenDAL().Insert(new KifuOpen(blackOpening, blackPlayer));
            if (whiteOpening != 0) new KifuOpenDAL().Insert(new KifuOpen(whiteOpening, whitePlayer));

            return 0;
        }

        public static DataTable GetAllKifu()
        {
            return new KifuDAL().SelectAll();
        }

        public static DataTable GetMyKifu(string uploader)
        {
            return new KifuDAL().SelectMyKifu(uploader);
        }

        public static string GetKifuContent(int kifuID)
        {
            string content = "(;";
            DataTable generalInformation = new KifuDAL().SelectKifuByID(kifuID);
            content += "RU[" + generalInformation.Rows[0][0] + "]"; //rule
            content += "SZ[" + generalInformation.Rows[0][1] + "]"; //size
            content += "KM[" + generalInformation.Rows[0][2] + "]"; //komi
            content += "GN[" + generalInformation.Rows[0][3] + "]"; //game name
            content += "EV[" + generalInformation.Rows[0][4] + "]"; //event
            content += "PW[" + generalInformation.Rows[0][5] + "]"; //player white
            content += "WR[" + generalInformation.Rows[0][6] + "]"; //white rank
            content += "PB[" + generalInformation.Rows[0][7] + "]"; //player black
            content += "BR[" + generalInformation.Rows[0][8] + "]"; //black rank
            content += "RE[" + generalInformation.Rows[0][9] + "]"; //result
            content += "DT[" + generalInformation.Rows[0][10] + "]"; //date

            DataTable eventInformation = new KifuEventDAL().SelectByID(kifuID);
            for(int i = 0; i < eventInformation.Rows.Count; i++)
            {
                content += ";" + ((i%2==0)?"B":"W")+ "[" + eventInformation.Rows[i][2] + "]";
            }
            return content+")";
        }

        public static int UpdateGeneralInformation(Kifu kifu)
        {
            return new KifuDAL().Update(kifu);
        }

        public static DataTable SearchKifu(string gameName, string playerName, string level)
        {
            return new KifuDAL().SearchKifu(gameName, playerName, level);
        }

        public static DataTable SearchKifuWithOpen(string gameName, string playerName, string level, string openID)
        {
            return new KifuDAL().SearchKifuWithOpen(gameName, playerName, level, openID);
        }

        public static DataTable GetTopNewKifu()
        {
            return new KifuDAL().SelectTopNewKifu();
        }

        public static DataTable GetOpening()
        {
            return new OpeningDAL().SelectAll();
        }

        public static int DeleteKifu(int kifuID)
        {
            new KifuRatingDAL().Delete(kifuID);
            new FavouriteKifuDAL().Delete(kifuID);
            new KifuEventDAL().Delete(kifuID);
            new KifuDAL().Delete(kifuID);
            return 0;
        }
    }
}
