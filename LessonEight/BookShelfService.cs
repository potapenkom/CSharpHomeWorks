using LessonEight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonEight
{
   public class BookShelfService
    {
        public void AddCharacters()
        {
            var dbContext = new BookShelfContext();
            List<Character> characters = GetCharacters();

            dbContext.Characters.AddRange(characters);

            dbContext.SaveChanges();
        }

        public void AddMovies()
        {
            var dbContext = new BookShelfContext();
            List<Movie> movies = GetMovies();

            dbContext.Movies.AddRange(movies);

            dbContext.SaveChanges();
        }

        public void GetCharactersFromDb()
        {
            var dbContext = new BookShelfContext();
            var characters = dbContext.Characters;

            foreach (var c in characters)
                Console.WriteLine($"Id: {c.Id},  \tFirstName: {c.FirstName}  " +
                    $"\tLastName: {c.LastName}  \tGender: {c.Gender}  \tAge: {c.Age}");
        }

        public void GetMoviesFromDb()
        {
            var dbContext = new BookShelfContext();
            var movies = dbContext.Movies;

            foreach (var c in movies)
                Console.WriteLine($"Id: {c.Id},  \tName: {c.Name}  " +
                    $"\tGenre: {c.Genre} \tYear: {c.Year}");
        }
        private List<Character> GetCharacters()
        {
            var characters = new List<Character>();

            characters.Add(new Character() { FirstName = "Finn", LastName = "Mertens", Gender = true, Age = 14 });
            characters.Add(new Character() { FirstName = "Philip", LastName = "Fry", Gender = true, Age = 25 });
            characters.Add(new Character() { FirstName = "Arven", LastName = "Undomiel", Gender = false, Age = 2700 });
            characters.Add(new Character() { FirstName = "Audrey", LastName = "Hepburn", Gender = false, Age = 29 });
            characters.Add(new Character() { FirstName = "John", LastName = "Wick", Gender = true, Age = 42 });
            characters.Add(new Character() { FirstName = "Anakin", LastName = "Skywalker", Gender = true, Age = 29 });
            characters.Add(new Character() { FirstName = "Princess", LastName = "Bubblegum", Gender = false, Age = 827 });
            characters.Add(new Character() { FirstName = "Svetlana", LastName = "Sokolova", Gender = false, Age = 45 });
            characters.Add(new Character() { FirstName = "Varian", LastName = "Wrynn", Gender = true, Age = 42 });
            characters.Add(new Character() { FirstName = "Harry", LastName = "Seldon", Gender = true, Age = 35 });

            return characters;
        }

        public static List<Movie> GetMovies()
        {
            var movies = new List<Movie>();

            movies.Add(new Movie() { Name = "Man in black", Genre = "fiction", Year = 1997 });
            movies.Add(new Movie() { Name = "Mumia", Genre = "adventure", Year = 2017 });
            movies.Add(new Movie() { Name = "Cars", Genre = "for Children", Year = 2011 });

            return movies;
        }
    }
}
