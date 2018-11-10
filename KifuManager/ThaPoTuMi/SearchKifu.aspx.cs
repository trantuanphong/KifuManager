using KifuManager.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KifuManager
{
    public partial class SearchKifu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rptList.DataSource = KifuService.GetAllKifu();
                rptList.DataBind();

                drOpen.DataSource = KifuService.GetOpening();
                drOpen.DataTextField = "OpenName";
                drOpen.DataValueField = "OpenID";
                drOpen.DataBind();
            }

            if (Request.QueryString["openID"] != null)
            {
                SearchByOpening(Request.QueryString["openID"]);
                rptList.DataBind();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbOpening.Checked && !drOpen.SelectedValue.Equals(""))
                SearchByOpening(drOpen.SelectedValue);
            else rptList.DataSource = KifuService.SearchKifu(txtGameName.Text, txtPlayerName.Text, drRank.SelectedValue);
            rptList.DataBind();
        }

        private void SearchByOpening(string openID)
        {
            rptList.DataSource = KifuService.SearchKifuWithOpen(txtGameName.Text, txtPlayerName.Text, drRank.SelectedValue, openID);
        }

    }
}