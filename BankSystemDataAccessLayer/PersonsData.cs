using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace BankSystemDataAccessLayer
{
    public class PersonsData
    {

        //public static bool ResetPersonsIdentity()
        //{     
        //        int rowsAffected = 0, maxPersonID = 0;

        //        SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

        //        string getMaxPersonIDQuery = "SELECT ISNULL(MAX(PersonID), 0) FROM Persons;";

        //        SqlCommand getMaxPersonIDCommand = new SqlCommand(getMaxPersonIDQuery, connection);

        //        try
        //        {
        //            connection.Open();

        //            object result = getMaxPersonIDCommand.ExecuteScalar();

        //            if (result != null)
        //            {
        //                maxPersonID = (int)result;
        //            }

        //            string resetIdentityQuery = $"DBCC CHECKIDENT ('Persons', RESEED, {maxPersonID});";

        //            SqlCommand resetIdentityCommand = new SqlCommand(resetIdentityQuery, connection);

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
        //}
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

        public static bool GetPersonInfoByFirstNameAndLastName(string firstName, ref int personID, string lastName, ref string email)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "Select * From Persons Where FirstName = @firstName And LastName = @lastName And IsDeleted = 0";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@lastName", lastName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
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

        public static bool GetPersonInfoByPersonID(int personID, ref string firstName, ref string lastName, ref string email)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "Select * From Persons Where PersonID = @personID And IsDeleted = 0";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    firstName = (string)reader["FirstName"];

                    lastName = (string)reader["LastName"];

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

        //مالا داعي
        public static bool DeletePerson(int personID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = "Update Persons Set IsDeleted = 1 WHERE PersonID = @personID";

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

        public static bool UpdatePerson(int personID, string firstName, string lastName, string email)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccessSettings.connectionString);

            string query = @"Update Persons 
                           set FirstName = @firstName,   LastName = @lastName,   Email = @email
                           Where PersonID = @personID And IsDeleted = 0;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@lastName", lastName);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@personID", personID);

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
