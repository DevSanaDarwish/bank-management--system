using System;
using System.Data;
using System.Data.SqlClient;

namespace BankSystemDataAccessLayer
{
    public class TransferLogsData
    {
        public static DataTable GetTransferLogsList()
        {
            DataTable dtTransferLogsList = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "Select * From vwTransferLogs";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dtTransferLogsList.Load(reader);
                }

                reader.Close();
            }

            catch (Exception ex) { }

            finally
            {
                connection.Close();
            }

            return dtTransferLogsList;
        }

        public static int AddTransferLog(DateTime date, int sourceClientID, int destinationClientID, decimal amount,
            decimal sourceBalance, decimal destinationBalance, int userID)
        {
            int transferLogID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"INSERT INTO TransferLogs (Date, SourceClientID, DestinationClientID, Amount,
                 SourceBalance, DestinationBalance, UserID)
                VALUES (@date, @sourceClientID, @destinationClientID, @amount, @sourceBalance, @destinationBalance, @userID)
                SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@sourceClientID", sourceClientID);
            command.Parameters.AddWithValue("@destinationClientID", destinationClientID);
            command.Parameters.AddWithValue("@amount", amount);
            command.Parameters.AddWithValue("@sourceBalance", sourceBalance);
            command.Parameters.AddWithValue("@destinationBalance", destinationBalance);
            command.Parameters.AddWithValue("@userID", userID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    transferLogID = insertedID;
                }
            }

            catch (Exception ex) { }

            finally
            {
                connection.Close();
            }

            return transferLogID;
        }
    }
}
