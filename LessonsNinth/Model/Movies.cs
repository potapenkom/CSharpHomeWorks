﻿using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonsNinth.Model
{
    [Table(Name = "Movies")]
    class Movies
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column]
        public string Name { get; set; }

        [Column]
        public string Genre { get; set; }

        [Column]
        public int Year { get; set; }
    }
}
