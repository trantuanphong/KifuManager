using KifuManager.BusinessLogicLayer;
using KifuManager.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KifuManager
{
    public partial class AdminSide : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["deleteTitle"] != null)
                DeleteTitle(Request.QueryString["deleteTitle"].ToString());

            rptListUser.DataSource = UserAccService.GetAllUser();
            rptListUser.DataBind();

            rptListTitle.DataSource = TitleService.GetAllTitle();
            rptListTitle.DataBind();

            rptListOpen.DataSource = OpeningService.GetAllOpening();
            rptListOpen.DataBind();
        }

        protected void btnNewOpening_Click(object sender, EventArgs e)
        {
            //get data
            string openingName = txtOpenName.Text;
            string openingDescription = txtOpenDescription.Text;
            string inputContent;
            //read content of sgf file
            using (StreamReader inputStreamReader = new StreamReader(fuOpening.PostedFile.InputStream))
            {
                inputContent = inputStreamReader.ReadToEnd();
            }

            //insert new opening information
            Opening open = new Opening(openingName, openingDescription);
            OpeningService.InsertNewOpening(open, inputContent);
        }

        protected void btnNewTitle_Click(object sender, EventArgs e)
        {
            //get data
            string titleName = txtTitleName.Text;
            int titlePoint = Int32.Parse(txtTitlePoint.Text);
            TitleService.NewTitle(new Title(titleName, titlePoint));
        }

        private void DeleteTitle(string titleID)
        {
            TitleService.DeleteTitle(titleID);
        }
    }
}