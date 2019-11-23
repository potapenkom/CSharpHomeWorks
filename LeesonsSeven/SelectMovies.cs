using System;
using System.Data.SqlClient;

namespace LeesonsSeven
{
   public class SelectMovies
    {
        public static void selectMovies()
        {
            var queryStringSelect = @"select * from Movies";
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source = DESKTOP-BKN0QS4; 
                    Initial Catalog = Cinema;
                    Integrated Security = SSPI;";
                SqlCommand command = new SqlCommand(queryStringSelect, connection);
                connection.Open();

                using (SqlDataReader sqlReader = command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        Console.WriteLine($"ID: {sqlReader[0].ToString()}, Name: {sqlReader[1].ToString()}, \tGenre: {sqlReader[2].ToString()}," +
                            $"  \tYear: {sqlReader[3].ToString()}");
                    }
                }
            }
        }
    }
}
