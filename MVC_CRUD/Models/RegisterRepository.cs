using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MVC_CRUD.Models
{
    public class RegisterRepository
    {
        public bool AddUser(Register user)
        {
            try
            {
                bool IsUserRegistered = false;
                string connectionString = ConfigurationManager.ConnectionStrings["DB_CONNECTION_STRING"].ToString();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("sp_insert_users", connection);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@username", user.Email);
                command.Parameters.AddWithValue("@pwd", user.Password);
                command.Parameters.AddWithValue("@phone", user.Phone);

                connection.Open();
                command.ExecuteNonQuery();
                IsUserRegistered = true;
                connection.Close();

                return IsUserRegistered;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}