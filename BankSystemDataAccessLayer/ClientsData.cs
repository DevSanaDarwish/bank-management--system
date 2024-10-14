using System;
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
    }
}
