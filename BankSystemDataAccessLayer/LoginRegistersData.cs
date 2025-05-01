using System;
using System.Data;
using System.Data.SqlClient;

namespace BankSystemDataAccessLayer
{
    public class LoginRegistersData
    {
        public static DataTable GetLoginRegistersList()
        {
            DataTable dtLoginRegistersList = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "Select * From vwLoginRegisters";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dtLoginRegistersList.Load(reader);
                }

                reader.Close();
            }

            catch (Exception ex) { }

            finally
            {
                connection.Close();
            }

            return dtLoginRegistersList;
        }

        public static int AddLoginRegister(DateTime datetime, int userID)
        {
            int loginRegisterID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"INSERT INTO LoginRegisters (DateTime, UserID)
                VALUES (@datetime, @userID)
                SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@datetime", datetime);
            command.Parameters.AddWithValue("@userID", userID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    loginRegisterID = insertedID;
                }
            }

            catch (Exception ex) { }

            finally
            {
                connection.Close();
            }

            return loginRegisterID;
        }
    }
}
