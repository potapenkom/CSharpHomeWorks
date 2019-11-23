using System.Data.SqlClient;
using System.Configuration;

namespace LeesonsSeven
{
    public class InsertMovie
    {
        public static void insertMovie()
        {
            var queryString1 = @"INSERT INTO Movies (Name, Genre, Year) VALUES ('Man in black', 'fiction', 1997 );";
            var queryString2 = @"INSERT INTO Movies (Name, Genre, Year) VALUES ('Mumia', 'adventure', 2017 );";
            var queryString3 = @"INSERT INTO Movies (Name, Genre, Year) VALUES ('Cars', 'for Children', 2011 );";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["Cinema"].ToString();
                SqlCommand command = new SqlCommand(queryString1, connection);
                SqlCommand command1 = new SqlCommand(queryString2, connection);
                SqlCommand command2 = new SqlCommand(queryString3, connection);
                connection.Open();
                command.ExecuteNonQuery();
                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
            }
        }
    }
}
