using System;
using System.Data;
using System.Data.SqlClient;

namespace BankSystemDataAccessLayer
{
    public class UsersData
    {
        public static bool GetUsername(string username, ref int id)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "Select Username From Users Where Username = @username";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@username", username);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                    username = (string)result;

                else
                    username = "";
            }

            catch(Exception ex)
            {
                isFound = false;
            }

            finally
            {
                connection.Close();
            }

            return isFound;
        }
    }
}
