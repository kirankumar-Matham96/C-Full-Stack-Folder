using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CRUD2.DataAccess
{
    public interface IDBHelper
    {
        SqlConnection GetDBConnection();
    }
}
