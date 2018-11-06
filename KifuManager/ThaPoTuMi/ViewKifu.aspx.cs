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

        protected void Page_Load(object sender, EventArgs e)
        {
            KifuID = Int32.Parse(Request.QueryString["KifuID"]);
            Content = KifuService.GetKifuContent(KifuID);
            txtGameDate.Text = DateTime.Parse(CommonService.GetContentInBracket(Content, "DT")).ToShortDateString();
            txtGameName.Text = CommonService.GetContentInBracket(Content, "GN");
            txtGameEvent.Text = CommonService.GetContentInBracket(Content, "EV");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Kifu kifu = new Kifu(KifuID, txtGameName.Text, txtGameEvent.Text, DateTime.Parse(txtGameDate.Text));
            int res = KifuService.UpdateGeneralInformation(kifu);
            if (res == 1) txtGameName.Text = kifu.GameName;
        }
    }
}