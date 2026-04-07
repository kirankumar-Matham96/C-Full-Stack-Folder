using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC_CRUD.Models
{
    public class LoginRepository
    {
        public bool VerifyUser(string username, string password) {

            string connectionString = ConfigurationManager.ConnectionStrings["DB_CONNECTION_STRING"].ToString();
            bool isValidUser = false;
            
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("sp_count_users", connection);

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@pwd", password);
            command.CommandType = CommandType.StoredProcedure;

            connection.Open();
            
            // ExecuteScalar() will return the first value from the table (first row and first column)
            isValidUser = Convert.ToBoolean(command.ExecuteScalar());
            
            connection.Close();

            return isValidUser;
        }
    }
}