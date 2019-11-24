using LessonEight.Models;
using System.Data.Entity;

namespace LessonEight
{
   public class BookShelfContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
