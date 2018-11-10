using KifuManager.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KifuManager
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rptTopNews.DataSource = KifuService.GetTopNewKifu();
                rptTopNews.DataBind();

                rptTopFavour.DataSource = FavouriteKifuService.GetTopFavouriteKifu();
                rptTopFavour.DataBind();

                rptTopOpening.DataSource = OpeningService.GetPopularOpening();
                rptTopOpening.DataBind();
            }
        }
    }
}