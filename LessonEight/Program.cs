using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonEight
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookShelfService = new BookShelfService();
            // bookShelfService.AddCharacters();
            // bookShelfService.GetCharactersFromDb();
            // bookShelfService.AddMovies();
            bookShelfService.GetMoviesFromDb();
            Console.Read();
        }
    }
}
