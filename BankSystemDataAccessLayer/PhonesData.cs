﻿using System;
using System.Collections.Generic;
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

        public static byte GetCountOfPhonesNumbers(int personID)
        {
            byte countOfPhones = 0;

            SqlConnection connection = new SqlConnection( DataAccessSettings.connectionString);

            string query = "Select Count(PhoneNumber) From Phones Where PersonID = @personID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if(result != null && byte.TryParse(result.ToString(), out byte count))
                {
                    countOfPhones = count;
                }
            }

            catch(Exception ex) { }
                       
            finally
            {
                connection.Close();
            }

            return countOfPhones;
        }

        public static bool GetPhoneNumberByClientIDInList(int clientID, List<string> phoneNumbers, List<int> phoneIds)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);
            
            string query = @"SELECT ph.PhoneId, ph.PhoneNumber FROM Phones ph
                            INNER JOIN Persons p ON p.PersonId = ph.PersonId
                            INNER JOIN Clients c ON c.PersonId = p.PersonId
                            WHERE c.ClientId = @clientID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@clientID", clientID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    isFound = true;

                    phoneNumbers.Add((string)reader["PhoneNumber"]);

                    phoneIds.Add((int)reader["phoneId"]);
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

        public static bool GetPhoneNumberByClientID(int clientID, ref string phoneNumber)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"Select PhoneNumbers From vwClients Where ClientID = @clientID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@clientID", clientID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
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

        public static bool DeletePhoneByPhoneNumber(string phoneNumber)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "Delete From Phones Where PhoneNumber = @phoneNumber";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);

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

            return rowsAffected > 0;

        }

        public static bool UpdatePhone(int phoneID, string phoneNumber)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"Update Phones 
                           set PhoneNumber = @phoneNumber
                           Where PhoneID = @phoneID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            command.Parameters.AddWithValue("@phoneID", phoneID);

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

        public static bool IsPhoneExistByPhoneNumber(string phoneNumber)
        {
            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "Select 1 Where Exists(Select 1 From Phones Where PhoneNumber = @phoneNumber);";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);

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

    }
}
