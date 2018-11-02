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
            if (!IsPostBack)
            {
            }
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string inputContent;
            using (StreamReader inputStreamReader = new StreamReader(KifuUpload.PostedFile.InputStream))
            {
                inputContent = inputStreamReader.ReadToEnd();
            }

        }
    }
}