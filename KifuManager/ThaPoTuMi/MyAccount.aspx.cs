using KifuManager.BusinessLogicLayer;
using KifuManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KifuManager.ThaPoTuMi
{
    public partial class MyAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"]==null) Response.Redirect("~/ThaPoTuMi/Home");
            UserAcc user = UserAccService.GetUser(Session["user"].ToString());
            txtEmail.Text = user.Email;
            lbPoint.Text = "Your point is: " + user.Point;
            drTitle.DataSource = TitleService.GetTitleSuitable(user.Point);
            drTitle.DataTextField = "TitleName";
            drTitle.DataValueField = "TitleID";
        }

        protected void btnChangeTitle_Click(object sender, EventArgs e)
        {

        }
    }
}