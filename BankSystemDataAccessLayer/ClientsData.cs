﻿using System;
using System.Data;
using System.Data.SqlClient;


namespace BankSystemDataAccessLayer
{
    public class ClientsData
    {
        public static DataTable GetAllClients()
        {
            DataTable dtClients = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            //string query = "SELECT Clients.ClientID, Persons.FirstName, Persons.LastName, Persons.Email, Clients.PinCode, Clients.Balance, Clients.AccountNumber, Phones.PhoneNumber\r\nFROM     Clients INNER JOIN\r\n                  Persons ON Clients.PersonID = Persons.PersonID INNER JOIN\r\n                  Phones ON Persons.PersonID = Phones.PersonID;";
            string query = "SELECT Clients.ClientID, \r\n       Persons.FirstName, \r\n       Persons.LastName, \r\n       Persons.Email, \r\n       Clients.PinCode, \r\n       Clients.Balance, \r\n       Clients.AccountNumber, \r\n       STRING_AGG(Phones.PhoneNumber, ', ') AS PhoneNumbers \r\nFROM Clients \r\nINNER JOIN Persons ON Clients.PersonID = Persons.PersonID\r\nLEFT JOIN Phones ON Persons.PersonID = Phones.PersonID\r\nGROUP BY Clients.ClientID, Persons.FirstName, Persons.LastName, Persons.Email, Clients.PinCode, \r\nClients.Balance, Clients.AccountNumber";

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
    }
}
