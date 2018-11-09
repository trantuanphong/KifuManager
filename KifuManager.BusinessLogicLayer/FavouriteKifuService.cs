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

        public static int RatingAndCommnent(KifuRating kifuRating)
        {
            KifuRatingDAL dal = new KifuRatingDAL();

            if (dal.Select(kifuRating).Rows.Count != 1)
            {
                return dal.Insert(kifuRating);
            }
            else
            {
                return dal.Update(kifuRating);
            }
        }

        public static DataTable GetKifuRating(int kifuID)
        {
            return new KifuRatingDAL().SelectByID(kifuID);
        }

        public static int GroupPointOfKifu(int kifuID)
        {
            DataTable dt = new KifuRatingDAL().GroupPointOfKifu(kifuID);
            int point = 0;
            if (dt.Rows.Count == 1 && dt.Rows[0][1] != null) point = Int32.Parse(dt.Rows[0][1].ToString());
            return point;
        }
    }
}
