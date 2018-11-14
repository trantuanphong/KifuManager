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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName1.Text;
            string password = txtPassword1.Text;
            int isLogin = UserAccService.CheckLogin(username, password);
            if (isLogin == 1)
            {
                UserAcc user = UserAccService.GetUser(username);
                Session["user"] = username;
                Session["type"] = user.Type;
                Response.Redirect("~/ThaPoTuMi/Home");
            }
            else
            {
                Label3.Text = "Wrong username or password";
            }
        }
    }
}