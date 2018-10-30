using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace KifuManager.App_Code.DataAccessLayer
{
    public class DBUtility
    {
        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        }
    }
}