using KifuManager.DataAccessLayer;
using KifuManager.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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

        public static int DeleteOpening(string openID)
        {
            int id;
            if (Int32.TryParse(openID, out id))
            {
                new KifuOpenDAL().Delete(id);
                new OpeningSequenceDAL().Delete(id);
                new OpeningDAL().Delete(id);
            }
            return 0;
        }

        public static DataTable GetAllOpening()
        {
            return new OpeningDAL().SelectAll();
        }

        public static DataTable GetPopularOpening()
        {
            return new OpeningDAL().SelectPopularOpening();
        }
    }
}
