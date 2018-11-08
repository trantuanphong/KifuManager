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
                grvListKifu.DataSource = KifuService.GetAllKifu();
                grvListKifu.DataBind();

                drOpen.DataSource = KifuService.GetOpening();
                drOpen.DataTextField = "OpenName";
                drOpen.DataValueField = "OpenID";
                drOpen.DataBind();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbOpening.Checked && !drOpen.SelectedValue.Equals(""))
                grvListKifu.DataSource = KifuService.SearchKifuWithOpen(txtGameName.Text, txtPlayerName.Text, drRank.SelectedValue,drOpen.SelectedValue);
            else grvListKifu.DataSource = KifuService.SearchKifu(txtGameName.Text,txtPlayerName.Text,drRank.SelectedValue);
            grvListKifu.DataBind();
        }
    }
}