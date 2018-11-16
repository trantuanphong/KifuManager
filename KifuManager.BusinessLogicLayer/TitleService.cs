using KifuManager.DataAccessLayer;
using KifuManager.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KifuManager.BusinessLogicLayer
{
    public class TitleService
    {
        public static DataTable GetAllTitle()
        {
            return new TitleDAL().SelectAll();
        }

        public static int NewTitle(Title title)
        {
            return new TitleDAL().Insert(title);
        }

        public static DataTable GetTitleSuitable(int point)
        {
            return new TitleDAL().SelectTitleSuitable(point);
        }

        public static int DeleteTitle(string titleID)
        {
            int id;
            if (Int32.TryParse(titleID, out id))
            {
                new UserAccDAL().RemoveAllTitle(id);
                return new TitleDAL().Delete(id);
            }
                
            return 0;
        }
    }
}
