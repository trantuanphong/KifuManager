using KifuManager.DataAccessLayer;
using KifuManager.Entity;
using System;
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

            return 0;
        }
    }
}
