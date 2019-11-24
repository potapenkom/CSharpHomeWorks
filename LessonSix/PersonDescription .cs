using System;
using LessonFive.HelpMaterial;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LessonSix
{
   public static class PersonDescription
   {
        public static void ShowProperty()
        {
            var characters = PersonsService.GetPersons();
            var persons = characters.Select(x => new { PersonDescription = $"{x.FirstName}, {x.LastName}, { x.Gender} ,{ x.Age}"
            });
            foreach (var person in persons )
                Console.WriteLine(person.PersonDescription);
        }
    }
}
