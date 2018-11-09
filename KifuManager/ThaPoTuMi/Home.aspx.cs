﻿using KifuManager.BusinessLogicLayer;
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
                grvTopNews.DataSource = KifuService.GetTopNewKifu();
                grvTopNews.DataBind();

                grvTopFavourite.DataSource = FavouriteKifuService.GetTopFavouriteKifu();
                grvTopFavourite.DataBind();

                grvTopOpening.DataSource = OpeningService.GetPopularOpening();
                grvTopOpening.DataBind();
            }
        }
    }
}