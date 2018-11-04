using KifuManager.BusinessLogicLayer;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            Content = KifuService.GetKifuContent(2);
            txtGameDate.Text = CommonService.GetContentInBracket(Content, "DT");
            txtGameName.Text = CommonService.GetContentInBracket(Content, "GN");
            txtGameEvent.Text = CommonService.GetContentInBracket(Content, "EV");
        }
    }
}