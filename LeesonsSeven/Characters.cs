using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace LeesonsSeven
{
   public class Characters
    {
        public static void UpdateCharacter()
        {
            var queryString =
                @"update Characters set LastName = 'Potapenko' where FirstName = 'Arven'";

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
