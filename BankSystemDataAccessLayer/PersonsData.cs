using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace BankSystemDataAccessLayer
{
    public class PersonsData
    {
        public static int AddNewPerson(string firstName, string lastName, string email)
        {
            int personID = -1;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"INSERT INTO Persons (FirstName, LastName, Email)
                             VALUES (@firstName, @lastName, @email);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@lastName", lastName);

            if (email != "")
                command.Parameters.AddWithValue(@"email", email);
            else
                command.Parameters.AddWithValue(@"email", System.DBNull.Value);  

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if(result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    personID = insertedID;
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

            return personID;
        }

        public static bool GetPersonInfoByFirstName(string firstName, ref int personID, string lastName, ref string email)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "Select * From Persons Where FirstName = @firstName And LastName = @lastName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@lastName", lastName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    personID = (int)reader["PersonID"];

                    if (reader["Email"] != DBNull.Value)
                    {
                        email = (string)reader["Email"];
                    }

                    else
                    {
                        email = "";
                    }
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
