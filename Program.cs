using System;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        // Connection string to your SQL Server database
        string connectionString = @"Server=127.0.0.1; Database=YourDatabaseName; User Id=YourUsername; Password=YourPassword;";

        // Create a connection object
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                // Open the connection
                connection.Open();
                Console.WriteLine("Connection to the database is successful!");

                // Example query
                string query = "SELECT TOP 5 * FROM YourTableName";

                // Create a command object
                SqlCommand command = new SqlCommand(query, connection);

                // Execute the query and read the data
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Example of reading columns by index or name
                        Console.WriteLine($"Column1: {reader[0]}, Column2: {reader["YourColumnName"]}");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Close the connection if it's still open
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
                Console.WriteLine("Connection closed.");
            }
        }
    }
}
