using System;
using System.Data;
using System.Data.SqlClient;

namespace BankSystemDataAccessLayer
{
    public class UsersData
    {
        public static bool IsUserValid(string username, string password)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "Select 1 Where Exists (Select 1 From Users Where Username = @username And Password = @password And IsDeleted = 0)";

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

            string query = "Select UserID From Users Where Username = @username And IsDeleted = 0;";

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

        public static short GetPermissionsByUserID(int userID)
        {
            short permissions = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "Select Permissions From Users Where UserID = @userID And IsDeleted = 0;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@userID", userID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && short.TryParse(result.ToString(), out short permissionFromDB))
                {
                    permissions = permissionFromDB;
                }
            }

            catch (Exception ex) { }

            finally
            {
                connection.Close();
            }

            return permissions;
        }

        public static bool GetUserInfoByUsername(string username, ref short permissions, ref string password, ref int personID, ref int userID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "Select * From Users Where Username = @username And IsDeleted = 0";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@username", username);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    userID = (int)reader["UserID"];

                    password = (string)reader["Password"];

                    permissions = (short)reader["Permissions"];

                    personID = (int)reader["PersonID"];
                }
            }

            catch (Exception ex)
            {
                isFound = false;
            }

            finally
            {
                connection.Close();
            }

            return isFound;
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

            string query = "Select 1 Where Exists (Select 1 From Users Where Username = @username And IsDeleted = 0);";

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

        public static int AddNewUser(string username, short permissions, string password, int personID)
        {
            int userID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"INSERT INTO Users (Username, Permissions, Password, PersonID)
                             VALUES (@username, @permissions, @password, @personID)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@permissions", permissions);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    userID = insertedID;
                }
            }

            catch (Exception ex) { }

            finally
            {
                connection.Close();
            }

            return userID;
        }

        public static bool DeleteUser(string username)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "UPDATE Users SET IsDeleted = 1 WHERE Username = @username;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@username", username);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                rowsAffected = 0;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool UpdateUser(string username, short permissions, string password)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"Update Users 
                           set Password = @password,   Permissions = @permissions
                           Where Username = @username And IsDeleted = 0;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@permissions", permissions);
            command.Parameters.AddWithValue("@Username", username);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                return false;
            }

            finally
            {
                connection.Close();
            }


            return (rowsAffected > 0);
        }


    }
}
