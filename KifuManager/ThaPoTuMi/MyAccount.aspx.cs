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
            if (!IsPostBack)
            {
                if (Session["user"] == null) Response.Redirect("~/ThaPoTuMi/Home");
                UserAcc user = UserAccService.GetUser(Session["user"].ToString());
                txtEmail.Text = user.Email;
                lbPoint.Text = "Your point is: " + user.Point;
                drTitle.DataSource = TitleService.GetTitleSuitable(user.Point);
                drTitle.DataTextField = "TitleName";
                drTitle.DataValueField = "TitleID";
                drTitle.DataBind();
                if (drTitle.SelectedItem == null) btnChangeTitle.Enabled = false;
                if (user.TitleID == 0) btnRemoveTitle.Visible = true;
            }
        }

        protected void btnChangeTitle_Click(object sender, EventArgs e)
        {
            UserAccService.SetTitle(Session["user"].ToString(), Int32.Parse(drTitle.SelectedValue));
        }

        protected void btnRemoveTitle_Click(object sender, EventArgs e)
        {
            UserAccService.RemoveTitle(Session["user"].ToString());
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            UserAccService.ChangePassword(Session["user"].ToString(), txtNewPassword.Text);
        }

        protected void btnChangeEmail_Click(object sender, EventArgs e)
        {
            UserAccService.ChangeEmail(Session["user"].ToString(), txtEmail.Text);
        }
    }
}