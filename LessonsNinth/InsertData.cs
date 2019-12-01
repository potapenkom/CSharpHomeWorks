using System;
using LessonsNinth.Model;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace LessonsNinth
{
    public static class InsertData
    {
        public static void InsertMovies()
        {
            DataContext dataContext = new DataContext(
                ConfigurationManager.ConnectionStrings["CSharpAdvancedContext"].ToString());

            dataContext.GetTable<Movies>().InsertOnSubmit(new Movies()
            { Id = 1,  Name = "Man in black", Genre = "Comady", Year = 1997});
            dataContext.SubmitChanges();

            Console.WriteLine("Movies inserted");
        }
        public static void InsertDirectors()
        {
            DataContext dataContext = new DataContext(
                ConfigurationManager.ConnectionStrings["CSharpAdvancedContext"].ToString());

            dataContext.GetTable<Director>().InsertOnSubmit(new Director()
            {  FirstName = "Quentin ", LastName = "Tarantino", BirthDate = new DateTime(1963, 3, 27) });
            dataContext.SubmitChanges();

            Console.WriteLine("Directors inserted");
        }
    }
}
