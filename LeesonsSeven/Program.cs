using System.Data.SqlClient;
using System.Configuration;

namespace LeesonsSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            var queryString = @"update Characters set LastName = 'Undomiel' where FirstName = 'Arven'";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["AdvanceCSharpCS"].ToString();
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
