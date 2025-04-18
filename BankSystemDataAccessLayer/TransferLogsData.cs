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
    }
}
