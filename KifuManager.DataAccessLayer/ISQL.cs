using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KifuManager.DataAccessLayer
{
    interface IDal
    {
        int Insert(object obj);
        int Update(object obj);
        int Delete(object obj);
        DataTable SelectAll();
    }
}
