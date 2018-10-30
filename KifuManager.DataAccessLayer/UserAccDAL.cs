using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KifuManager.Entity;

namespace KifuManager.DataAccessLayer
{
    public class UserAccDAL : IDal
    {
        public int Delete(object obj)
        {
            UserAcc userAcc = (UserAcc) obj;
            throw new NotImplementedException();
        }

        public int Insert(object obj)
        {
            UserAcc userAcc = (UserAcc)obj;
            throw new NotImplementedException();
        }

        public DataTable SelectAll()
        {
            throw new NotImplementedException();
        }

        public int Update(object obj)
        {
            UserAcc userAcc = (UserAcc)obj;
            throw new NotImplementedException();
        }
    }
}
