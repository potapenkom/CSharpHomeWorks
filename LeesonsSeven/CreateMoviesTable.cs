using System;
using System.Data.SqlClient;
using System.Configuration;

namespace LeesonsSeven
{
    public class CreateMoviesTable
    {
        public static void createMoviesTable()
        {
            string queryString = @"CREATE TABLE dbo.[Movies]
                           (
                               [ID] [int] NOT NULL,  
                               [Name] [nvarchar](50) NULL,
                               [Genre] [nvarchar](50) NULL,
                               [Year] [int] NOT NULL,   
                           ) on [PRIMARY];";
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["Cinema"].ToString();
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
