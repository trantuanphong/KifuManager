using KifuManager.BusinessLogicLayer;
using KifuManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KifuManager
{
    public partial class ViewKifu : System.Web.UI.Page
    {
        public String Content { get; set; }
        public int KifuID { get; set; }
        public Boolean IsFavour { get; set; }

        private FavouriteKifu favourite;

        protected void Page_Load(object sender, EventArgs e)
        {
            KifuID = Int32.Parse(Request.QueryString["KifuID"]);
            Content = KifuService.GetKifuContent(KifuID);
            favourite = new FavouriteKifu(KifuID, Session["user"].ToString());
            if (!IsPostBack)
            {
                Content = KifuService.GetKifuContent(KifuID);
                txtGameDate.Text = DateTime.Parse(CommonService.GetContentInBracket(Content, "DT")).ToShortDateString();
                txtGameName.Text = CommonService.GetContentInBracket(Content, "GN");
                txtGameEvent.Text = CommonService.GetContentInBracket(Content, "EV");
                IsFavour = FavouriteKifuService.IsFavour(favourite);
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Kifu kifu = new Kifu(KifuID, txtGameName.Text, txtGameEvent.Text, DateTime.Parse(txtGameDate.Text));
            int res = KifuService.UpdateGeneralInformation(kifu);
        }

        protected void btnLike_Click(object sender, EventArgs e)
        {
            FavouriteKifuService.LikeKifu(favourite);
            IsFavour = true;
        }

        protected void btnDisLike_Click(object sender, EventArgs e)
        {
            FavouriteKifuService.UnLikeKifu(favourite);
            IsFavour = false;
        }
    }
}