using System;
using System.Collections.Generic;
using System.Text;

namespace LessonNinth
{
    class CSharpAdvancedContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        
    }
}
