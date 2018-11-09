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
    public class FavouriteKifuService
    {
        public static Boolean IsFavour(FavouriteKifu favourite)
        {
            DataTable dt = new FavouriteKifuDAL().Select(favourite);
            if (dt.Rows.Count != 1) return false;
            return true;
        }

        public static DataTable GetFavouriteKifu(string username)
        {
            return new FavouriteKifuDAL().SelectFavouriteKifu(username);
        }

        public static int LikeKifu(FavouriteKifu favourite)
        {
            return new FavouriteKifuDAL().Insert(favourite);
        }

        public static int UnLikeKifu(FavouriteKifu favourite)
        {
            return new FavouriteKifuDAL().Delete(favourite);
        }

        public static DataTable GetTopFavouriteKifu()
        {
            return new FavouriteKifuDAL().SelectTopFavour();
        }
    }
}
