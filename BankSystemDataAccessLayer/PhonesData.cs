using System;
using System.Data;
using System.Data.SqlClient;

namespace BankSystemDataAccessLayer
{
    public class PhonesData
    {

        //public static bool ResetPhonesIdentity()
        //{
        //    int rowsAffected = 0, maxPhoneID = 0;

        //    SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

        //    string getMaxPhoneIDQuery = "SELECT ISNULL(MAX(PhoneID), 0) FROM Phones;";

        //    SqlCommand getMaxPhoneIDCommand = new SqlCommand(getMaxPhoneIDQuery, connection);

        //    try
        //    {
        //        connection.Open();

        //        object result = getMaxPhoneIDCommand.ExecuteScalar();

        //        if (result != null)
        //        {
        //            maxPhoneID = (int)result;
        //        }

        //        string resetIdentityQuery = $"DBCC CHECKIDENT ('Phones', RESEED, {maxPhoneID});";

        //        SqlCommand resetIdentityCommand = new SqlCommand(resetIdentityQuery, connection);

        //        rowsAffected = resetIdentityCommand.ExecuteNonQuery();
        //    }

        //    catch (Exception ex)
        //    {
        //        return false;
        //    }

        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return (rowsAffected > 0);
        //}
        public static int AddNewPhone(string phoneNumber, int personID)
        {
            int phoneID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"INSERT INTO Phones (PhoneNumber, PersonID)
                             VALUES (@phoneNumber, @personID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            command.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    phoneID = insertedID;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            finally
            {
                connection.Close();
            }

            return phoneID;
        }

        public static bool GetPhoneNumberByClientID(int clientID, ref string phoneNumber)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection( DataAccessSettings.connectionString);
            
            //string query = "Select * From Phones Where PersonID = @clientID";
            string query = "Select PhoneNumbers From vwClients Where ClientID = @clientID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@clientID", clientID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    phoneNumber = (string)reader["PhoneNumbers"];
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

        public static bool DeletePhone(int personID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "Delete Phones Where personID = @personID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@personID", personID);

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

        public static bool UpdatePhone(int personID, string phoneNumber)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"Update Phones 
                           set PhoneNumber = @phoneNumber
                           Where PersonID = @personID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            command.Parameters.AddWithValue("@personID", personID);

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

    }
}
