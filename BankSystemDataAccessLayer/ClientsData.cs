
using System;
using System.Data;
using System.Data.SqlClient;


namespace BankSystemDataAccessLayer
{
    public class ClientsData
    {
        //    public static bool ResetClientIdentity()
        //    {
        //        int rowsAffected = 0;

        //        SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

        //        string resetIdentityQuery = @"
        //                 DECLARE @maxClientID INT;
        //                 SELECT @maxClientID = ISNULL(MAX(ClientID), 0) FROM Clients;
        //                 DBCC CHECKIDENT ('Clients', RESEED, @maxClientID);";

        //        SqlCommand resetIdentityCommand = new SqlCommand(resetIdentityQuery, connection);

        //        try
        //        {
        //            connection.Open();
        //            rowsAffected = resetIdentityCommand.ExecuteNonQuery();
        //        }

        //        catch (Exception ex)
        //        {
        //            return false;
        //        }

        //        finally
        //        {
        //            connection.Close();
        //        }

        //        return (rowsAffected > 0);
            
            

        //    //int rowsAffected = 0, maxClientID = 0;

        //    //SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

        //    //string getMaxClientIDQuery = "SELECT ISNULL(MAX(ClientID), 0) FROM Clients;";

        //    //SqlCommand getMaxClientIDCommand = new SqlCommand(getMaxClientIDQuery, connection);

        //    //try
        //    //{
        //    //    connection.Open();

        //    //    object result = getMaxClientIDCommand.ExecuteScalar();

        //    //    if(result != null)
        //    //    {
        //    //        maxClientID = (int)result;
        //    //    }

        //    //    string resetIdentityQuery = $"DBCC CHECKIDENT ('Clients', RESEED, {maxClientID});";

        //    //    SqlCommand resetIdentityCommand = new SqlCommand(resetIdentityQuery, connection);

        //    //    rowsAffected = resetIdentityCommand.ExecuteNonQuery();
        //    //}

        //    //catch (Exception ex)
        //    //{
        //    //    return false;
        //    //}

        //    //finally
        //    //{
        //    //    connection.Close();
        //    //}

        //    //return (rowsAffected > 0);
        //}

        

        public static DataTable GetTotalBalances()
        {
            DataTable dtBalances = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "Select * From vwTotalBalances;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    dtBalances.Load(reader);
                }

                reader.Close();
            }

            catch(Exception ex) { }
            
            finally
            {
                connection.Close();
            }

            return dtBalances;
        }

        public static DataTable GetAllClients()
        {
            DataTable dtClients = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

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

            catch (Exception ex) { }

            finally
            {
                connection.Close();
            }

            return dtClients;

        }

        public static decimal GetSumOfBalances()
        {
            decimal sumOfBalances = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "Select Sum(Balance) From Clients WHERE IsDeleted = 0;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if(result != null && decimal.TryParse(result.ToString(), out decimal sum))
                {
                    sumOfBalances = sum;
                }
            }

            catch (Exception ex) { }

            finally
            {
                connection.Close();
            }

            return sumOfBalances;
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

            catch (Exception ex) { }

            finally
            {
                connection.Close();
            }

            return clientID;
        }

       
        public static bool GetClientInfoByAccountNumber(string accountNumber, ref string pinCode, ref decimal balance, ref int personID, ref int clientID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "Select * From Clients Where AccountNumber = @accountNumber And IsDeleted = 0";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@accountNumber", accountNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    clientID = (int)reader["ClientID"];

                    balance = (decimal)reader["Balance"];

                    pinCode = (string)reader["PinCode"];

                    personID = (int)reader["PersonID"];
                }
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

        public static bool DeleteClient(string accountNumber)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "UPDATE Clients SET IsDeleted = 1 WHERE AccountNumber = @accountNumber;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@accountNumber", accountNumber);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }

            catch(Exception ex)
            {
                rowsAffected = 0;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool UpdateClient(string accountNumber, string pinCode, decimal balance)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection( DataAccessSettings.connectionString);

            string query = @"Update Clients 
                           set PinCode = @pinCode,   Balance = @balance
                           Where AccountNumber = @accountNumber And IsDeleted = 0;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@pinCode", pinCode);
            command.Parameters.AddWithValue("@balance", balance);
            command.Parameters.AddWithValue("@accountNumber", accountNumber);

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

        public static bool DepositAmount(decimal amount, string accountNumber)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"Update Clients 
                           set Balance = Balance + @amount
                           Where AccountNumber = @accountNumber And IsDeleted = 0;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@amount", amount);
            command.Parameters.AddWithValue("@accountNumber", accountNumber);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }

            catch(Exception ex)
            {
                return false;
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool WithdrawAmount(decimal amount, string accountNumber)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"Update Clients 
                           set Balance = Balance - @amount
                           Where AccountNumber = @accountNumber And IsDeleted = 0;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@amount", amount);
            command.Parameters.AddWithValue("@accountNumber", accountNumber);

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

        public static bool IsAccountNumberExist(string accountNumber)
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "Select 1 Where Exists (Select 1 From Clients Where AccountNumber = @accountNumber And IsDeleted = 0);";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@accountNumber", accountNumber);

            try
            {
                connection.Open();

                return (command.ExecuteScalar() != null);            
            }

            catch(Exception ex)
            {
                return false;
            }

            finally
            {
                connection.Close();
            }
        }

        public static bool TransferAmount(string accountNumberFrom, string accountNumberTo, decimal amount)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"Update Clients 
                           set Balance = Balance - @amount
                           Where AccountNumber = @accountNumberFrom And IsDeleted = 0; 

                           Update Clients 
                           set Balance = Balance + @amount
                           Where AccountNumber = @accountNumberTo And IsDeleted = 0;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@accountNumberFrom", accountNumberFrom);
            command.Parameters.AddWithValue("@accountNumberTo", accountNumberTo);
            command.Parameters.AddWithValue("@amount", amount);

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
