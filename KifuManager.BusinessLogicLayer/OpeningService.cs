using KifuManager.DataAccessLayer;
using KifuManager.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KifuManager.BusinessLogicLayer
{
    public class OpeningService
    {
        public static int InsertNewOpening(Opening open, string inputContent)
        {
            //insert general information
            new OpeningDAL().Insert(open);

            //insert open move
            ArrayList stepOpening = CommonService.OpeningStep(inputContent);
            foreach(string step in stepOpening)
            {
                new OpeningSequenceDAL().Insert(step);
            }
            return 0;
        }

        public static int DeleteOpening(int openID)
        {
            new KifuOpenDAL().Delete(openID);
            new OpeningSequenceDAL().Delete(openID);
            new OpeningDAL().Delete(openID);
            return 0;
        }
    }
}
