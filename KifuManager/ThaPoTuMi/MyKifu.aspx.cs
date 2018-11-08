using KifuManager.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KifuManager
{
    public partial class MyKifu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("~/ThaPoTuMi/Home");
            }

            if (!IsPostBack)
            {

            }
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string inputContent;
            //read content of sgf file
            using (StreamReader inputStreamReader = new StreamReader(KifuUpload.PostedFile.InputStream))
            {
                inputContent = inputStreamReader.ReadToEnd();
            }

            //process content
            KifuService.NewKifu(inputContent);

            //increase point
            UserAccService.IncreasePoint(Session["user"].ToString());
        }

        protected void btnListMyKifu_Click(object sender, EventArgs e)
        {
            grvList.DataSource = KifuService.GetMyKifu(Session["user"].ToString());
            grvList.DataBind();
        }

        protected void btnListFavorKifu_Click(object sender, EventArgs e)
        {
            grvList.DataSource = KifuService.GetFavouriteKifu(Session["user"].ToString());
            grvList.DataBind();
        }
    }
}