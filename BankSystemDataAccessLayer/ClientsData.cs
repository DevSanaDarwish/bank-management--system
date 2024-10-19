using System;
using System.Data;
using System.Data.SqlClient;


namespace BankSystemDataAccessLayer
{
    public class ClientsData
    {

        public static bool ResetClientIdentity()
        {
            int rowsAffected = 0, maxClientID = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string getMaxClientIDQuery = "SELECT ISNULL(MAX(ClientID), 0) FROM Clients;";

            SqlCommand getMaxClientIDcommand = new SqlCommand(getMaxClientIDQuery, connection);

            try
            {
                connection.Open();

                object result = getMaxClientIDcommand.ExecuteScalar();

                if(result != null)
                {
                    maxClientID = (int)result;
                }

                string resetIdentityQuery = $"DBCC CHECKIDENT ('Clients', RESEED, {maxClientID});";

                SqlCommand resetIdentityCommand = new SqlCommand(resetIdentityQuery, connection);

                rowsAffected = resetIdentityCommand.ExecuteNonQuery();
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

        public static DataTable GetAllClients()
        {
            DataTable dtClients = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            //string query = "SELECT Clients.ClientID, \r\n       Persons.FirstName, \r\n       Persons.LastName, \r\n       Persons.Email, \r\n       Clients.PinCode, \r\n       Clients.Balance, \r\n       Clients.AccountNumber, \r\n       STRING_AGG(Phones.PhoneNumber, ', ') AS PhoneNumbers \r\nFROM Clients \r\nINNER JOIN Persons ON Clients.PersonID = Persons.PersonID\r\nLEFT JOIN Phones ON Persons.PersonID = Phones.PersonID\r\nGROUP BY Clients.ClientID, Persons.FirstName, Persons.LastName, Persons.Email, Clients.PinCode, \r\nClients.Balance, Clients.AccountNumber";

            string query = "Select * From vwClients";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dtClients.Load(reader);

                    
                }

                reader.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            finally
            {
                connection.Close();
            }

            return dtClients;

        }

        public static int AddNewClient(string pinCode, decimal balance, string accountNumber, int personID)
        {
            int clientID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"INSERT INTO Clients (PinCode, Balance, AccountNumber, PersonID)
                             VALUES (@pinCode, @balance, @accountNumber, @personID)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@pinCode", pinCode);
            command.Parameters.AddWithValue("@balance", balance);
            command.Parameters.AddWithValue("@accountNumber", accountNumber);
            command.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    clientID = insertedID;
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            finally
            {
                connection.Close();
            }

            return clientID;
        }

        public static bool GetClientInfoByFirstName(string firstName, ref string lastName, ref string email, ref string phoneNumber, ref string pinCode, ref decimal balance, ref string accountNumber)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            //string query = "\r\nSELECT Persons.FirstName, Persons.LastName, Persons.Email, Clients.PinCode, Clients.Balance, Clients.AccountNumber, Phones.PhoneNumber\r\nFROM     Clients INNER JOIN\r\n                  Persons ON Clients.PersonID = Persons.PersonID INNER JOIN\r\n                  Phones ON Persons.PersonID = Phones.PersonID\r\n\r\n\t\t\t\t  Where FirstName = 'Sana';";

            string query = "Select * From vwClientsWithoutClientID Where FirstName = @firstName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@firstName", firstName);
            
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    lastName = (string)reader["LastName"];

                    phoneNumber = (string)reader["PhoneNumber"];

                    pinCode = (string)reader["PinCode"];

                    balance = (decimal)reader["Balance"];

                    accountNumber = (string)reader["AccountNumber"];

                    if (reader["Email"] != DBNull.Value)
                        email = (string)reader["Email"];

                    else
                        email = "";

                }

                else
                {
                    isFound = false;
                }

                reader.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

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
