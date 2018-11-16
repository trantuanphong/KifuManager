using KifuManager.BusinessLogicLayer;
using KifuManager.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
        public Boolean IsOwnKifu { get; set; }

        private FavouriteKifu favourite;

        protected void Page_Load(object sender, EventArgs e)
        {
            KifuID = Int32.Parse(Request.QueryString["KifuID"]);
            Content = KifuService.GetKifuContent(KifuID);
            IsOwnKifu = false;
            if (Session["user"] != null)
            {
                favourite = new FavouriteKifu(KifuID, Session["user"].ToString());
                IsFavour = FavouriteKifuService.IsFavour(favourite);
                IsOwnKifu = KifuService.IsOwnKifu(Session["user"].ToString(), KifuID);
            }
            if (!IsOwnKifu)
            {
                txtGameName.ReadOnly = true;
                txtGameEvent.ReadOnly = true;
                txtGameDate.ReadOnly = true;
            }
            if (!IsPostBack)
            {
                Content = KifuService.GetKifuContent(KifuID);
                txtGameDate.Text = DateTime.Parse(CommonService.GetContentInBracket(Content, "DT")).ToString("yyyy-MM-dd");
                txtGameName.Text = CommonService.GetContentInBracket(Content, "GN");
                txtGameEvent.Text = CommonService.GetContentInBracket(Content, "EV");
            }
            rpComment.DataSource = FavouriteKifuService.GetKifuRating(KifuID);
            rpComment.DataBind();

            lblRate.Text = FavouriteKifuService.GroupPointOfKifu(KifuID) + "/5";
            GetOpen();
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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string comment = txtComment.Text;
            int point = Int32.Parse(drRate.SelectedValue);
            KifuRating kifuRating = new KifuRating(KifuID, Session["user"].ToString(), point, comment);
            FavouriteKifuService.RatingAndCommnent(kifuRating);
        }

        protected void btnIdentify_Click(object sender, EventArgs e)
        {
            ArrayList steps = KifuService.GetKifuStep(KifuID);
            string blackPlayer = CommonService.GetContentInBracket(Content, "PB");
            string whitePlayer = CommonService.GetContentInBracket(Content, "PW");
            KifuService.IdentifyOpening(KifuID, steps, blackPlayer, whitePlayer);
        }

        private void GetOpen()
        {
            string blackPlayer = CommonService.GetContentInBracket(Content, "PB");
            string whitePlayer = CommonService.GetContentInBracket(Content, "PW");
            foreach (DataRow row in KifuService.GetKifuOpen(KifuID).Rows)
            {
                if (row["Player"].Equals(blackPlayer))
                {
                    txtBlackOpen.Text = row["OpenName"].ToString();
                } else if (row["Player"].Equals(whitePlayer))
                {
                    txtWhiteOpen.Text = row["OpenName"].ToString();
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["KifuID"] != null)
            {
                KifuService.DeleteKifu(KifuID, Session["user"].ToString());
                Response.Redirect("~/ThaPoTuMi/Home");
            }
        }
    }
}