using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_CRUD2.DataAccess
{
    /* NOTE: Do not use Singleton pattern in web applications. Always create a new connection per request.*/
    public class DBHelper : IDBHelper
    {
        private readonly string connectionString;

        public DBHelper()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DB_CONNECTION_STRING"].ConnectionString;
        }

        public SqlConnection GetDBConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}