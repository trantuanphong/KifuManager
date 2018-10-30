using KifuManager.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KifuManager.DataAccessLayer
{
    public class KifuEventDAL : IDal
    {
        public int Delete(object obj)
        {
            KifuEvent kifuEvent = (KifuEvent)obj;
            throw new NotImplementedException();
        }

        public int Insert(object obj)
        {
            KifuEvent kifuEvent = (KifuEvent)obj;
            throw new NotImplementedException();
        }

        public DataTable SelectAll()
        {
            throw new NotImplementedException();
        }

        public int Update(object obj)
        {
            KifuEvent kifuEvent = (KifuEvent)obj;
            throw new NotImplementedException();
        }
    }
}
