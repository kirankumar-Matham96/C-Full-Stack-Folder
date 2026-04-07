using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Keshav.Models
{
    public class KeshavaaaaaRepository
    {
        public void InsertUser(Keshavaaaaa user) {

            // get connection string
            var connectionString = ConfigurationManager.ConnectionStrings["DB_CONNECTION_URL"].ToString();

            // get connection
            SqlConnection connection = new SqlConnection(connectionString);

            // give command
            SqlCommand command = new SqlCommand("sp_insert_keshav", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@id", user.Id);
            command.Parameters.AddWithValue("@name", user.Name);
            command.Parameters.AddWithValue("@age", user.Age);
            command.Parameters.AddWithValue("@loc", user.Location);

            // execute
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
    }
}