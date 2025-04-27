using System;
using System.Data;
using System.Data.SqlClient;

namespace BankSystemDataAccessLayer
{
    public class UsersData
    {
        public static bool GetUsernameAndPassword(string username, string password)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "Select Username, Password From Users Where Username = @username And Password = @password";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                    isFound = true;

                else
                    isFound = false;

                reader.Close();
            }

            catch(Exception ex)
            {
                isFound = false;

                Console.WriteLine("Error: " + ex.Message);
            }

            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static int GetUserIDByUsername(string username)
        {
            int userID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "Select UserID From Users Where Username = @username;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@username", username);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(), out int userIDFromDB))
                {
                    userID = userIDFromDB;
                }
            }

            catch (Exception ex) { }

            finally
            {
                connection.Close();
            }

            return userID;
        }

        public static DataTable GetAllUsers()
        {
            DataTable dtUsers = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "Select * From vwUsers";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dtUsers.Load(reader);
                }

                reader.Close();
            }

            catch (Exception ex) { }

            finally
            {
                connection.Close();
            }

            return dtUsers;
        }

        public static bool IsUsernameExist(string username)
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "Select 1 Where Exists (Select 1 From Users Where Username = @username);";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@username", username);

            try
            {
                connection.Open();

                return (command.ExecuteScalar() != null);
            }

            catch (Exception ex)
            {
                return false;
            }

            finally
            {
                connection.Close();
            }
        }
    }
}
