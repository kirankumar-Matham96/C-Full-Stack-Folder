using MVC_CRUD2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace MVC_CRUD2.DataAccess
{
    public class UserRepository
    {
        private IDBHelper db;

        public UserRepository(IDBHelper dbHelper)
        {
            db = dbHelper;
        }

        public int AddUser(User user)
        {
            using (SqlConnection connection = db.GetDBConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    // Insert User
                    SqlCommand command = new SqlCommand("sp_insert_users", connection, transaction);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@username", user.Username);
                    command.Parameters.AddWithValue("@pwd", user.Password);
                    command.Parameters.AddWithValue("@gender", user.Gender);
                    command.Parameters.AddWithValue("@city", user.City);

                    SqlParameter userIdParam = new SqlParameter("@userId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(userIdParam);
                    command.ExecuteNonQuery();

                    int userId = Convert.ToInt32(userIdParam.Value);

                    // Insert UserHobbies
                    foreach (var hobby in user.Hobbies.Where(hobby => hobby.IsSelected))
                    {
                        SqlCommand hobbyCommand = new SqlCommand("sp_insert_userHobbies", connection, transaction);
                        hobbyCommand.CommandType = CommandType.StoredProcedure;

                        hobbyCommand.Parameters.AddWithValue("@userId", userId);
                        hobbyCommand.Parameters.AddWithValue("@hobbyId", hobby.Id);

                        hobbyCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    return userId;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }
        }

        public List<Hobby> GetAllHobbies()
        {
            try
            {
                var hobbies = new List<Hobby>();

                using (SqlConnection connection = db.GetDBConnection())
                {
                    SqlCommand command = new SqlCommand("sp_get_hobbies", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        hobbies.Add(new Hobby()
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Name = Convert.ToString(reader["name"]),
                            //IsSelected = false
                        });
                    }
                    return hobbies;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public User GetUsersWithHobbies(int userId)
        {
            User user = null;

            using (SqlConnection connection = db.GetDBConnection())
            {
                try
                {
                    SqlCommand command = new SqlCommand("sp_GetUserWithHobbies_all", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@userId", userId);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    List<Hobby> hobbies = new List<Hobby>();

                    while (reader.Read())
                    {

                        if (user == null)
                        {
                            user = new User()
                            {
                                Username = reader["username"].ToString(),
                                Gender = reader["gender"].ToString(),
                                City = reader["city"].ToString(),
                                Hobbies = new List<Hobby>()
                            };
                        }

                        if (reader["HobbyId"] != DBNull.Value)
                        {
                            hobbies.Add(new Hobby()
                            {
                                Id = Convert.ToInt32(reader["HobbyId"]),
                                Name = reader["HobbyName"].ToString(),
                                IsSelected = true
                            });
                        }
                    }

                    if (user != null)
                    {
                        user.Hobbies = hobbies;
                    }

                    Console.WriteLine("user object: " + user);
                    return user;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }
        }

        public User GetUserForEdit(int userId)
        {
            User user = null;

            using (SqlConnection connection = db.GetDBConnection())
            {

                SqlCommand command = new SqlCommand("sp_GetUserWithHobbies_all", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@userId", userId);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                List<int> selectedHobbyIds = new List<int>();

                while (reader.Read())
                {
                    if (user == null)
                    {
                        user = new User()
                        {
                            Username = reader["username"].ToString(),
                            Gender = reader["gender"].ToString(),
                            City = reader["city"].ToString()
                        };
                    }
                    if (reader["HobbyId"] != DBNull.Value)
                    {

                        selectedHobbyIds.Add(Convert.ToInt32(reader["HobbyId"]));
                    }
                    reader.Close();

                    // getting all hobbies
                    var allHobbies = GetAllHobbies();

                    // marking selected allHobbies
                    foreach (var hobby in allHobbies)
                    {
                        hobby.IsSelected = selectedHobbyIds.Contains(hobby.Id);
                    }

                    user.Hobbies = allHobbies;
                }
                return user;
            }
        }

        public void UpdateUser(User user, int userId)
        {
            using (SqlConnection connection = db.GetDBConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    SqlCommand command = new SqlCommand("sp_update_users", connection, transaction);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@id", userId);
                    command.Parameters.AddWithValue("@username", user.Username);
                    command.Parameters.AddWithValue("@pwd", user.Password);
                    command.Parameters.AddWithValue("@gender", user.Gender);
                    command.Parameters.AddWithValue("@city", user.City);

                    command.ExecuteNonQuery();

                    // Deleting old hobbies
                    SqlCommand deleteHobbiesCommand = new SqlCommand("sp_delete_userHobbies", connection, transaction);
                    deleteHobbiesCommand.CommandType = CommandType.StoredProcedure;

                    deleteHobbiesCommand.Parameters.AddWithValue("@userId", userId);
                    deleteHobbiesCommand.ExecuteNonQuery();

                    // inserting new hobies
                    foreach (var hobby in user.Hobbies.Where(h => h.IsSelected))
                    {
                        SqlCommand insertHobbyCommand = new SqlCommand("sp_insert_userHobbies", connection, transaction);
                        insertHobbyCommand.CommandType = CommandType.StoredProcedure;

                        insertHobbyCommand.Parameters.AddWithValue("@userId", userId);
                        insertHobbyCommand.Parameters.AddWithValue("@hobbyId", hobby.Id);

                        insertHobbyCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (SqlException ex)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
