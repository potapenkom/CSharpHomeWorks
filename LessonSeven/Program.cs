using System;
using LINQ;


namespace LessonSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source = DESKTOP-BKN0QS4;
             initial Catalog = CSharpAdvansed;
             Integrated Security = SSPI;";
            try
            {
                connection.Open();
                Console.WriteLine("DB name: " + connection.Database);
            }
            finally
            {
                connection.Close();
                Console.ReadLine();
            }
        }
    }
}
